using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    public class RansomNote_Dictionary_Solution
    {
        public static void checkMagazine(List<string> magazine, List<string> note)
        {
            //got help from https://gist.github.com/siccolo/ea234b594f4befe5ed6d071aff7737f1

            var sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            // Fill CountMagazine Dictionary
            var countMagzine = new Dictionary<string, int>();
            for (int i = 0; i < magazine.Count; i++)             
            {
                if (countMagzine.ContainsKey(magazine[i])) 
                {
                    countMagzine[magazine[i]] += 1; //add 1 to previous value of magzine[i]. like "Hello:2"
                }
                else 
                {
                    countMagzine.Add(magazine[i], 1);
                }
            }
            sw.Stop();
            Console.WriteLine(magazine.Count + " magazine " + sw.ElapsedMilliseconds + " milliseconds");

            sw.Reset();
            sw.Start();

            //Fill CountNote Dictionary

            var countNote = new Dictionary<string, int>();
            for (int i = 0; i < note.Count; i++) 
            {
                if (countNote.ContainsKey(note[i])) 
                {
                    countNote[note[i]] += 1;
                }
                else 
                {
                    countNote.Add(note[i], 1);
                }
            }

            sw.Stop();
            Console.WriteLine(note.Count + " note " + sw.ElapsedMilliseconds +" milliseconds");



            sw.Reset();
            sw.Start();
            //Now by matching keys and check Magazine contains words of Note.

            foreach (var nk in countNote) 
            {
                if (!countMagzine.ContainsKey(nk.Key)) 
                {
                    Console.WriteLine("No");
                    return;
                }
                var mc = countMagzine[nk.Key];

                //compare no.of words in both lists.
                if (mc < nk.Value) 
                {
                    Console.WriteLine("No");
                    return;
                }
            }
            Console.WriteLine("Yes");
            sw.Stop();
            Console.WriteLine(" all done " + sw.ElapsedMilliseconds + " milliseconds");
            return;
        }
    }
    
    public class RansomNote_Dictionary_Result
    {        
        public static void Input() 
        {
            //string magazine = "ive got a lovely bunch of coconuts";
            //string note = "ive got some coconuts";

            string magazine = "give me one grand today night";
            string note = "give one grand today";

            //string magazine = "two times three is not four";
            //string note = "two times two is four";
            
            //string magazine = "attack at dawn";
            //string note = "Attack at dawn";
            

            List<string> magzineList = magazine.Split(' ').ToList();
            List<string> noteList = note.Split(' ').ToList();

            RansomNote_Dictionary_Solution.checkMagazine(magzineList, noteList);
        }
    }
}
