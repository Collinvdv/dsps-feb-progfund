using System;
namespace week12_zoo
{
	public class Fish: Animal
	{
		// Props
		public List<Fish> Children { get; set; }
		public Fish Father { get; set; }
        public Fish Mother { get; set; }
		public Gender Gender { get; set; }

        // Constructor
        public Fish(string _name, Gender _gender) : base(_name)
		{
			this.Children = new List<Fish>();
			this.Gender = _gender;
		}

		public Fish(string _name, Fish _father, Fish _mother, Gender _gender) : base(_name)
		{
			this.Father = _father;
			this.Mother = _mother;
            this.Children = new List<Fish>();
			this.Gender = _gender;
        }
 
		// Methods
		public void Swim()
		{
			Console.WriteLine($"Jihaaah, {this.Name} is swimming");
		}

		public Fish CreateBaby(Fish _father, String _name)
		{
            // Creating a fish
            // random item of gender
			if (this.Gender == _father.Gender)
			{
				Console.WriteLine("We got an issue, animals with same gender");
				return null;
			}
            Random random = new Random();
            Gender randomGender = (Gender)random.Next(0, Enum.GetValues(typeof(Gender)).Length);
            Fish babyFish = new Fish(_name, _father, this, randomGender);

			// Add the fish to the children of the father and mother
			this.Children.Add(babyFish);
			_father.Children.Add(babyFish);

			return babyFish;
		}
	}
}

