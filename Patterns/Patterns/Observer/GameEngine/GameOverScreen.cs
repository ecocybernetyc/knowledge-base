using Patterns.Common;

namespace Patterns.Observer.GameEngine;

public class GameOverScreen(Player subject, IPatternsLogger logger) : IObserver
{
    private readonly Player _subject = subject;
    private readonly IPatternsLogger _logger = logger;

    public void Update()
    {
        var health = _subject.GetHealth();

        if (health == 0)
        {
            _logger.Log("Game over!");
        }
    }
}
