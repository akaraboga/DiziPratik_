using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziPratik
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[] dizi = new int[10];//10 elemanlı diziyi tanımlıyoruz

            Console.WriteLine("10 tane sayi giriniz");

            for (int i = 0; i < dizi.Length; i++)//diziyi for ile alma
            {
                Console.WriteLine("{0}.Sayi giriniz", i + 1);
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();

            Console.WriteLine("Girdiğiniz sayilar : ");

            foreach (int sayilar in dizi)//Foreach ile yazdırma
            {
                Console.WriteLine(sayilar);
            }



            int[] dizi2 = new int[11];//11 elemanlı yani bir dizi tanımlıyoruz

            for (int i = 0; i < dizi.Length; i++) 
            {
                dizi2[i] = dizi[i];//11 elemanlı diziye 10 elemanlı diziyi kopyalıyoruz
            }


   
            

            int Ydeger = 0;//Default olarak  kullanıcıdan gelecek olan değeri tanımlıyoruz

        tekrar://Etiketin geldiği yer

            Console.WriteLine("Yeni değer eklemek istiyor musunuz? E || H");//Eğer kullanıcı yeni değer girmek istiyorsanız
            string cevap = Console.ReadLine().ToUpper();

      

           

 

           
            if (cevap == "E")//Cevap E ise 
            {
                Console.Write("Eklemek istediğiniz sayiyi giriniz : ");

                Ydeger = Convert.ToInt32(Console.ReadLine());//İstedğimiz sayiyi giriyoruz

                dizi2[dizi.Length] = Ydeger;//Girdiğimiz sayiyi dizi2 ye 11 haneli dizi2 ye atıyoruz

                Array.Sort(dizi2);//Küçükten büyüğe doğru sıralar eğer bunu yapmazsak diziye girdiğimiz yeni değer hep en başa yazılır
                Array.Reverse(dizi2);//Diziyi buyukten küçüğe sıralamak için

                Console.WriteLine("Yeni sayilar :");

                foreach (int sayi in dizi2)//Yeni hali
                {
                    Console.WriteLine(sayi);
                }

            }
            else if (cevap == "H")//H ise aşağıdaki işlemleri yapıyoruz
            {
                Console.WriteLine("Yeni değer eklemediniz");
                Console.WriteLine("Çıkmak için bir tuşa basınız");
 

                foreach (int sayi in dizi)//Deger eklenmediği için 10 haneli dizi değerini bastırıyoruz
                {
                    Console.WriteLine(sayi);
                }

                Console.ReadKey();

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Yanlış cevap");
               
                goto tekrar;// E || H den baska cevap verdiyse goto etiketi ile başa donderiyoruz
            }
          

           

          
           




            Console.ReadLine();
        }
    }
}
