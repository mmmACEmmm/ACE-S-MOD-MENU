using System;

namespace Monkey_Magic_Menu.Mods.adavtages
{
    internal class ghostmonkey
    {
        // Define a boolean variable to keep track of the state
        private static bool isGhostMonkeEnabled = false;

        public static void GhostMonke()
        {
            // Toggle the state when the right controller secondary button is pressed
            if (ControllerInputPoller.instance.rightControllerSecondaryButton)
            {
                isGhostMonkeEnabled = !isGhostMonkeEnabled;
            }

            // Set the state of offlineVRRig based on the boolean variable
            GorillaTagger.Instance.offlineVRRig.enabled = isGhostMonkeEnabled;
        }
    }
}
