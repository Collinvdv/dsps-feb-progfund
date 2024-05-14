using System;
namespace week11_OO_TheRealDeal
{
	public class Fighter: Person
	{
		// Properties
		public int Height { get; set; }
		public int Health { get; set; }

		// Constructor
		public Fighter(string _name, DateOnly _dob, int _height) : base(_name, _dob)
		{
			this.Health = 100;
			this.Height = _height;
		}

		// Method
		public void Kick(Fighter victim)
		{
			this.Health -= 1;
			this.HealthStatus();

			victim.Health -= 10;
			victim.HealthStatus();
		}

		public void HealthStatus()
		{
			Console.WriteLine("I am " + this.Name + " and I have a health of " + this.Health + "%");
		}
	}
}

