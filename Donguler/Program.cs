﻿using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            //string kurs2 = "Programlamaya başlangıç için temel kurs";
            //string kurs3 = "Java";

            // array - dizi

            string[] kurslar = new string[] { "Yazılım Gelişririci Yetiştirme Kampı", "Programlamaya Başlangıç için temel kurs", "Java", "Python", "Android" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);

            }

            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
