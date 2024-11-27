using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP2
{
    internal class Pokemon
    {
        public string Name;
        public bool IsHungry;
        public bool Bured;
        public bool NeedsToilet;


        public Pokemon(string name)
        {
            Name = name;
            IsHungry = true;
            Bured = true;
            NeedsToilet = true;
        }

        public void Needs(int needs)
        {
            switch (needs)
            {
                case 0:
                    IsHungry = true;
                    break;
                case 1:
                    Bured = true;
                    break;
                case 2:
                    NeedsToilet = true;
                    break;
            }
        }

        public void Toilet()
        {
            if (NeedsToilet)

            {
                NeedsToilet = false;
                Console.WriteLine($"{Name} må på do");
            }
            else
            {
                Console.WriteLine("Må ikke på do");

            }
        }

        public void Mat()
        {
            if (IsHungry)
            {
                IsHungry = false;
                Console.WriteLine($"{Name} trenger mat");
            }
            else
            {

                Console.WriteLine($"{Name} er mett og fornøyd ");
            }

        }

        public void GiveAttention()
        {
            if (Bured)
            {
                Bured = false;
                Console.WriteLine($"{Name} trenger kos");
            }
            else
            {
                Console.WriteLine($"{Name} trenger ikke kos");
            }
        }
    }
}
