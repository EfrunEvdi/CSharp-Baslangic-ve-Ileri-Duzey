﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //MerhabaHataYonetimi();
            HataYonetimiInceleme();
        }

        static void HataYonetimiInceleme()
        {
            try
            {
                // Standart uygulama için yazmış olduğumuz kod blokları
                Console.Write("Bir sayı girişi yapınız : ");
                int sayi1 = int.Parse(Console.ReadLine());

                if (sayi1 == 10)
                {
                    throw new OzelHataSinifi();
                }
            }

            catch (OzelHataSinifi fx)
            {
                Console.WriteLine("Özel hata sınıfı catch içerisinde yakalandı.");
            }

            catch (FormatException fx)
            {
                Console.WriteLine("Sizden beklenen değer sayısal bir değerdir.");
                Console.WriteLine(fx.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Herhangi bir hata oluştu.");
                Console.WriteLine(ex.Message);
                // Catch blokları sistem içerisinde çalışma zamanında alınan hataların loglanmasına ve kullanıcıya daha açıklayıcı hata mesajları vermemize yarayan bloklardır.
            }

            finally
            {
                // Try kısmında bizim kodlarımız çalışır,
                // Catch => ...
                // Finally => Kod tarafında herhangi bir hata almasakta bizim finally çalışmaya devam eder.
                Console.WriteLine("Finally bloğu çalıştı.");
            }

            Console.WriteLine("Uygulama bitti.");
            Console.ReadLine();
        }

        static void MerhabaHataYonetimi()
        {
            Console.Write("Bir sayı girişi yapınız : ");
            int sayi1 = int.Parse(Console.ReadLine());
        }
    }
}
