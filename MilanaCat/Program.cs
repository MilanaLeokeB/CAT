using System;

namespace MilanaCat
{
    class Program
    {


        class Cat
        {
            string name;
            string color;
            double hungry;

            public Cat(string _name, string _color)
            {
                name = _name;
                color = _color;
                hungry = 0;
                Console.WriteLine($"The cat {name} has been created.");
            }
            public double Hungry
            {
                get { return hungry; }
            }



            public void Sleep()
            {
                Console.WriteLine("Zzzzzz");
                hungry += 0.2;
            }
            public void SayMeow()
            {
                Console.WriteLine("Meow-Meow");
            }
            public void Rename(string newName)
            {
                name = newName;
            }

            public void ShowCatData()
            {
                Console.WriteLine($"Name: {name}; Color: {color}; Hungry: {hungry};");
            }
        }

        static void Main(string[] args)
        {
            Cat newCat = new Cat("Missi", "Yellow");

            Console.WriteLine($"The level of hungry: {newCat.Hungry}");

            while (newCat.Hungry != 1)
            {
               newCat.Sleep(); 
            }

            newCat.SayMeow();

            Console.WriteLine("Name the cat: ");
            string newCatName = Console.ReadLine();
            newCat.Rename(newCatName);
            newCat.ShowCatData();

        }
    }
}

    

