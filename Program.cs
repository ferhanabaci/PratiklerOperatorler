using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Atama ve işlemli atama 
            Console.WriteLine("Atama ve işlemli atama");

            int x = 3;
            int y = 3;
            y = y +2;
            Console.WriteLine(y);
            y+=2; // buna işlemli atama denir .
            Console.WriteLine(y);


            y/=1;
            Console.WriteLine(y);

            x *=2;
            Console.WriteLine(x);

            //Mantıksal Operatörler 
            // || && !(degil anlamındadır)
            Console.WriteLine("Mantıksal Operatörler ");


            bool isSuccess =true;
            bool isCompleted = false ;

            if(isSuccess && isCompleted ) // herikisiin de true olmasını bekler 
                Console.WriteLine("Perfect");

            if(isSuccess || isCompleted ) // her ikisinden biri true ise Great yazar 
                Console.WriteLine("Great ");

            if(isSuccess &&  !isCompleted ) 
                Console.WriteLine("Fine ");

            //iliskisel operatorler   
            // < > <= >= == !=
            Console.WriteLine( "iliskisel operatorler   ");

            int a = 3;
            int b=4;
            bool sonuc = a<b;
            Console.WriteLine( sonuc);
            sonuc = a>b;

            Console.WriteLine( sonuc);
            sonuc = a>=b;
            Console.WriteLine( sonuc);
            sonuc = a<=b;
            Console.WriteLine( sonuc);
            sonuc = a==b;
            Console.WriteLine( sonuc);
            sonuc = a!=b;
            Console.WriteLine( sonuc);


        }
    }
}
