using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class StartUp
    {
        static void Main()
        {
            Dictionary<string, Trainer> trainers = new();
            AddTrainersAndPokemons(trainers);
            CheckElements(trainers);

            Dictionary<string, Trainer> sortedTrainers = trainers
                .OrderByDescending(t => t.Value.Badges)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var trainer in sortedTrainers)
            {
                Console.WriteLine($"{trainer.Key} {trainer.Value.Badges} {trainer.Value.Pokemons.Count}");
            }
        }

        private static void CheckElements(Dictionary<string, Trainer> trainers)
        {
            string element;
            while ((element = Console.ReadLine()) != "End")
            {
                foreach (var trainer in trainers)
                {
                    bool haveType = false;

                    foreach (var pokemon in trainer.Value.Pokemons)
                    {
                        if (pokemon.Element == element)
                        {
                            haveType = true;
                            break;
                        }
                    }

                    if (haveType)
                    {
                        trainer.Value.Badges++;
                    }
                    else
                    {
                        for (int i = 0; i < trainer.Value.Pokemons.Count; i++)
                        {
                            trainer.Value.Pokemons[i].Health -= 10;
                            if (trainer.Value.Pokemons[i].Health <= 0)
                            {
                                trainer.Value.Pokemons.Remove(trainer.Value.Pokemons[i]);
                            }
                        }
                    }
                }
            }
        }

        private static void AddTrainersAndPokemons(Dictionary<string, Trainer> trainers)
        {
            string input;
            while ((input = Console.ReadLine()) != "Tournament")
            {
                string[] commArgs = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string trainerName = commArgs[0];
                string pokemonName = commArgs[1];
                string pokemonElement = commArgs[2];
                int pokemonHealth = int.Parse(commArgs[3]);

                Trainer trainer = new Trainer();
                trainer.Name = trainerName;
                Pokemon pokemon = new Pokemon();
                pokemon.Name = pokemonName;
                pokemon.Element = pokemonElement;
                pokemon.Health = pokemonHealth;
                trainer.Pokemons.Add(pokemon);

                if (!trainers.ContainsKey(trainerName))
                {
                    trainers.Add(trainerName, trainer);
                }
                else
                {
                    trainers[trainerName].Pokemons.Add(pokemon);
                }
            }
        }
    }
}
