using System;
using System.Data.Common;

namespace CCC_Solution1
{
    class Program
    {
        static void Main()
        {
            int id = 0;
            int speed = 0;
            int[] location = new int[2];
            int[] target = new int[2];
            string[] choice;
            string direction = "N";
            string input;

            Console.WriteLine("Possible commands: DIRECTION <drone ID> <direction (N,O,S,W,NO,..)>");
            Console.WriteLine("SPEED <drone ID> <number from 0-5>");

            Console.WriteLine("Please give Start Coordinates: ");
            input = Console.ReadLine();
            choice = input.Split(" ");

            int.TryParse(choice[0], out location[0]);
            int.TryParse(choice[1], out location[1]);

            Console.WriteLine("Please give Target Coordinates <TargetX> <TargetY>: ");
            input = Console.ReadLine();
            choice = input.Split(" ");

            int.TryParse(choice[2], out target[0]);
            int.TryParse(choice[3], out target[1]);

            Drone drone = new Drone(id, direction, speed, location);

            switch (choice[0])
            {
                case "DIRECTION":
                    if (int.TryParse(choice[1], out id))
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
                    if (int.TryParse(choice[1], out id))
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
                    Console.WriteLine("ID: " + drone.ID);
                    Console.WriteLine("Direction: " + drone.Direction);
                    Console.WriteLine("Speed: " + drone.Speed);
                    Console.WriteLine("Location: " + drone.Location); //arrayausgabe
                    break;
                case "TICK":

                    break;
                default:
                    Console.WriteLine("Sog amoi wos duastn du do heast?");
                    break;
            }
        }
    }
}
