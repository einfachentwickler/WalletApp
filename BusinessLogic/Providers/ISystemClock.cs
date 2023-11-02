namespace BusinessLogic.Providers;

public interface ISystemClock
{
    public DateTime UtcNow { get; }
}