using System;
using System.Collections.Generic;
using System.Text;
using static BetterDayNightManager;

namespace Monkey_Magic_Menu.Mods.visuals
{

    internal class forceRain
{
    public static void ForceRain()
    {
        instance.weatherCycle[instance.currentWeatherIndex] = WeatherType.Raining;
        instance.CurrentWeather();
    }
}
}
