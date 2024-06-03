using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics;
using Practice;


namespace Practice
{

    internal static class Program
    {
        
        public class Variants
        {
            public static double ans1A;
            public static double ans1B;
            public static double ans2A;
            public static double ans2B;
            public static double ans4A;
            public static double ans4B;
            public static double ans4C;
            public static double ans5;
            public static double ans6;
            public static double ans7;
            public static double ans8;
            public static double ans9;
            public static string ans10A;
            public static string ans10B;
            public static string ans11;
            public static string ans12;
            public static string ans13;
            public static string ans14;
            public static string ans15A;
            public static string ans15B;
            public static string ans15C;
            public static string ans16;
            public static string ans17;
            public static string ans18;
            public static string task1()
            {
                int n = new Random().Next(9,13);
                int k = new Random().Next(5,9);
                ans1A = Solution.solution1A(n, k);
                ans1B = Solution.solution1B(n, k);
                return $"1. {n} вариантов контрольной работы по математике распределяются случайным образом среди {k} студентов, сидящих в одном ряду. Каждый получает по одному варианту. Найти вероятность того, что:\n" +
                    "a) варианты 1'й и 2'й достанутся первым двум студентам;\n" +
                    "б) первые " + 3 + " вариантов распределятся последовательно.\n";
            }
            public static string task2() //--b
            {
                int k=new Random().Next(3,8);
                ans2A= Solution.solution2A(k);
                ans2B = Solution.solution2B(k);
                return $"2. В розыгрыше кубка по футболу участвуют 16 команд, среди которых {k} команд первой лиги. Все команды по жребию делятся на две группы по 8 команд. Найти вероятность того, что: \n" +
                    "a) все команды первой лиги попадут в одну группу;\n" +
                    "б) в одну группу попадут хотя бы две команды первой лиги.\n";
            }
            public static string task3() //--
            {
                return "3. Электронная схема содержит три транзистора, четыре конденсатора и пять резисторов. Событие Tk — выход из строя k-го транзистора (k = 1, 2, 3), событие Сi — выход из строя i-го конденсатора (i = 1, 2, 3, 4), Rj — выход из строя" +
                    " j-го резистора (j = 1, 2, 3, 4, 5). Электронная схема считается исправной, если одновременно исправны все транзисторы, не менее двух конденсаторов и хотя бы один резистор. Записать в алгебре событий событие А: схема исправна\n";
            }
            public static string task4()
            {
                Random r = new Random();
                double p1 = Math.Round(r.NextDouble(),1) ;
                double p2 = Math.Round(r.NextDouble(), 1);
                if (p1 == 0) p1 = 0.1;
                if (p2 == 0) p2 = 0.1;
                ans4A = Solution.solution4A(p1,p2);
                ans4B = Solution.solution4B(p1,p2);
                ans4C=Solution.solution4C(p1,p2);
                return $"4. Два рыбака ловят рыбу на озере. Вероятность поймать на удочку карася для первого равна {p1}, для второго — {p2}. Какова вероятность того, что: \n" +
                    "а) они поймают хотя бы одного карася;\n" +
                    "б) вообще не поймают карасей;\n" +
                    "в) поймает карася только первый рыбак?\n";
            }
            public static string task5()
            {
                Random r = new Random();
                double p1 = Math.Round(r.NextDouble(), 1);
                double p2 = Math.Round(r.NextDouble(), 1);
                if (p1 == 0) p1 = 0.1;
                if (p2 == 0) p2 = 0.1;
                ans5 = Solution.solution5(p1,p2);
                return $"5. Барон вызвал графа на дуэль. В пистолетах у дуэлянтов по два патрона. Вероятность попадания в своего противника для барона (он и начинает дуэль) равна {p1}, для графа — {p2}. Найти вероятность того, " +
                    "что барон останется невредимым, если дуэль продолжается либо до первого попадания в кого-либо из противников, либо до тех пор, пока не закончатся все патроны.\n";
            }
            public static string task6()
            {
                Random r = new Random();
                int n = r.Next(16,21); 
                int k = r.Next(8, 13);
                int m = r.Next(3, 7);
                ans6=Solution.solution6(n,k,m);
                return $"6. В корзине {n} шаров, среди которых {k} оранжевых. Из нее поочередно извлекаются {m} шаров. Найти вероятность того, что все вынутые шары оранжевые. \n";
            }
            public static string task7()
            {
                Random r = new Random();
                double p1 = Math.Round(r.NextDouble(), 1);
                double p2 = Math.Round(r.NextDouble(), 1);
                double p3 = Math.Round(r.NextDouble(), 1);
                if (p1 == 0) p1 = 0.1;
                if (p2 == 0) p2 = 0.1;
                if (p3 == 0) p3 = 0.1;
                ans7 = Solution.solution7(p1,p2,p3);
                return $"7. В диагностическом центре прием больных ведут три невропатолога: Фридман, Гудман и Шерман, которые ставят правильный диагноз с вероятностью {p1}, {p2} и {p3} соответственно." +
                    " Какова вероятность того, что больному Сидорову будет поставлен неверный диагноз, если он выбирает врача случайным образом?\n";
            }
            public static string task8()
            {
                Random r = new Random();
                double p1 = Math.Round(r.NextDouble(), 1);
                double p2 = Math.Round(r.NextDouble(), 1);
                double p3 = Math.Round(r.NextDouble(), 1);
                if (p1 == 0) p1 = 0.1;
                if (p2 == 0) p2 = 0.1;
                if (p3 == 0) p3 = 0.1;
                ans8 = Solution.solution8(p1, p2, p3);
                return $"8. Учитель литературы предложил викторину по распознаванию портретов великих людей. Школьникам были показаны репродукции картин Ильи Репина: шесть портретов " +
                    "русских музыкантов (Глинки, Мусоргского, Бородина, Глазунова, Лядова, Римского-Корсакова), десять портретов русских писателей (Гоголя, Тургенева, Льва Толстого, Писемского, Гаршина, Фета, " +
                    "Стасова, Горького, Леонида Андреева, Короленко) и пять портретов русских ученых (Сеченова, Менделеева, Павлова, Тарханова, Бехтерева). Подготовка учеников такова, что портреты " +
                    $"музыкантов они узнают с вероятностью {p1}, писателей — {p2}, ученых — {p3}. Школьница Даша правильно распознала портрет, выбранный наугад. Какова вероятность того, что ей попался портрет музыканта?\n";
            }
            public static string task9()
            {
                Random r = new Random();
                int n = r.Next(3, 6);
                double p = Math.Round(r.NextDouble(), 1);
                if (p==0) p = 0.1;
                p *= 0.1;
                ans9 = Solution.solution9(p,n);
                return $"9. В поезде {n} электрических лампочек. Каждая из них перегорает в течение года с вероятностью {p}. Найти вероятность того, что в течение года перегорит не менее 2 лампочек.\n";
            }
            public static string task10()
            {
                Random r = new Random();
                double p = Math.Round(r.NextDouble(), 2);
                if (p == 0) p = 0.1;
                int n = r.Next(5, 9);
                n *= 10;
                ans10A = Solution.solution10A(p,n);
                ans10B = Solution.solution10B(p, n);
                return $"10. Вероятность рождения мальчика равна {p}. Чему равна вероятность того, что среди {n} новорожденных: \n" +
                    "а) мальчиков ровно половина;\n" +
                    "б) не менее половины мальчиков?\n";
            }
            public static string task11()
            {
                Random r = new Random();
                int p = r.Next(2, 11); // percent
                int n = r.Next(5, 11);
                n = n * 10; // sverla
                int k2 = r.Next(3, 10); // nekach
                ans11 = Solution.solution11(p,n,k2);
                return $"11. Некачественные сверла составляют {p}% всей продукции фабрики. Изготовленные сверла упаковываются в ящики по {n} штук. Какова вероятность того, что в ящике окажется не более {k2} некачественных сверл?\n";
            }
            public static string task12()
            {
                ans12 = Solution.solution12();
                return "12. Имеется пять ключей, из которых только один подходит к замку. Составить ряд распределения числа подбора ключа к замку, " +
                    "если не подошедший ключ в последующих опробованиях не участвует. Найти М(Х), D(X), (X), F(X) этой случайной величины. Построить график F(X).\n";
            }
            public static string task13()
            {
                Random r = new Random();
                int n = r.Next(3,7);
                double p = Math.Round(r.NextDouble(), 1);
                if (p == 0) p = 0.1;
                ans13 = Solution.solution13(n,p);
                return $"13. Вероятность приема сигнала равна {p}. Сигнал передается {n} раз. Составить ряд распределения числа передач, в которых сигнал будет принят. Найти M(X) и D(X) этой случайной величины.\n";
            }
            public static string task14()
            {
                Random r = new Random();
                int n = r.Next(8, 12);
                n *= 100;
                double p = Math.Round(r.NextDouble(), 1);
                if (p == 0) p = 0.1;
                p /= 10;
                ans14 = Solution.solution14(n, p);
                return $"14. Прядильщица обслуживает {n} веретен. Вероятность обрыва нити на одном веретене в течение одной минуты равна {p}. Составить ряд распределения числа обрывов нити в течение одной минуты. " +
                    "Найти M(X) этой случайной величины.\n";
            }
            public static string task15() //-----
            {
                ans15A = Solution.solution15A();
                ans15B = Solution.solution15B();
                ans15C = Solution.solution15C();
                return "15. Независимые случайные величины X и Y заданы таблицами распределений. Найти:\n" +
                    "а) M(X), M(Y), D(X), D(Y);\n" +
                    "б) таблицы распределения случайных величин Z1 = 2X + Y, Z2 = X * Y;\n" +
                    "а) M(Z1 ), M(Z2 ), D(Z1 ), D(Z2 ) непосредственно по таблицам распределений и на основании свойств математического ожидания и дисперсии.\n" +
                    "Ряд распределения X x={-4,1,2}; P={0.1, 0.6, 0.3} соответсвенно\n" +
                    "Ряд распределения Y y={-1,3}; P={0.8, 0.2} соответсвенно\n";
            }
            
