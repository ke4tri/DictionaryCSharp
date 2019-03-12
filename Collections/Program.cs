using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //var arrayOfObjects = new object[5];
            //var studentsWithBlackHair = new List<string>();
            // collection initilization is the brackets, doint it to the collection
            var studentsWithBlackHair = new List<string>() { "Nathan", "Austin", "Marty mcfly"};


            var studentsByHairColor = new Dictionary<string, List<string>> { {"Black", studentsWithBlackHair } };

            studentsByHairColor.Add("Bald", new List<string> { "Martin" });
            // Can not do the below because that key already is in the list above. 
            //You have to add the below "adam" to the list above
            // studentsByHairColor.Add("Bald", new List<string> { "Adam" });


            //
            //var studentsByHairColor = new Dictionary<string,string>(); // key is string, and other string is value. This is one key one value
            //This is one key with muli value
            //var studentsByHairColor = new Dictionary<string, List<string>>(); 
            //var studentsByHairColor = new Dictionary<string, object>>(); //This is one key with muli value


            // how you add to dic
            // studentsByHairColor.Add("Black",studentsWithBlackHair);
            //get one value out
            var theBlackHairedStudents = studentsByHairColor["Black"];

            //Change the value here
            // studentsWithBlackHair["Black"] = new List<string>(); 
            if (theBlackHairedStudents == studentsWithBlackHair)
            {
                Console.WriteLine("They are the same");
            }
             //
            // can loop. kvp key value pair when loop over dictonary, the kvp's are objects
          //foreach (var (key,value) in studentsByHairColor
            foreach (var (hairColor,students) in studentsByHairColor)
            {
                students.Add("newPerson");
                // destructioring using (kvp, value)
                Console.WriteLine($"The following students have {hairColor} hair");
                foreach (var student in students)
                {
                    Console.WriteLine(student);
                }
              
            }
            Console.ReadLine();



        }
    }
}

