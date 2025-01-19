using Patterns.Common;

namespace Patterns.Facade.YouTubeCast;

public class YouTubeApp(IPatternsLogger logger) : IApp
{
    private readonly IPatternsLogger _logger = logger;

    public Task PlayAsync(Guid videoId)
    {
        _logger.Log($"Playing {videoId}");
        return Task.CompletedTask;
    }
}
