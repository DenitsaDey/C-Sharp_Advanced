using System;
using System.Collections.Generic;
using System.Linq;

namespace _19.PokemonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();
            while ((input = Console.ReadLine()) != "Tournament")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string trainerName = command[0];
                string pokemonName = command[1];
                string element = command[2];
                int health = int.Parse(command[3]);
                Pokemon currentPokemon = new Pokemon(pokemonName, element, health);
                if (!trainers.ContainsKey(trainerName))
                {
                    trainers.Add(trainerName, new Trainer(trainerName));
                }
                trainers[trainerName].Collection.Add(currentPokemon);
            }

            string info = string.Empty;
            while ((info = Console.ReadLine()) != "End")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.Value.Collection.Any(x => x.Element == info))
                    {
                        trainer.Value.Badges++;
                    }
                    else
                    {
                        for (int i = 0; i < trainer.Value.Collection.Count; i++)
                        {
                            trainer.Value.Collection[i].Health -= 10;
                            if (trainer.Value.Collection[i].Health <= 0)
                            {
                                trainer.Value.Collection.Remove(trainer.Value.Collection[i]);
                                i--;
                            }
                        }
                    }
                }
            }
            var sortedTrainers = trainers.OrderByDescending(x => x.Value.Badges).ToDictionary(x => x.Key, y => y.Value);
            foreach (var trainer in sortedTrainers)
            {
                Console.WriteLine($"{trainer.Key} {trainer.Value.Badges} {trainer.Value.Collection.Count}");
            }
        }
    }
}