            public static string task16()
            {
                ans16 = Solution.solution16();
                return "16. Отклонение длины L изготавливаемых деталей от стандарта есть случайная величина, распределенная по нормальному закону (m = 0,  σ = 0,4 см). " +
                    "Если стандартная длина детали равна 40 см, то в каком диапазоне окажутся длины деталей с вероятностью 0,8?\n";
            }
            public static string task17()
            {
                return "17. Случайная величина X распределена по нормальному закону (MX = 40; DX = 200). Какова вероятность события {X ∈ (30; 80)}?\n";
            }
            public static string task18()
            {
                ans18 = Solution.solution18();
                return "18. Число вагонов в прибывающем на расформирование составе является случайной величиной, распределенной по нормальному" +
                    " закону с параметрами σ = 10, m = 100. Определить вероятность того, что в составе будет не более 90 вагонов.\n";
            }
            //public static string task19()
            //{
            //    return "19. Состав содержит 25 вагонов, 20 платформ и 30 цистерн. Массы вагонов имеют распределение в диапазоне (45 +- 15) т, массы платформ — " +
            //        "распределение в диапазоне (40 +- 18) т, массы цистерн — в диапазоне (60 +- 12) т. Локомотив способен везти состав массой не более 3700 т, " +
            //        "иначе необходимо прицеплять второй. Какова вероятность того, что одного локомотива не хватит для перевозки состава?\n";
            //}
        }

