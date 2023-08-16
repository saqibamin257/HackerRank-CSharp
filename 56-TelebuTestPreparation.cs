using HackerRank;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class TelebuTestPreparation_Result
    {
        #region TotalSaturdays
        public void TotalSaturday() 
        {
            int month = 1;
            int year = 2023;            
            int totaldays = DateTime.DaysInMonth(year, month);
            int count = 0;
            for (int i = 1; i <= totaldays; i++)
            {
                string dayName = Convert.ToString(new DateOnly(year, month, i).DayOfWeek);
                if (dayName.ToUpper() == "SATURDAY")
                {
                    count++;
                }
            }
            Console.WriteLine($"Total Number of Saturdays are: {count}");
        }
        #endregion

        #region Overloading
        
        public int Add(int num1,int num2) 
        {
            return num1 + num2;
        }
        public int Add(int num1, int num2,int num3)
        {
            return num1 + num2 + num3;
        }

        public float Add(float num1, float num2)
        {
            return num1 + num2;
        }

        //this will show error that Add with same parameters already exists.
        //public float Add(int num1, int num2)
        //{
        //    return num1 + num2;
        //}


        #endregion

        #region Recursion
        public int Factorial(int n) 
        {
            if (n == 0) 
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }

        public int MultiplyByExponent(int exponent, int number) 
        {
            if(exponent == 0) 
            {
                return 1;
            }
            return number * MultiplyByExponent(exponent - 1, number);
        }

        public void PrintNaturalNumber(int number, int start) 
        {
            if (number > 0)
            {
                Console.WriteLine(start);
                start++;
                PrintNaturalNumber(number - 1, start);
            }
        }

        #endregion

        #region TotalSunday
        public int TotalSunday(int year, int month) 
        {            
            int totalDays = DateTime.DaysInMonth(year, month);
            int count = 0;
            for (int i = 1; i <= totalDays; i++) 
            {
                DateTime d= new DateTime(year, month, i);
                if (d.DayOfWeek.ToString().ToLower() == "sunday") 
                {
                    count++;
                }
            }
            return count;
        }
        #endregion

        #region Factorial
        public int GetFactorial(int num) 
        {
            int result = 1;
            for (int i = num; i >= 1; i--) 
            {
                result = result * i;
            }
            return result;
        }
        #endregion

        #region SlowestKey
        public char SlowestKey() 
        {
            //Sample test case

            //{ 0,2},
            //{ 1,5},
            //{ 0,9},
            //{ 2,15}

            //2 - 0  = 2 => a
            //5 - 2  = 3 => b
            //9 - 5  = 4 => a
            //15 - 9 = 6 => c
            //output C it tooks Longest time

            int[,] keyTime = new int[4,2] {
                                        {0,2},
                                        {1,5},
                                        {0,9},
                                        {2,15}
                                    };

            char[] alphabetArray="ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char slowestCharacter = alphabetArray[keyTime[0, 0]];
            int slowestKey = keyTime[0,1];
            
            int RowLength = keyTime.GetLength(0);
            int ColLength = keyTime.GetLength(1);

            for (int row = 0; row < RowLength; row++) 
            {
                for (int col = 0; col < ColLength; col++) 
                {
                    if (col == 1 && row > 1) 
                    {
                        int currentKeyValue = keyTime[row, col] - keyTime[row, col];
                        slowestKey = currentKeyValue > slowestKey ? currentKeyValue : slowestKey;
                        slowestCharacter = alphabetArray[slowestKey];
                    }
                }
            }
            return slowestCharacter;            
        }
        #endregion

        #region character frequency

        //Input S=aabccc;
        //a=2,b=1,c=3
        //output 2*3*1=6

        public int StringFrequency(string s)
        {
            s = string.Concat(s.OrderBy(x => x));
            int total = 1;
            Dictionary<char, int> dict = new Dictionary<char, int>();
            int count = 1;

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == s[i + 1])
                {
                    count++;
                    if (!dict.ContainsKey(s[i]))
                    {
                        dict.Add(s[i], count);
                    }
                    else
                    {
                        dict[s[i]] = count;
                    }
                }
                else
                {
                    count = 1;
                    dict.Add(s[i + 1], count);
                }
            }
            foreach (var v in dict)
            {
                total = total * v.Value;
            }
            return total;
        }
        #endregion
    }
}
    public class TelebuPreparation_Solution 
    {
        public void Input() 
        {
            new TelebuTestPreparation_Result().TotalSaturday();
            
            //Factorial
            int n = 5;
            int result = new TelebuTestPreparation_Result().Factorial(n);
            Console.WriteLine($"Factorial of {n} is : {result}");

            //MultiplyByExponent
            int num = 10;
            int exponent = 4;
            int exponentResult = new TelebuTestPreparation_Result().MultiplyByExponent(exponent, num);
            Console.WriteLine($"The result of {num} exponent {exponent} is: {exponentResult}");

            //TotalSunday
            int year = 2023;
            int month = 8;
            int TotalSundayCount = new TelebuTestPreparation_Result().TotalSunday(year, month);
            Console.WriteLine($"Total Sundays in year: {year} , month: {month} are {TotalSundayCount}");

            //Factorial Repractice
            int num1 = 6;
            int FactorialResult = new TelebuTestPreparation_Result().GetFactorial(num1);
            Console.WriteLine($"Factorial of {num1} is :{FactorialResult}");

            //Print Natural Number in Ascending Order            
            int numberParam = 10;
            int startParam = 1;
            new TelebuTestPreparation_Result().PrintNaturalNumber(numberParam, startParam);

            //Slowest Key PRess

            char ch = new TelebuTestPreparation_Result().SlowestKey();
            Console.WriteLine($"Slowest Key is {ch}");

           //String Frequency
           string s = "aabccc";
          int result5 = new TelebuTestPreparation_Result().StringFrequency(s);
          Console.WriteLine($" Frequecy of {s} is :{result5}");
        }
    }

