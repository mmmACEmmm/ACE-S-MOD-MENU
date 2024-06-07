using System;
using System.Collections.Generic;
using System.Text;
using StupidTemplate.Menu;

namespace Monkey_Magic_Menu.Mods.visuals
{
    internal class WeatherMonicle
{
    public static int weatherMonicle = 2;
    public static void WeatherChangers()
    {
        weatherMonicle++;
        if (weatherMonicle > 5)
        {
            weatherMonicle = 2;
        }
        if (weatherMonicle == 2)
        {
            BetterDayNightManager.instance.SetTimeOfDay(1);
            Buttons.buttons[7][8].buttonText = "Time Changer [Aesthetic]";
            Buttons.buttons[7][8].overlapText = "Time Changer [Aesthetic]";
        }
        if (weatherMonicle == 3)
        {
            BetterDayNightManager.instance.SetTimeOfDay(3);
            Buttons.buttons[7][8].buttonText = "Time Changer [Day]";
            Buttons.buttons[7][8].overlapText = "Time Changer [Day]";
        }
        if (weatherMonicle == 4)
        {
            BetterDayNightManager.instance.SetTimeOfDay(0);
            Buttons.buttons[7][8].buttonText = "Time Changer [Night]";
            Buttons.buttons[7][8].overlapText = "Time Changer [Day]";
        }
        if (weatherMonicle == 5)
        {
            BetterDayNightManager.instance.SetTimeOfDay(6);
            Buttons.buttons[7][8].buttonText = "Time Changer [Fall]";
            Buttons.buttons[7][8].overlapText = "Time Changer [Day]";
        }
        Main.RecreateMenu();
    }
}

}
