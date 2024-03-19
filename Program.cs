using System;
using jci.Utilities;

internal class Program
{
    private static void Main(string[] args)
    {
        // Create a new instance of the WelcomeMessage class
        var welcomeMessage = new WelcomeMessage();

        // Call the GetMessage method from the WelcomeMessage class
        Console.WriteLine(welcomeMessage.GetMessage());
        
    }
}