// CargoAirplaneBuilder.cs
public class CargoAirplaneBuilder : IAirplaneBuilder
{
    private Airplane cargoAirplane = new Airplane();

    public void SetType() => cargoAirplane.Type = "Cargo Airplane";
    public void SetSeats() => cargoAirplane.Seats = 2;
    public void SetCargoCapacity() => cargoAirplane.CargoCapacity = 100000;
    public void SetEngineType() => cargoAirplane.EngineType = "Turboprop";
    public void SetWiFi() => cargoAirplane.HasWiFi = false;

    public Airplane GetAirplane() => cargoAirplane;
}
