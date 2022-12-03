using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StringManipulationApp
{
    public class Helper
    {


        public void SwapEvenAndOdd(string input)
        {
           int length = input.Length;

           int half = length / 2;

           var first = input.Substring(0, half);
           var second = input.Substring(half);
            
            string firstText = first.Replace(" ", string.Empty);

            string secondText = second.Replace(" ", string.Empty);

            Console.WriteLine(firstText);

            var firstArray = firstText.ToCharArray();
            var secondArray = secondText.ToCharArray();

            string newA = "";
            string newB = "";
            int i;
            for( i = 0; i <= firstArray.Length - 1; i++)
            {
                bool even = i % 2 == 0;
                bool odd = i % 2 != 0;
                if(even)
                {
                    newA += firstArray[i]  + "" + secondArray[i];
                
                }
                else if(odd)
                {
                    newB += firstArray[i] + "" + secondArray[i];
                }

                Console.WriteLine(newA);
                Console.WriteLine(newB);
                Console.WriteLine(newA + "" + newB);

                string reversedA = String.Join(first, "", second);
                Console.WriteLine(reversedA);
            }



            
           


            


        }
    }            
}
    