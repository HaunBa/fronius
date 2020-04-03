using System;
using System.Data.Common;

namespace CCC_Solution1
{
    class Program
    {
        static void Main()
        {
            int speed = 0;
            int[] location = new int[2];
            int[] target = new int[2];
            string[] choice;
            string direction = "N";
            string input;

            bool success = false;

            Console.WriteLine("Possible commands:");
            Console.WriteLine(" DIRECTION ü<direction (N,O,S,W,NO,..)>");
            Console.WriteLine("SPEED <number from 0-5>");
            Console.WriteLine("TICK");

            Console.WriteLine("Please give Start Coordinates: ");
            input = Console.ReadLine();
            choice = input.Split(" ");

            int.TryParse(choice[0], out location[0]);
            int.TryParse(choice[1], out location[1]);

            Console.WriteLine("Please give Target Coordinates <TargetX> <TargetY>: ");
            input = Console.ReadLine();
            choice = input.Split(" ");

            int.TryParse(choice[0], out target[0]);
            int.TryParse(choice[1], out target[1]);

            Console.WriteLine("Please give Direction: ");
            input = Console.ReadLine();
            choice = input.Split(" ");

            Console.WriteLine("Please give Speed: ");
            input = Console.ReadLine();



            Drone drone = new Drone(direction, speed, location);
            do
            {

                switch (choice[0])
                {
                    case "DIRECTION":
                        if (choice[1])
                        {
                            switch (choice[2])
                            {
                                case "N":
                                    drone.Direction = choice[2];
                                    break;
                                case "O":
                                    drone.Direction = choice[2];
                                    break;
                                case "S":
                                    drone.Direction = choice[2];
                                    break;
                                case "W":
                                    drone.Direction = choice[2];
                                    break;
                                case "NO":
                                    drone.Direction = choice[2];
                                    break;
                                case "SO":
                                    drone.Direction = choice[2];
                                    break;
                                case "SW":
                                    drone.Direction = choice[2];
                                    break;
                                case "NW":
                                    drone.Direction = choice[2];
                                    break;
                                default:
                                    Console.WriteLine("Wrong input, enter dirction!");
                                    break;
                            }
                        }
                        else Console.WriteLine("NO");

                        break;
                    case "SPEED":
                        if (int.TryParse(choice[1], out speed))
                        {
                            int.TryParse(choice[1], out speed);
                            if (speed >= 0 && speed <= 5)
                            {
                                drone.Speed = speed;
                            }
                        }
                        else Console.WriteLine("NO");
                        break;
                    case "STATUS":
                        Console.WriteLine("Direction: " + drone.Direction);
                        Console.WriteLine("Speed: " + drone.Speed);
                        Console.WriteLine("Location: " + drone.Location); //arrayausgabe
                        break;
                    case "TICK":
                            switch (drone.Direction)
                            {
                                case "N":
                                    drone.Location[1] = drone.Location[1] + drone.Speed;
                                    break;
                                case "O":
                                    drone.Location[0] = drone.Location[0] + drone.Speed;
                                    break;
                                case "S":
                                    drone.Location[1] = drone.Location[1] - drone.Speed;
                                    break;
                                case "W":
                                    drone.Location[0] = drone.Location[0] - drone.Speed;
                                    break;
                                case "NO":
                                    drone.Location[0] = drone.Location[0] + drone.Speed;
                                    drone.Location[1] = drone.Location[1] + drone.Speed;
                                    break;
                                case "SO":
                                    drone.Location[0] = drone.Location[0] + drone.Speed;
                                    drone.Location[1] = drone.Location[1] - drone.Speed;
                                    break;
                                case "SW":
                                    drone.Location[0] = drone.Location[0] - drone.Speed;
                                    drone.Location[1] = drone.Location[1] - drone.Speed;
                                    break;
                                case "NW":
                                    drone.Location[0] = drone.Location[0] + drone.Speed;
                                    drone.Location[1] = drone.Location[1] - drone.Speed;
                                    break;
                            }
                            if (location[0] == target[0] && location[1] == target[1])
                            {
                            success = true;
                            }
                        break;
                    default:
                        Console.WriteLine("Sog amoi wos duastn du do heast?");
                        break;
                }
            } while (!success);            
        }
    }
}
