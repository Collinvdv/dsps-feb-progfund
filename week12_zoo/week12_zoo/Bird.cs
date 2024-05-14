using System;
namespace week12_zoo
{
	public class Bird: Animal
	{
		// Properties
		public Boolean IsFlying { get; set; }

		// Constructor
		public Bird(string _name) : base(_name)
		{
		}

        public Bird(string _name, DateOnly _dob) : base(_name, _dob)
        {
        }

		// Methods
		public void Fly()
		{
			Console.WriteLine("YIHAAH I am flying");
			this.IsFlying = true;
		}

        public void Landing()
        {
            Console.WriteLine("YIHAAH I am on the earth again");
            this.IsFlying = false;
        }
    }
}

