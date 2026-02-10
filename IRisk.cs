namespace BioTechVaultManager;

public interface IRisk
{
    RiskLevelEnum RiskLevel { get; }
    void AlertProtocol();
}
