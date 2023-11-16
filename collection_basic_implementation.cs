using System;
using System.Collections.Generic;
using System.Collections;


namespace collection_implementation
{
    class Program
    {
        static void Main(string[] args)
        {

            /*int[] array = new int[2];
            int[][] array1 = new int[2][];
            int[,] array2 = new int[2,6];
            int[,] array4 = new int[2,5];
            foreach(var v in array)
            {
                Console.WriteLine(v);
            }
            */

            //  array[2] = 3;

            ArrayList array11 = new ArrayList();
            array11.Add(101);
            array11.Add("James");
            array11.Add("James");
            array11.Add(" ");
            array11.Add(true);






            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, 1);
            hashtable.Add(2, "hello");
            hashtable.Add(3, 'w');
            hashtable.Add(4, 1000);



            Queue q = new Queue();
            q.Enqueue(10);
            q.Enqueue("string");
            q.Enqueue("hello");
            q.Enqueue('g');
            q.Dequeue();
            q.Peek();



            Stack st = new Stack();
            st.Push(22);
            st.Push(33);
            st.Pop();
            st.Peek();



            List <int> list = new List<int>();

            list.Add(5);
            list.Add(10);
            list.Add(15);
            list.Add(15);
            list.Add(20);
            list.Add(25);

            Console.WriteLine("\nList<T>:");
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
            list.Remove(15);
            list.Remove(10);
            Console.WriteLine("\nList<T> after Remove:");
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
       
            Dictionary<int, string> myD = new Dictionary<int, string>();

            myD.Add(1, "Utkarsh");
            myD.Add(2, "srivastava");
            myD.Add(3, " ");

            Console.WriteLine("\nDictionary<TKey , TValue>:");
            foreach (var i in myD)
            {
                Console.WriteLine("{0} : {1}", i.Key, i.Value);
            }
            Console.WriteLine("Count : {0} ", myD.Count);
        


            foreach (var item in array11)
            {
                Console.WriteLine(item);
            }

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine(item.Key);
            }




        }
    }
}

