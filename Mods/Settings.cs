using static StupidTemplate.Menu.Main;
using static StupidTemplate.Settings;

namespace StupidTemplate.Mods
{
    internal class SettingsMods
    {
        public static void EnterSettings()
        {
            buttonsType = 0;
        }

        public static void MenuSettings()
        {
            buttonsType = 1;
        }

        public static void Movement()
        {
            buttonsType = 2;
        }

        public static void Advantages()
        {
            buttonsType = 3;
        }

        public static void Fun()
        {
            buttonsType = 4;
        }

        public static void Overpowered()
        {
            buttonsType = 5;
        }
        public static void Visuals()
        
        {
            buttonsType = 6;
        }

        public static void disconnects()
        {
        buttonsType = 7;
        }
        public static void speedboots()
        {
            buttonsType = 8;
        } 
        public static void FastSwim()
        {
            buttonsType = 9;
        }
        public static void colorofplats()
        {
            buttonsType = 10;
        }
   
        public static void RightHand()
        {
            rightHanded = true;
        }

        public static void LeftHand()
        {
            rightHanded = false;
        }

        public static void EnableFPSCounter()
        {
            fpsCounter = true;
        }

        public static void DisableFPSCounter()
        {
            fpsCounter = false;
        }

        public static void EnableNotifications()
        {
            disableNotifications = false;
        }

        public static void DisableNotifications()
        {
            disableNotifications = true;
        }
    }
}
