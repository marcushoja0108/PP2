using System.Runtime.InteropServices;
using PP2;

string pokemonName;
bool isTrue = true;
Pokemon selectedPokemon = null;

Pokemon pikachu = new Pokemon("Pikachu");
Pokemon browzie = new Pokemon($"Browzie");
List<Pokemon> array = new List<Pokemon>();
array.Add(pikachu);
array.Add(browzie);

while (true)
{
    Console.WriteLine("1. Se dine pokemon");
    Console.WriteLine("2. Legg til pokemon");
    
    switch (Console.ReadLine())
    {
        case "1":
            Console.WriteLine("      Dine Pokemon");
            foreach (var item in array)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine();
            Console.WriteLine("Hvilket dyr vil du ta vare på?");
            pokemonName = Console.ReadLine();


            foreach (var pokemon in array)
            {
                if (pokemon.Name == pokemonName)
                {
                    selectedPokemon = pokemon;
                }
            }

            if (selectedPokemon != null)
            {
                Console.WriteLine();
                Console.WriteLine($"1 - Sjekk om {selectedPokemon.Name} må på do ");
                Console.WriteLine($"2 - Gi {selectedPokemon.Name} mat");
                Console.WriteLine($"3 - Kos med {selectedPokemon.Name}");
                Console.WriteLine("4 - Avslutt");
            }
            else
            {
                Console.WriteLine("Ingen Pokemon med det navnet");
            }


            while (selectedPokemon != null)
            {
                Random random = new Random();
                int needs = random.Next(0, 4);
                if (needs < 3)
                {
                    selectedPokemon.Needs(needs);
                }

                switch (Console.ReadLine())
                {
                    case "1":
                        selectedPokemon.Toilet();

                        break;
                    case "2":
                        selectedPokemon.Mat();

                        break;
                    case "3":
                        selectedPokemon.GiveAttention();
                        break;
                    case "4":
                        selectedPokemon = null;
                        Console.WriteLine("Avslutter");
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Ingen gyldig kommando");
                        break;
                }
            }
            break;
        case "2":
            Console.Write("Pokemon Navn:  ");
            string name = Console.ReadLine();
            Pokemon newPokemon = new Pokemon(name);
            array.Add(newPokemon);
            break;
    }
    
}

