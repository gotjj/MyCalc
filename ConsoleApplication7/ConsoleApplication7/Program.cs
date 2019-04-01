using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] {3, 7, 9, 2, 14, 6 };

            //length
            Console.WriteLine("lenght of the array is " + numbers.Length);
            

            //there're five overloads or five versions.
            //now look for the index of the number 9 in the array above
            //1- IndexOf
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("the index of number 9 in the array is " + index);
            

            //2-Clear()
            //let's clear the first two elemenets in the array
            Array.Clear(numbers, 0, 2);
            
            //Now iterate each element in the array
            foreach(var n in numbers)
               Console.WriteLine(n);
         
            //the result is "0, 0, 9, 2, 14, 6";


            //3-Copy
            var anotherArray = new int[] { 88,55,45 };
            //(source array, destination array, number of element to be copied to)
            Array.Copy(anotherArray, numbers, 3);

            foreach (var n in numbers)
            Console.WriteLine(n);
            Console.WriteLine("Copy an array to another:");
            DisplayNumValues(numbers);
            //the result is "88,55,45, 2, 14, 6";

            //Another example of Copy, this new array can contain three elements
            int[] NewNumbers = new int[3];
            Array.Copy(numbers, NewNumbers, 3);


            foreach (var n in NewNumbers)
            Console.WriteLine("the new group of numbers is "  + n);
            Console.WriteLine("Copy an array to another empty array that can hold three elements: ");
            DisplayNumValues(numbers);
            //the result of the new group is "88,55,45";    

            //4-Sort
            Array.Sort(numbers);

            foreach (var n in numbers)
            Console.WriteLine(n);
            Console.WriteLine("Sort the elements in an array: ");
            DisplayNumValues(numbers);
            //result of the sorted list is 2, 6, 14, 55, 88.

            //5-Reverse
            Array.Reverse(numbers);
            foreach (var n in numbers)
                Console.WriteLine(n);
            //the result is 88,55,14,6,2,

            //See https://msdn.microsoft.com/en-us/library/system.array.sort(v=vs.110).aspx         

            String[] words = { "One", "Two", "three", "Four", "five", "six" };

            IComparer revCompare = new ReverseCompare();
            
            foreach(var s in words)            
            Console.WriteLine("The original order of the words order: " + s);
            Console.WriteLine("The original order of the words order: ");
            DisplayValues(words);
     

            //now sort a section of the array using the default comparer
            Array.Sort(words, 1, 3);

            foreach (var s in words)
            Console.WriteLine("Sort a section of the array: " + s);
            Console.WriteLine("Sort a section of the array: ");
            DisplayValues(words);

            //sort a section of the array using the reverse case-insensit
            Array.Sort(words, 0, 3, revCompare);

            foreach (var s in words)            
            Console.WriteLine("sort a section of the array using the reverse case-insensit " + s);
            Console.WriteLine("sort a section of the array using the reverse case-insensit: ");
            DisplayValues(words);




        }
        public class ReverseCompare: IComparer
        {
            public int Compare(Object x, Object y)
            {
                return (new CaseInsensitiveComparer().Compare(y, x));
            }
        }

        public static void DisplayValues(String[] arr)
            {
                    for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); i++)
                    {
                        Console.WriteLine("  [{0}] : {1}", i, arr[i] );
                    }
                    Console.WriteLine();
                
           
            }
        public static void DisplayNumValues(int[] arr)
        {
            for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); i++)
            {
                Console.WriteLine("  [{0}] : {1}", i, arr[i]);
            }
            Console.WriteLine();


        }


    }
}
