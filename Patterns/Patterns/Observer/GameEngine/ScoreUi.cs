using Patterns.Common;

namespace Patterns.Observer.GameEngine;

public class ScoreUi(Player subject, IPatternsLogger logger) : IObserver
{
    private readonly Player _subject = subject;
    private readonly IPatternsLogger _logger = logger;

    public void Update()
    {
        var score = _subject.GetScore();
        _logger.Log($"Score updated: {score}");
    }
}
