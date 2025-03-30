namespace PolicyDomain;

public class PolicyResponse
{
    public required string PolNum { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public decimal AmountDue { get; set; }
    public bool HasRiders { get; set; }
    public string? SpouseName { get; set; }

}
