using Patterns.Common;

namespace Patterns.Observer.GameEngine;

public class HealthBarUi(Player subject, IPatternsLogger logger) : IObserver
{
    private readonly Player _subject = subject;
    private readonly IPatternsLogger _logger = logger;

    public void Update()
    {
        var health = _subject.GetHealth();
        _logger.Log($"Health updated: {health}");
    }
}
