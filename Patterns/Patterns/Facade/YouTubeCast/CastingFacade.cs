using Patterns.Common;

namespace Patterns.Facade.YouTubeCast;

public class CastingFacade(DeviceExplorer deviceExplorer)
{
    private readonly DeviceExplorer _deviceExplorer = deviceExplorer;

    public async Task CastAsync(Guid deviceId, Guid videoId)
    {
        var device = await _deviceExplorer.GetAsync(deviceId);

        if (device is not SmartTVDevice)
        {
            throw new NotSupportedException("Smart TV not found");
        }

        Connection connection;
        try
        {
            connection = await device.ConnectAsync();
        }
        catch
        {
            connection = await device.TurnOnAsync();
            await Task.Delay(2000);
        }

        var app = await connection.LaunchAppAsync("com.google.youtube");

        if (app is not YouTubeApp youTubeApp)
        {
            throw new NotSupportedException("Failed opening YouTube app.");
        }

        await youTubeApp.PlayAsync(videoId);
    }
}
