using System;

namespace Gradebook.UserInterfaces
{
    public class StartingUserInterface
    {
        public static bool Quit = false;

        public static void CommandLoop()
        {
            while (!Quit)
            {
                Console.WriteLine(string.Empty);
                Console.WriteLine(">> What would you like to do?");
                Console.WriteLine(">> Possible inputs starts with: create, load, help, quit");

                string command = Console.ReadLine().ToLower();
                CommandRouter(command);
            }
        }

        private static void CommandRouter(string command)
        {
            if (command.StartsWith("create", StringComparison.Ordinal))
                CreateCommand(command);
            else if (command.StartsWith("load", StringComparison.Ordinal))
                LoadCommand(command);
            else if (command.StartsWith("help", StringComparison.Ordinal))
                HelpCommand(command);
            else if (command.StartsWith("quit", StringComparison.Ordinal))
                Quit = true;
            else
                Console.WriteLine("{0} was not recognized, please try again.", command);
        }

        private static void CreateCommand(string command)
        {
            Console.WriteLine("Not implemented yet");
        }

        private static void LoadCommand(string command)
        {
            Console.WriteLine("Not implemented yet");
        }

        private static void HelpCommand(string command)
        {
            Console.WriteLine("Not implemented yet");
        }
    }
}
