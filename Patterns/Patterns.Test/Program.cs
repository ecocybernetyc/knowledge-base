using Patterns.Test;

var logger = new ConsoleLogger();
await ObserverExecuter.Execute(logger);

Console.ReadKey();
