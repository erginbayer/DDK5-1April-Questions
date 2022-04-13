using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDK5_1April
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1) Ekrana 10 kez “Hello World!” yazdır.

            //for(int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("Hello World!");
            //}

            #endregion

            #region 2) Dışarıdan girilen sayıya kadar olan çift sayıları ekrana yazdır. Örneğin 11 girdiyse ekrana “2”,”4”,”6”,”8” gibi.

            //Console.Write("Lütfen bir sayı giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < sayi; i++)
            //{
            //    if (i % 2 == 0) // i değeri 2 ile bölündüğünde kalan 0 ise
            //        Console.Write(i + " ");
            //}

            #endregion

            #region 3) Dışarıdan girilen bir sayının rakamlarını tersine çeviren program.Örneğin 123 girdiyse ekrana 321 yazsın gibi

            //Console.Write("Sayıyı giriniz : ");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //int sonuc = 0;

            //while (sayi > 10)
            //{
            //    sonuc = sayi % 10; // sayi değerinin sonuncu rakamı almak için %10 ile işlem yapmamız lazım.
            //    Console.Write(sonuc);
            //    sayi /= 10; // bir sonraki basamak değerini almak için /10 ile işlem yapmamız lazım.
            //}

            //Console.WriteLine(sayi);
            #endregion

            #region 4) Verilen tamsayının sıfır, pozitif ya da negatif olup olmadığını bulan program.

            //Console.Write("Sayı giriniz : ");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi > 0)
            //    Console.WriteLine(sayi + " değeri pozitiftir.");

            //else if (sayi < 0)
            //    Console.WriteLine(sayi + " değeri negatiftir.");

            //else
            //    Console.WriteLine(sayi + " değeri sıfırdır.");


            #endregion

            #region 5) Girilen fiyatın KDV li halini ( % 18 ) ekrana yazdır.

            //Console.WriteLine("Fiyat giriniz : ");
            //int fiyat = Convert.ToInt32(Console.ReadLine());

            //double sonuc = fiyat + (fiyat * 0.18);//fiyat ile kdv hesaplaması parantez içinde olması lazım ki işlem önceliği dikkat edilmesi lazım

            //Console.WriteLine(fiyat + " girilen fiyatın %18 KDV'li hali: " + sonuc);

            #endregion

            #region 6) Üniversite bir dersin başarı notu bir vize bir final sınav notu ile hesaplanır. Vize notunun kat sayısı %30 final notunun kat sayısı %70’dir.Bir öğrencinin sınavda almış olduğu bu notlar neticesinde ders ortalaması bulun.

            //Console.WriteLine("Vize notu giriniz: ");
            //int vize = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Final notu giriniz: ");
            //int final = Convert.ToInt32(Console.ReadLine());

            //double ortalama = (vize * 0.30) + (final * .70);

            //Console.WriteLine("Vize = " + vize + "\nFinal = " + final + "\nOrtalama = " + ortalama);
            #endregion

            #region 7) Kullanıcıdan alınan sayının tek ya da çift olduğunu kontrol edip ekranda yazdırın

            //Console.Write("Sayi giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi % 2 == 0)
            //    Console.WriteLine(sayi + " sayısı çifttir.");
            //else
            //    Console.WriteLine(sayi + " sayısı tektir.");
            #endregion

            #region 8) Bir kenar uzunluğu ve o kenara ait yüksekliği girilen üçgenin alanını hesaplayın.

            //Console.Write("Kenar uzunluğu giriniz: ");
            //int uzunluk = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Yükseklik giriniz: ");
            //int yukseklik = Convert.ToInt32(Console.ReadLine());

            //int sonuc = (uzunluk * yukseklik) / 2;

            //Console.WriteLine("Üçgenin alanı: " + sonuc);
            #endregion

            #region 9) Girilen bir x sayısının yine girilen bir y sayısına tam bölünüp bölünmediğini ekrana yazdırın.

            //Console.Write("Bölünecek sayı giriniz: ");
            //int bolunen = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Bölen sayı giriniz: ");
            //int bolen = Convert.ToInt32(Console.ReadLine());

            //int sonuc = bolunen % bolen; //bolunen ile bolenin kalanını sonuc değerine aktar.
            //if (sonuc == 0)
            //    Console.WriteLine(bolunen + " sayı ile " + bolen + " sayısı tam bölünüyor.");
            //else
            //    Console.WriteLine(bolunen + " sayı ile " + bolen + " sayısı tam bölünmüyor.");

            #endregion

            #region 10) Çarpma operatörü kullanmadan klavyeden girilen sayının 5 katını bulun.

            //Console.Write("Sayı giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //int sonuc = 0;

            //for (int i = 1; i <= 5; i++)
            //{
            //    sonuc += sayi;// 5'e kadar sayıyı sonuca toplayarak aktarıyor.
            //}

            //Console.WriteLine(sayi + " * " + "5 = " + sonuc);
            #endregion

            #region 11) Klavyeden girilen sayının kaç basamaklı olduğunu bulun.

            //Console.Write("Bir sayı giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int karakterSayisi = 0;

            //while (sayi > 0)
            //{
            //    sayi /= 10;//Her bir basamak çıkardıkça karakterSayisi değerine birer değer artar.
            //    karakterSayisi++;
            //}

            //Console.WriteLine("Karakter sayısı = " + karakterSayisi);
            #endregion

            #region 12) Klavyeden girilen sayının asal olup olmadığını söylesin

            //bool asalMi = true;
            //Console.Write("Sayı Giriniz : ");

            //int sayi = Convert.ToInt32(Console.ReadLine());

            //for (int i = 2; i < sayi; i++)
            //{
            //    if (sayi % i == 0)
            //    {
            //        asalMi = false;// sayi ve i değeri ile bölününce kalan 0 oluyorsa asalMi değeri false değerine dönüyor.
            //    }
            //}

            //if (asalMi) //if koşullarda eğer sadece boolean değeri koyarsak otomatik olarak true olur.
            //    Console.WriteLine("Girilen Sayı Asal");

            //else
            //    Console.WriteLine("Girilen Sayı Asal Değil");

            #endregion

            #region 13) N elemanlı bir dizi yi yedek dizi KULLANMADAN tersine çeviren program

            //int[] numbers = new int[] { 10, 20, 30, 40, 50 };

            //int temp = 0;

            //for(int i = 0; i < numbers.Length / 2; i++)
            //            {
            //    temp = numbers[i];
            //    numbers[i] = numbers[numbers.Length - i - 1];
            //    numbers[numbers.Length - i - 1] = temp;
            //}
            //foreach (int sayi in numbers)
            //    Console.WriteLine(sayi);

            #endregion

            #region 14) Dışarıdan girilen bir cümledeki kelime sayısını bulan program

            //Console.Write("Metin giriniz  : ");
            //string metin = Console.ReadLine();

            //string[] kelimeler = metin.Split(' '); //metinde boşluk olduğu zaman kesilip kelimeler dizisine aktarır.

            //Console.WriteLine("Kelime Sayısı :" + kelimeler.Length);

            #endregion

            #region 15) Dışarıdan girilen en az 5 basamaklı sayının ilk ve son basamakları arasındaki sayıların toplamını bulan program.

            //int sonuc = 0;

            //Console.WriteLine("Sayı giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi < 10000)
            //{
            //    Console.WriteLine("5 basamaklı sayı giriniz.");
            //    Console.ReadKey();
            //}

            //string rakamlar = sayi.ToString();// rakamları teker teker almak için sayiyi stringe döndürüp rakamlara aktarıyoruz.

            //for (int i = 1; i < rakamlar.Length - 1; i++)//ilk ve son basamak hariç olacağı için i ile 1 den başlatıyoruz rakamlar.length ise -1 ile devam ediyoruz.
            //{
            //    int b = rakamlar[i] -'0'; // -'0' integere çevirmek için koyuyoruz.
            //    sonuc += b;
            //}
            //Console.WriteLine("Sonuç = " + sonuc);

            #endregion

            #region 16) Dışarıdan girilen sayının faktöriyelini hesapla

            //Console.Write("Sayı giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int faktoriyel = 1;

            //for (int i = 1; i <= sayi; i++)
            //    faktoriyel *= i; //i sayısına kadar çarpar. Faktöriyel değerini bulur.

            //Console.WriteLine(sayi + "!: " + faktoriyel);


            #endregion

            #region 17) Aşağıdaki formu ekrana yazdıran program.

            //1

            //2 3

            //4 5 6

            //7 8 9 10

            //11 12 13 14 15

            //int temp = 1;

            //for (int i = 0; i < 7; i++)
            //{


            //    for (int k = 1; k < i; k++)
            //    {
            //        Console.Write(temp + " ");

            //        temp++;
            //    }

            //    Console.Write("\n");

            //}


            #endregion

            #region 18) Aşağıdaki formu ekrana yazdıran program.

            //2 3 4 5 6

            //3 5 7 9 11

            //4 7 10 13 16

            //5 9 13 17 21

            //6 11 16 21 26

            //int line2 = 3, line3 = 4, line4 = 5, line5 = 6;


            //for (int i = 2; i <= 6; i++)
            //{
            //    while (i <= 6)
            //    {
            //        Console.Write(i + " ");

            //        i++;

            //    }

            //    Console.WriteLine();

            //    while (line2 <= 11)
            //    {
            //        Console.Write(line2 + " ");

            //        line2 += 2;

            //    }
            //    Console.WriteLine();

            //    while (line3 <= 16)
            //    {
            //        Console.Write(line3 + " ");

            //        line3 += 3;

            //    }

            //    Console.WriteLine();

            //    while (line4 <= 21)
            //    {
            //        Console.Write(line4 + " ");

            //        line4 += 4;

            //    }

            //    Console.WriteLine();

            //    while (line5 <= 26)
            //    {
            //        Console.Write(line5 + " ");

            //        line5 += 5;

            //    }
            //    Console.WriteLine();
            //}

            #endregion


            Console.ReadKey();
        }
    }
}
