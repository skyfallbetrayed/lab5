// PassengerAirplaneBuilder.cs
public class PassengerAirplaneBuilder : IAirplaneBuilder
{
    private Airplane passengerAirplane = new Airplane();

    public void SetType() => passengerAirplane.Type = "Passenger Airplane";
    public void SetSeats() => passengerAirplane.Seats = 180;
    public void SetCargoCapacity() => passengerAirplane.CargoCapacity = 20000;
    public void SetEngineType() => passengerAirplane.EngineType = "Turbofan";
    public void SetWiFi() => passengerAirplane.HasWiFi = true;

    public Airplane GetAirplane() => passengerAirplane;
}
