using Patterns.Common;
using Patterns.Observer;
using Patterns.Observer.GameEngine;

namespace Patterns.Test;

public static class ObserverExecuter
{
    public static async Task Execute(IPatternsLogger logger)
    {
        logger.Log("Generic Observer pattern started");

        Subject subject = new();

        IObserver firstObserver = new Observer.Observer(subject, logger);
        IObserver secondObserver = new Observer.Observer(subject, logger);

        subject.Attach(firstObserver);
        subject.Attach(secondObserver);

        subject.SetState("New State");

        await Task.Delay(1000);

        subject.Detach(firstObserver);

        subject.SetState("Another State");

        logger.Log("Generic Observer pattern executed");
        logger.Log("Game Engine Observer pattern started");

        Player player = new();

        player.Attach(new ScoreUi(player, logger));
        player.Attach(new HealthBarUi(player, logger));
        player.Attach(new GameOverScreen(player, logger));

        player.SetState(health: 100, score: 0);
        await Task.Delay(1000);
        player.SetState(health: 100, score: 10);
        await Task.Delay(1000);
        player.SetState(health: 80, score: 20);
        await Task.Delay(1000);
        player.SetState(health: 90, score: 30);
        await Task.Delay(1000);
        player.SetState(health: 0, score: 100);

        logger.Log("Game Engine Observer pattern executed");
    }
}
