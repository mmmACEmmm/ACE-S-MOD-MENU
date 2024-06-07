using UnityEngine;
using UnityEngine.UI;
using BepInEx;

namespace Monkey_Magic_Menu.Mods.visuals
{
    [BepInPlugin("com.ace.GhostGuiTemp", "ACE'S CASTING MOD", "1.0.0")]
    public class GhostGUI : BaseUnityPlugin
    {
        private bool showGUI = true;
        private bool showCameraTab, showInfoTab, showModsTab;
        private bool showMainMenu = true, showMenuSettings, showMovement, showFun, showAdvantages, showOverpowered, showVisuals, showDisconnectTypes, showColorOfPlats, showSpeedBoost, showFastSwim;

        private Camera mainCamera;
        private Vector3 freeCamPosition, freeCamRotation;
        private float fovAngle = 60f, timeOfDay = 12f, zoomLevel = 5f, rotationSpeed = 100f, clippingDistance = 100f;
        private Rect guiRect = new Rect(40, 40, 600, 1000);

        private string joinCode = "Enter code";
        private float posX, posY, posZ, rotX, rotY, rotZ;

        private readonly bool[] toggles = new bool[81];
        public GUISkin customSkin;

        void Start()
        {
            mainCamera = Camera.main;
            freeCamPosition = mainCamera.transform.position;
            freeCamRotation = mainCamera.transform.eulerAngles;

            // Load the custom skin
            customSkin = Resources.Load<GUISkin>("Path/To/Your/CustomSkin");
        }

        void OnGUI()
        {
            if (showGUI)
            {
                GUI.skin = customSkin; // Apply the custom skin
                guiRect = GUI.Window(0, guiRect, DrawGUI, "ACE'S GUI [F1 = Toggle]");
            }
        }

        void DrawGUI(int windowID)
        {
            GUI.color = new Color(0.0f, 0.2f, 0.0f);
            GUI.Box(new Rect(0, 0, guiRect.width, guiRect.height), "");

            GUI.color = new Color(1.0f, 1.0f, 1.0f); // Reset color to default for the content
            GUI.contentColor = new Color(1.0f, 1.0f, 1.0f);

            GUI.DragWindow();

            if (showMainMenu) DrawMainMenu();
            if (showMenuSettings) DrawMenuSettings();
            if (showMovement) DrawMovement();
            if (showFun) DrawFun();
            if (showAdvantages) DrawAdvantages();
            if (showOverpowered) DrawOverpowered();
            if (showVisuals) DrawVisuals();
            if (showDisconnectTypes) DrawDisconnectTypes();
            if (showColorOfPlats) DrawColorOfPlats();
            if (showSpeedBoost) DrawSpeedBoost();
            if (showFastSwim) DrawFastSwim();
            if (showInfoTab) DrawInfoTab();
            if (showCameraTab) DrawCameraTab();

            if (GUI.Button(new Rect(560, 10, 20, 20), "X")) showGUI = false;

            GUI.DragWindow(new Rect(0, 0, 10000, 20));
        }

        private void DrawMainMenu()
        {
            if (GUI.Button(new Rect(20, 30, 150, 30), "MENU SETTINGS")) { showMainMenu = false; showMenuSettings = true; }
            if (GUI.Button(new Rect(20, 70, 150, 30), "MOVEMENT")) { showMainMenu = false; showMovement = true; }
            if (GUI.Button(new Rect(20, 110, 150, 30), "FUN")) { showMainMenu = false; showFun = true; }
            if (GUI.Button(new Rect(20, 150, 150, 30), "ADVANTAGES")) { showMainMenu = false; showAdvantages = true; }
            if (GUI.Button(new Rect(20, 190, 150, 30), "OVERPOWERED")) { showMainMenu = false; showOverpowered = true; }
            if (GUI.Button(new Rect(20, 230, 150, 30), "VISUALS")) { showMainMenu = false; showVisuals = true; }
            if (GUI.Button(new Rect(20, 270, 150, 30), "DISCONNECT TYPES")) { showMainMenu = false; showDisconnectTypes = true; }
            if (GUI.Button(new Rect(20, 310, 150, 30), "INFO")) { showMainMenu = false; showInfoTab = true; }
            if (GUI.Button(new Rect(20, 350, 150, 30), "CAMERA")) { showMainMenu = false; showCameraTab = true; }
        }

        private void DrawMenuSettings()
        {
            if (GUI.Button(new Rect(10, 10, 150, 30), "RETURN TO MAIN")) { showMenuSettings = false; showMainMenu = true; }
            GUI.Toggle(new Rect(10, 50, 150, 30), false, "RIGHT HAND");
            GUI.Toggle(new Rect(10, 90, 150, 30), false, "NOTIFICATIONS");
            GUI.Toggle(new Rect(10, 130, 150, 30), false, "FPS COUNTER");
        }

