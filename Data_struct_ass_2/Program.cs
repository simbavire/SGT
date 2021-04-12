using System;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
/* Take a look to Assignment No.5 from the String materials.
a. Write a program where the verification of the palindrome is provided. Palindrome
is the sentence which reads the same backward as forward. Please take a look at
description of the palindrome: https://en.wikipedia.org/wiki/Palindrome
b. Create the algorithm which will process the sentence and return the result - is this
sentence palindrome or not.

c. Testing sentences:
i. Mom
ii. Was it a car or a cat I saw?
iii. Madam, in Eden, I’m Adam.
iv. Yo, banana boy!

● Rewrite the algorithm of the assignment using Stack and ArrayBlockingQueue classes.
Is it possible to use PrioriyQueue for this assignment?
How do You think which realization is the most suitable for this assignment?
Deque is a double-ended queue with two fronts and two rears. Visualization here:
https://visualgo.net/en/list. Choose the Deque tab.

Take a look at the LinkedList class: https://docs.microsoft.com/en-
us/dotnet/api/system.collections.generic.linkedlist-1?redirectedfrom=MSDN&view=net-5.0 */


namespace Data_struct_ass_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Madam, in Edken, I’m Adam.";

            string test = sentence.ToLower();
            test = new Regex("[^a-z]").Replace(test, "");

            bool isPalindrome = true;
            for (int i = 0; i < test.Length / 2; i++)
            {
                if (test[i] != test[test.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }

            Console.WriteLine(isPalindrome ? "Yes" : "No");


            // Creates and initializes a new Stack.
            Stack myStack = new Stack();
            foreach (char character in test)
            {
                myStack.Push(character);
                Console.Write(character);
            }


            Queue myQueue = new Queue();
            foreach (char character in test)
            { myQueue.Enqueue(character); }

            Console.WriteLine((char)myStack.Pop() + (char)myQueue.Dequeue());

            bool isPalindrome1 = true;
            while (myStack.Count > 0 && myQueue.Count > 0)
            {
                                 
                    if ((char)myStack.Pop() != (char)myQueue.Dequeue())
                    {
                        isPalindrome1 = false;
                        break;
                    }
                
                }
                Console.Write( "Stack and Queue is palindrome: ");
                Console.WriteLine(isPalindrome1 ? "Yes" : "No");
            

            LinkedList<char> linkedList = new LinkedList<char>(test);
            //foreach (char letter in test)
            //{linkedList.AddFirst(letter); }
            Console.WriteLine(linkedList.Count);
            Console.WriteLine(linkedList.First.Value); 
            Console.WriteLine(linkedList.Last.Value); 
            bool isPalindrome2 = true;
            while (linkedList.Count >1)
            {
                if (linkedList.First.Value != linkedList.Last.Value)
                {
                    isPalindrome2 = false;
                    break;
                }
                linkedList.RemoveFirst();
                linkedList.RemoveLast();
            }

            Console.Write("Linkedlist is palindrome: ");
            Console.WriteLine(isPalindrome2 ? "Yes" : "No");
                    
                
        
        }

    }
}