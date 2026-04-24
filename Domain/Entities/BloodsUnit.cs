using System.ComponentModel;

public class BloodsUnit
{
    public Guid Id
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
    public DateTime IssuedAt
    {
        get; private set;
    }

    public DateTime Transfuedat
    {
        get; private set;
    }
    public int Version
    {
        get; set;
    }


public BloodsUnit(
    Guid id,
    BloodTypes bloodType,
    RhFactor rhFactor,
    int volumeML,
    DateTime collectedAt,
    DateTime expiryAt,
    Bloodstatus status,
    Guid donorId,
    string? storageLocation = null,
    Guid? reservedForRequestId = null,
    DateTime? reservedAt = null,
    DateTime? issuedAt = null,
    DateTime? transfusedAt = null,
    int version = 1)
{
    Id = id;
    BloodType = bloodType;
    RhFactor = rhFactor;
    VolumeML = volumeML;
    CollectedAt = collectedAt;
    ExpiryAt = expiryAt;
    this.status = status;
    DonorId = donorId;
    StorageLocation = storageLocation;

    ReservedForRequestId = reservedForRequestId ?? Guid.Empty;
    ReservedAt = reservedAt ?? DateTime.MinValue;
    IssuedAt = issuedAt ?? DateTime.MinValue;
    Transfuedat = transfusedAt ?? DateTime.MinValue;

    Version = version;
}
}