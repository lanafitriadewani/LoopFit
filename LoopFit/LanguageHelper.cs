using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopFit
{
    public static class LanguageHelper
    {
        public static void UpdateUI(Control parentControl)
        {
            // Update all labels in the parent control and its children
            foreach (var label in parentControl.Controls.OfType<Label>())
            {
                string resourceKey = label.Name + ".Text";
                var labelText = Resources.ResourceManager.GetString(resourceKey);
                if (labelText != null)
                {
                    label.Text = labelText;
                }
            }

            // Update all buttons in the parent control and its children
            foreach (var button in parentControl.Controls.OfType<Button>())
            {
                string resourceKey = button.Name + ".Text";
                var buttonText = Resources.ResourceManager.GetString(resourceKey);
                if (buttonText != null)
                {
                    button.Text = buttonText;
                }
            }

            // Update all radio buttons in the parent control and its children
            foreach (var radioButton in parentControl.Controls.OfType<RadioButton>())
            {
                string resourceKey = radioButton.Name + ".Text";
                var radioButtonText = Resources.ResourceManager.GetString(resourceKey);
                if (radioButtonText != null)
                {
                    radioButton.Text = radioButtonText;
                }
            }

            // Update all combo boxes in the parent control and its children
            foreach (var comboBox in parentControl.Controls.OfType<ComboBox>())
            {
                UpdateComboBoxItems(comboBox);
            }

            // Recursively update nested controls
            foreach (Control nestedControl in parentControl.Controls)
            {
                UpdateUI(nestedControl); // Recursive call for nested controls
            }
        }

        public static void UpdateComboBoxItems(ComboBox comboBox)
        {
            // Clear existing items
            comboBox.Items.Clear();

            // Add items based on ComboBox name
            switch (comboBox.Name)
            {
                case "cbClothType":
                    comboBox.Items.Add(Resources.ResourceManager.GetString("InnerTop"));
                    comboBox.Items.Add(Resources.ResourceManager.GetString("OuterTop"));
                    comboBox.Items.Add(Resources.ResourceManager.GetString("Pants"));
                    comboBox.Items.Add(Resources.ResourceManager.GetString("Skirt"));
                    comboBox.Items.Add(Resources.ResourceManager.GetString("Hijab"));
                    comboBox.Items.Add(Resources.ResourceManager.GetString("Overall"));
                    comboBox.Items.Add(Resources.ResourceManager.GetString("Other"));
                    break;

                case "cbMaterial":
                    comboBox.Items.Add(Resources.ResourceManager.GetString("Cotton"));
                    comboBox.Items.Add(Resources.ResourceManager.GetString("Linen"));
                    comboBox.Items.Add(Resources.ResourceManager.GetString("Silk"));
                    comboBox.Items.Add(Resources.ResourceManager.GetString("Wool"));
                    comboBox.Items.Add(Resources.ResourceManager.GetString("Polyester"));
                    comboBox.Items.Add(Resources.ResourceManager.GetString("Nylon"));
                    comboBox.Items.Add(Resources.ResourceManager.GetString("Denim"));
                    comboBox.Items.Add(Resources.ResourceManager.GetString("Leather"));
                    comboBox.Items.Add(Resources.ResourceManager.GetString("Satin"));
                    comboBox.Items.Add(Resources.ResourceManager.GetString("Jersey"));
                    comboBox.Items.Add(Resources.ResourceManager.GetString("Other"));
                    break;

                case "cbClothColour":
                    comboBox.Items.Add(Resources.ResourceManager.GetString("Red"));
                    comboBox.Items.Add(Resources.ResourceManager.GetString("Orange"));
                    comboBox.Items.Add(Resources.ResourceManager.GetString("Yellow"));
                    comboBox.Items.Add(Resources.ResourceManager.GetString("Green"));
                    comboBox.Items.Add(Resources.ResourceManager.GetString("Blue"));
                    comboBox.Items.Add(Resources.ResourceManager.GetString("Indigo"));
                    comboBox.Items.Add(Resources.ResourceManager.GetString("Violet"));
                    comboBox.Items.Add(Resources.ResourceManager.GetString("Black"));
                    comboBox.Items.Add(Resources.ResourceManager.GetString("White"));
                    comboBox.Items.Add(Resources.ResourceManager.GetString("Grey"));
                    comboBox.Items.Add(Resources.ResourceManager.GetString("Brown"));
                    comboBox.Items.Add(Resources.ResourceManager.GetString("Other"));
                    break;
            }
        }


        public static void SetLanguage(string language)
        {
            if (language == "indonesia")
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("id-ID");
            }
            else if (language == "english")
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            }

            // Refresh the UI to apply new language
            foreach (Form form in Application.OpenForms)
            {
                UpdateUI(form);
            }
        }
    }
}
