namespace Patterns.Observer.GameEngine;

public class Player : ISubject
{
    private readonly IList<IObserver> _observers = [];
    private int _health;
    private int _score;
    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update();
        }
    }

    public int GetHealth()
    {
        return _health;
    }

    public int GetScore()
    {
        return _score;
    }

    public void SetState(int health, int score)
    {
        _health = health;
        _score = score;
        Notify();
    }
}
