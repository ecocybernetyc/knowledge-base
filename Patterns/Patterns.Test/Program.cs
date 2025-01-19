using Patterns.Test;

var logger = new ConsoleLogger();
await ObserverExecuter.Execute(logger);

logger.Log(string.Empty);
await FacadeExecuter.Execute(logger);

Console.ReadKey();
