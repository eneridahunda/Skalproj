using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' ' ; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            List<string> theList = new List<string>();
            string input = Console.ReadLine();
            char nav = input[0];
           // string value = input.substring(1);

            switch(nav){

                case '1':
                    AddInput();
                break;
                case '2':
                    RemoveInput();
                break;
                default:
                    Console.WriteLine("Please enter only (+) or (-)");
                    break;

            }
        }

        private static void RemoveInput()
        {
            List<string> theList = new List<string>();
            Console.WriteLine("Please remove an input.");
            string input = Console.ReadLine();
            theList.Remove(input);

            while (!String.IsNullOrEmpty(input))
            {

                Console.WriteLine("Please enter the input you want to remove: ");
                input = Console.ReadLine();

            }


            if (String.IsNullOrEmpty(input))
            {
                Console.WriteLine("The input you have entered is: " + " " + input);
                theList.Remove(input);
                foreach (string value in theList)
                {
                    Console.WriteLine("The input that was removed from the list is : " + " " + value);
                }
                Console.ReadLine();
            }
        }

        private static void AddInput()
        {


            List<string> theList = new List<string>();
            Console.WriteLine("Please enter your input.");
            string input = Console.ReadLine();
            theList.Add(input);

            while (!String.IsNullOrEmpty(input))
            {

                Console.WriteLine("Please enter another integer: ");
                input = Console.ReadLine();

            }


            if (String.IsNullOrEmpty(input))
            {
                Console.WriteLine("The input you have entered is: " + " " + input);
                theList.Add(input);
                foreach (string value in theList)
                {
                    Console.WriteLine("The input that was added to the list is : " + " " + value);
                }
                Console.ReadLine();
            }

        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            // Loop this method untill the user inputs something to exit to main menue.
             
            int num = 0;
            string userChoice = string.Empty;
            do
            {
                
                Console.Write("Enter the number of your choice: ");
                if (num == 0)
                    break;
                else
                    userChoice = Console.ReadLine();

            }
            while (Int32.TryParse(userChoice, out num)); //checks to see if the input is a number
            if (userChoice == "0")
            {
                Environment.Exit(0);
            }

            Console.WriteLine("Choice = " + userChoice);

            // Create a switch with cases to enqueue items or dequeue items

            Queue q = new Queue();

            char input = ' ';
            //switch (input)
            //{

            //    case ' 1 ':
            //        q.Enqueue(AddInput);
            //        break;
            //    case ' 2 ':
            //        q.Dequeue();
            //        break;
            //    default:
            //        Environment.Exit(0);
            //        break;

            //}

            q.Enqueue("Kallle");
            q.Enqueue("Greta");
            q.Enqueue("Stina");
            


            Console.WriteLine("Current queue: ");
            foreach (string s in q) Console.Write(s + " ");
          
            Console.WriteLine();
            q.Enqueue("Olle");

            Console.WriteLine("Current queue: ");
            foreach (string s in q) Console.Write(s + " ");

            Console.WriteLine();
            Console.ReadKey();
        }

        // Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            
              //Loop this method until the user inputs something to exit to main menue.
              
              int num = 0;
            string userChoice = string.Empty;
            do
            {
                
                Console.Write("Enter the number of your choice: ");
                if (num == 0)
                    break;
                else
                    userChoice = Console.ReadLine();

            }
            while (Int32.TryParse(userChoice, out num)); //checks to see if the input is a number
            if (userChoice == "0")
            {
                Environment.Exit(0);
            }

            Console.WriteLine("Choice = " + userChoice);

            // Create a switch with cases to push or pop items

            Stack st = new Stack();

            string input = "";

            while (!String.IsNullOrEmpty(input))

            {
                Console.WriteLine("Enter a name:");

                st.Pop();
               
                input = Console.ReadLine();

            }

            st.Push("Kalle");
            st.Push("Greta");
            st.Push("Stina");

            foreach (Object obj in st)
            {
                Console.WriteLine(obj);
            }


            Console.WriteLine();
            Console.WriteLine("The number of names in the stack " + st.Count);
             Console.ReadKey();

            // Make sure to look at the stack after pushing and and poping to see how it behaves

        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }

    }

    
}



