using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOOP
{
    class Generics
    {
        List<string> firstList = new List<string>();
        Dictionary<string, string> keyValueDictionary = new Dictionary<string, string>();
        SortedList<int, string> sortedList = new SortedList<int, string>();
        SortedDictionary<int, string> sortedDictionary = new SortedDictionary<int, string>();
        Stack<string> Ram = new Stack<string>();
        Queue<DateTime> arrivals = new Queue<DateTime>();

        void Capitals()
        {
            var capitals = new List<KeyValuePair<string, string>>();

            capitals.Add(new KeyValuePair<string, string>("Georgia", "Tbilisi"));
        }

        public Generics()
        {
            //list
            firstList.Add("Generic List Add");

            //dictionary added with key value pairs
            keyValueDictionary.Add("abc", "firstItem");
            Console.WriteLine(keyValueDictionary["abc"]); //<- get by index of firstItem

            //sortedList
            sortedList.Add(1, "GE");

            //sortedDictionary will sort it for us
            sortedDictionary.Add(2, "B");
            sortedDictionary.Add(1, "A");

            //generic stack
            Ram.Push("visual");

            //queue
            arrivals.Enqueue(new DateTime(2018,02,22));
            arrivals.Enqueue(new DateTime(2019, 02, 25));
            arrivals.Enqueue(new DateTime(2008, 12, 12));

            foreach (var item in arrivals)
            {
                Console.WriteLine(item);
            }
        }
    }
}
