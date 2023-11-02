using BusinessLogic.Formatters.Interfaces;

namespace BusinessLogic.Formatters;

public class DailyPointsFormatter : IDailyPointsFormatter
{
    public string Format(long dailyPoints)
    {
        return dailyPoints > 1000 ? (dailyPoints / 1000).ToString() + "k" : dailyPoints.ToString();
    }
}