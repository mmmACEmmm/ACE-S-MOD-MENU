using StupidTemplate.Classes;
using StupidTemplate.Mods;
using static Monkey_Magic_Menu.Mods.Movement.SpeedBoost7f1f;
using static Monkey_Magic_Menu.Mods.Movement.SpeedBoost7f1f.SpeedBoost8f2f.SpeedBoost9f3f.SpeedBoost10f4f.SpeedBoost11f5f.SpeedBoost12f6f.SpeedBoost13f7f.SpeedBoost14f8f.SpeedBoost15f9f.SpeedBoost16f10f.SpeedBoost17f11f.SpeedBoost18f12f.SpeedBoost19f13f.SpeedBoost20f14f;
using static Monkey_Magic_Menu.Mods.Movement.SpeedBoost7f1f.SpeedBoost8f2f.SpeedBoost9f3f.SpeedBoost10f4f.SpeedBoost11f5f.SpeedBoost12f6f.SpeedBoost13f7f.SpeedBoost14f8f.SpeedBoost15f9f.SpeedBoost16f10f.SpeedBoost17f11f.SpeedBoost18f12f.SpeedBoost19f13f;
using static Monkey_Magic_Menu.Mods.Movement.SpeedBoost7f1f.SpeedBoost8f2f.SpeedBoost9f3f.SpeedBoost10f4f.SpeedBoost11f5f.SpeedBoost12f6f.SpeedBoost13f7f.SpeedBoost14f8f.SpeedBoost15f9f.SpeedBoost16f10f.SpeedBoost17f11f.SpeedBoost18f12f;
using static Monkey_Magic_Menu.Mods.Movement.SpeedBoost7f1f.SpeedBoost8f2f.SpeedBoost9f3f.SpeedBoost10f4f.SpeedBoost11f5f.SpeedBoost12f6f.SpeedBoost13f7f.SpeedBoost14f8f.SpeedBoost15f9f.SpeedBoost16f10f.SpeedBoost17f11f;
using static Monkey_Magic_Menu.Mods.Movement.SpeedBoost7f1f.SpeedBoost8f2f.SpeedBoost9f3f.SpeedBoost10f4f.SpeedBoost11f5f.SpeedBoost12f6f.SpeedBoost13f7f.SpeedBoost14f8f.SpeedBoost15f9f.SpeedBoost16f10f;
using static Monkey_Magic_Menu.Mods.Movement.SpeedBoost7f1f.SpeedBoost8f2f.SpeedBoost9f3f.SpeedBoost10f4f.SpeedBoost11f5f.SpeedBoost12f6f.SpeedBoost13f7f.SpeedBoost14f8f.SpeedBoost15f9f;
using static Monkey_Magic_Menu.Mods.Movement.SpeedBoost7f1f.SpeedBoost8f2f.SpeedBoost9f3f.SpeedBoost10f4f.SpeedBoost11f5f.SpeedBoost12f6f.SpeedBoost13f7f.SpeedBoost14f8f;
using static Monkey_Magic_Menu.Mods.Movement.SpeedBoost7f1f.SpeedBoost8f2f.SpeedBoost9f3f.SpeedBoost10f4f.SpeedBoost11f5f.SpeedBoost12f6f;
using static Monkey_Magic_Menu.Mods.Movement.SpeedBoost7f1f.SpeedBoost8f2f.SpeedBoost9f3f.SpeedBoost10f4f.SpeedBoost11f5f;
using static Monkey_Magic_Menu.Mods.Movement.SpeedBoost7f1f.SpeedBoost8f2f.SpeedBoost9f3f.SpeedBoost10f4f;
using static Monkey_Magic_Menu.Mods.Movement.SpeedBoost7f1f.SpeedBoost8f2f.SpeedBoost9f3f;
using static Monkey_Magic_Menu.Mods.Movement.SpeedBoost7f1f.SpeedBoost8f2f;
using static StupidTemplate.Settings;
using static Monkey_Magic_Menu.Mods.Movement.SpeedBoost7f1f.SpeedBoost8f2f.SpeedBoost9f3f.SpeedBoost10f4f.SpeedBoost11f5f.SpeedBoost12f6f.SpeedBoost13f7f;
using static Monkey_Magic_Menu.Mods.adavtages.changeTagAuraRange;
using Monkey_Magic_Menu.Mods.Movement;
using Monkey_Magic_Menu.Mods.adavtages;
using Monkey_Magic_Menu.Mods.Overpowered;
using Monkey_Magic_Menu.Mods.visuals;
using iiMenu.Mods;
using Monkey_Magic_Menu;
using Mods.visuals;

