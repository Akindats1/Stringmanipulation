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

           

            var firstArray = firstText.ToCharArray();
            var secondArray = secondText.ToCharArray();

            string newA = "";
            string newB = "";
            int i;
            for( i = 0; i < firstArray.Length; i++)
            {
             
                if(i % 2 == 0)
                {
                    newA += firstArray[i]  + "" + secondArray[i];
                
                }
                else 
                {
                    newB += firstArray[i] + "" + secondArray[i];
                }

                var result = newA + "" + newB;
                Console.WriteLine(result);

            }

                int decodeFirstLength = half / 2;
                int decodeSecondLength = length - decodeFirstLength ;
                char[] decodedfirstStr = firstArray;
                char[] decodedSecondStr = secondArray;
                string[] decodedResult = new string[] {new string(decodedfirstStr), new string(decodedSecondStr)};

                string outcome = String.Join(" ", decodedResult);

                foreach (var item in outcome)
                {
                   
                   Console.Write(item);
                }




            
           


            


        }
    }            
}
    