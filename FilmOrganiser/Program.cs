using System;
using System.Collections.Generic;

namespace FilmOrganiser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Organiser what would you like to do?");
            Console.WriteLine("1) Add a film");
            Console.WriteLine("2) Remove a film");
            Console.WriteLine("3) Return a random film");
            Console.WriteLine("4) Exit");


            var character = Console.ReadKey().KeyChar;

            var listOffilms = new List<string>();

            string usrin;

            switch (character)
            {
                case '1':
                    Console.Write("Which film do you want to add?");

                    usrin = Console.ReadLine();

                    foreach (var listOffilm in listOffilms)
                    {
                        if (listOffilm == usrin)
                        {
                            break;
                        }

                        listOffilms.Add(usrin);

                    }

                    Console.WriteLine("Ok added " + usrin);
                    break;

                case '2':

                    Console.Write("Which film do you want to add?");

                    usrin = Console.ReadLine();

                    foreach (var listOffilm in listOffilms)
                    {
                        if (listOffilm == usrin)
                        {
                            listOffilms.Remove(usrin);

                            Console.WriteLine("Ok deleted " + usrin);

                            return;
                        }
                    }

                    Console.WriteLine("This wasn't in there: " + usrin);


                    break;

                case '3':
                    throw new NotImplementedException();
                    break;

                case '4':
                    Console.WriteLine("Bye");

                    Environment.Exit(0);
                    break;

                    
                default:

                    break;

            }

            Console.WriteLine("Bye");
            Console.ReadKey();

        }
    }
}
