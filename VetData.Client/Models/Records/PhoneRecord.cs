namespace VetData.Client.Models;

public record PhoneRecord
{
    public string ID { get; init; } = string.Empty;
    public string? Type { get; init; }
    public bool? IsPrimary { get; init; }
    public string Number { get; init; } = string.Empty;
    public string RelationshipId { get; init; } = string.Empty;
    public string? RelationshipPmsId { get; init; }
    public string RelationshipEntity { get; init; } = string.Empty;
    public DateTime APICreateDate { get; init; }
    public DateTime? APILastChangeDate { get; init; }
    public DateTime? APIRemovedDate { get; init; }
    public Guid InstallationId { get; init; }
}
