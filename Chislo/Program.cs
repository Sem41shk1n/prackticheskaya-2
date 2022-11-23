// See https://aka.ms/new-console-template for more information
namespace _3_in_1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("1:угадай число");
            Console.WriteLine("2:Таблица умножения");
            int a = int.Parse(Console.ReadLine());

            if (a == 1)
            {
                Console.WriteLine("угадай число");
                kpp();
            }
            if (a == 2)
            {
                Console.WriteLine("таблица умножения ");
                bb();
            }

            if (a == 3)
            {
                Console.WriteLine("вывод делителя числа");
                gg();
            }
            static void kpp()
            {


                Random end = new Random();


                int c = end.Next(0, 100);
                int i = c;
                int a;
                do
                {
                    Console.WriteLine("Введи чиcло");
                    a = int.Parse(Console.ReadLine());
                    if (i != a)
                    {
                        if (i > a)
                        {
                            Console.WriteLine("Возьми побольше");


                        }
                        if (i < a)
                        {
                            Console.WriteLine("Возьми поменьше");

                        }



                    }
                    else
                    {
                        Console.WriteLine("Молодец, нашел");
                    }
                }
                while (a != c);


            }


            static void bb()
            {
                Console.WriteLine("Таблица умножения: ");

                while (true)
                {
                    int[,] q = new int[9, 9]
                    {
                        {1,2,3,4,5,6,7,8,9},
                        {2,4,6,8,10,12,14,16,18},
                        {3,6,9,12,15,18,21,24,27},
                        {4,8,12,16,20,24,28,32,36},
                        {5,10,15,20,25,30,35,40,45},
                        {6,12,18,24,30,36,42,48,54},
                        {7,14,21,28,35,42,49,56,63},
                        {8,16,24,32,40,48,56,64,72},
                        {9,18,27,36,45,54,64,72,81}
                    };
                    for (int m = 0; m < q.GetLength(0); m++)
                    {
                        for (int n = 0; n < q.GetLength(1); n++)
                        {
                            if (q[m, n] < 10)
                            {
                                Console.Write(q[m, n] + "    ");
                            }
                            else
                            {
                                Console.Write(q[m, n] + "   ");
                            }
                        }
                        Console.WriteLine();
                    }
                    Thread.Sleep(5000);
                    break;
                }
            }
        }



        static void gg()
        {



        }
    }
}