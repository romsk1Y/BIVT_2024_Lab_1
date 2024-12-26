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

    return sum;
}

    public double Task_1_3()
{
    double sum = 0;
    double m = 0;
    double n = 0;

    while (m != 112 && n != 113)
    {
        m += 2;
        n += 3;
        double ch = m / n;
        sum += ch;
    }

    return sum;
}

    public double Task_1_4(double x)
{
    double ch = x;
    double sum = Math.Cos(x);

    for (int i = 2; i < 10; i++) {
        ch = Math.Cos(i * x) / Math.Pow(x, (i - 1));
        sum += ch;
    }

    return sum;
}

    public double Task_1_5(double p, double h)
{
    double sum = 0;

    for (int i = 0; i < 10; i++)
    {
        double ch = Math.Pow((p + i * h), 2);
        sum += ch;
    }

    return sum;
}

    public double Task_1_6(double x)
    {
        double y = 0;
        while(x <=4) {
            y = 0.5 * Math.Pow(x, 2) - 7 * x;
            x+=0.5;
        }
        return x;
    }
    public int Task_1_7()
{
    int fact = 1;
    for (int i = 1; i <= 6; i++)
    {
        fact *= i;
    }

    return fact;
}

    public int Task_1_8()
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
        return sum;
    }
    public int Task_1_10()
    {
        int ch = 3;
        for(int i = 1; i < 7; i++)
        {
            ch = ch * 3;
        }
        return ch;
    }
    public void Task_1_11()
    {
        int a = 0;
        for(int i = 1; i <= 6; i++)
        {
            a++;
        }
        for (int i = 1; i <= 6; i++)
        {
            a++;
        }
    }
    public double Task_1_12(double x)
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

    public double Task_1_13(double x)
{
    double y = 0;
    
    if (x <= -1)
    {
        y = 1;
    }
    else if (x > 1)
    {
        y = -1;
    }
    else
    {
        y = -x;
    }

    return y;
}
    
    public int Task_1_14()
{
    int pred = 1;
    int pred2 = 1;
    int tec;
    int result = 0;

    for (int i = 1; i <= 8; i++)
    {
        tec = pred + pred2;
        result = tec;
        pred2 = pred;
        pred = tec;
    }

    return result;
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
            return tec;
    }
    unsafe static double Method16(double* tochnost)
{
    double sum = 0;
    double ch = 1;
    double gr = 0;

    for (int i = 0; i < 64; i++)
    {
        sum += ch;
        ch *= 2;
    }

    gr = sum / 15.0;
    *tochnost = 1;

    return gr;
}

    static double Method17(double x)
{
    double r = 6350;
    double rast = Math.Sqrt(2 * r * x);
    return rast;
}

    public int Task_1_18(int x)
{
    int kl = 10;
    for (int i = 3; i <= x; i += 3)
    {
        kl *= 2;
    }
    return kl;
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
    int n = 4;
    int p = 1;
    int L = 30000;

    for (int i = n; p * i <= L; i += 3)
    {
        p *= i;
        n = i;
    }

    return n;
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
    double s = 0.0;
    double term;
    long n = 0;
    const double e = 0.0001;

    do
    {
        term = Math.Pow(x, 2 * n);
        s += term;
        n++;
    } while (Math.Abs(term) >= e);

    return s;
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
    int cells = 10;
    int targetCells = 105;
    int hours = 0;

    while (cells < targetCells)
    {
        cells *= 2;
        hours += 3;
    }

    return hours;
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
    double a = 10000;
    double b = a * 2;
    int c = 0;

    while (a < b)
    {
        a *= 1.08;
        c++;
    }

    return c;
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
    double num1 = 1, den1 = 1; 
    double num2 = 2, den2 = 1;
    double diff = 0.001;
    int n = 2;

    while (true)
    {
        double num3 = num1 + num2;
        double den3 = den1 + den2;

        if (Math.Abs((num3 / den3) - (num2 / den2)) <= diff)
        {
            break;
        }
        num1 = num2;
        den1 = den2;
        num2 = num3;
        den2 = den3;
        
        n++;
    }

    return n;
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
    double sum = 1;
    double ch = 1;
    double i = 2;
    double summath = 0;

    do
    {
        ch *= (x * x) / (i * (i - 1));
        sum += ch;
        i += 2;
    } while (Math.Abs(ch) >= 0.0001);

    summath = (Math.Exp(x) + Math.Exp(-x)) / 2;

    return (sum, summath);
}

    public (double, double) Task_3_8(double x)
{
    double a = 0;
    double b = 1;
    double h = 0.05;
    int n = (int)((b - a) / h);

    double S = (h / 2) * (f(a) + f(b));
    for (int i = 1; i < n; i++)
    {
        double xi = a + i * h;
        S += f(xi);
    }
    S *= h;

    double y = Math.Exp(2 * x);

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
