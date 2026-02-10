namespace BioTechVaultManager;

public abstract class Specimen
{
    public string Id { get; }
    public string Name { get; set; }
    public double TemperatureC { get; protected set; }

    public Specimen(string id, string name, double temperatureC)
    {
        this.Id = id;
        this.Name = name;
        this.TemperatureC = temperatureC;
    }
}
