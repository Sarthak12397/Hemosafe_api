using System.ComponentModel;

public class BloodsUnit
{
    public Guid id
    {
        get; private set;
    }

    public BloodTypes BloodType
    {
        get; private set;
    }
    
    public RhFactor RhFactor
    {
        get; private set;
    }
    public int VolumeML
    {
        get; private set;
    }
    public DateTime CollectedAt
    {
        get; private set;
    }
    public DateTime ExpiryAt
    {
        get; private set;
    }
    public Bloodstatus status
    {
        get; private set;
    }
    public Guid DonorId
    {
        get; private set;
    }

    public string? StorageLocation
    {
        get; private set;
    }
    public Guid ReservedForRequestId
    {
        get; private set;
    }
    public DateTime ReservedAt
    {
        get; private set;
    }
    public DateTime issuedAt
    {
        get; private set;
    }

    public DateTime Transfuedat
    {
        get; private set;
    }
    public int version
    {
        get; set;
    }
}