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
            /// Update all labels in the parent control and its children
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

            // Check other controls as needed (e.g., TextBox, LinkLabel, etc.)
            foreach (Control otherControl in parentControl.Controls)
            {
                // Only call UpdateUI if the control is of type Control (or subclass of Control)
                if (otherControl is Control)
                {
                    UpdateUI(otherControl); // Recursively call for nested controls
                }
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
