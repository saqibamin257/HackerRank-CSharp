using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    internal class GradingStudent_Solution
    {
        public static List<int> gradingStudent(List<int> grades) 
        {
            List<int> students=new List<int>();
            
            for(int i = 0; i < grades.Count; i++) 
            {
                // reminder = grade[i]%5 => 73 % 5 => 3.
                // diff = 5 - (remainder) => 5-3 = 2.
                // total = diff + grade[i] => 2+ 73 = 75.

                if (grades[i] >= 38)
                {
                    int remainder = grades[i] % 5; 
                    int diff = 5 - remainder;
                         
                    if(remainder == 0 || diff >2) 
                    {
                        students.Add(grades[i]);
                    }

                   else
                    {                                
                        int total = diff + grades[i];
                        students.Add(total);
                    }

                    //int t = (remainder == 0 || diff>2)?grades[i]: diff + grades[i];
                    //students.Add(t);

                }
                else 
                {
                    students.Add(grades[i]);
                }                
            }
            return students;
        }

        public static List<int> gradingStudent2(List<int> grades) 
        {
            List<int> students = new List<int>();
            for(int i = 0; i < grades.Count; i++) 
            {
                int grade = grades[i];
                int value = (grade < 38 || grade % 5 < 3) ? grade : grade + (5- (grade%5));
                students.Add(value);
            } 
            return students;
        }


    }
    internal class GradingStudent_Result
    {
        public static void Input() 
        {
            List<int> lst = new List<int> {73,67,38,33};
            List<int> result = GradingStudent_Solution.gradingStudent(lst);
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("****** By Using Ternary Operator   ******");
            List<int> result2 = GradingStudent_Solution.gradingStudent2(lst);
            foreach (int i in result2)
            {
                Console.WriteLine(i);
            }


        }
    }
}
