using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Google.Apis.Auth.OAuth2;
using Google.Apis.PeopleService.v1.Data;
using Google.Apis.PeopleService.v1;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace LoopFit
{
    public class User
    {
        public static int UserID { get; set; }
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static string Email { get; set; }
        public static string NewEmail { get; set; }
        public static string PhoneNumber { get; set; }
        public static string Address { get; set; }
        public static bool IsInJogja { get; set; }
        public static string ProfileImage { get; set; }
        public static string FirstName { get; set; }
        public static string LastName { get; set; }

        public User()
        {

        }

        private static NpgsqlConnection GetDbConnection()
        {
            string conn = "Host=localhost; Port=5432;Username=postgres;Password=admin;Database=loopfit";
            return new NpgsqlConnection(conn);
        }

        public static bool SaveUserToDatabase(string connstring)
        {
            using (var conn = new NpgsqlConnection(connstring))
            {
                try
                {
                    conn.Open();
                    string sql = @"INSERT INTO ""User"" (firstname, lastname, email, phonenumber, username, password)
                                   VALUES (@firstname, @lastname, @Email, @phonenumber, @username, @password)";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("firstname", FirstName);
                        cmd.Parameters.AddWithValue("lastname", LastName);
                        cmd.Parameters.AddWithValue("email", Email);
                        cmd.Parameters.AddWithValue("phonenumber", PhoneNumber);
                        cmd.Parameters.AddWithValue("username", Username);
                        cmd.Parameters.AddWithValue("password", Password); 

                        cmd.ExecuteNonQuery();
                    }
                    return true; 
                }
                catch (NpgsqlException ex) 
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false; 
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false; 
                }
            }
        }

        public void EditProfile(string email, string phoneNumber, string profileImage)
        {
            Email = email;
            PhoneNumber = phoneNumber;
            ProfileImage = profileImage;
        }

        public void ViewProfile()
        {
            Console.WriteLine($"Username: {Username}\nEmail: {Email}\nPhone: {PhoneNumber}\nAddress: {Address}");
        }

        public static string generatedVerificationCode;
        public static bool isEmailVerified = false;

        public static void SendVerificationEmail(string recipientEmail)
        {
            Random random = new Random();
            generatedVerificationCode = random.Next(1000, 9999).ToString();

            //MessageBox.Show("Verification code : " + generatedVerificationCode, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string senderEmail = "loopfit2024@gmail.com"; 
            string senderPassword = "tbzq rnxq yzgr bkfa"; 

            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(senderEmail);
                mail.To.Add(recipientEmail);
                mail.Subject = "Verification Code";
                mail.Body = $"Your verification code is: {generatedVerificationCode}";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential(senderEmail, senderPassword),
                    EnableSsl = true
                };

                smtp.Send(mail);
                MessageBox.Show("Verification code sent to " + recipientEmail, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static bool ValidateUser(string connstring, string input, string password, out string role, out string username, out string email)
        {
            role = string.Empty;
            username = string.Empty;
            email = string.Empty;

            using (var conn = new NpgsqlConnection(connstring))
            {
                try
                {
                    conn.Open();
                    string sql = @"SELECT username, email, role 
                           FROM ""User"" 
                           WHERE (username = @input OR email = @input) 
                           AND password = @password";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("input", input);
                        cmd.Parameters.AddWithValue("password", password);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                username = reader["username"].ToString();
                                email = reader["email"].ToString();
                                role = reader["role"].ToString();
                                return true; // User ditemukan
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return false; // User tidak ditemukan
        }


        public static bool ValidateUserGoogle(string connstring, string username)
        {
            using (var conn = new NpgsqlConnection(connstring))
            {
                try
                {
                    conn.Open();
                    string sql = @"SELECT 1 FROM ""User"" WHERE username = @username"; // Query hanya memeriksa apakah username ada
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("username", username);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return true; // Pengguna ditemukan
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return false;
        }

        public static string GetUsernameByEmail(string connectionString, string email)
        {
            string username = null;

            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Query SQL untuk mengambil username berdasarkan email
                    string query = "SELECT username FROM \"User\" WHERE email = @Email";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        // Menambahkan parameter email untuk mencegah SQL Injection
                        command.Parameters.AddWithValue("@Email", email);

                        // Mengeksekusi query dan membaca hasilnya
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Mengambil username dari hasil query dan menyimpannya dalam variabel lokal
                                username = reader.GetString(0);
                            }
                            else
                            {
                                Console.WriteLine("Email not found.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured: " + ex.Message);
            }

            return username;  // Mengembalikan username yang ditemukan
        }

        public static User GetFirstName(string connstring, string username)
        {
            using (var conn = new NpgsqlConnection(connstring))
            {
                try
                {
                    conn.Open();
                    string sql = @"SELECT firstname FROM ""User"" WHERE username = @username";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("username", username);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                FirstName = reader["firstname"].ToString(); 
                                return new User();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return null; 
        }

        public static int? GetUserId(string connstring, string username)
        {
            using (var conn = new NpgsqlConnection(connstring))
            {
                try
                {
                    conn.Open();
                    string sql = @"SELECT userid FROM ""User"" WHERE username = @username";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("username", username);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return reader["userid"] as int?;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return null; // Mengembalikan null jika userid tidak ditemukan atau terjadi kesalahan
        }

        public static void ResetEmailVerification()
        {
            User.generatedVerificationCode = null;  // Clear the verification code
            User.isEmailVerified = false;  // Reset the email verification state
        }

        public static void DisplayProfileImage(string username, PictureBox picProfile)
        {
            string conn = "Host=localhost; Port=5432; Username=postgres; Password=admin; Database=loopfit";

            try
            {
                // Membuat koneksi ke database
                using (NpgsqlConnection con = new NpgsqlConnection(conn))
                {
                    con.Open();

                    // Query untuk mengambil gambar profil berdasarkan username
                    string query = "SELECT profileimage FROM \"User\" WHERE username = @username";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
                    {
                        // Menambahkan parameter untuk username
                        cmd.Parameters.AddWithValue("@username", username);

                        // Menjalankan query dan mendapatkan gambar sebagai byte[]
                        var result = cmd.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            // Mengonversi byte[] ke Image
                            byte[] imageBytes = (byte[])result;
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                picProfile.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            // Jika tidak ada gambar, tampilkan gambar default (opsional)
                            picProfile.Image = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Menangani error jika ada
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static bool UpdatePassword(string connString, string email, string newPassword)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string sql = @"UPDATE ""User"" SET password = @Password WHERE email = @Email";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("Password", newPassword); // Consider hashing the password here
                        cmd.Parameters.AddWithValue("Email", email);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public static bool IsUsernameTaken(string username)
        {
            using (var connection = GetDbConnection())
            {
                connection.Open();
                string queryCheckUsername = "SELECT COUNT(*) FROM \"User\" WHERE username = @newUsername";
                using (var command = new NpgsqlCommand(queryCheckUsername, connection))
                {
                    command.Parameters.AddWithValue("@newUsername", username);
                    int usernameExists = Convert.ToInt32(command.ExecuteScalar());
                    return usernameExists > 0;
                }
            }
        }

        public static bool IsUsernameRegistered(string username, string connectionString)
        {
            string query = "SELECT COUNT(*) FROM \"User\" WHERE username = @Username";

            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);

                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count > 0; // Mengembalikan true jika username ditemukan
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while checking username in database: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static void UpdateUserData(string newUsername, string newFirstName, string newLastName, string newEmail, string newPhoneNumber, string newPassword, byte[] profileImageBytes)
        {
            using (var connection = GetDbConnection())
            {
                connection.Open();
                string queryUpdate = "UPDATE \"User\" SET username = @newUsername, firstname = @firstname, lastname = @lastname, email = @email, phonenumber = @phonenumber, password = @password, profileimage = @profileimage WHERE username = @currentUsername";
                using (var command = new NpgsqlCommand(queryUpdate, connection))
                {
                    command.Parameters.AddWithValue("@newUsername", newUsername);
                    command.Parameters.AddWithValue("@firstname", newFirstName);
                    command.Parameters.AddWithValue("@lastname", newLastName);
                    command.Parameters.AddWithValue("@email", newEmail);
                    command.Parameters.AddWithValue("@phonenumber", newPhoneNumber);
                    command.Parameters.AddWithValue("@password", newPassword);
                    command.Parameters.AddWithValue("@profileimage", (object)profileImageBytes ?? DBNull.Value);
                    command.Parameters.AddWithValue("@currentUsername", User.Username);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static bool IsEmailVerified(string inputCode)
        {
            return inputCode == User.generatedVerificationCode && User.isEmailVerified;
        }

        public static bool IsEmailRegistered(string connString, string email)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string sql = @"SELECT COUNT(*) FROM ""User"" WHERE email = @Email";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);

                        // Mengambil hasil query
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public static (bool emailExists, bool phoneExists) CheckEmailAndPhoneStatus(string email, string phoneNumber)
        {
            string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=admin;Database=loopfit";
            string query = "SELECT email, phonenumber FROM \"User\" WHERE email = @Email OR phonenumber = @PhoneNumber";

            bool emailExists = false;
            bool phoneExists = false;

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (reader["email"] != DBNull.Value && reader["email"].ToString() == email)
                                {
                                    emailExists = true;
                                }
                                if (reader["phonenumber"] != DBNull.Value && reader["phonenumber"].ToString() == phoneNumber)
                                {
                                    phoneExists = true;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while checking database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return (emailExists, phoneExists);
        }

        public static async Task<Person> AuthenticateWithGoogleAsync(string clientSecretJson, string applicationName)
        {
            try
            {
                // Tentukan scope Google API
                string[] scopes = {
            "https://www.googleapis.com/auth/userinfo.email",
            "https://www.googleapis.com/auth/userinfo.profile"
        };

                string tokenPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    "LoopFit_" + DateTime.Now.ToString("yyyyMMddHHmmss"), "token.json");

                if (File.Exists(tokenPath))
                {
                    File.Delete(tokenPath); // Menghapus token lama
                }

                // Parse kredensial dari string JSON
                UserCredential credential;
                using (var stream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(clientSecretJson)))
                {
                    var clientSecrets = GoogleClientSecrets.FromStream(stream);
                    credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                        clientSecrets.Secrets,
                        scopes,
                        "user",
                        CancellationToken.None,
                        new FileDataStore(tokenPath, true)); // Menyimpan token baru
                }

                // Inisialisasi layanan People API
                var service = new PeopleServiceService(new BaseClientService.Initializer
                {
                    HttpClientInitializer = credential,
                    ApplicationName = applicationName
                });

                // Dapatkan informasi pengguna menggunakan People API
                var request = service.People.Get("people/me");
                request.PersonFields = "names,emailAddresses";
                return await request.ExecuteAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error during Google authentication: {ex.Message}");
            }
        }

        public static string EncryptPassword (string password)
        {
            string encrypt = Eramake.eCryptography.Encrypt(password);
            return encrypt;
        }


    }
}