        public class Solution
        {
            public static double solution1A(int n, int k)
            {
                double arrangements = (Utlis.CalculateArrangements(n - 2, k - 2) / Utlis.CalculateArrangements(n, k)) * 2;
                return Math.Round(arrangements,4);
            }
            public static double solution1B(int n,int k)
            {
                double arrangements= (Utlis.Combinations(n - 5, k-5)/Utlis.CalculateArrangements(n,k)) * Utlis.Factorial(k-5);
                //double arrangements = (Utlis.Combinations(10 - 3, 6 - 3) / Utlis.CalculateArrangements(10, 6)) * Utlis.Factorial(6 - 3);
                
                return Math.Round(arrangements, 7);
            }
            public static double solution2A(int k)
            {
                int n = 16;
                return Math.Round((Utlis.Combinations(n-k,(n/2) -k)+ Utlis.Combinations(n - k, n / 2))/Utlis.Combinations(n, n / 2),5);
            }
            public static double solution2B(int k)
            {              
                return 1;
            }
            public static double solution4A(double p1, double p2)
            {
                return 1 - ((1 - p1) * (1 - p2));
            }
            public static double solution4B(double p1, double p2)
            {
                return (1 - p1) * (1 - p2);
            }
            public static double solution4C(double p1, double p2)
            {
                return p1 * (1 - p2);
            }
            public static double solution5(double p1, double p2)
            {
                return 1 - ((1-p1)*p2 + (1-p1)*(1-p1)*(1-p2)*p2);
            }
            public static double solution6(int n, int k, int m)
            {
                return Math.Round(Utlis.Combinations(k,m)/Utlis.Combinations(n,m),3);
            }
            public static double solution7(double p1, double p2, double p3)
            {
                return Math.Round((3-p1-p2-p3)/3,3);
            }
            public static double solution8(double p1, double p2, double p3)
            {
                return Math.Round(   (p1*6)/(p1*6 + p2*10 +p3*5),3         );
            }
            public static double solution9(double p,int n)
            {
                double ans = 0;
                for(int k = 2; k <= n; k++)
                {
                    ans += (Utlis.Combinations(n,k)*Math.Pow(p,k)*Math.Pow((1-p),n-k));
                }
                return Math.Round(ans,3);
            }
            public static string solution10A(double p,int n)
            {
                int k = n / 2;
                double q = 1 - p;
                double x= Math.Round((k - (n * p))/Math.Sqrt(n*p*q),4);
                double sqrt = Math.Round(1/Math.Sqrt(n * p * q),4);
                return $"{sqrt} * f({x})";
            }
            public static string solution10B(double p, int n)
            {
                int k = n / 2;
                double q = 1 - p;
                double x1 = Math.Round((n - (n * p)) / Math.Sqrt(n * p * q),4);
                double x2 = Math.Round((k - (n * p)) / Math.Sqrt(n * p * q),4);               
                return $"f({x1})" + " - " + $"f({x2})";
            }
            public static string solution11(int p, int n,int k2)
            {
                double p1 = p / 100;
                double q=1- p1;
                int k1 = 0;
                double x1= Math.Round((k2-n*p)/ Math.Sqrt(n*p*q));
                double x2 = Math.Round((k1-n*p)/ Math.Sqrt(n*p*q));

                return $"f({x1})" + " - " + $"f({x2})";
            }
            public static string solution12()
            {
                string s = "ряд распределения   0.2    0.2    0.2    0.2    0.2;\t" +
                    "M(x)=3;\t D(x)=2;\t σ(x) = sqrt(2);\n  F(x)=0, F(x)=0.2, F(x)=0.4, F(x)=0.6, F(x)=0.8, F(x)=1";
                return s;
            }
            public static string solution13(int n,double p)
            {
                double q = 1-p;
                string s = "ряд распределения: ";
                for (int i = n; i >= 0; i--)
                {
                    double temp = Math.Round(Math.Pow(p, i)*Math.Pow(q,n-i) * Utlis.Combinations(n,i),4);
                    s+=temp.ToString()+"\t";
                }
                s += $"M(x) = {n * p}\t";
                s += $"D(x) = {n * p * q}\t";
                return s;
            }
            public static string solution14(int n, double p)
            {
                double a = n * p;
                double q = 1 - p;
                string s = "распределение : ";
                for (int i = 0; i <= 4; i++)
                {
                    double temp = Math.Pow(a, i) / Utlis.Factorial(i);
                    s += $"{temp} * exp(-{a})\t";
                }
                s += $"M(x) = {n * p}";
                return s;
            }
            public static string solution15A()
            {
                return " M(x) = 0.8; M(y) = -0.2; D(x) = 2.76; D(y) = 2.2";
            }
            public static string solution15B()
            {
                return " Ряд распределения Z1 z1={-9,-5,1,5,3,7}; P={0.08, 0.02, 0.48, 0.12, 0.24, 0.06} соответсвенно\n" +
                    "Ряд распределения Z2 z2={4,-12,-1,3,-2,6}; P={0.08, 0.02, 0.48, 0.12, 0.24, 0.06} соответсвенно";
            }
            public static string solution15C()


            {
                return " D(Z1) = 13.24; D(Z2) = 8.8144";
            }
            public static string solution16()
            {
                return "(-0.8; 0.8)";
            }
            public static string solution18()
            {
                return "0.1587";
            }
        }
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
