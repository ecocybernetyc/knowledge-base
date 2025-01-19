using Patterns.Common;

namespace Patterns.Facade.YouTubeCast;

public class SmartTVDevice(IPatternsLogger logger) : IDevice
{
    private readonly IPatternsLogger _logger = logger;

    public Task<Connection> ConnectAsync()
    {
        _logger.Log("TV is off");
        throw new NotImplementedException();
    }

    public Task<Connection> TurnOnAsync()
    {
        _logger.Log("Turning on TV");
        return Task.FromResult<Connection>(new(_logger));
    }
}
