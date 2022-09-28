using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faktöriyel_hesaplama2
{
    internal class Program
    {
       public static int faktoriyel(int sayi)
        {
          int faktoriyel = 1;

           for (int i = 1; i <= sayi; i++)
           {
                faktoriyel = faktoriyel * i;
           }
           return faktoriyel;
        }

        static void Main(string[] args)
        {
            Console.Write("Değer dizisini giriniz: ");
            string value = Console.ReadLine();
            string[] array = value.Split(',');

            int[] intarray=  new int[array.Length];

            for(int i=0; i<array.Length; i++)
            {
                string item = array[i];
                intarray[i] = Int32.Parse(item);
            }

            string str = " ";

            for(int i=0; i<intarray.Length;i++)
            {
                int sonuc = faktoriyel(intarray[i]);                               
                str += sonuc;
                if (i != intarray.Length - 1)
                    str += ",";
            }
            
          
            Console.Write("Sonuç: " + str);
            Console.ReadLine();
        }
      
    }

}
