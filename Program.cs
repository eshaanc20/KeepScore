using System;

namespace KeepScore
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your cards");
            string userinput = Console.ReadLine();
            userinput.ToUpper();
            string outputstring = " ";
            int counter = 0;
            int points = 0;
            for (int i = 0; i < userinput.Length; i++)
            {
                string card = userinput[i].ToString();
                switch (card)
                {
                    case "C":
                        outputstring += "\nClubs: ";
                        counter = 0;
                        break;
                    case "D":
                        switch (counter)
                        {
                            case 0:
                                points += 3;
                                break;
                            case 1:
                                points += 2;
                                break;
                            case 2:
                                points += 1;
                                break;
                            default:
                                break;
                        }
                        outputstring += "\nDiamonds: ";
                        counter = 0;
                        break;
                    case "H":
                        switch (counter)
                        {
                            case 0:
                                points += 3;
                                break;
                            case 1:
                                points += 2;
                                break;
                            case 2:
                                points += 1;
                                break;
                            default:
                                break;
                        }
                        outputstring += "\nHearts: ";
                        counter = 0;
                        break;
                    case "S":
                        switch (counter)
                        {
                            case 0:
                                points += 3;
                                break;
                            case 1:
                                points += 2;
                                break;
                            case 2:
                                points += 1;
                                break;
                            default:
                                break;
                        }
                        outputstring += "\nSpades: ";
                        counter = 0;
                        break;
                    case "J":
                        points += 1;
                        outputstring += " " + card;
                        counter += 1;
                        break;
                    case "Q":
                        points += 2;
                        outputstring += " " + card;
                        counter += 1;
                        break;
                    case "K":
                        points += 3;
                        outputstring += " " + card;
                        counter += 1;
                        break;
                    case "A":
                        points += 4;
                        outputstring += " " + card;
                        counter += 1;
                        break;
                    default:
                        counter += 1;
                        outputstring += " " + card;
                        if (i == userinput.Length)
                        {
                            switch (counter)
                            {
                                case 0:
                                    points += 3;
                                    break;
                                case 1:
                                    points += 2;
                                    break;
                                case 2:
                                    points += 1;
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                }
            }
            Console.WriteLine(outputstring);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nTotal Points: " + points);
        }
    }
}