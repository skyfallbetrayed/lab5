// AirplaneDirector.cs
using System;
using System.Threading.Tasks;

public class AirplaneDirector
{
    private readonly IAirplaneBuilder _builder;
    private readonly Func<string, Task> _logActionAsync;

    public AirplaneDirector(IAirplaneBuilder builder, Func<string, Task> logActionAsync)
    {
        _builder = builder;
        _logActionAsync = logActionAsync;
    }

    public async Task ConstructAirplane()
    {
        await _logActionAsync("Встановлюється тип літака...");
        _builder.SetType();

        await _logActionAsync("Встановлюється кількість місць...");
        _builder.SetSeats();

        await _logActionAsync("Встановлюється вантажопідйомність...");
        _builder.SetCargoCapacity();

        await _logActionAsync("Встановлюється тип двигуна...");
        _builder.SetEngineType();

        await _logActionAsync("Встановлюється наявність WiFi...");
        _builder.SetWiFi();
    }

    public Airplane GetAirplane() => _builder.GetAirplane();
}
