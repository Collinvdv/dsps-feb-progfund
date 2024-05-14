using System;
namespace week12_zoo
{
	public class Animal
	{
		// Properties
		// The actual information
		// public: accesible from everywhere, outside of the class
		// private: only accesible in the class itself
		// protected: available for the class and it subclass
		public string Name { get; set; }
		public DateOnly DoB { get; set; }

		// Constructor
		// 
		public Animal(string _name)
		{
			this.Name = _name;
            // We didn't ask a year, so fill in a default date only
            this.DoB = DateOnly.FromDateTime(DateTime.Today);
        }

        public Animal(string _name, DateOnly _dob)
		{
			this.Name = _name;
			this.DoB = _dob;
		}

		// Methods
		// when using a method that doesn't return anythig: use void
		public void MakeNoise ()
		{
			Console.WriteLine($"WHAAAAh, {this.Name} making some noise");
		}
	}
}

