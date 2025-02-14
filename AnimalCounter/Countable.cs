using System.Security.Cryptography.X509Certificates;

namespace AnimalCounter
{
    internal interface Countable
    {
        public void IncrementCount();

        public void ResetCount();

       
        public string GetCountString();

     }
}
