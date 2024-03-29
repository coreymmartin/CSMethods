﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMethods
{
    internal class Program
    {

        public enum Selection
        {
            Add = 1,
            Subtract,
            Multiply,
            Divide
        }

        public static void TellAStory()
        {
            Console.WriteLine("please enter a greeting");
            string greeting = Console.ReadLine();
            Console.WriteLine("please enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("please enter an emotion");
            string emotion = Console.ReadLine();
            Console.WriteLine("please enter an integer ");
            string integer1 = Console.ReadLine();
            Console.WriteLine("please enter a location");
            string location1 = Console.ReadLine();
            Console.WriteLine("please enter an adjective");
            string adjective1 = Console.ReadLine();
            Console.WriteLine("please enter a plural noun");
            string pluralNoun1 = Console.ReadLine();
            Console.WriteLine("please enter an integer");
            string integer2 = Console.ReadLine();
            Console.WriteLine("please enter an occupation");
            string occupation = Console.ReadLine();
            Console.WriteLine("please enter a company");
            string company = Console.ReadLine();
            Console.WriteLine("please enter a plural noun");
            string pluralNoun2 = Console.ReadLine();
            Console.WriteLine("please enter a plural noun");
            string pluralNoun3 = Console.ReadLine();
            Console.WriteLine("please enter an adjective");
            string adjective2 = Console.ReadLine();
            Console.WriteLine("please enter a form of technology");
            string technology = Console.ReadLine();
            Console.WriteLine("please enter a location");
            string location2 = Console.ReadLine();
            Console.WriteLine("please enter an adjective");
            string adjective3 = Console.ReadLine();
            Console.WriteLine("please enter a personal interest");
            string interest = Console.ReadLine();
            Console.WriteLine("please enter a hobby");
            string hobby1 = Console.ReadLine();
            Console.WriteLine("please enter an exclamation");
            string exclamation = Console.ReadLine();
            Console.WriteLine("please enter an activity");
            string activity1 = Console.ReadLine();
            Console.WriteLine("please enter an animal (plural)");
            string pluralAnimal = Console.ReadLine();
            Console.WriteLine("please enter an activity");
            string activity2 = Console.ReadLine();
            Console.WriteLine("please enter a type of furniture");
            string furniture = Console.ReadLine();

            string myStory = $"{greeting}! My name is {name} and I am {emotion} to become a software developer through truecoders! \n" +
            $"A bit of background about me, I am {integer1} years old. I am from {location1}. Its a pretty {adjective1} area, full of {pluralNoun1}.\n" +
            $"For the past {integer2} years I have been working as a {occupation} for {company}.\n" +
            $"I am looking forward to becoming a developer with hopes of finding a job with less {pluralNoun2} and more {pluralNoun3}!\n" +
            $"My dream job would be writing software for {adjective2} {technology} in {location2}.\n" +
            $"I believe I am a {adjective3} fit for a software developer for my love of {interest} and {hobby1}.\n" +
            $"I have dabbled in coding throughout the past and now plan to take it to a whole new level. {exclamation}!\n" +
            $"Some hobbies of mine include {activity1} in the woods,playing dungeons and {pluralAnimal} with friends, or \n" +
            $"simply {activity2} alone on my favorite {furniture}.";

            Console.Clear();
            Console.WriteLine(myStory);
            Console.WriteLine("\npress enter to clear story and continue...");
            Console.ReadLine();
            Console.Clear();

        }

        public static int Add(params int[] inputs) {
            int result = inputs[0];
            for (int i = 1; i < inputs.Length; i++)
            {
                Console.WriteLine($"adding {inputs[i]} to {result}");
                result += inputs[i];
            }
            return result; }

        public static int Subtract(params int[] inputs) {
            int result = inputs[0];
            for (int i = 1; i < inputs.Length; i++) 
            {
                Console.WriteLine($"subtracting {inputs[i]} from {result}");
                result -= inputs[i]; 
            }
            return result; }

        public static int Multiply(params int[] inputs)
        {
            int result = inputs[0];
            for (int i = 1; i < inputs.Length; i++)
            {
                Console.WriteLine($"multiplying {result} by {inputs[i]}");
                result *= inputs[i];
            }
            return result;
        }

        public static int Divide(params int[] inputs)
        {
            int result = inputs[0];
            for (int i = 1; i < inputs.Length; i++)
            {
                Console.WriteLine($"dividing {result} by {inputs[i]}");
                result /= inputs[i];
            }
            return result;
        }

        public static void SelectMathOperator()
        {
            bool bRunOperations = true;
            Console.WriteLine("How many integers do you want to perform the operation on?");
            int numValues = Convert.ToInt32(Console.ReadLine());
            int[] userVals = new int[numValues];
            Console.Clear();
            for (int i = 0; i < numValues; i++)
            {
                Console.WriteLine($"Please enter value {i+1}:");
                userVals[i] = Convert.ToInt32(Console.ReadLine());
            }
            while (bRunOperations)
            {
                Console.Clear();
                Console.WriteLine($"all values entered:");
                Console.Write(userVals[0]);
                for (int j = 1; j < userVals.Length; j++)
                {
                    Console.Write(", ");
                    Console.Write(userVals[j]);
                }
                Console.WriteLine();
                Console.WriteLine("press enter to continue to select operation to perform");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("please select a mathematical operation to perform");
                Console.WriteLine("\t(1) Add \n\t(2) Subtract \n\t(3) Multiply \n\t(4) Divide");
                int OperatorSelected = Convert.ToInt32(Console.ReadLine());
                int result = 0;
                switch (OperatorSelected){
                    case (int)Selection.Add:
                        Console.WriteLine("Operator Selected: Add");
                        result = Add(userVals);
                        break;
                    case (int)Selection.Subtract:
                        Console.WriteLine("Operator Selected: Subtract");
                        result = Subtract(userVals);
                        break;
                    case (int)Selection.Multiply:
                        Console.WriteLine("Operator Selected: Multiply");
                        result = Multiply(userVals);
                        break;
                    case (int)Selection.Divide:
                        Console.WriteLine("Operator Selected: Divide");
                        result = Divide(userVals);
                        break;
                    default:
                        Console.WriteLine("Operator Selected: INVALID!");
                        break;
                }
                Console.WriteLine($"result = {result}");
                Console.WriteLine("\nwould you like to run another operation on the same set of values? \n\t (0) Yes, (1) No/Return");
                int userDecision = Convert.ToInt16(Console.ReadLine());
                if (userDecision > 0)
                    bRunOperations = false;
                else
                    Console.Clear();
            }
        }

        static void Main(string[] args)
        {
            // Exercise 1: write program that takes user input and creates a story. ask for name, color, animal, yada yada
            // Exercise 2: write different methods that use each math operator
            // Challenge mode: use params keyword to support range of arguments

            bool bContinue = true;
            while (bContinue)
            {
                Console.Clear();
                Console.WriteLine("Please select option: \n\t(1) Excercise 1: Tell A Story\n\t(2) Excercise 2: Math Operators \n\t(3) Exit\n\nPlease enter your option number...");
                int iUserSelection = Convert.ToInt16(Console.ReadLine());
                switch (iUserSelection)
                {
                    case 1:
                        Console.WriteLine("\nExcercise 1 Selected!\n");
                        TellAStory();
                        break;
                    case 2:
                        Console.WriteLine("\nExcercise 2 Selected!\n");
                        SelectMathOperator();
                        break;
                    case 3:
                        Console.WriteLine("\nExiting!\n");
                        bContinue = false;
                        break;
                    default:
                        Console.WriteLine("invalid input, please enter valid integer for option 1 through 3:");
                        break;
                }
            }
        }
    }
}
