using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOOP
{
    class NonGenerics
    {

        ArrayList array = new ArrayList();
        Hashtable hash = new Hashtable();
        SortedList sortedList = new SortedList();
        Stack stack = new Stack();
        Queue queue = new Queue();

        public NonGenerics()
        {
            //arrayList
            array.Add("First");
            array.Add("Second");
            array.Add(3);

            Console.WriteLine(array[0].ToString());
            Console.WriteLine(array.Count);

            //hashtable
            hash.Add("Shaurma", "GE");
            hash.Add("Gnomon", "USA");

            foreach (DictionaryEntry item in hash)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            //sortedList, they are sorted by ket so, use one type for sorting BIATCH <3
            sortedList.Add(1, "Jan");
            sortedList.Add(2, "That");

            //stack, first in last out "FILO"
            stack.Push("Gio");
            stack.Push("Mariam");

            //queue First in first out "FIFO", rigis pontia chveulebrivi
            queue.Enqueue("First in Queue");
            queue.Dequeue();
        }
        
    }
}
