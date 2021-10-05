using System;

namespace Heritage
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animalsSet = new Animal[5];
            Elephant elephant = new Elephant("Dumbo l'éléphant");
            Reptile lezard = new Reptile("Rango le lézard");
            Mammifere mammifaire = new Mammifere("King Kong");
            Mammifere humain = new Mammifere("John");
            Tortue tortue = new Tortue("Franklin");

            animalsSet[0] = elephant;
            animalsSet[1] = lezard;
            animalsSet[2] = mammifaire;
            animalsSet[3] = humain;
            animalsSet[4] = tortue;

            foreach (Animal animal in animalsSet)
            {
                animal.Move();
                animal.Eat();
            }
        }
    }

    public abstract class Animal
        {
            protected string _name;
            protected short _LegsCount;
            protected string _typeOfAnimal;

         public Animal(string name, short LegsCount, string typeOfAnimal)
            {
                _name = name;
                _LegsCount = LegsCount;
                _typeOfAnimal = typeOfAnimal;
            }

         public virtual void Move()
            {
                Console.Write(_name + " marche");
            }

         public void Eat()
            {
                Console.WriteLine(" pour aller manger !!! ");
            }

        }

    public class Mammifere:Animal
    {
        public Mammifere(string name):base(name,2,"Mammifere")
        {

        }
        public override void Move()
        {
            Console.WriteLine(_name + " marche sur ses deux jambes");
        }
    }
    public class Elephant : Animal
    {
        public Elephant(string name) : base(name, 4, "Mammifere proboscidiens")
        {

        }
        public override void Move()
        {
            Console.WriteLine(_name + " se déplace rapidement sur 4 pieds");
        }
    }

    public class Reptile:Animal
    {
        public Reptile(string name):base(name,4,"Reptile")
        {

        }
        public override void Move()
        {
            Console.WriteLine(_name + " se deplace rapidement par ondulation");
        }
    }
    public class Tortue : Animal
    {
        public Tortue(string name) : base(name, 4, "Tortue")
        {

        }
        public override void Move()
        {
            Console.WriteLine(_name + " se deplace len.....te......ment....");
        }
    }
}
