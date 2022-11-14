using System;

namespace array
{
    class program
    {
        static void Main(string[]args)
        { 
            // sort
            int[] sayidizisi ={23,12,4,86,72,3,11,17};

            Console.WriteLine("****sırasız dizi*****");
            foreach (var sayi in sayidizisi)
              Console.WriteLine(sayi);

               Console.WriteLine("**** Sırasız Dizi*****");
               Array.Sort(sayidizisi);

               foreach(var sayi in sayidizisi)
                 Console.WriteLine(sayi);

                 //clear
                 Console.WriteLine("****Array Clear*****");
                 // sayiDizisi elemanlarını kullanarak 2.index ten itibaren 2 tane elemanı 0'lar.
                 Array.Clear(sayidizisi,2,2);

                 foreach(var sayi in sayidizisi)
                   Console.WriteLine(sayi);

                   //Revarse
                   Console.WriteLine("**** Array Reverse *****");
                   Array.Reverse(sayidizisi);

                   foreach(var sayi in sayidizisi)
                     Console.WriteLine(sayi);

                  //indexOf
                   Console.WriteLine("**** indexOf *****");
                  Console.WriteLine( Array.IndexOf(sayidizisi,23));

                  //Resize
                  Console.WriteLine("**** Array Resize *****");
                  Array.Resize<int>(ref sayidizisi,9);
                  sayidizisi[8] = 99;
                  
                  foreach(var sayi in sayidizisi)
                     Console.WriteLine(sayi);





            
        }
    }
}      
       