        private void DrawMovement()
        {
            if (GUI.Button(new Rect(10, 10, 150, 30), "RETURN TO MAIN")) { showMovement = false; showMainMenu = true; }
            if (GUI.Button(new Rect(10, 50, 150, 30), "Speed Boost")) { showMovement = false; showSpeedBoost = true; }
            GUI.Toggle(new Rect(10, 90, 150, 30), false, "Uncap Max Velocity");
            GUI.Toggle(new Rect(10, 130, 150, 30), false, "Fast Swim speeds");
            GUI.Toggle(new Rect(10, 170, 150, 30), false, "Left Grab Speed Boost");
            GUI.Toggle(new Rect(10, 210, 150, 30), false, "ZIP LINE NO FRICTION");
            GUI.Toggle(new Rect(10, 250, 150, 30), false, "Fix Water");
            GUI.Toggle(new Rect(10, 290, 150, 30), false, "Solidify Water");
            GUI.Toggle(new Rect(10, 330, 150, 30), false, "Disable Water");
            GUI.Toggle(new Rect(10, 370, 150, 30), false, "Fly");
            GUI.Toggle(new Rect(10, 410, 150, 30), false, "Joystick Fly");
            GUI.Toggle(new Rect(10, 450, 150, 30), false, "Auto Funny Run");
            GUI.Toggle(new Rect(10, 490, 150, 30), false, "Auto Pinch Climb");
            GUI.Toggle(new Rect(10, 530, 150, 30), false, "Auto run");
            GUI.Toggle(new Rect(10, 570, 150, 30), false, "Grab Rig");
        }

        private void DrawFun()
        {
            if (GUI.Button(new Rect(10, 10, 150, 30), "RETURN TO MAIN")) { showFun = false; showMainMenu = true; }
            GUI.Toggle(new Rect(10, 50, 150, 30), false, "FIX HEAD");
            GUI.Toggle(new Rect(10, 90, 150, 30), false, "UPSIDE DOWN HEAD");
            GUI.Toggle(new Rect(10, 130, 150, 30), false, "BROKEN NECK");
            GUI.Toggle(new Rect(10, 170, 150, 30), false, "BACKWARDS HEAD");
            GUI.Toggle(new Rect(10, 210, 150, 30), false, "SPIN HEAD X");
            GUI.Toggle(new Rect(10, 250, 150, 30), false, "FLIP HANDS");
            GUI.Toggle(new Rect(10, 290, 150, 30), false, "FIX HAND TAPS");
            GUI.Toggle(new Rect(10, 330, 150, 30), false, "LOUD HAND TAPS");
            GUI.Toggle(new Rect(10, 370, 150, 30), false, "SILENT HAND TAPS");
            GUI.Toggle(new Rect(10, 410, 150, 30), false, "ENABLE INSTANT HAND TAPS");
            GUI.Toggle(new Rect(10, 450, 150, 30), false, "DISABLE INSTANT HAND TAPS");
        }

        private void DrawAdvantages()
        {
            if (GUI.Button(new Rect(10, 10, 150, 30), "RETURN TO MAIN")) { showAdvantages = false; showMainMenu = true; }
            GUI.Toggle(new Rect(10, 50, 150, 30), false, "Lag Prevention");
            GUI.Toggle(new Rect(10, 90, 150, 30), false, "Breakout Prevention");
            GUI.Toggle(new Rect(10, 130, 150, 30), false, "Double Time");
            GUI.Toggle(new Rect(10, 170, 150, 30), false, "Multihit Prevention");
            GUI.Toggle(new Rect(10, 210, 150, 30), false, "Fast Unstuck");
        }

        private void DrawOverpowered()
        {
            if (GUI.Button(new Rect(10, 10, 150, 30), "RETURN TO MAIN")) { showOverpowered = false; showMainMenu = true; }
            GUI.Toggle(new Rect(10, 50, 150, 30), false, "God Mode");
            GUI.Toggle(new Rect(10, 90, 150, 30), false, "Invisible");
            GUI.Toggle(new Rect(10, 130, 150, 30), false, "Stamina Mod");
            GUI.Toggle(new Rect(10, 170, 150, 30), false, "Friction Mod");
            GUI.Toggle(new Rect(10, 210, 150, 30), false, "Underwater Mode");
            GUI.Toggle(new Rect(10, 250, 150, 30), false, "Freecam");
        }

        private void DrawVisuals()
        {
            if (GUI.Button(new Rect(10, 10, 150, 30), "RETURN TO MAIN")) { showVisuals = false; showMainMenu = true; }
            GUI.Toggle(new Rect(10, 50, 150, 30), false, "All Colors");
            GUI.Toggle(new Rect(10, 90, 150, 30), false, "Neon Colors");
            GUI.Toggle(new Rect(10, 130, 150, 30), false, "Reds");
            GUI.Toggle(new Rect(10, 170, 150, 30), false, "Blues");
            GUI.Toggle(new Rect(10, 210, 150, 30), false, "Greens");
            GUI.Toggle(new Rect(10, 250, 150, 30), false, "Pinks");
            GUI.Toggle(new Rect(10, 290, 150, 30), false, "Purples");
            GUI.Toggle(new Rect(10, 330, 150, 30), false, "All Types");
        }

