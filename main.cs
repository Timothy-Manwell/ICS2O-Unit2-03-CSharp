// Created by: Timothy Manwell
// Created on: Oct 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int number;
        string name;
        
        Console.WriteLine("This program gets a user's street number and name.");
        Console.WriteLine("");

        Console.Write("Enter your street number: ");
        number = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your street name: ");
        name = Console.ReadLine();
        

        Console.WriteLine("");
        Console.WriteLine("Your address is: " + number + " " + name + ".");

        Console.WriteLine("\nDone.");
    }
}