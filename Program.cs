using System;
using System.Collections.Generic;
using TeamPlayersLibrary;

namespace CricketTeamPlayersList
{
    public class Program
    {
        static void Main()
        {
            TeamBase cricketTeam = new Team();

            int choice;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add Player");
                Console.WriteLine("2. Remove Player");
                Console.WriteLine("3. Get Player by ID");
                Console.WriteLine("4. Get Player by Name");
                Console.WriteLine("5. Get All Players");
                Console.WriteLine("0. Exit ");

                Console.Write("Enter your choice: ");
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter ID : ");
                            if (int.TryParse(Console.ReadLine(), out int playerId))
                            {
                                Console.Write("Enter Name : ");
                                string playerName = Console.ReadLine();
                                Console.Write("Enter Age : ");
                                if (int.TryParse(Console.ReadLine(), out int playerAge))
                                {
                                    TeamPlayer newPlayer = new TeamPlayer
                                    {
                                        PlayerId = playerId,
                                        Name = playerName,
                                        Age = playerAge
                                    };
                                    cricketTeam.AddPlayer(newPlayer);
                                }
                                else
                                {
                                    Console.WriteLine("Invalid player age as input.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid PlayerId as Input. ");
                            }
                            break;
                        case 2:
                            Console.Write("Enter Player ID to remove: ");
                            if (int.TryParse(Console.ReadLine(), out int playerIdToRemove))
                            {
                                cricketTeam.RemovePlayer(playerIdToRemove);
                            }
                            else
                            {
                                Console.WriteLine("Invalid player ID as input.");
                            }
                            break;

                        case 3:
                            Console.Write("Enter Player ID to get details: ");
                            if (int.TryParse(Console.ReadLine(), out int playerIdToGet))
                            {
                                TeamPlayer playerById = cricketTeam.GetPlayerById(playerIdToGet);
                                if (playerById != null)
                                {
                                    Console.WriteLine($"\n PlayerId: {playerById.PlayerId}, Name: {playerById.Name}, Age: {playerById.Age} Years");
                                }
                                else
                                {
                                    Console.WriteLine($"\n Player with ID {playerIdToGet} is not found.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid player ID as input.");
                            }
                            break;

                        case 4:
                            Console.Write("Enter Player Name to get details: ");
                            string playerNameToGet = Console.ReadLine();
                            TeamPlayer playerByName = cricketTeam.GetPlayerByName(playerNameToGet);
                            if (playerByName != null)
                            {
                                Console.WriteLine($"\n PlayerId: {playerByName.PlayerId}, Name: {playerByName.Name} , Age: {playerByName.Age} Years");
                            }
                            else
                            {
                                Console.WriteLine($"\n Player with Name {playerNameToGet} is not found.");
                            }
                            break;

                        case 5:
                            List<TeamPlayer> allPlayers = cricketTeam.GetAllPlayers();
                            Console.WriteLine("Players in the team:");
                            foreach (var player in allPlayers)
                            {
                                Console.WriteLine($"Id: {player.PlayerId}, Name: {player.Name}, Age: {player.Age}");
                            }
                            break;

                        case 0:
                            Console.WriteLine("Exiting the program.");
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }

                Console.WriteLine();
            } while (choice != 0);
        }
    }

}
