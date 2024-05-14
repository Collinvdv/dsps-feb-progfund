using System;
namespace week11_OO_TheRealDeal
{
	public class Person
	{
		// Properties
		public String Name { get; set; }
		protected DateOnly DateOfBirth { get; set; }

		// Constructor
		public Person(String _name, DateOnly _dob)
		{
			this.Name = _name;
			this.DateOfBirth = _dob;
		}

		// Methods
		public void SayHello()
		{
			if (this.GetAge() <= 2)
			{
				Console.WriteLine("Dada");
			} else
			{
				Console.WriteLine("Hello, I am " + this.Name);
			}
		}

		public int GetAge()
		{
			return DateTime.Now.Year - this.DateOfBirth.Year;
        }
	}
}

