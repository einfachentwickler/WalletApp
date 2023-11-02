namespace BusinessLogic.Providers;

public class SystemClock : ISystemClock
{
    public DateTime UtcNow => DateTime.UtcNow;
}