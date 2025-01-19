using Patterns.Common;

namespace Patterns.Facade.YouTubeCast;

public class DeviceExplorer(IPatternsLogger logger)
{
    private readonly IPatternsLogger _logger = logger;

    public Task<IDevice> GetAsync(Guid deviceId)
    {
        _logger.Log($"Getting {deviceId}");

        return Task.FromResult<IDevice>(new SmartTVDevice(_logger));
    }
}
