using Patterns.Common;

namespace Patterns.Test
{
    public static class FacadeExecuter
    {
        public static async Task Execute(IPatternsLogger logger)
        {
            logger.Log("Generic Facade pattern started");

            var facade = new Facade.Facade();
            facade.Operation1();

            logger.Log("Generic Facade pattern executed");

            logger.Log("YouTube Cast Facade pattern started");

            var deviceExplorer = new Facade.YouTubeCast.DeviceExplorer(logger);
            var youTubeCastFacade = new Facade.YouTubeCast.CastingFacade(deviceExplorer);
            await youTubeCastFacade.CastAsync(deviceId: Guid.NewGuid(), videoId: Guid.NewGuid());

            logger.Log("YouTube Cast Facade pattern executed");
        }
    }
}
