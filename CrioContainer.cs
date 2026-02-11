namespace BioTechVaultManager;

using System.Linq;

public class CrioContainer<T> where T : Specimen
{
    private List<T> container = new List<T>();

    public void AddSpecimen(T specimen)
    {
        container.Add(specimen);
    }

    public T GetSpecimenByName(string name)
    {
        var specimen = container.FirstOrDefault(x => x.Name == name);
        if (specimen == null)
        {
            throw new Exception("Specimen not found!");
        } else
        {
            return specimen;
        }
    }
}