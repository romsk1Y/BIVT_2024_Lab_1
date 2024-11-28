using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;

namespace laba1
{

    class Programm
    {
        static void Main()
        {
            int pynkt = -1;
            Console.WriteLine("vvedite pynkt(cifra-nomer zadania) ");
            string s = Console.ReadLine();
            if (s != null)
                pynkt = int.Parse(s);
            double x = 0;





            switch (pynkt)
            {

                case 1:
                    int r = method1();
                    Console.WriteLine("znachenie= {0,3:d}", r);


                    break;


                case 2:
                    float f = method2();
                    Console.WriteLine("znachenie= {0,8:f}", f);


                    break;


                case 3:
                    float e = method3();
                    Console.WriteLine("znachenie= {0,3:f}", e);


                    break;

                case 4:
                    Console.WriteLine("vvedite znachenie x");
                    string l = Console.ReadLine();
                    if (l != null)
                        x = double.Parse(l);
                    double q = method4(x);
                    Console.WriteLine("znachenie= {0,3:f}", q);


                    break;

                case 5:
                    int o = 0;
                    int p = 0;
                    Console.WriteLine("vvedite pervy chlen");
                    string k = Console.ReadLine();
                    if (k != null)
                        p = int.Parse(k);
                    Console.WriteLine("vvedite raznitsy");
                    string m = Console.ReadLine();
                    if (m != null)
                        o = int.Parse(m);
                    double otv = method5(p, o);
                    Console.WriteLine("otvet- {0,3:f}", otv);

                    break;


                case 6:
                    method6();

                    break;


                case 7:
                    int fact = method7();
                    Console.WriteLine("otvet- {0,3:d}", fact);

                    break;


                case 8:
                    int b = method8();
                    Console.WriteLine("otvet- {0,3:d}", b);

                    break;


                case 9:
                    double j = method9();
                    Console.WriteLine("otvet- {0,3:f}", j);

                    break;


                case 10:
                    int qp = method10();
                    Console.WriteLine("otvet- {0,3:d}", qp);

                    break;


                case 11:
                    method11();

                    break;


                case 12:
                    Console.WriteLine("vvedite x");
                    string d = Console.ReadLine();
                    if (d != null)
                        x = double.Parse(d);

                    double summ = method12(x);
                    Console.WriteLine("otvet- {0,3:f}", summ);

                    break;


                case 13:
                    method13();

                    break;


                case 14:
                    method14();

                    break;


                case 15:
                    double chlen = method15();
                    Console.WriteLine("otvet- {0,3:f}", chlen);

                    break;

                case 16:
                    double otvet;
                    double tochnost;
                    otvet = Method16(out tochnost);
                    Console.WriteLine("otvet- {0:f} tochnost- {1:f}", otvet, tochnost);

                    break;
                case 17:
                    Method17();

                    break;
                case 18:
                    Method18();

                    break;
                case 19:
                    Method19();

                    break;
                case 20:
                    Method20();

                    break;
                case 21:
                    Method21();
                    break;
                case 22:
                    Method22();
                    break;
                default:
                    Console.WriteLine("neverny vvod");
                    break;


            }
            Console.ReadKey();

        }


