namespace BioTechVaultManager;

public class Virus : Specimen, IRisk
{
    public Virus(string id, string name, double temperatureC) : base(id, name, temperatureC)
    {
    }

    public RiskLevelEnum RiskLevel => RiskLevelEnum.DANGEROUS;

    public void AlertProtocol()
    {
        Console.WriteLine($"ALERTA! VIRUS {Name} DETECTADO");
        Thread.Sleep(2000);
        Console.WriteLine("PROTOCOLOS DE CONTENÇÃO ATIVADOS");
        Thread.Sleep(2000);
        Console.WriteLine("ISOLANDO ÁREA AFETADA...");
        Thread.Sleep(2000);
        Console.WriteLine("DESCONTAMINAÇÃO EM ANDAMENTO...");
        Thread.Sleep(2000);
        Console.WriteLine("ATIVAÇÃO DE RESPOSTA IMUNOLÓGICA ASSISTIDA...");
        Thread.Sleep(2000);
        Console.WriteLine("AMEAÇA NEUTRALIZADA! DESATIVANDO QUARENTENA...");
    }
}
