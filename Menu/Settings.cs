using UnityEngine;
using StupidTemplate.Classes;
using static StupidTemplate.Menu.Main;

namespace StupidTemplate
{
    internal class Settings
    {
        // Helper method to create a gradient from colors
        private static GradientColorKey[] GetGradientColorKeys(Color[] colors)
        {
            GradientColorKey[] gradientColorKeys = new GradientColorKey[colors.Length];
            for (int i = 0; i < colors.Length; i++)
            {
                gradientColorKeys[i] = new GradientColorKey(colors[i], (float)i / (colors.Length - 1));
            }
            return gradientColorKeys;
        }

        // Background color with a gradient transition
        public static ExtGradient backgroundColor = new ExtGradient
        {
            colors = GetGradientColorKeys(new Color[]
            {
                new Color(0.2f, 0.2f, 0.2f), // Dark gray
                new Color(0.6f, 0.6f, 0.6f)  // Brighter gray
            })
        };

        // Button colors with more pronounced gradients
        public static ExtGradient[] buttonColors =
        {
            new ExtGradient
            {
                colors = GetGradientColorKeys(new Color[]
                {
                    new Color(0.0f, 0.0f, 0.0f), // Black
                    new Color(0.3f, 0.3f, 0.3f)  // Dark gray
                })
            },
            new ExtGradient
            {
                colors = GetGradientColorKeys(new Color[]
                {
                    new Color(0.5f, 0.5f, 0.5f), // Light gray
                    new Color(0.8f, 0.8f, 0.8f)  // Pale gray
                })
            }
        };

        // Text colors remain unchanged for clarity
        public static Color[] textColors = new Color[]
        {
            Color.white, // Disabled
            Color.white  // Enabled
        };

        // Custom font for a more modern look
        public static Font currentFont = Resources.GetBuiltinResource(typeof(Font), "Arial.ttf") as Font;

        // Other settings
        public static bool fpsCounter = true;
        public static bool disconnectButton = true;
        public static bool rightHanded = false;
        public static bool disableNotifications = false;

        public static KeyCode keyboardButton = KeyCode.Q;

        // Menu size adjusted for better proportions
        public static Vector3 menuSize = new Vector3(0.2f, 1.5f, 1.5f); // Depth, Width, Height

        // Number of buttons per page for improved navigation
        public static int buttonsPerPage = 6;
    }
}
