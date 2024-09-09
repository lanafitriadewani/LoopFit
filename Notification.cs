using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopFit
{
    public class Notification
    {
        public int NotificationID { get; set; }
        public string NotificationType { get; set; } // Progress/Pickup/History
        public string Message { get; set; }
        public bool IsRead { get; set; }

        public List<Notification> ViewNotifications()
        {
            // Logic to view notifications
            return new List<Notification>();
        }

        public void MarkAsRead(int notificationID)
        {
            // Logic to mark notification as read
        }

        public void AddNotification(string notificationType, string message)
        {
            NotificationType = notificationType;
            Message = message;
        }

        public void DeleteNotification(int notificationID)
        {
            // Logic to delete notification
        }
    }

}
