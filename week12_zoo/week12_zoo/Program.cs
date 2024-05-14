namespace week12_zoo;

class Program
{
    static void Main(string[] args)
    {
        Animal collin = new Animal("Collin");
        Animal lisa = new Animal("Lisa", new DateOnly(2000, 4, 5));
        Bird bird1 = new Bird("Bird 1");
        Fish nemo = new Fish("Nemo", Gender.Male);
        Fish dory = new Fish("Dory", Gender.Female);
        Fish renske = new Fish("Renske", Gender.Female);

        //Fish nemojunior = new Fish("Nemo junior", nemo, dory);

        //Console.WriteLine(nemojunior.Father.Name);

        Fish nemojunior = dory.CreateBaby(renske, "Nemo Junior");
        //Console.WriteLine(nemojunior.Father.Name);
        //Console.WriteLine(nemojunior.Father.Children.Count);

        Console.WriteLine(nemojunior.Gender);
    }
}