        private void DrawDisconnectTypes()
        {
            if (GUI.Button(new Rect(10, 10, 150, 30), "RETURN TO MAIN")) { showDisconnectTypes = false; showMainMenu = true; }
            GUI.Toggle(new Rect(10, 50, 150, 30), false, "Host");
            GUI.Toggle(new Rect(10, 90, 150, 30), false, "All Players");
            GUI.Toggle(new Rect(10, 130, 150, 30), false, "Random Players");
            GUI.Toggle(new Rect(10, 170, 150, 30), false, "Report Only");
            GUI.Toggle(new Rect(10, 210, 150, 30), false, "Server");
        }

        private void DrawColorOfPlats()
        {
            if (GUI.Button(new Rect(10, 10, 150, 30), "RETURN TO MAIN")) { showColorOfPlats = false; showMainMenu = true; }
            GUI.Toggle(new Rect(10, 50, 150, 30), false, "Red");
            GUI.Toggle(new Rect(10, 90, 150, 30), false, "Blue");
            GUI.Toggle(new Rect(10, 130, 150, 30), false, "Green");
            GUI.Toggle(new Rect(10, 170, 150, 30), false, "Yellow");
        }

        private void DrawSpeedBoost()
        {
            if (GUI.Button(new Rect(10, 10, 150, 30), "RETURN TO MAIN")) { showSpeedBoost = false; showMovement = true; }
            GUI.Toggle(new Rect(10, 50, 150, 30), false, "Activate Speed Boost");
            GUI.Toggle(new Rect(10, 90, 150, 30), false, "Adjust Speed Boost");
        }

        private void DrawFastSwim()
        {
            if (GUI.Button(new Rect(10, 10, 150, 30), "RETURN TO MAIN")) { showFastSwim = false; showMovement = true; }
            GUI.Toggle(new Rect(10, 50, 150, 30), false, "Activate Fast Swim");
            GUI.Toggle(new Rect(10, 90, 150, 30), false, "Adjust Fast Swim Speed");
        }

        private void DrawInfoTab()
        {
            if (GUI.Button(new Rect(10, 10, 150, 30), "RETURN TO MAIN")) { showInfoTab = false; showMainMenu = true; }
            GUI.Label(new Rect(10, 50, 200, 30), "Info goes here...");
        }

        private void DrawCameraTab()
        {
            if (GUI.Button(new Rect(10, 10, 150, 30), "RETURN TO MAIN")) { showCameraTab = false; showMainMenu = true; }
            fovAngle = GUI.HorizontalSlider(new Rect(10, 50, 200, 30), fovAngle, 30f, 120f);
            GUI.Label(new Rect(220, 50, 200, 30), $"FOV: {fovAngle}");

            timeOfDay = GUI.HorizontalSlider(new Rect(10, 90, 200, 30), timeOfDay, 0f, 24f);
            GUI.Label(new Rect(220, 90, 200, 30), $"Time of Day: {timeOfDay}");

            zoomLevel = GUI.HorizontalSlider(new Rect(10, 130, 200, 30), zoomLevel, 1f, 10f);
            GUI.Label(new Rect(220, 130, 200, 30), $"Zoom Level: {zoomLevel}");

            rotationSpeed = GUI.HorizontalSlider(new Rect(10, 170, 200, 30), rotationSpeed, 50f, 200f);
            GUI.Label(new Rect(220, 170, 200, 30), $"Rotation Speed: {rotationSpeed}");

            clippingDistance = GUI.HorizontalSlider(new Rect(10, 210, 200, 30), clippingDistance, 0.1f, 500f);
            GUI.Label(new Rect(220, 210, 200, 30), $"Clipping Distance: {clippingDistance}");

            if (GUI.Button(new Rect(10, 250, 200, 30), "Save Camera Position"))
            {
                freeCamPosition = mainCamera.transform.position;
                freeCamRotation = mainCamera.transform.eulerAngles;
            }

            if (GUI.Button(new Rect(10, 290, 200, 30), "Load Camera Position"))
            {
                mainCamera.transform.position = freeCamPosition;
                mainCamera.transform.eulerAngles = freeCamRotation;
            }

            GUI.Label(new Rect(10, 330, 200, 30), "Camera Position");
            posX = float.Parse(GUI.TextField(new Rect(10, 370, 60, 30), posX.ToString()));
            posY = float.Parse(GUI.TextField(new Rect(80, 370, 60, 30), posY.ToString()));
            posZ = float.Parse(GUI.TextField(new Rect(150, 370, 60, 30), posZ.ToString()));

            GUI.Label(new Rect(10, 410, 200, 30), "Camera Rotation");
            rotX = float.Parse(GUI.TextField(new Rect(10, 450, 60, 30), rotX.ToString()));
            rotY = float.Parse(GUI.TextField(new Rect(80, 450, 60, 30), rotY.ToString()));
            rotZ = float.Parse(GUI.TextField(new Rect(150, 450, 60, 30), rotZ.ToString()));

            if (GUI.Button(new Rect(10, 490, 200, 30), "Apply Camera Transform"))
            {
                mainCamera.transform.position = new Vector3(posX, posY, posZ);
                mainCamera.transform.eulerAngles = new Vector3(rotX, rotY, rotZ);
            }
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.F1))
            {
                showGUI = !showGUI;
            }
        }
    }
}
