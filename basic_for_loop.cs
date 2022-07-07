using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {

            /* HOCAM RİCA ETSEM KODUN OUTPUTUNA SİYAH EKRANDA BAKARKEN TAM SAYFA OLARAK AÇABİLİR MİSİNİZ? , ÇÜNKÜ KÜÇÜK EKRANDA KESİRLER KAYIYOR */

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n\t\t\t\t\t---RESULT OF THE FOLLOWING MATHEMATICAL FORMULA AFTER 30 TERMS---\n");
            Console.ResetColor();


            Console.ForegroundColor = ConsoleColor.Blue;
           
            Console.WriteLine("\t min(3x^2), 4!) ∆ 2    min(7x^5, 6!) ∆ 7      min(11x^8, 8!) ∆ 12         min(15x^11, 10!) ∆ 17            min(19x^14, 12!) ∆ 22 ");
            Console.WriteLine("\t  ________________ - _____________________ + ______________________ - ____________________________ + ____________________________________ .... (30 term ) ");
            Console.WriteLine("\t    (2^2 +4^2)          (4^3 +6^3 +8^3)     (6^4 +8^4 +10^4 +12^4)   (8^5 +10^5 +12^5 +14^5 +16^5)  (10^6 +12^6 +14^6 +16^6 +18^6 +20^6))  \n");
            Console.ResetColor();

            //////////////////////////////////////////////////////

            //Input the number from the user.Checking the number range.

            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.Write("\t Please enter a number between 0 and 25 for value of 'x': ");
            double x1;
            for (x1 = Convert.ToDouble(Console.ReadLine()); x1 > 25 || x1 < 0;)
            {
                Console.Write("\n \t That is not between 0 and 25, re-enter number : ");
                x1 = Convert.ToDouble(Console.ReadLine());
            }

            //Input and control of mathematical operation (∆) from the user.

            Console.Write("\n \t Please enter the math operation for (∆).   ( * or / ): ");
            string character;

            for (character = (Console.ReadLine()); character != "*" && character != "/";)
            {
                Console.Write("\n \t Please re-enter the math operation for (∆).  ( * or / ): ");
                character = Console.ReadLine();
            }
            Console.ResetColor();
            ///////////////////////////////////////////////////////

            double exponential_number ;    //the result of the exponential number found in each round in the loop.
            double numerator_result = 0;   //the result of the numerator of fraction found in each round in the loop.
            double mul_1;                  //multiplier to find exponential

            double facto = 1;              //the result of the factoriel in each round in the loop.
            double facto_number;           //multiplier to find factoriel

            double number;                 //the base of the first exponential numbers I found in the denominator.   
            double denominator_result = 0; //the result of the denominator of fraction found in each round in the loop.
            double mul_2 ;                 //multiplier to find denominator

            double result ;                //the result of the fraction found in each round in the loop.
            double total_result = 0;       //total result of all fraction
           
            ///////////////////////////////////////////////////

            for (int i = 0; i < 30; i++) //loop that finds numbers of terms
            {
                   //the result of the exponential number
                mul_1 = 1;
                
                for (int j = 0; j < ((3 * i) + 2); j++)
                {
                    mul_1 = mul_1 * x1;
                }
                exponential_number = ((4 * i) + 3) * mul_1 ;  //like 3x^2

                    //The result of the factoriel

                facto_number = 1;
                facto = 1;

                for (int j = 0; j < (2 * (i + 2)); j++)
                {
                    facto = facto * facto_number;
                    facto_number++;
                }

                    //Control of mathematical operation (∆) . The result of the numerator is respect to the minimum requirement.   

                if (character == "*")
                {
                    if (exponential_number > facto)
                    {
                        numerator_result = facto * (2 + (5 * i));  //(2 + (5 * i)) = The number to be multiplied or divided by the specified minimum value. 
                    }
                    else
                    {
                        numerator_result = exponential_number * (2 + (5 * i));
                    }
                }
                else if (character == "/")
                {
                    if (exponential_number > facto)
                    {
                        numerator_result = facto / (2 + (5 * i));
                    }
                    else
                    {
                        numerator_result = exponential_number / (2 + (5 * i));
                    }
                }

                    //The result of the denominator of fraction  

                number = (i + 1) * 2;
                denominator_result = 0;

                for (int k = 0; k < i + 2; k++)
                {
                    mul_2 = 1;

                    for (int j = 0; j < i + 2; j++)
                    {
                        mul_2 = mul_2 * number;
                    }

                    denominator_result = mul_2 + denominator_result;
                    number = number + 2;
                }

                     //The result of the whole fraction found in round in the loop and assign to total_result

                result = numerator_result / denominator_result;

                if (i % 2 == 1)  //The condition that fractions are negative or positive.
                {
                    result = (-1) * result;
                }
                else
                {
                    result = (+1) * result;
                }

                total_result = total_result + result;   //Value of "result" assign to "total_result"

            }
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("\n \t Result of the mathematical formula is = " );
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(total_result+"\n");
            Console.ResetColor();


































        }
}
}
