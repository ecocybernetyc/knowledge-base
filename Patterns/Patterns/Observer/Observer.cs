using Patterns.Common;

namespace Patterns.Observer;

public class Observer(Subject subject, IPatternsLogger logger) : IObserver
{
    private readonly Subject _subject = subject;
    private readonly IPatternsLogger _logger = logger;

    public void Update()
    {
        var state = _subject.GetState();
        _logger.Log($"Observer updated with state: {state}");
    }
}