        static int method1()
        {
            int sum = 2;
            int m = 2;
            while (m != 35)
            {
                m = m + 3;
                sum += m;


            }
            return sum;
        }
        static float method2()
        {
            float sum = 0;
            float m = 0;
            float ch = 0;

            do
            {
                m++;
                ch = 1 / m;
                sum += ch;

            } while (m != 10);
            return sum;
        }
        static float method3()
        {
            float sum = 0;
            float m = 0;
            float ch = 0;
            float n = 0;
            while (m != 112 && n != 113)
            {
                m += 2;
                n += 3;
                ch = m / n;
                sum += ch;

            }
            return sum;
        }
        static double method4(double x)
        {
            double ch = x;
            double sum = Math.Cos(x);
            for (int i = 2; i < 9; i++)
            {
                ch = Math.Cos(i * x) / Math.Pow(x, (i - 1));
                sum += ch;
            }
            return sum;
        }
        static double method5(int p, int f)
        {
            double sum = p;
            double ch = 0;
            for (int i = 1; i <= 9; i++)
            {
                ch = Math.Pow((p + i * f), 2);
                sum = sum + ch;
            }
            return sum;
        }
        static void method6()
        {
            double x = -4;
            double y = 0;
            while (x <= 4)
            {
                y = 0.5 * Math.Pow(x, 2) - 7 * x;
                Console.WriteLine("x={0,5:f}\ty={1,5:f}", x, y);
                x += 0.5;
            }
        }
        static int method7()
        {
            int fact = 1;
            for (int i = 1; i <= 6; i++)
            {
                fact *= i;
            }
            return fact;
        }
        static int method8()
        {
            int sum = 0;
            int ch = 1;
            for (int i = 1; i <= 6; i++)
            {
                for (int m = 1; m <= i; m++)
                {
                    ch = ch * m;
                }
                sum += ch;
                ch = 1;
            }
            return sum;
        }
        static double method9()
        {
            double sum = 0;
            double ch = 1;
            double del = 1;
            for (double i = 1; i <= 6; i++)
            {
                del = del * i;
                ch = (-ch * 5) / del;
                sum += ch;
            }
            return sum;
        }
        static int method10()
        {
            int ch = 3;
            for (int i = 1; i < 7; i++)
            {
                ch = ch * 3;
            }
            return ch;
        }
        static void method11()
        {
            for (int i = 1; i <= 6; i++)
            {
                Console.Write("{0,1:d} ", i);
            }
            Console.Write("\n");
            for (int i = 1; i <= 6; i++)
            {
                Console.Write("5 ");
            }
        }
        static double method12(double x)
        {
            double ch = 1;
            double sum = 1;
            for (int i = 1; i <= 10; i++)
            {
                ch = ch * x;
                sum += 1 / ch;
            }
            return sum;
        }
        static void method13()
        {
            double x = -1.5;
            double y = 0;
            while (x <= 1.5)
            {
                if (x <= -1)
                {
                    y = 1;
                    Console.WriteLine("x={0,3:f}  y={1,3:f}", x, y);

                }
                else if (x > 1)
                {
                    y = -1;
                    Console.WriteLine("x={0,3:f}  y={1,3:f}", x, y);


                }
                else
                {
                    y = -x;
                    Console.WriteLine("x={0,3:f}  y={1,3:f}", x, y);

                }
                x += 0.1;
            }
        }
        static void method14()
        {
            int pred = 1;
            int pred2 = 1;
            int tec;
            for (int i = 1; i <= 8; i++)
            {
                tec = pred + pred2;
                Console.WriteLine("chislo={0,4:d}", tec);
                pred2 = pred;
                pred = tec;



            }
        }
        static double method15()
        {
            double pred = 2;
            double pred2 = 1;
            double preddel = 1;
            double preddel2 = 1;
            double tec = 0;
            double c;
            double m;
            for (int i = 3; i <= 5; i++)
            {
                c = pred + pred2;
                m = preddel + preddel2;
                tec = c / m;
                pred2 = pred;
                pred = c;
                preddel2 = preddel;
                preddel = m;


            }
            return tec;
        }
        static double Method16(out double tochnost)
        {
            double sum = 0;
            double ch = 2;
            double gr = 0;
            for (int i = 2; i <= 64; i++)
            {
                ch *= 2;
            }
            sum = ch - 1;
            gr = sum / 15.0;
            tochnost = 1;
            return gr;
        }
        static void Method17()
        {
            double r = 6350;
            double rast;
            for (int i = 1; i <= 10; i++)
            {
                rast = Math.Sqrt(2 * r * i);
                Console.WriteLine("km={0:f}   \tr={1:f}", i, rast);
            }
        }
        static void Method18()
        {
            int kl = 10;
            int i = 3;
            while (i <= 24)
            {
                kl *= 2;
                Console.WriteLine("chas={0:d}   kletki={1:d}", i, kl);
                i += 3;
            }
        }
        static void Method19()
        {
            double sum = 1;
            double ch = 1;
            double x = 0.1;
            double i = 2;
            double summath = 0;
            do
            {
                ch *= (x * x / (i * (i - 1)));
                sum += ch;
                i += 2;
                if (x != 1)
                    x += 0.05;
            } while (ch >= 0.0001);
            summath = (Math.Exp(x) + Math.Exp(-x)) / 2;
            Console.WriteLine("math={0:f}          \tryad={1:f}", summath, sum);

        }
        static void Method20()
        {
            int n = 4;
            int p = 1;
            for (int i = n; ; i += 3)
            {
                if (p * i < 30000)
                    p *= i;
                else
                {
                    n = i - 3;
                    break;
                }
            }
            Console.WriteLine(n);
        }
        static void Method21()
        {
            double s = 0.0;
            double x;
            long n = 0;
            const double e = 0.0001;

            Console.Write("Введите x: ");
            x = double.Parse(Console.ReadLine());

            do
            {
                s += Math.Pow(x, 2 * n);
                n++;
            } while (s <= e);

            Console.WriteLine($"REZ: {s}");
        }
        static void Method22()
        {
            double a = 1000;
            int b = 2000;
            int c = 1;
            while (a <= b)
            {
                a *= 1.08;
                c++;
            }
            Console.WriteLine(c);
            Console.WriteLine(a);
        }

    }
        }
    

