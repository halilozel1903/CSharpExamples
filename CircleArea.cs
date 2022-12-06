using System;
namespace DeclaringConstants
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14; //sabit pi değeri  
            double radius=5.0; //Daire yarıçapı 5.0
            double areaCircle = pi * radius * radius; //Daire alanı hesaplama
            Console.WriteLine("Radius: {0}, Area: {1}", radius, areaCircle); //Dairenin yarıçapı ve alanı yazdırıldı.
        }
    }
}
