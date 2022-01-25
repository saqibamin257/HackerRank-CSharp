using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class HashTable_Solution
    {        
        public static void Hashing() 
        {
            Hashtable ht = new Hashtable();
            ht.Add("001", "Saqib Amin");
            ht.Add("002", "Amjad Ismail");
            ht.Add("003", "Wasim Akram");
            ht.Add("004", "Imran Khan");
            ht.Add("005", "Shoaib Akhtar");
            if (ht.ContainsValue("Ali")) 
            {
                Console.WriteLine("This name already exists in HashTable");
            }
            else {
                ht.Add("006", "Ali");
            }

            //get a collection of keys.

            ICollection key = ht.Keys;
            foreach (string k in key) 
            {
                Console.WriteLine($"{k}: {ht[k]}");
            }
            Console.ReadKey();
        }       
    }
    public class HashTable_Result 
    {
        public static void Input() 
        {
            HashTable_Solution.Hashing();
        }
    }    
}
