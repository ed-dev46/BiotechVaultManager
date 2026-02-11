using System.ComponentModel;
using BioTechVaultManager;

CrioContainer<Virus> virusContainer = new CrioContainer<Virus>();

try
{
        var ebola = virusContainer.GetSpecimenByName("ebola");
} catch (Exception e)
{
        Console.WriteLine($"{e.Message}");
}

Console.ReadKey();