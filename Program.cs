using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace lab8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("MH01", "Mumbai");
            ht.Add("MH04", "Thane");
            ht.Add("MH06", "Raigad");
            
            foreach(DictionaryEntry t in ht)
            {
                Console.WriteLine(ht.ContainsKey("MH01"));
                Console.WriteLine(ht.ContainsValue("Mumbai"));
                Console.WriteLine(t.Key + " : " + t.Value);
                ht.Remove("MH04");
                Console.WriteLine(ht.Count);

                Console.ReadKey();


            }
        }
    }
}
