/*
This file contains a static class named MathOps that contains various methods for performing mathematical operations.
*/

namespace jci.Helpers
{

    // Generate a static class that contains various methods for performing mathematical operations
    public static class MathOps
    {
        // Generate a method that returns the sum of two numbers
        public static int Add(int a, int b)
        {
            return a + b;
        }

        /*
        The definition of factorial is as follows:
         n! = n * (n -1)!
        0! = 1
        1! = 1

        Define a method named 'fact' that takes am unsigned integer 'n' as a parameter and returns the factorial of 'n' using recursion.
        Implementation of the method should be as follows:
        if n is negative, throw an ArgumentException with the message "The input must be a non-negative integer."
        if n is 0 or n is 1, return 1
        otherwise return n *  (n - 1)!
        */

        /// <summary>
        /// Calculates the factorial of a non-negative integer.
        /// </summary>
        /// <param name="n">The non-negative integer.</param>
        /// <returns>The factorial of the input number.</returns>
        public static int Fact(int n)
        {
            if (n < 0)
            {
                throw new System.ArgumentException("The input must be a non-negative integer.");
            }
            if (n == 0 || n == 1)
            {
                return 1;
            }
            return n * Fact(n - 1);
        }

    }

    // Generate a static class that contains various methods for performing string operations
    public static class StringOps
    {
        // Generate a method that returns the length of a string
        public static int Length(string s)
        {
            return s.Length;
        }

        // Generate a method that returns the concatenation of two strings
        public static string Concat(string s1, string s2)
        {
            return s1 + s2;
        }

        // Generate a method that returns the substring of a string
        public static string Substring(string s, int startIndex, int length)
        {
            return s.Substring(startIndex, length);
        }
    }

    // Generate a static class that contains various methods for performing array operations
    public static class ArrayOps
    {
        // Generate a method that returns the length of an array
        public static int Length<T>(T[] array)
        {
            return array.Length;
        }

        // Generate a method that returns the element at a specified index in an array
        public static T GetElementAt<T>(T[] array, int index)
        {
            return array[index];
        }

        // Generate a method that sets the element at a specified index in an array to a specified value
        public static void SetElementAt<T>(T[] array, int index, T value)
        {
            array[index] = value;
        }
    }

}
