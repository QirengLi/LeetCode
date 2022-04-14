using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanToInt
{
    internal class Program
    {
        public static void RomanToInt(string s)
        {

            char[] romanLetters = s.ToCharArray();
            Hashtable romanTable = new Hashtable();
            int sum = 0;


            romanTable.Add('I', 1);
            romanTable.Add('V', 5);
            romanTable.Add('X', 10);
            romanTable.Add('L', 50);
            romanTable.Add('C', 100);
            romanTable.Add('D', 500);
            romanTable.Add('M', 1000);

            for (int i = 0; i<romanLetters.Length; i++)
            {
                if(romanLetters[i] == )
                int numVal = (int) romanTable[romanLetters[i]];
                sum += numVal;
            }
            Console.WriteLine(sum);
        }
        static void Main(string[] args)
        {
            RomanToInt("III");
        }
    }
}
