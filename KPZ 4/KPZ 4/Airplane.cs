// Airplane.cs
public class Airplane : IPrototype<Airplane>
{
    public string Type { get; set; }
    public int Seats { get; set; }
    public int CargoCapacity { get; set; }
    public string EngineType { get; set; }
    public bool HasWiFi { get; set; }

    public Airplane Clone()
    {
        return (Airplane)MemberwiseClone();
    }

    public override string ToString()
    {
        return $"Тип: {Type}\n" +
               $"Кількість місць: {Seats}\n" +
               $"Вантажопідйомність: {CargoCapacity} кг\n" +
               $"Тип двигуна: {EngineType}\n" +
               $"Наявність WiFi: {(HasWiFi ? "Так" : "Ні")}";
    }
}
