using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaratonCevaplar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rastgele 10 adet sayı tanımla ve bu sayıları diziye at. Kullanıcı dışarıdan sayı girdiğinde dizide varsa kazandınız yoksa kaybettiniz yazsın. (Kullanıcının 3 kere yanlış girme hakkı var. Hemen kaybettiniz yazamaz )

            //int[] sayidizi = new int[10];

            //Random rnd = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    sayidizi[i] = rnd.Next(1, 20);
            //}

            //bool sayiVarmi = false;
            //int yanlisadet = 0;

            //while (sayiVarmi != true && yanlisadet < 3)
            //{
            //    Console.WriteLine("Sayı gir!");
            //    int girilensayi = Convert.ToInt32(Console.ReadLine());

            //    for (int i = 0; i < sayidizi.Length; i++)
            //    {
            //        if (sayidizi[i] == girilensayi)
            //        {
            //            sayiVarmi = true;
            //        }
            //    }

            //    if (sayiVarmi == false)
            //    {
            //        yanlisadet++;
            //    }
            //}


            //if (sayiVarmi == true)
            //{
            //    Console.WriteLine("Kazandınız!");
            //}
            //else
            //{
            //    Console.WriteLine("Geçmiş olsun!");
            //}

            //Console.ReadLine();


            //Bir metin tanımla. “İstanbul,izmir,Ankara,Diyarbakır” gibi aralarında virgüller olan. Bunları split metotduyla ayırıp tüm harfleri büyük olacak şekilde ekrana yazdır

            string sehirler = "İstanbul,izmir,Ankara,Diyarbakır";

            string[] sehirdizi = sehirler.Split(',');

            for (int i = 0; i < sehirdizi.Length; i++)
            {
                sehirdizi[i] = sehirdizi[i].ToUpper();
                Console.Write(" " + sehirdizi[i] + " ");
            }



            Console.ReadLine();


        }
    }
}