namespace StupidTemplate.Menu
{
    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Main Mods
                new ButtonInfo { buttonText = "MENU SETTINGS", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
                new ButtonInfo { buttonText = "MOVEMENT", method =() => SettingsMods.Movement(), isTogglable = false, toolTip = "Opens the movement settings for the menu."},
                new ButtonInfo { buttonText = "FUN", method =() => SettingsMods.Fun(), isTogglable = false, toolTip = "Opens the fun mod for the menu."},
                new ButtonInfo { buttonText = "ADVANTAGES", method =() => SettingsMods.Advantages(), isTogglable = false, toolTip = "Opens the Advantages mods for the menu."},
                new ButtonInfo { buttonText = "OVERPOWERED", method =() => SettingsMods.Overpowered(), isTogglable = false, toolTip = "Opens the Overpowered mods for the menu."},
                new ButtonInfo { buttonText = "VISUALS", method =() => SettingsMods.Visuals(), isTogglable = false, toolTip = "Opens the Visuals mods for the menu."},
                new ButtonInfo { buttonText = "DISCONNECT TYPES", method =() => SettingsMods.disconnects(), isTogglable = false, toolTip = "Opens the Disconnect types mods for the menu."},      
            },      
            new ButtonInfo[] { // Menu Settings
                new ButtonInfo { buttonText = "RETURN TO MAIN", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "RIGHT HAND", enableMethod =() => SettingsMods.RightHand(), disableMethod =() => SettingsMods.LeftHand(), toolTip = "Puts the menu on your right hand."},
                new ButtonInfo { buttonText = "NOTIFICATIONS", enableMethod =() => SettingsMods.EnableNotifications(), disableMethod =() => SettingsMods.DisableNotifications(), enabled = !disableNotifications, toolTip = "Toggles the notifications."},
                new ButtonInfo { buttonText = "FPS COUNTER", enableMethod =() => SettingsMods.EnableFPSCounter(), disableMethod =() => SettingsMods.DisableFPSCounter(), enabled = fpsCounter, toolTip = "Toggles the FPS counter."},       
            },
            new ButtonInfo[] { // Movement 
                new ButtonInfo { buttonText = "RETURN TO MAIN", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "speed boosts", method =() => SettingsMods.speedboots(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Uncap Max Velocity", method = uncapMaxVelocity.UncapMaxVelocity, toolTip = "Uncaps the maximum velocity for improved movement", isTogglable = true },
                new ButtonInfo { buttonText = "Fast Swim speeds", method =() => SettingsMods.FastSwim(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Left Grab Speed Boost", method = leftGrabSpeedBoost.LeftGrabSpeedBoost, toolTip = "Boosts speed when left grab is activated", isTogglable = true },
                new ButtonInfo { buttonText = "ZIP LINE NO FRICTION", method = () => zipLinenofriction.ZipLinenofriction(), toolTip = "ZIP LINE NO FRICTION", isTogglable = true },
                new ButtonInfo { buttonText = "Fix Water", method = fixwater.FixWater, toolTip = "Fixes water layers", isTogglable = true },
                new ButtonInfo { buttonText = "Solidify Water", method = solidWater.SolidWater, toolTip = "Makes water solid", isTogglable = true },
                new ButtonInfo { buttonText = "Disable Water", method = disableWater.DisableWater, toolTip = "Disables water", isTogglable = true },
                new ButtonInfo { buttonText = "Fly", method = fly.Fly, toolTip = "Allows the player to fly forward", isTogglable = true },
                new ButtonInfo { buttonText = "Joystick Fly", method = joystickFly.JoystickFly, toolTip = "Allows the player to fly using joystick input", isTogglable = true },
                new ButtonInfo { buttonText = "Auto Funny Run", method = autoFunnyRun.AutoFunnyRun, toolTip = "Automatically performs a funny running animation when grabbing with both hands", isTogglable = true },
                new ButtonInfo { buttonText = "Auto Pinch Climb", method = autoPinchClimb.AutoPinchClimb, toolTip = "Automatically performs a pinch climbing animation when grabbing with right hand", isTogglable = true },
                new ButtonInfo { buttonText = "Auto run", method = autorun.AutoRun, toolTip = "Enables autorun for your character", isTogglable = true },
                new ButtonInfo { buttonText = "Auto Dance", method = autoDance.AutoDance, toolTip = "Makes the gorilla dance", isTogglable = true },
                new ButtonInfo { buttonText = "Auto Walk", method = AutooWalk.Execute, toolTip = "Enables auto-walk for your character", isTogglable = true },
                new ButtonInfo { buttonText = "Auto Run", method = AutooRun.Execute, toolTip = "Enables auto-run for your character", isTogglable = true },

                new ButtonInfo { buttonText = "Grab Rig", method = grabRig.GrabRig, toolTip = "Enables grabbing the VR rig with the right hand", isTogglable = true }

            },
            new ButtonInfo[] { // Advantages
                new ButtonInfo { buttonText = "RETURN TO MAIN", method = () => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "COLOR OF PLATS", method = () => SettingsMods.colorofplats(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "CLEAR PLATFORMS", method = () => Platforms.Plattys(new UnityEngine.Color(0f, 0f, 0.0f)), toolTip = "Create invisible platforms ", isTogglable = true },
                new ButtonInfo { buttonText = "CHAMS", method = () => chams.Chams(), toolTip = "Charms (UNDETECTED)", isTogglable = true},  // Clarified tooltip
                new ButtonInfo { buttonText = "MOSA BOOST", method = () => MosaSpeed.Mosaspeed(), toolTip = "A speed boost 8f and 2f", isTogglable = true},
                new ButtonInfo { buttonText = "GHOST MONKEY", method = () => ghostmonkey.GhostMonke(), toolTip = "Ghost Monke", isTogglable = true},
                new ButtonInfo { buttonText = "INVIS MONKE", method = () => InvisMonke.InvisMonkeMod(), toolTip = "Invis Monke", isTogglable = true},
                new ButtonInfo { buttonText = "WALLWALK", method = () => wallwalk.WallWalkMod(), toolTip = "Wall walk", isTogglable = true},
                new ButtonInfo { buttonText = "PHYSICAL TAG AURA", method = () => physicalTagAura.PhysicalTagAura(), toolTip = "Apply physical tag aura effects", isTogglable = true },
                new ButtonInfo { buttonText = "AURA RANGE FIXER", method = () => changeTagAuraRange.ChangeTagAuraRange(), toolTip = "Apply physical tag aura effects", isTogglable = true },
                new ButtonInfo { buttonText = "TP GUN", method = () => TPGun.Tpgun(), toolTip = "It teleports you", isTogglable = true },  // Clarified tooltip
                new ButtonInfo { buttonText = "LONG ARMS", method = () => long_arms.weirdlongArms(), toolTip = "Long arms", isTogglable = true },
                new ButtonInfo { buttonText = "CONNECT TO EU SERVERS", method = () => Server_.EUServers(), toolTip = "Connects to European servers", isTogglable = true },
                new ButtonInfo { buttonText = "CONNECT TO US SERVERS", method = () => Server_.USServers(), toolTip = "Connects to US servers", isTogglable = true },
                new ButtonInfo { buttonText = "CONNECT TO USW SERVERS", method = () => Server_.USWServers(), toolTip = "Connects to US West servers", isTogglable = true },
                new ButtonInfo { buttonText = "UNLOCK COMPETITIVE QUEUE", method = () => unlockCompetitiveQueue.UnlockCompetitiveQueue(), toolTip = "Unlocks the competitive queue", isTogglable = true },
                new ButtonInfo { buttonText = "IRON MONKE", method = () => ironMonke.IronMonke(), toolTip = "Iron Monke", isTogglable = true },
                new ButtonInfo { buttonText = "45HZ", method = _45hz.Hertz45, toolTip = "Set the refresh rate to 45Hz", isTogglable = true },
                new ButtonInfo { buttonText = "Enable 10hz", method = () => enableRemoveLeaves.EnableRemoveLeaves(), toolTip = "Removes the leaves from the forest", isTogglable = true },
                new ButtonInfo { buttonText = "Disable 10hz", method = () => enableRemoveLeaves.DisableRemoveLeaves(), toolTip = "Restores the leaves in the forest", isTogglable = true },



},
            new ButtonInfo[] { // fun
                new ButtonInfo { buttonText = "RETURN TO MAIN", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "FIX HEAD", method = () => HeadMod.FixHead.fixHead(), toolTip = "Fixes the head position", isTogglable = true },
                new ButtonInfo { buttonText = "UPSIDE DOWN HEAD", method = () => HeadMod.UpsideDownHead.upsideDownHead(), toolTip = "Rotates the head 180 degrees", isTogglable = true },
                new ButtonInfo { buttonText = "BROKEN NECK", method = () => HeadMod.BrokenNeck.brokenNeck(), toolTip = "Rotates the head 90 degrees", isTogglable = true },
                new ButtonInfo { buttonText = "BACKWARDS HEAD", method = () => HeadMod.BackwardsHead.backwardsHead(), toolTip = "Rotates the head 180 degrees along the y-axis", isTogglable = true },
                new ButtonInfo { buttonText = "SPIN HEAD X", method = () => HeadMod.SpinHeadX.spinHeadX(), toolTip = "Spins the head along the x-axis", isTogglable = true },
                new ButtonInfo { buttonText = "FLIP HANDS", method = () => HandMod.FlipHands.flipHands(), toolTip = "Flips the hands positions and rotations", isTogglable = true },
                new ButtonInfo { buttonText = "FIX HAND TAPS", method = () => HandMod.FixHandTaps.fixHandTaps(), toolTip = "Sets the hand tap volume to 0.1f", isTogglable = true },
                new ButtonInfo { buttonText = "LOUD HAND TAPS", method = () => HandMod.LoudHandTaps.loudHandTaps(), toolTip = "Sets the hand tap volume to maximum", isTogglable = true },
                new ButtonInfo { buttonText = "SILENT HAND TAPS", method = () => HandMod.SilentHandTaps.silentHandTaps(), toolTip = "Disables hand taps", isTogglable = true },
                new ButtonInfo { buttonText = "ENABLE INSTANT HAND TAPS", method = () => HandMod.EnableInstantHandTaps.enableInstantHandTaps(), toolTip = "Enables instant hand taps", isTogglable = true },
                new ButtonInfo { buttonText = "DISABLE INSTANT HAND TAPS", method = () => HandMod.DisableInstantHandTaps.disableInstantHandTaps(), toolTip = "Disables instant hand taps", isTogglable = true },
                new ButtonInfo { buttonText = "Auto Join RUN", method = () => RoomJoiners.AutoJoinRoomRUN(), toolTip = "Automatically joins the RUN room", isTogglable = true },
                new ButtonInfo { buttonText = "Auto Join DAISY", method = () => RoomJoiners.AutoJoinRoomDAISY(), toolTip = "Automatically joins the DAISY room", isTogglable = true },
                new ButtonInfo { buttonText = "Auto Join DAISY09", method = () => RoomJoiners.AutoJoinRoomDAISY09(), toolTip = "Automatically joins the DAISY09 room", isTogglable = true },
                new ButtonInfo { buttonText = "Auto Join PBBV", method = () => RoomJoiners.AutoJoinRoomPBBV(), toolTip = "Automatically joins the PBBV room", isTogglable = true },
                new ButtonInfo { buttonText = "Auto Join BOT", method = () => RoomJoiners.AutoJoinRoomBOT(), toolTip = "Automatically joins the BOT room", isTogglable = true },
            },
            new ButtonInfo[] { // OVERPOWERED
               new ButtonInfo { buttonText = "RETURN TO MAIN", method = () => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
               new ButtonInfo { buttonText = "DISABLE NETWORK TRIGGERS CS", method = () => DisableNetworkTriggers.disableNetworkTriggers(), toolTip = "DISABLE NETWORK TRIGGERS UND", isTogglable = true },
               new ButtonInfo { buttonText = "DISABLE QUIT BOX", method = () => DisableQuitBox.disableQuitBox(), toolTip = "Disables the quit box", isTogglable = true },
               new ButtonInfo { buttonText = "GRAB PLAYER INFO", method = RestartGame.GrabPlayerInfo, toolTip = "Generates a text file with player information in the current room", isTogglable = false },
               new ButtonInfo { buttonText = "Mod menu protector", method = modmenuprotector.Modmenuprotector, toolTip = "Mod menu protector adds a Ghost monkey effect when you use your menu so no one can see you using It. So you don’t have to go run a hide to use your mod menu", isTogglable = true },



    },
            new ButtonInfo[] { // visuals
                new ButtonInfo { buttonText = "RETURN TO MAIN", method = () => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
               new ButtonInfo { buttonText = "Snake ESP ", method = () => snakeESP.SnakeESP(), toolTip = "Enables snake ESP visuals", isTogglable = true },
               new ButtonInfo { buttonText = "SkeletonESP", method = skeletonESP.SkeletonESP, toolTip = "Set color values to negative", isTogglable = true },
               new ButtonInfo { buttonText = "ESP", method = () => ESP.esp(), toolTip = "Enables ESP visuals", isTogglable = true },
               new ButtonInfo { buttonText = "Box ESP", method = () => boxESP.BoxESP(), toolTip = "Enables box ESP visuals", isTogglable = true },
               new ButtonInfo { buttonText = "Custom Sky ", method = () => Custom_Sky.CustomSky(), toolTip = "Changes the sky color", isTogglable = true },
               new ButtonInfo { buttonText = "Tracers", method = tracers.Tracers, toolTip = "Draw tracers between players", isTogglable = true },
               new ButtonInfo { buttonText = "Custom Boards", method = () => customboards.Customboards(), toolTip = "Customizes various boards in the environment", isTogglable = true },
               new ButtonInfo { buttonText = " Hat ", method = () => Hat.kkkHat(), toolTip = "Adds a hat to the character", isTogglable = true },
               new ButtonInfo { buttonText = "Sigma", method = () => ssigma.Sigma(), toolTip = "Enables sigma visuals", isTogglable = true },
               new ButtonInfo { buttonText = "color code name", method = () => nametag.Nametag(), toolTip = "Displays player name tags", isTogglable = true },
               new ButtonInfo { buttonText = "DAY TIME", method = () => daytime.DayTime(), toolTip = "makes it day time only CS", isTogglable = true },
               new ButtonInfo { buttonText = "NIGHT TIME", method = () => nightTime.NightTime(), toolTip = "makes it night time only CS", isTogglable = true },
               
               new ButtonInfo { buttonText = "ENABLE FPS BOOST", method = () => fpsboost.EnableFPSBoost(), toolTip = "Increases FPS by adjusting texture mipmaps", isTogglable = true },
               new ButtonInfo { buttonText = "BETTER FPS BOOST", method = betterFPSBoost.BetterFPSBoost, toolTip = "Improves FPS performance by optimizing shaders", isTogglable = true },
               new ButtonInfo { buttonText = "DISABLE FPS BOOST", method = () => disfpsboost.DisableFPSBoost(), toolTip = "Restores default FPS settings", isTogglable = true },
               new ButtonInfo { buttonText = "DISABLE MOUTH MOVEMENT", method = () => MouthMovement.DisableMouthMovement(), toolTip = "Disables mouth movement", isTogglable = true },
               new ButtonInfo { buttonText = "ENABLE MOUTH MOVEMENT", method = () => MouthMovement.EnableMouthMovement(), toolTip = "Enables mouth movement", isTogglable = true },
               new ButtonInfo { buttonText = "ACCEPT TERMS OF SERVICE", method = () => acceptTOS.AcceptTOS(), toolTip = "Accepts the Terms of Service", isTogglable = true },
               new ButtonInfo { buttonText = "FORCE RAIN", method = forceRain.ForceRain, toolTip = "Forces the weather to rain", isTogglable = false },
               new ButtonInfo { buttonText = "CLEAR WEATHER", method = clearWeather.ClearWeather, toolTip = "Clears the current weather", isTogglable = false },
               new ButtonInfo { buttonText = "CHANGE WEATHER", method = WeatherMonicle.WeatherChangers, toolTip = "Change the weather", isTogglable = false },
               new ButtonInfo { buttonText = "Negative Color", method = negativeColor.NegativeColor, toolTip = "Set color values to negative", isTogglable = false },
               new ButtonInfo { buttonText = "Make Everyone RGB", method = makeEveryoneRGB.MakeEveryoneRGB, toolTip = "Set everyone's color to RGB", isTogglable = true },
               new ButtonInfo { buttonText = "Green Screen", method = () => colorScreen.GreenScreen(), toolTip = "Creates a green screen environment", isTogglable = true },
               new ButtonInfo { buttonText = "Blue Screen", method = () => colorScreen.BlueScreen(), toolTip = "Creates a blue screen environment", isTogglable = true },
               new ButtonInfo { buttonText = "Red Screen", method = () => colorScreen.RedScreen(), toolTip = "Creates a red screen environment", isTogglable = true },
               new ButtonInfo { buttonText = "Urine", method = () => ProjectileShit.Urine(), toolTip = "Launch a yellow projectile", isTogglable = true },
               new ButtonInfo { buttonText = "Feces", method = () => ProjectileShit.Feces(), toolTip = "Launch a brown projectile", isTogglable = true },
               new ButtonInfo { buttonText = "Semen", method = () => ProjectileShit.Semen(), toolTip = "Launch a white projectile", isTogglable = true },
               new ButtonInfo { buttonText = "Vomit", method = () => ProjectileShit.Vomit(), toolTip = "Launch a green projectile", isTogglable = true },
               new ButtonInfo { buttonText = "Projectile Gun", method = () => ProjectileShit.ProjectileGun(), toolTip = "Use the projectile gun", isTogglable = true },
               new ButtonInfo { buttonText = "Projectile Rain", method = () => ProjectileShit.ProjectileRain(), toolTip = "Creates a rain of projectiles", isTogglable = true },














    },
            new ButtonInfo[] { // Disconnect types
                new ButtonInfo { buttonText = "RETURN TO Movement ", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "RIGHT GRIP", method = gripDisconnectrightGrip.GripDisconnectrightGrip, toolTip = "Disconnect using Right Grip", isTogglable = true },
                new ButtonInfo { buttonText = "LEFT GRIP", method = gripDisconnectleftGrip.GripDisconnestleftGrip, toolTip = "Disconnect using Left Grip", isTogglable = true },
                new ButtonInfo { buttonText = "RIGHT CONTROLLER SECONDARY", method =  rightControllerSecondary.RightControllerSecondary, toolTip = "Disconnect using Left Grip", isTogglable = true },
                new ButtonInfo { buttonText = "LEFT CONTROLLER SECONDARY", method =  leftControllerSecondary.LeftControllerSecondary, toolTip = "Disconnect using Left Grip", isTogglable = true },
            },
            new ButtonInfo[] { // speedboost
                new ButtonInfo { buttonText = "RETURN TO Movement", method =() => SettingsMods.Movement(), isTogglable = false, toolTip = "Returns to the Movement page of the menu."},
                new ButtonInfo { buttonText = "7F 1F", method = () => SpeedBoost7f1f.speedboost7f1f(), toolTip = "A speed boost of 7f and 1f", isTogglable = true },
                new ButtonInfo { buttonText = "8F 2F", method = () => SpeedBoost8f2f.speedboost8f2f(), toolTip = "A speed boost of 8f and 2f", isTogglable = true },
                new ButtonInfo { buttonText = "9F 3F", method = () => SpeedBoost9f3f.speedboost9f3f(), toolTip = "A speed boost of 9f and 3f", isTogglable = true },
                new ButtonInfo { buttonText = "10F 4F", method = () => SpeedBoost10f4f.speedboost10f4f(), toolTip = "A speed boost of 10f and 4f", isTogglable = true },
                new ButtonInfo { buttonText = "11F 5F", method = () => SpeedBoost11f5f.speedboost11f5f(), toolTip = "A speed boost of 11f and 5f", isTogglable = true },
                new ButtonInfo { buttonText = "12F 6F", method = () => SpeedBoost12f6f.speedboost12f6f(), toolTip = "A speed boost of 12f and 6f", isTogglable = true },
                new ButtonInfo { buttonText = "13F 7F", method = () => SpeedBoost13f7f.speedboost13f7f(), toolTip = "A speed boost of 13f and 7f", isTogglable = true },
                new ButtonInfo { buttonText = "14F 8F", method = () => SpeedBoost14f8f.speedboost14f8f(), toolTip = "A speed boost of 14f and 8f", isTogglable = true },
                new ButtonInfo { buttonText = "15F 9F", method = () => SpeedBoost15f9f.speedboost15f9f(), toolTip = "A speed boost of 15f and 9f", isTogglable = true },
                new ButtonInfo { buttonText = "16F 10F", method = () => SpeedBoost16f10f.speedboost16f10f(), toolTip = "A speed boost of 16f and 10f", isTogglable = true },
                new ButtonInfo { buttonText = "17F 11F", method = () => SpeedBoost17f11f.speedboost17f11f(), toolTip = "A speed boost of 17f and 11f", isTogglable = true },
                new ButtonInfo { buttonText = "18F 12F", method = () => SpeedBoost18f12f.speedboost18f12f(), toolTip = "A speed boost of 18f and 12f", isTogglable = true },
                new ButtonInfo { buttonText = "19F 13F", method = () => SpeedBoost19f13f.speedboost19f13f(), toolTip = "A speed boost of 19f and 13f", isTogglable = true },
                new ButtonInfo { buttonText = "20F 14F", method = () => SpeedBoost20f14f.speedboost20f14f(), toolTip = "A speed boost of 20f and 14f", isTogglable = true },
            },
            new ButtonInfo[] { // fastswimddd
                new ButtonInfo { buttonText = "RETURN TO Movement", method =() => SettingsMods.Movement(), isTogglable = false, toolTip = "Returns to the Movementpage of the menu."},


           },
             new ButtonInfo[] { // color of plats
                new ButtonInfo { buttonText = "RETURN TO ADVANTAGES", method = () => SettingsMods.Advantages(), isTogglable = false, toolTip = "Returns to the Advantages page of the menu."},
                new ButtonInfo { buttonText = "RED PLATFORMS", method = () => Platforms.Plattys(UnityEngine.Color.red), toolTip = "Create platforms with Red color", isTogglable = true },
                new ButtonInfo { buttonText = "BLUE PLATFORMS", method = () => Platforms.Plattys(UnityEngine.Color.blue), toolTip = "Create platforms with Blue color", isTogglable = true },
                new ButtonInfo { buttonText = "YELLOW PLATFORMS", method = () => Platforms.Plattys(UnityEngine.Color.yellow), toolTip = "Create platforms with Yellow color", isTogglable = true },
                new ButtonInfo { buttonText = "CYAN PLATFORMS", method = () => Platforms.Plattys(UnityEngine.Color.cyan), toolTip = "Create platforms with Cyan color", isTogglable = true },
                new ButtonInfo { buttonText = "MAGENTA PLATFORMS", method = () => Platforms.Plattys(UnityEngine.Color.magenta), toolTip = "Create platforms with Magenta color", isTogglable = true },
                new ButtonInfo { buttonText = "GREEN PLATFORMS", method = () => Platforms.Plattys(UnityEngine.Color.green), toolTip = "Create platforms with Green color", isTogglable = true },
                new ButtonInfo { buttonText = "GRAY PLATFORMS", method = () => Platforms.Plattys(UnityEngine.Color.gray), toolTip = "Create platforms with Gray color", isTogglable = true },
                new ButtonInfo { buttonText = "WHITE PLATFORMS", method = () => Platforms.Plattys(UnityEngine.Color.white), toolTip = "Create platforms with White color", isTogglable = true },
                new ButtonInfo { buttonText = "BLACK PLATFORMS", method = () => Platforms.Plattys(UnityEngine.Color.black), toolTip = "Create platforms with Black color", isTogglable = true },
                new ButtonInfo { buttonText = "ORANGE PLATFORMS", method = () => Platforms.Plattys(new UnityEngine.Color(1f, 0.5f, 0f)), toolTip = "Create platforms with Orange color", isTogglable = true },
                new ButtonInfo { buttonText = "AQUA PLATFORMS", method = () => Platforms.Plattys(new UnityEngine.Color(0f, 1f, 1f)), toolTip = "Create platforms with Aqua color", isTogglable = true },
                new ButtonInfo { buttonText = "PURPLE PLATFORMS", method = () => Platforms.Plattys(new UnityEngine.Color(0.5f, 0f, 0.5f)), toolTip = "Create platforms with Purple color", isTogglable = true },
                new ButtonInfo { buttonText = "OLIVE PLATFORMS", method = () => Platforms.Plattys(new UnityEngine.Color(0.5f, 0.5f, 0f)), toolTip = "Create platforms with Olive color", isTogglable = true },
                new ButtonInfo { buttonText = "DIM GRAY PLATFORMS", method = () => Platforms.Plattys(new UnityEngine.Color(0.5f, 0.5f, 0.5f)), toolTip = "Create platforms with Dim Gray color", isTogglable = true },
                new ButtonInfo { buttonText = "SILVER PLATFORMS", method = () => Platforms.Plattys(new UnityEngine.Color(0.75f, 0.75f, 0.75f)), toolTip = "Create platforms with Silver color", isTogglable = true },
                new ButtonInfo { buttonText = "DIM GREY PLATFORMS", method = () => Platforms.Plattys(new UnityEngine.Color(0.25f, 0.25f, 0.25f)), toolTip = "Create platforms with Dim Grey color", isTogglable = true },
                new ButtonInfo { buttonText = "LIGHT GREY PLATFORMS", method = () => Platforms.Plattys(new UnityEngine.Color(0.75f, 0.75f, 0.75f)), toolTip = "Create platforms with Light Grey color", isTogglable = true },
                new ButtonInfo { buttonText = "PALE GREEN PLATFORMS", method = () => Platforms.Plattys(new UnityEngine.Color(0.6f, 0.8f, 0.4f)), toolTip = "Create platforms with Pale Green color", isTogglable = true
                    },




           },
        };
    }
}
