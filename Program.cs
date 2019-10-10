using System;
using System.Text;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //---- Локальная функция ----------
            (int max, int min, int sym, char Al) Func(int[] mss, string StRR)
            {
                var tuplee = (max: mss[0], min: mss[0], sym: 0, Al: ' ');
                for (int l = 0; l < mss.Length; l++)
                {
                    if (mss[l] > tuplee.max)
                    {
                        tuplee.max = mss[l];
                    }
                    if (mss[l] < tuplee.min)
                    {
                        tuplee.min = mss[l];
                    }
                    tuplee.sym += mss[l];

                }
                for (int h = 0; h < StRR.Length; h++)
                {
                    if (StRR[h] != ' ')
                    {
                        tuplee.Al = StRR[h];
                        break;
                    }

                }
                return tuplee;
            }
            //------------------------
            sbyte sbyteA = -1;
            short shortA = -2;
            int intA = -3;
            long longA = -4;
            byte byteA = 1;
            ushort ushortA = 2;
            uint uintA = 3;
            ulong ulongA = 4;
            char с = 'А';
            float f = 6.5f;
            double d = 3.5;
            decimal D = 9.1M;
            bool b = true;
            //------------------------
            int B = 200;
            // Явное преобразование
            double BBB = B;   // int в double
            double AAA = f;   // float в double
            float CCC = B; // int в float
            long DDD = B; // int в long
            int FFF = shortA; // short в int
            // Неявное преобразование
            int AA = (int)d;   // double в int
            byte BB = (byte)B;   // int в byte
            double CC = (double)B;  // int в double
            decimal DD = (decimal)d; // double в decimal
            decimal FF = (decimal)B; // int в decimal
            //-------------------------
            int x1 = 5;
            Object o = x1;   // boxing
            int x2 = (int)o;   // unboxing
            //-------------------------
            var R1 = 5;
            Console.WriteLine(R1.GetType());
            var R2 = 10.567;
            Console.WriteLine(R2.GetType());
            //-------------------------
            int ? N1 = null;
            int? N2 = null;
            Console.WriteLine(N1 == N2);
            //-------------------------
            string s1 = "Auf";
            string s2 = "auf";
            string s3 = "Auf";
            Console.WriteLine(s1 == s2);
            Console.WriteLine(s1 == s3);
            //-------------------------
            string S = "Я";
            string SS = " хочу";
            string SSS = " спать";
            string S_S = S + SS + SSS; // Сцепление (конкатенация)
            Console.WriteLine("\nСцепление строк: " + S_S);
            string copy = string.Copy(S_S); // Копирование
            Console.WriteLine("Копирование строки: " + copy);
            Console.WriteLine("Выделение подстроки: " + S_S.Substring(3, 3)); // Выделение подстроки
            string[] words = S_S.Split(' ');   //Разделение строки на слова
            Console.Write("Разделения строки на слова:\n");
            for (int j = 0; j < words.Length; j++)
            {
                Console.WriteLine(words[j]);
            }
            Console.WriteLine("Вставка подстроки: " + S_S.Insert(6, " СДАТЬ ЛАБУ ПО ООП и немножко"));   //вставка подстроки в заданную позицию
            Console.WriteLine("Удаление подстроки: " + S_S.Remove(2, 5)); //Удаление подстроки
            //--------------------------
            string Str0 = "";
            string StrNull = null;
            Console.WriteLine(Str0.Length);
            Console.WriteLine(Str0 == StrNull);
            //--------------------------
            StringBuilder st = new StringBuilder("мне нравится", 50);
            Console.WriteLine("\n" + st);
            Console.WriteLine(st.Remove(0, 1));
            Console.WriteLine(st.Append("?"));
            Console.WriteLine(st.Insert(0, "что тебе уже "));
            //--------------------------
            int[,] matriza = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("\nДвумерный массив:\n");
            foreach (var i in matriza)
            {
                if (i % 3 == 0)
                { Console.Write("\t" + i + "\n"); }
                else
                { Console.Write("\t" + i); }
            }
            //-------------------------
            string[] mas =
            {"джована",
            "моя царица ритмов капуэйра",
            "ты моя бум бум бейба",
            "девочка мулатка шоколадка с пляжей Рио-де-Жанейро",
            "о моя бум бум бейба"};
            Console.WriteLine("\nОдномерный массив:\n");
            foreach (var j in mas)
            {
                Console.Write("\t" + j + "\n");
            }
            Console.WriteLine("\nРазмер массива: " + mas.Length);
            mas[2] = "...";
            Console.WriteLine("\nИзмененный массив:\n");
            foreach (var j in mas)
            {
                Console.Write("\t" + j + "\n");
            }
            //-------------------------
            double[][] StupenchMas = { new double[2], new double[3], new double[4] };
            Console.WriteLine();
            for (int k = 0; k < StupenchMas.Length; k++)
            {
                for (int m = 0; m < StupenchMas[k].Length; m++)
                {
                    Console.Write("Введите " + (m + 1) + "-e число " + (k + 1) + "-й строки: ");
                    StupenchMas[k][m] = Convert.ToDouble(Console.ReadLine());
                }
            }
            Console.WriteLine("\nCтупенчатый массив:\n");
            foreach (double[] x in StupenchMas)
            {
                foreach (double h in x)
                    Console.Write("\t" + h);
                Console.WriteLine();
            }
            //-------------------------
            var tMas = new object[0];
            var tStr = "";
            //-------------------------
            (int, string, char, string, ulong) tuple1 = (9, "alina", '!', "pimenova", 22222222);
            (int, string, char, string, ulong) tuple2 = (9, "alina", '!', "pimenova", 22222222);
            Console.WriteLine(tuple1);
            Console.WriteLine(tuple1.Item2);
            Console.WriteLine(tuple1.Item4);
            var (t1, t2, t3, t4, t5) = tuple1;//распаковка кортежа в переменные?
            //---------------------------------------
            int[] ms = { 1, -2, 3, -4, 5, -6, 7 };
            string StR = "оооо";
            foreach (double a in ms)
                Console.Write("\t" + a);
            Console.WriteLine();
            Console.WriteLine(StR);
            var tuple = Func(ms, StR);
            Console.WriteLine(tuple);
            Console.Read();
        }
    }
}
