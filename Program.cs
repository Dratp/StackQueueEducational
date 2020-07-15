using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets Learn about Data Structures");
            Console.WriteLine("S = Stack");
            Console.WriteLine("Q = Queue");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "S":
                    StackPractice();
                    break;
                case "Q":
                    QueuePractice();
                    break;
            }
            
            
        }

        static void StackPractice()
        {
            Stack<int> st = new Stack<int>();
            st.Push(10);
            st.Push(20);
            st.Push(50);
            st.Push(5);
            st.Push(8);
            st.Push(100);

            int count = (int)st.Count;
            bool proceed = true;
            string what = "Stack";
            Console.WriteLine($"There is a premade integer {what} of 6 integers");
            do
            {
                Console.WriteLine($"\nLets learn about the {what} Data Structure");
                Console.WriteLine("C = Count");
                Console.WriteLine("A = Add");
                Console.WriteLine("P = Peek");
                Console.WriteLine("T = Take");
                Console.WriteLine("L = List");
                Console.WriteLine("Q = Quit");
                Console.Write("Would you like to do? ");
                string entry = Console.ReadLine();
                switch (entry)
                {
                    case "C":
                        Console.Clear();
                        Console.WriteLine("We can find out how many items are in it by using a .count");
                        Console.WriteLine($"There are {st.Count} this in the stack");
                        break;
                    case "A":
                        Console.Clear();
                        Console.WriteLine($"When you use a .Push command you add something to the stack this changes the size of the stack");
                        int addnum;
                        bool isValid;
                        do
                        {
                            Console.Write("What integer would you like to add to the Stack: ");
                            string input = Console.ReadLine();
                            isValid = int.TryParse(input, out addnum);
                        } while (isValid == false);
                        st.Push(addnum);
                        break;
                    case "P":
                        Console.Clear();
                        Console.WriteLine($"Peek lets you see what is on top but does not take it");
                        Console.WriteLine($"The Last thing added to the stack is {st.Peek()}");
                        break;
                    case "T":
                        Console.Clear();
                        Console.WriteLine("When you use a pop you take the last thing added to the stack.");
                        Console.WriteLine($"This is destructive. If you do not save it to a varible you will lose it.");
                        Console.WriteLine($"We just took {st.Pop()} off the top of the stack");
                        break;
                    case "L":
                        Console.Clear();
                        Console.WriteLine("If you are using this command with a Stack you might want to consider an Array instead");
                        Console.WriteLine("The Stack contains the following");
                        foreach (int num in st)
                        {
                            Console.WriteLine(num);
                        }
                        break;
                    case "Q":
                        Console.WriteLine($"Thank you for learning about a {what} with me");
                        proceed = false;
                        break;
                }
            } while (proceed == true);
        }

        static void QueuePractice()
        {
            //https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.queue-1?view=netcore-3.1

            Queue<string> myQ = new Queue<string>();
            myQ.Enqueue("Hello");
            myQ.Enqueue("World.");
            myQ.Enqueue("How");
            myQ.Enqueue("are");
            myQ.Enqueue("you");
            myQ.Enqueue("today?");


            bool proceed = true;
            string what = "Queue";
            Console.WriteLine($"There is a premade string {what} of 6 strings");
            do
            {
                Console.WriteLine($"\nLets learn about the {what} Data Structure");
                Console.WriteLine("C = Count");
                Console.WriteLine("A = Add");
                Console.WriteLine("P = Peek");
                Console.WriteLine("T = Take");
                Console.WriteLine("L = List");
                Console.WriteLine("Q = Quit");
                Console.Write("Would you like to do? ");
                string entry = Console.ReadLine();
                switch (entry)
                {
                    case "C":
                        Console.Clear();
                        Console.WriteLine("We can find out how many items are in it by using a .count");
                        Console.WriteLine($"There are {myQ.Count} this in the stack");
                        break;
                    case "A":
                        Console.Clear();
                        Console.WriteLine($"When you use a .Enqueue command you add something to the {what} this changes the size of the stack");
                        Console.Write($"What string would you like to add to the {what}: ");
                        myQ.Enqueue(Console.ReadLine());
                        break;
                    case "P":
                        Console.Clear();
                        Console.WriteLine($"Peek lets you see what is next does not take it");
                        Console.WriteLine($"The First thing added to the {what} is {myQ.Peek()}");
                        break;
                    case "T":
                        Console.Clear();
                        Console.WriteLine($"When you use a Dequeue you take the first thing added to the {what}.");
                        Console.WriteLine($"This is destructive. If you do not save it to a varible you will lose it.");
                        Console.WriteLine($"We just took {myQ.Dequeue()} off the top of the {what}");
                        break;
                    case "L":
                        Console.Clear();
                        Console.WriteLine($"If you are using this command with a {what} you might want to consider an Array instead");
                        Console.WriteLine($"The {what} contains the following");
                        foreach (string thing in myQ)
                        {
                            Console.WriteLine(thing);
                        }
                        break;
                    case "Q":
                        Console.WriteLine($"Thank you for learning about a {what} with me");
                        proceed = false;
                        break;
                }
            } while (proceed == true);

        }

    }
}
