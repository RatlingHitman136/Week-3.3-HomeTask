using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3._3_HT
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        void Case18()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            switch(a/100)
            {
                case 1:
                    Console.WriteLine("Сто ");
                    break;
                case 2:
                    Console.WriteLine("Двести ");
                    break;
                case 3:
                    Console.WriteLine("Триста ");
                    break;
                case 4:
                    Console.WriteLine("Четыреста ");
                    break;
                case 5:
                    Console.WriteLine("Пятьсот ");
                    break;
                case 6:
                    Console.WriteLine("Шестьсот ");
                    break;
                case 7:
                    Console.WriteLine("Семьсот ");
                    break;
                case 8:
                    Console.WriteLine("Восемьсот ");
                    break;
                case 9:
                    Console.WriteLine("Девятьсот ");
                    break;
            }
            switch((a/10)%10)
            {
                case 1:
                    switch (a % 10)
                    {
                        case 0:
                            Console.WriteLine("десять");
                            break;
                        case 1:
                            Console.WriteLine("одинадцать");
                            break;
                        case 2:
                            Console.WriteLine("двенадцать");
                            break;
                        case 3:
                            Console.WriteLine("тринадцать");
                            break;
                        case 4:
                            Console.WriteLine("четырнадцать");
                            break;
                        case 5:
                            Console.WriteLine("пятнадцать");
                            break;
                        case 6:
                            Console.WriteLine("шестнадцать");
                            break;
                        case 7:
                            Console.WriteLine("семнадцать");
                            break;
                        case 8:
                            Console.WriteLine("восемнадцать");
                            break;
                        case 9:
                            Console.WriteLine("девятнадцать");
                            break;
                    }
                    return;
                case 2:
                    Console.WriteLine("двадцать ");
                    break;
                case 3:
                    Console.WriteLine("тридцать ");
                    break;
                case 4:
                    Console.WriteLine("сорок ");
                    break;
                case 5:
                    Console.WriteLine("пятьдесят ");
                    break;
                case 6:
                    Console.WriteLine("шестьдесят ");
                    break;
                case 7:
                    Console.WriteLine("семьдесят ");
                    break;
                case 8:
                    Console.WriteLine("восемьдесят ");
                    break;
                case 9:
                    Console.WriteLine("девяносто ");
                    break;
            }
            switch(a%10)
            {
                case 1:
                    Console.WriteLine("один");
                    break;
                case 2:
                    Console.WriteLine("два");
                    break;
                case 3:
                    Console.WriteLine("три");
                    break;
                case 4:
                    Console.WriteLine("четыре");
                    break;
                case 5:
                    Console.WriteLine("пять");
                    break;
                case 6:
                    Console.WriteLine("шесть");
                    break;
                case 7:
                    Console.WriteLine("семь");
                    break;
                case 8:
                    Console.WriteLine("восемь");
                    break;
                case 9:
                    Console.WriteLine("девять");
                    break;
            }
        }

        void Case20()
        {
            int D = Convert.ToInt32(Console.ReadLine());
            int M = Convert.ToInt32(Console.ReadLine());
            switch(M)
            {
                case 1:
                    if (D < 20) Console.WriteLine("«Козерог»");
                    else Console.WriteLine("«Водолей»");
                    break;
                case 2:
                    if (D < 19) Console.WriteLine("«Водолей»");
                    else Console.WriteLine("«Рыбы»");
                    break;
                case 3:
                    if (D < 21) Console.WriteLine("«Рыбы»");
                    else Console.WriteLine("«Овен»");
                    break;
                case 4:
                    if (D < 20) Console.WriteLine("«Овен»");
                    else Console.WriteLine("«Телец»");
                    break;
                case 5:
                    if (D < 21) Console.WriteLine("«Телец»");
                    else Console.WriteLine("«Близнецы»");
                    break;
                case 6:
                    if (D < 22) Console.WriteLine("«Близнецы»");
                    else Console.WriteLine("«Рак»");
                    break;
                case 7:
                    if (D < 23) Console.WriteLine("«Рак»");
                    else Console.WriteLine("«Лев»");
                    break;
                case 8:
                    if (D < 23) Console.WriteLine("«Лев»");
                    else Console.WriteLine("«Дева»");
                    break;
                case 9:
                    if (D < 23) Console.WriteLine("«Дева»");
                    else Console.WriteLine("«Весы»");
                    break;
                case 10:
                    if (D < 23) Console.WriteLine("«Весы»");
                    else Console.WriteLine("«Скорпион»");
                    break;
                case 11:
                    if (D < 23) Console.WriteLine("«Скорпион»");
                    else Console.WriteLine("«Стрелец»");
                    break;
                case 12:
                    if (D < 22) Console.WriteLine("«Стрелец»");
                    else Console.WriteLine("«Козерог»");
                    break;
            }
        }

        void For1()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int K = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < K; i++) Console.WriteLine(N);
        }
        void For4()
        {
            double N = Convert.ToDouble(Console.ReadLine());
            for (int i = 1; i <= 10; i++) Console.WriteLine(N*i);
        }
        void For7()
        {
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = A; i <= B; i++) sum += i;
            Console.WriteLine(sum);
        }
        void For10()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= N; i++) sum += 1 / (double)i;
            Console.WriteLine(sum);
        }
        void For13()//думаю тут в задаче шаг 0.1 
        {
            int N = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            int flag = 1;
            for (int i = 0; i < N; i++,flag*=-1)
            {
                sum += flag*(1 + (i + 1) * 0.1);
            }
            Console.WriteLine(sum);
        }
        void For16()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            double A = Convert.ToDouble(Console.ReadLine());
            double ans = 1;
            for (int i = 0; i < N; i++)
            {
                ans *= A;
                Console.WriteLine(ans);
            }
        }
        void For19()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            double ans = 1;
            for (int i = 1; i <= N; i++)
            {
                ans *= i;

            }
            Console.WriteLine(ans);
            // также можно рекурсией
        }
        void For22()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            double X = Convert.ToDouble(Console.ReadLine());
            double Xpow = 1;
            double fac = 1;
            double ans = 1;
            for (int i = 1; i <= N; i++)
            {
                Xpow *= X;
                fac *= i;
                ans += Xpow / fac;
            }
            Console.WriteLine(ans);
        }
        void For25()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            double X = Convert.ToDouble(Console.ReadLine());
            double Xpow = 1;
            double isMinus = 1;
            double ans = 0;
            for (int i = 1; i <= N; i++)
            {
                Xpow *= X;
                ans += (Xpow / (double)i) * isMinus;
                isMinus *= -1;
            }
            Console.WriteLine(ans);
        }
        void For28()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            double X = Convert.ToDouble(Console.ReadLine());
            double Xpow = 1;
            double isMinus = 1;
            int evenMul = 1;
            int oddMul = 1;
            double ans = 1;
            for (int i = 1; i <= N; i++)
            {
                Xpow *= X;
                evenMul *= (2 * i);
                ans += isMinus * oddMul * Xpow / evenMul;
                oddMul *= 2 * (i + 1) - 3;
            }
            Console.WriteLine(ans);
        }
        void For31()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            double ans = 2;
            for (int i = 1; i <= N; i++)
            {
                ans = 2 + 1 / ans;
                Console.WriteLine(ans);
            }
        }
        void For34()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            double Cur, Prev = 2, PrevPrev = 1;
            Console.WriteLine(PrevPrev);
            Console.WriteLine(Prev);
            for (int i = 3; i <= N; i++)
            {
                Cur = (PrevPrev + 2 * Prev) / 3.0;
                PrevPrev = Prev;
                Prev = Cur;
                Console.WriteLine(Cur);
            }
        }
        void For37()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= N; i++)
            {
                double partSum = 1;
                for (int j = 0; j < i; j++)
                {
                    partSum *= i;
                }
                sum += partSum;
            }
            Console.WriteLine(sum);
        }
        void For40()
        {
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= B-A; i++)
            {
                for (int j = 0; j <= i; j++)
                    Console.WriteLine(A+i);
            }
            
        }

        void While3()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int K = Convert.ToInt32(Console.ReadLine());
            int full = 0, part;
            while (N > K)
            {
                full++;
                N -= K;
            }
            part = N;
            Console.WriteLine("{0}, {1}", full, part);
        }
        void While6()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            double ans = 1;
            while (N > 2)
            {
                ans *= N;
                N -= 2;
            }
            ans *= N;
            Console.WriteLine(ans);
        }
        void While9()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int K = 0;
            double ans = 1;
            while (N > ans)
            {
                ans *= 3;
                K++;
            }
            Console.WriteLine(K);
        }
        void While12()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int K = 1;
            double ans = 0;
            while (N >= ans)
            {
                ans += K;
                K++;
            }
            Console.WriteLine(K-1);
        }
        void While15()
        {
            double P = Convert.ToDouble(Console.ReadLine())/100.0+1;
            int k = 0;
            double ans = 1000;
            while (1100 > ans)
            {
                ans *= P;
                k++;
            }
            Console.WriteLine(k);
        }
        void While18()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int ans = 0;
            while (N < 0)
            {
                ans += N % 10;
                N /= 10;
            }
            Console.WriteLine(ans);
        }
        void While21()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            while (N < 0)
            {
                if ((N % 10) % 2 == 1)
                {
                    Console.WriteLine(true);
                    return;
                }
                N /= 10;
            }
            Console.WriteLine(false);
        }
        void While24()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int P_cur = 1, P_prevprev = 1, P_prev = 1;
            while (N < P_cur)
            {
                if (N== P_cur)
                {
                    Console.WriteLine(true);
                    return;
                }
                P_cur = P_prevprev + P_prev;
                P_prevprev = P_prev;
                P_prev = P_cur;
            }
            Console.WriteLine(false);
        }
        void While27()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int P_cur = 1, P_prevprev = 1, P_prev = 1;
            int K = 2;
            while (N != P_cur)
            {
                P_cur = P_prevprev + P_prev;
                K++;
                P_prevprev = P_prev;
                P_prev = P_cur;
            }
            Console.WriteLine(K);
        }
        void While30()
        {
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int BcanChange = B;
            int C = Convert.ToInt32(Console.ReadLine());
            int ans = 0;
            while (A > C)
            {
                while (BcanChange > C)
                {
                    ans++;
                    BcanChange -= C;
                }
                A -= C;
                BcanChange = B;
            }
            Console.WriteLine(ans);
        }
    }
}
