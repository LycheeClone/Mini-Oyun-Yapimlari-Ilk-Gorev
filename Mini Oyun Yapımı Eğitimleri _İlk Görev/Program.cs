using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Mini_Oyun_Yapımı_Eğitimleri__İlk_Görev
{
    class NewMath
    {
        static void Main(string[] args)
        {
            Min();
            Max();
            Factoriel();
            Sort();
        }

        public static void Min()
        {
            Console.WriteLine("İki Sayıdan Küçük Olanı Döndüren Fonksiyon \n" + "\nLütfen Birinci Sayıyı Giriniz.");
            string input1 = Console.ReadLine();
            Console.WriteLine("Lütfen İkinci Sayıyı Giriniz. \n");
            string input2 = Console.ReadLine();
            int num1, num2, minimumValue;
            bool isInteger1 = int.TryParse(input1, out num1);
            bool isInteger2 = int.TryParse(input2, out num2);
            if (isInteger1 && isInteger2)
            {
                if (num1 > num2)
                {
                    minimumValue = num2;
                }
                else
                {
                    minimumValue = num1;
                }
                Console.WriteLine("Girilen İki Sayıdan Küçüğü: " + minimumValue);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Girdiğiniz Değerler Tam Sayı Olmak Zorundadır! \n");
                Min();
                Console.ReadLine();
            }
        }


        public static void Max()
        {
            Console.WriteLine("İki Sayıdan Büyük Olanı Döndüren Fonksiyon \n" + "\nLütfen Birinci Sayıyı Giriniz. ");
            string input1 = Console.ReadLine();
            Console.WriteLine("Lütfen İkinci Sayıyı Giriniz. ");
            string input2 = Console.ReadLine();
            int num1, num2, maximumValue;
            bool isInteger1 = int.TryParse(input1, out num1);
            bool isInteger2 = int.TryParse(input2, out num2);
            if (isInteger1 && isInteger2)
            {
                if (num1 > num2)
                {
                    maximumValue = num1;
                }
                else
                {
                    maximumValue = num2;
                }
                Console.WriteLine("Girilen İki Sayıdan Büyüğü: " + maximumValue);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Girdiğiniz Değerler Tam Sayı Olmak Zorundadır!\n");
                Max();
                Console.ReadLine();
            }
        }

        public static void Factoriel()
        {
            BigInteger num1, factorial = 1;
            Console.WriteLine("Faktöriyel Hesaplama Programı\n" + "\nLütfen Faktöriyelini Bulmak İstediğiniz Değeri Giriniz.\n");
            string input1 = Console.ReadLine();
            //bool isInteger = int.TryParse(input1, out num1);
            bool isInteger = BigInteger.TryParse(input1, out num1);
            if (isInteger && num1 > 0)
            {
                for (int i = 1; i <= num1; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine("\nGirdiğiniz Değerin Faktöriyeli:" + factorial);
                 //   + "\n" +
                //    "\nYeni Bir Hesaplama Yapmak için Y, Programdan Çıkmak İçin Enter Tuşuna Basınız\n");
                //ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                //if (keyInfo.KeyChar == 'y' || keyInfo.KeyChar == 'Y')
                //{
                //    Factoriel();
                //}
                //else
                //{
                //    Environment.Exit(0);
                //}
            }
            else
            {
                Console.WriteLine("\nGirdiğiniz Değer Pozitif Tam Sayı Olmaz Zorundadır!\n");
                Factoriel();
            }
        }

        public static void Sort()
        {
            Console.WriteLine("\nGirilen Değerleri Numerik Ve Alfabetik Sıralama Fonksiyonu\n  \nDeğerleri sıralamak için virgülle ayırarak girin:");
            string input = Console.ReadLine();

            string[] values = input.Split(',');

            List<string> numbers = new List<string>();
            List<string> words = new List<string>();

            foreach (string value in values)
            {
                if (int.TryParse(value.Trim(), out int num))
                {
                    numbers.Add(value.Trim());
                }
                else
                {
                    words.Add(value.Trim());
                }
            }

            numbers.Sort((a, b) => int.Parse(a).CompareTo(int.Parse(b)));

            words.Sort();

            string sortedValues = string.Join(", ", numbers.Concat(words));

            Console.WriteLine("Sıralanmış değerler: ");
            Console.WriteLine(sortedValues);

            Console.ReadLine();
        }
    }
}
