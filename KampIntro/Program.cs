﻿using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği

            //Do not repeat yourself - Kendini tekrarlama
            
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faziOrani = 1.45;
            bool sistemeGirisYapilmismi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if(dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }

            if (sistemeGirisYapilmismi == true)
            {
                Console.WriteLine("Kullaıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi); 
        }
    }
}
