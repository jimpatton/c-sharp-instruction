using Microsoft.AspNetCore.Mvc;

namespace CollectionsDemoWithMike.Controllers
{
    [ApiController]
    [Route("Collections")]
    public class WeatherForecastController : ControllerBase
    {

        public WeatherForecastController() { }

        [HttpGet("array")]

        public IActionResult GetArrayDemo()

        {

            string[] names = { "Alice", "Bob", "Charlie" };

            names[0] = "Steve";

            return Ok(new

            {

                Type = "Array",

                Data = names,

                Count = names.Length,

                ExampleAccess = names[1]

            });

        }

        // 2️⃣ List Demo: Dynamic, ordered, allows adding/removing.

        [HttpGet("list")]

        public IActionResult GetListDemo()

        {

            List<string> names = new List<string> { "Bob", "Charlie" };

            return Ok(new

            {

                Type = "List",

                Data = names,

                Count = names.Count,

                ExampleAccess = GetFirstName(names)

            });

        }

        private string? GetFirstName(List<string> names) =>

            names.FirstOrDefault(n => n == "Alice") ?? "There is no Alice here";

        // 3️⃣ Dictionary Demo: Key-value pair with fast lookups.

        [HttpGet("dictionary")]

        public IActionResult GetDictionaryDemo()

        {

            Dictionary<string, string> nameDict = new Dictionary<string, string>

{

    { "Alice Walter", "Walmart" },

    { "Alice Walter1", "Walmart" },

    { "Steve", "Target" }

};

            // Example of retrieving a value by key

            List<string> exampleValue = FilterContractors(nameDict);

            if (exampleValue is not null)

            {

                return Ok(new

                {

                    Type = "Dictionary",

                    Data = nameDict,

                    Count = nameDict.Count,

                    ExampleAccess = exampleValue // Getting value for key 2 (Bob)

                });

            }

            return BadRequest("The value was not there.");

        }

        private static List<string> FilterContractors(Dictionary<string, string> contracts)

        {

            //SELECT contract_key + ' : ' + contract_value AS FilteredContract

            //FROM Contracts

            //WHERE contract_key LIKE 'W%';

            return contracts

                .Where(c => c.Value == "Walmart")

                .Select(contract => contract.Key)

                .ToList();

        }

    }
}
