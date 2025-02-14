using System.Xml.Linq;

namespace AnimalCounter
{
    internal class Alligator : Animal
    {

        public override string GetCountString()
        {
            return Count + "Alligator";
        }
    }
}
