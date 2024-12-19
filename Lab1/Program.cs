using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        Program program = new Program();

        //program.Task_1_1();
        //program.Task_1_2();
        //program.Task_1_3();
        //program.Task_1_4(0.9);
        //program.Task_1_5(0, 2);
        //program.Task_1_6(4);
        //program.Task_1_7();
        //program.Task_1_8();
        //program.Task_1_9();
        //program.Task_1_10();
        //program.Task_1_11();
        //program.Task_1_12(0.9);
        //program.Task_1_13(-1.5);
        //program.Task_1_14();
        //program.Task_1_15();
        //program.Task_1_16();
        //program.Task_1_17(10);
        //program.Task_1_18(24);
        //program.Task_2_1(0);
        //program.Task_2_2();
        //program.Task_2_3(8, 2, 0);
        //program.Task_2_4(0.8);
        //program.Task_2_5(11, 5);
        //program.Task_2_6();
        //program.Task_2_7a();
        //program.Task_2_7b();
        //program.Task_2_7c();
        //program.Task_2_8();
        //program.Task_2_9();
        //program.Task_2_10();
        //program.Task_3_1(0.1);
        //program.Task_3_2(0.1);
        //program.Task_3_3(0.1);
        //program.Task_3_4(0.1);
        //program.Task_3_5(double.Pi/5);
        //program.Task_3_6(0.1);
        //program.Task_3_7(0.1);
        //program.Task_3_8(0.1);
        //program.Task_3_9(0.1);
    }
    #region Level 1
    public int Task_1_1()
    {
        int sum = 2;
        int m = 2;
        while (m != 35)
        {
            m = m + 3;
            sum += m;

        }
        Console.WriteLine($"znachenie= {sum,3:d}");
        return sum;
    }
    public double Task_1_2()
    {
        double sum = 0;
        double m = 0;
        double ch = 0;
        do
        {
            m++;
            ch = 1 / m;
            sum += ch;

        } while (m != 10);
        Console.WriteLine("znachenie= {0:f}", sum);
        return sum;
    }
    public double Task_1_3()
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
        Console.WriteLine("znachenie= {0:f}", sum);
        return sum;
    }
    public double Task_1_4(double x)
    {
        string l = Console.ReadLine();
        double x = 0;

        if (l != null) {
            x = double.Parse(l);
        }

        double ch = x;
        double sum = Math.Cos(x);
        
        for (int i = 2; i < 10; i++) {
            ch = Math.Cos(i * x) / Math.Pow(x, (i - 1));
            sum += ch;
        }

        Console.WriteLine("znachenie= {0:f3}", sum);
        return sum;

    }
    public double Task_1_5(double p, double h)
    {
        int o = 0;
        int p = 0;

        Console.WriteLine("vvedite pervy chlen");
        string k = Console.ReadLine();
        if (!string.IsNullOrEmpty(k)) {
            p = int.Parse(k);
        } else {
            Console.WriteLine("Vvedeno nepravilnoe znachenie. Poprobyite snova.");
            return;
        }

        Console.WriteLine("vvedite raznitsy");
        string m = Console.ReadLine();
        if (!string.IsNullOrEmpty(m)) {
            o = int.Parse(m);
        } else {
            Console.WriteLine("Vvedeno nepravilnoe znachenie. Poprobyite snova.");
            return;
        }

        double sum = 0;

        for (int i = 0; i < 10; i++) {
            double ch = Math.Pow((p + i * o), 2);
            sum += ch;
        }

        Console.WriteLine("otvet- {0:f3}", sum);
        return sum;
    }
    public double Task_1_6(double x)
    {
        double x = -4;
        double y = 0;
        while(x <=4) {
            y = 0.5 * Math.Pow(x, 2) - 7 * x;
            Console.WriteLine("x={0,5:f}\ty={1,5:f}", x, y);
            x+=0.5;
        }
    public int Task_1_7()
    {
        int fact = 1;
        for(int i=1;i<=6;i++)
        {
            fact *= i;
        }
        Console.WriteLine("otvet- {0:f3}", fact);
        return fact;
    }
    public int Task_1_8()
    {
            int sum = 0;
            int ch = 1;
            for(int i = 1; i <= 6; i++)
            {
                for(int m = 1; m <= i; m++)
                {
                    ch = ch * m;
                }
                sum += ch;
                ch = 1;
            }
            Console.WriteLine("{0:f3}", sum);
            return sum;
    }
    public double Task_1_9()
    {
        double sum = 0;
        double ch = 1;
        double del = 1;
        for(double i=1; i <= 6; i++)
        {
            del= del * i;
            ch = (-ch * 5) / del;
            sum+= ch;   
        }
        Console.WriteLine("{0:f3}", sum);
        return sum;
    }
    public int Task_1_10()
    {
        int ch = 3;
        for(int i = 1; i < 7; i++)
        {
            ch = ch * 3;
        }
        Console.WriteLine("{0:f3}", ch);
        return ch;
    }
    public void Task_1_11()
    {
        for(int i = 1; i <= 6; i++)
        {
            Console.Write("{0.1:d} ", i);
        }
        Console.Write("\n");
        for (int i = 1; i <= 6; i++)
        {
            Console.Write("5");
        }
    }
    public double Task_1_12(double x)
    {
        using System;

class HelloWorld {
    static void Main() {
        double ch = 1;
        double sum = 1;
        double x = 0;
        string d = Console.ReadLine();
        if (!string.IsNullOrEmpty(d)) {
            x = double.Parse(d);
        } else {
            return;
        }

        for (int i = 1; i <= 10; i++) {
            ch = ch * x;
            sum += 1 / ch;
        }

        Console.WriteLine("{0:f3}", sum);
        return sum;
    }
}
    }
    public double Task_1_13(double x)
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
    public void Task_1_14()
    {
        int pred = 1;
        int pred2 = 1;
        int tec;
        for(int i = 1; i <= 8; i++)
        {
            tec = pred + pred2;
            Console.WriteLine("chislo={0,4:d}", tec);
            pred2 = pred;
            pred = tec;               
        }

    }
    public double Task_1_15()
    {
            double pred = 2;
            double pred2 = 1;
            double preddel = 1;
            double preddel2 = 1;
            double tec=0;
            double c;
            double m;
            for(int i = 3; i <= 5; i++)
            {
                c = pred + pred2;
                m=preddel + preddel2;
                tec = c / m;
                pred2 = pred;
                pred = c;
                preddel2 = preddel;
                preddel = m;


            }
            Console.WriteLine("{0:f3}", tec);
            return tec;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here

        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_2_2()
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_2_3(double a, double h, double p)
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public double Task_2_4(double x)
    {
        double answer = 0;

        // code here

        // end

        return answer;
    }
    public (int, int) Task_2_5(int N, int M)
    {
        int quotient = 0, remainder = 0;

        // code here

        // end

        return (quotient, remainder);
    }
    public int Task_2_6()
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public double Task_2_7a()
    {
        double answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_2_8()
    {
        int answer = 0;

        // code here;

        // end

        return answer;
    }
    public int Task_2_9()
    {
        int answer = 0;

        // code here;

        // end

        return answer;
    }
    public int Task_2_10()
    {
        int answer = 0;

        // code here;

        // end

        return answer;
    }
    #endregion

    #region Level 3
    public (double, double) Task_3_1(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_2(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_3(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_4(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_5(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_6(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_7(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_8(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_9(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    #endregion
}
