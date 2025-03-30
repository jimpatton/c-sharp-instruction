using System.Net.Security;
using Microsoft.AspNetCore.Mvc;
using PolicyDomain.Services;

namespace PolicyDomain.Controllers;

[ApiController]
[Route("[controller]")]
public class PolicyController(IPolicyService policyService): ControllerBase
{
    [HttpGet(Name = "GetPolicy")]
    public PolicyResponse Get([FromQuery] PolicyRequest request)
    {       
        return policyService.GetPolicy(request.PolNum);
    }
   
}




 //private PolicyResponse GetPolicy(string polNum)
 //   {
 //       return new PolicyResponse
 //       {
 //           PolNum = polNum,
 //           FirstName = "John",
 //           LastName = "Doe",
 //           AmountDue = 100.00M,
 //           HasRiders = false,
 //           SpouseName = null
 //       };
 //   }