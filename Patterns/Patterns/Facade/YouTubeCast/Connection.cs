using Patterns.Common;

namespace Patterns.Facade.YouTubeCast;

public class Connection(IPatternsLogger logger)
{
    private readonly IPatternsLogger _logger = logger;

    public Task<IApp> LaunchAppAsync(string appId)
    {
        _logger.Log($"Launching {appId}");

        return Task.FromResult<IApp>(new YouTubeApp(_logger));
    }
}
