using System;
namespace OperatorsArithmetic
{
   class Program 
   { 
      static void Main(string[] args) 
      { 
         int number1 = 58;
         int number2 = 12;
         int result;

         result = number1 + number2;
         Console.WriteLine("1.işlemin sonucu result :{0}",result); //Toplama işlemi sonucu
         result = number1 - number2;
         Console.WriteLine("2.işlemin sonucu result :{0}",result); //Çıkarma işlemi sonucu
         result = number1 * number2;
         Console.WriteLine("3.işlemin sonucu result :{0}",result); //Çarpma işlemi sonucu
         result = number1 / number2;
         Console.WriteLine("4.işlemin sonucu result :{0}",result); //Bölme işlemi sonucu
       
      }
   }
}
