using System;
using System.Xml.Linq;

namespace week11_OO_TheRealDeal
{
	public class Doctor : Person
    {
		// Property
		public string Department { get; set; }

		// Constructor
		public Doctor(string _name, DateOnly _dob, string _department) : base(_name, _dob)
        {
			this.Department = _department;
		}

		// Methods
		public void SayHello()
		{
            Console.WriteLine("Hello, I am doctor" + this.Name);
        }

		public void Treat(Fighter patient)
		{
			patient.Health = 100;
			Console.WriteLine($"I am {this.Name} and I treat {patient.Name}");
		}
	}
}

