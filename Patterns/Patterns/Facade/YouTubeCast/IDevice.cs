namespace Patterns.Facade.YouTubeCast;

public interface IDevice
{
    Task<Connection> ConnectAsync();

    Task<Connection> TurnOnAsync();
}
