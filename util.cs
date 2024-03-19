using System.Collections.Generic;

/*
This file contains various classes and methods that are used throughout the project.
*/

namespace jci.Utilities
{

// Generate a public that call the GetWelcomeMessage method from the WelcomeMessageGenerator class
    public class WelcomeMessage
    {
        public string GetMessage()
        {
            var generator = new WelcomeMessageGenerator();
            return generator.GetWelcomeMessage();
        }
    }

// Generate an internal class that models a welcome message generator
    internal class WelcomeMessageGenerator
    {
        // Generate a method that returns a welcome message
        public string GetWelcomeMessage()
        {
            return "Hello, GitHub Copilot!";
        }

        // generate a method that return a random welcome message from a list of messages
        public string GetRandomWelcomeMessage()
        {
            var messages = new List<string>
            {
                "Hello, GitHub Copilot!",
                "Welcome to the project!",
                "Good to see you!"
            };

            return messages[new System.Random().Next(0, messages.Count)];
        }


    }

}
