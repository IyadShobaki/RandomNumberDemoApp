using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomNumberDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random random = new Random();

            //for (int i = 0; i < 10; i++)
            //{
            //    //Console.WriteLine(random.Next(11));  // [0 - 11). 0 to 10, inclusive 0 | exclusive 11
            //    // Console.WriteLine(random.Next(5,11)); // [5 - 11). 5 to 10, inclusive 5 | exclusive 11
            //    //SimpleMethod(random);

            //    //Console.WriteLine(random.NextDouble() * 10);  // between 0 and less than 1

            //}
            List<PersonModel> people = new List<PersonModel>
                {
                    new PersonModel{FirstName = "Iyad"},
                    new PersonModel{FirstName = "Tim"},
                    new PersonModel{FirstName = "Sue"},
                    new PersonModel{FirstName = "Mary"},
                    new PersonModel{FirstName = "George"},
                    new PersonModel{FirstName = "Jane"},
                    new PersonModel{FirstName = "Nancy"}
                };

            //var sortedPeople = people.OrderBy(x => x.FirstName);

            //if the performance is not important and the list is not very big
            //the following method is good to shuffle 
            var sortedPeople = people.OrderBy(x => random.Next());
            //for better performance and more advance shuffle, check the following website
            //RNGCryptoServiceProvider demo:
            //https://stackoverflow.com/questions/273313/randomize-a-listt/1262619#1262619

            foreach (var p in sortedPeople)
            {
                Console.WriteLine(p.FirstName);
            }
            Console.ReadLine();
        }

        private static void SimpleMethod(Random random)
        {
            Console.WriteLine(random.Next());
        }
    }

    public class PersonModel
    {
        public string FirstName { get; set; }
    }
}
