namespace AnimalCounter
{
    internal class Sheep : Animal
    {
       
        
        public string Name { get; set; }

        //public Sheep(string name)
        //{
        //    this.Name = name;
        //}

             
        public override string GetCountString() 
        {
            return Count + " " + Name;
        }

        
    }
}
