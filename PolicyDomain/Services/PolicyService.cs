namespace PolicyDomain.Services;
public interface IPolicyService
{
    PolicyResponse GetPolicy(string polNum);
}

public class PolicyService : IPolicyService
{
   public PolicyResponse GetPolicy(string polNum)
    {
        return new PolicyResponse
        {
            PolNum = polNum,
            FirstName = "John",
            LastName = "Doe",
            AmountDue = 100.00M,
            HasRiders = false,
            SpouseName = null
        };
    }
}

