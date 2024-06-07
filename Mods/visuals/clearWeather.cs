using System;
using System.Collections.Generic;
using System.Text;
using static BetterDayNightManager;

namespace Monkey_Magic_Menu.Mods.visuals
{
    internal class clearWeather
{
    public static void ClearWeather()
    {
        BetterDayNightManager.instance.weatherCycle[BetterDayNightManager.instance.currentWeatherIndex] = WeatherType.None;
        BetterDayNightManager.instance.CurrentWeather();
    }
}
}
