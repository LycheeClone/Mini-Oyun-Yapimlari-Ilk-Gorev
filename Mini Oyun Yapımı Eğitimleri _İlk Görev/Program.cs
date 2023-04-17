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
            //Min();
            //Max();
            //Factoriel();
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
                Console.WriteLine("\nGirdiğiniz Değerin Faktöriyeli:" + factorial + "\n" +
                    "\nYeni Bir Hesaplama Yapmak için Y, Programdan Çıkmak İçin Enter Tuşuna Basınız\n");
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (keyInfo.KeyChar == 'y' || keyInfo.KeyChar == 'Y')
                {
                    Factoriel();
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("\nGirdiğiniz Değer Pozitif Tam Sayı Olmaz Zorundadır!\n");
                Factoriel();
            }
        }

        public static void Sort()
        {
            Console.WriteLine("Sıralamak istediğiniz Değerleri Virgülle Ayırarak Giriniz\n");

            string input = Console.ReadLine();

            // Sayıları ve kelimeleri virgüllerden ayırarak diziye aktarır
            string[] values = input.Split(',');
            int[] numbers = new int[values.Length];
            string[] words = new string[values.Length];
            int numCount = 0;
            int wordCount = 0;

            foreach (string value in values)
            {
                int num;
                bool isNumber = int.TryParse(value.Trim(), out num);

                if (isNumber)
                {
                    numbers[numCount++] = num;
                }
                else
                {
                    words[wordCount++] = value.Trim();
                }
            }

            // Kelimeleri sıralar
            Array.Sort(words);

            // Sayıları sıralar
            Array.Sort(numbers);

            // Sıralanmış sayıları ve kelimeleri birleştirir
            string[] sortedValues = new string[numbers.Length + words.Length];
            int i = 0;
            for (; i < numbers.Length; i++)
            {
                sortedValues[i] = numbers[i].ToString();
            }
            for (int j = 0; j < words.Length; j++)
            {
                sortedValues[i++] = words[j];
            }

            // Sıralanmış sayıları ve kelimeleri ekrana yazdırır
            Console.WriteLine("Sıralanmış değerler: ");
            foreach (string value in sortedValues)
            {
                Console.Write("{0} ", value);
            }
            Console.ReadLine();

            //string input = Console.ReadLine();

            //// Sayıları ve kelimeleri virgüllerden ayırarak listeye aktarır
            //List<string> values = input.Split(',').ToList();

            //// Sayıları ve kelimeleri ayrı ayrı sıralar
            //List<string> numbers = values.Where(n => int.TryParse(n.Trim(), out int num)).OrderBy(n => int.Parse(n.Trim())).ToList();
            //List<string> words = values.Where(n => !int.TryParse(n.Trim(), out int num)).OrderBy(n => n.Trim()).ToList();

            //// Sayıları ve kelimeleri birleştirir
            //string sortedValues = string.Join(", ", numbers.Concat(words));

            //// Sıralanmış sayıları ve kelimeleri ekrana yazdırır
            //Console.WriteLine("Sıralanmış değerler: ");
            //Console.WriteLine(sortedValues);
            //Console.ReadLine();


            //string input = Console.ReadLine();

            //// Sayıları ve kelimeleri virgüllerden ayırarak diziye aktarır
            //string[] values = input.Split(',');
            //int[] numbers = new int[values.Length];
            //string[] words = new string[values.Length];
            //int numCount = 0;
            //int wordCount = 0;

            //foreach (string value in values)
            //{
            //    int num;
            //    bool isNumber = int.TryParse(value.Trim(), out num);

            //    if (isNumber)
            //    {
            //        numbers[numCount++] = num;
            //    }
            //    else
            //    {
            //        words[wordCount++] = value.Trim();
            //    }
            //}

            //// Sayıları ve kelimeleri ayrı ayrı sıralar
            //Array.Sort(numbers);
            //Array.Sort(words);

            //// Sayıları ve kelimeleri birleştirir
            //string[] sortedValues = new string[numbers.Length + words.Length];
            //int i = 0;
            //for (; i < numbers.Length; i++)
            //{
            //    sortedValues[i] = numbers[i].ToString();
            //}
            //for (int j = 0; j < words.Length; j++)
            //{
            //    sortedValues[i++] = words[j];
            //}

            //// Sıralanmış sayıları ve kelimeleri ekrana yazdırır
            //Console.WriteLine("Sıralanmış değerler: ");
            //foreach (string value in sortedValues)
            //{
            //    Console.Write("{0} ", value);
            //}
            //Console.ReadLine();


            //string input = Console.ReadLine();
            //string[] numberStrings = input.Split(',');
            //int[] numbers = new int[numberStrings.Length];
            //for (int i = 0; i < numberStrings.Length; i++)
            //{
            //    numbers[i] = int.Parse(numberStrings[i]);
            //}

            //Array.Sort(numbers);

            //Console.WriteLine("\nSıralanmış sayılar: ");
            //foreach (int number in numbers)
            //{
            //    Console.Write("{0} ", number);
            //}
            //Console.ReadLine();
        }
    }
}
