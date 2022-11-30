using System;

internal class Program
{
    private static void Main(string[] args)
    {
        p();
        void p()
        {
            Console.Write("alegeti numarul problemei:");
            int a = 1;
            while (a != 0) {
                a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 0:
                        a = 0;
                        break;
                    case 1:
                        p1();
                        p();
                        break;
                    case 2:
                        p2();
                        p();
                        break;
                    case 3:
                        p3();
                        p();
                        break;
                    case 4:
                        p4();
                        p();
                        break;
                    case 5:
                        p5();
                        p();
                        break;
                    case 6:
                        p6();
                        p();
                        break;
                    case 7:
                        p7();
                        p();
                        break;
                    case 8:
                        p8();
                        p();
                        break;
                    case 9:
                        p9();
                        p();
                        break;
                    case 10:
                        p10();
                        p();
                        break;
                    case 11:
                        p11();
                        p();
                        break;
                    case 12:
                        p12();
                        p();
                        break;
                    case 13:
                        p13();
                        p();
                        break;
                    case 14:
                        p14();
                        p();
                        break;
                    case 15:
                        p15();
                        p();
                        break;
                    case 16:
                        p16();
                        p();
                        break;
                    case 17:
                        p17();
                        p();
                        break;
                    case 18:
                        p18();
                        p();
                        break;
                    case 19:
                        p19();
                        p();
                        break;
                    case 20:
                        p20();
                        p();
                        break;
                    case 21:
                        p21();
                        p();
                        break;
                }
            }
        }
        void p1()
        {
            Console.WriteLine("Cerinta problemei este:");
            Console.WriteLine("Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. ");
            double a, b;
            Console.Write("a:");
            a = double.Parse(Console.ReadLine());
            Console.Write("b:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine($"in ecuatia {a}x + {b} = 0, x este {(0 - b) / a}");

        }
        void p2()
        {
            Console.WriteLine("Cerinta problemei este:");
            Console.WriteLine("Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile. ");
            double a, b, c, x1, x2, d;
            // d = delta
            Console.Write("a:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c:");
            c = Convert.ToDouble(Console.ReadLine());
            if (a == 0)
                if (b == 0)
                    if (c == 0)
                        Console.WriteLine("imposibil");
                    else
                        Console.WriteLine("imposibil");
                else
                {
                    x1 = 0 - c / b;
                    Console.WriteLine($"ecuatie de grad 1 cu x = {x1}");
                }
            else
            {
                d = b * b - 4 * a * c;
                if (d < 0)
                    Console.WriteLine("x nu apartine multimii numerelor reale");
                else
                {
                    if (d == 0)
                    {
                        x1 = x2 = -b / (2 * a);
                        Console.WriteLine("solutia este :" + x1);
                    }

                    else
                    {
                        x1 = (-b + Math.Sqrt(d)) / (2 * a);
                        x2 = (-b - Math.Sqrt(d)) / (2 * a);
                        Console.WriteLine($"solutiile sunt: {x1}, {x2}");
                    }
                }
            }
            Console.ReadKey();
        }   
        void p3()
        {
            Console.WriteLine("Cerinta problemei este:");
            Console.WriteLine("Determinati daca n se divide cu k, unde n si k sunt date de intrare. ");
            double a, b;
            Console.Write("n:");
            a = double.Parse(Console.ReadLine());
            Console.Write("k:");
            b = double.Parse(Console.ReadLine());
            if (a % b == 0)
                Console.WriteLine($"{a} se divide cu {b}");
            else
                Console.WriteLine($"{a} nu se divide cu {b}");
        }
        void p4()
        {
            Console.WriteLine("Cerinta problemei este:");
            Console.WriteLine("Detreminati daca un an y este an bisect. ");
            int a;
            Console.Write("y:");
            a = int.Parse(Console.ReadLine());
            if (a % 4 == 0)
                if (a % 100 != 0)
                    Console.WriteLine($"anul {a} este bisect");
                else
                    if (a % 400 == 0)
                    Console.WriteLine($"anul {a} este bisect");
                else
                    Console.WriteLine($"anul {a} nu este bisect");
            else Console.WriteLine($"anul {a} nu este bisect");

        }
        void p5()
        {
            Console.WriteLine("Cerinta problemei este:");
            Console.WriteLine("Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga.");
            int a, a2, b, x = 0;
            Console.Write("n:");
            a = int.Parse(Console.ReadLine());
            Console.Write("k:");
            b = int.Parse(Console.ReadLine());
            a2 = a;
            while (a != 0)
            {

                x++;
                if (x == b)
                    Console.WriteLine(a % 10);
                a = a / 10;
            }
            if (x < b)
                Console.WriteLine($"numarul {a2} are mai putin de {b} cifre");

        }
        void p6()
        {
            Console.WriteLine("Cerinta problemei este:");
            Console.WriteLine("Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. ");
            double c, a, b;
            Console.Write("a:");
            a = double.Parse(Console.ReadLine());
            Console.Write("b:");
            b = double.Parse(Console.ReadLine());
            Console.Write("c:");
            c = double.Parse(Console.ReadLine());

            if (a > 0 && b > 0 && c > 0)
                if (a + b > c && a + c > b && b + c > a)
                    Console.WriteLine($"{a} {b} si {c} pot fi laturile unui triunghi");
                else
                    Console.WriteLine($"{a} {b} si {c} nu pot fi laturile unui triunghi");
            else
                Console.WriteLine($"{a} {b} si {c} nu pot fi laturile unui triunghi");
        }
        void p7()
        {
            Console.WriteLine("Cerinta problemei este:");
            Console.WriteLine("Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor.");
            double a, b;
            Console.Write("a:");
            a = double.Parse(Console.ReadLine());
            Console.Write("b:");
            b = double.Parse(Console.ReadLine());
            (a, b) = (b, a);
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        void p8()
        {
            Console.WriteLine("Cerinta problemei este:");
            Console.WriteLine("Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.");
            double a, b;
            Console.Write("a:");
            a = double.Parse(Console.ReadLine());
            Console.Write("b:");
            b = double.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        void p9()
        {
            Console.WriteLine("Cerinta problemei este:");
            Console.WriteLine("Afisati toti divizorii numarului n.");
            int n;
            Console.Write("n:");
            n = int.Parse(Console.ReadLine());
            Console.Write($"divizorii numarului {n} sunt: ");
            if (n % 2 == 0)
                Console.Write($"{2} {n / 2} ");
            for (int i = 3; i * i < n; i++)
            {
                if (n % i == 0)
                    Console.Write($"{i} {n / i} ");
            }

        }
        void p10()
        {
            Console.WriteLine("Cerinta problemei este:");
            Console.WriteLine("Test de primalitate: determinati daca un numar n este prim.");
            int n, v = 0;
            Console.Write("n:");
            n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.Write($"{n} nu este numar prim");
                v++;
            }
            else
            {
                for (int i = 3; i * i < n; i++)
                    if (n % i == 0)
                    {
                        Console.Write($"{n} nu este numar prim");
                        v++;
                    }

            }
            if (v == 0)
                Console.Write($"{n} este numar prim");

        }
        void p11()
        {
            Console.WriteLine("Cerinta problemei este:");
            Console.WriteLine("Afisati in ordine inversa cifrele unui numar n.");
            int n;
            Console.Write("n:");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                Console.Write(n % 10 + " ");
                n = n / 10;
            }
        }
        void p12()
        {
            Console.WriteLine("Cerinta problemei este:");
            Console.WriteLine("Determinati cate numere intregi divizibile cu n se afla in intervalul [a, b]. ");
            int n, a, b, x = 0;
            Console.Write("a:");
            a = int.Parse(Console.ReadLine());
            Console.Write("b:");
            b = int.Parse(Console.ReadLine());
            Console.Write("n:");
            n = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
                if (i % n == 0)
                    x++;
            Console.WriteLine($"int intrevalul[{a},{b}] sunt {x} numere care se divid cu {n}");
        }
        void p13()
        {
            Console.WriteLine("Cerinta problemei este:");
            Console.WriteLine("Determianti cati ani bisecti sunt intre anii y1 si y2.");
            int a, x = 0, y1, y2;
            Console.Write("y1:");
            y1 = int.Parse(Console.ReadLine());
            Console.Write("y2:");
            y2 = int.Parse(Console.ReadLine());
            for (a = y1; a <= y2; a++)
            if (a % 4 == 0)
                if (a % 100 != 0)
                    x++;
                else
                    if (a % 400 == 0)
                    x++;
            Console.WriteLine($"din anul {y1} pana in anul {y2} sunt {x} ani bisecti");

        }
        void p14()
        {
            Console.WriteLine("Cerinta problemei este:");
            Console.WriteLine("Determianti daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321. ");
            int a, b = 0, x;
            Console.Write("n:");
            a = int.Parse(Console.ReadLine());
            x = a;
            while (x != 0)
            {
                b = b * 10 + x % 10;
                x = x / 10;
            }
            if (a == b)
                Console.WriteLine($"{a} este numar palindrom");
            else
                Console.WriteLine($"{a} nu este numar palindrom");

        }
        void p15()
        {
            Console.WriteLine("Cerinta problemei este:");
            Console.WriteLine("Se dau 3 numere. Sa se afiseze in ordine crescatoare. ");
            int a, b, c, x1 = 0, x2 = 0, x3 = 0, ok = 0;
            Console.Write("a:");
            a = int.Parse(Console.ReadLine());
            Console.Write("b:");
            b = int.Parse(Console.ReadLine());
            Console.Write("c:");
            c = int.Parse(Console.ReadLine());
      
            
            if (a < b && a < c && ok == 0)
            {
                x1 = a;
                if (b < c)
                {
                    x2 = b;
                    x3 = c;
                }
                else
                {
                    x2 = c;
                    x3 = b;
                }
                ok++; 
            }
            if (b < a && b < c)
            {
                x1 = b;
                if (a < c)
                {
                    x2 = a;
                    x3 = c;
                }
                else
                {
                    x2 = c;
                    x3 = a;
                }
                ok++;
            }
            if (c < a && c < b)
            {  
                x1 = c;
                if (a < b)
                {
                    x2 = a;
                    x3 = b;
                }
                else
                {
                    x2 = b;
                    x3 = a;
                }
                ok++;
            }
            if (ok == 1)
            Console.WriteLine($"{x1} {x2} {x3}");
            else
                if (a == b && b == c)
                    Console.WriteLine($"{a} {b} {c}");
                else
                {
                    if (a == b)
                        if (a < c)
                            Console.WriteLine($"{a} {b} {c}");
                        else
                            Console.WriteLine($"{c} {b} {a}");
                    if (b == c)
                        if (a < c)
                            Console.WriteLine($"{a} {b} {c}");
                        else
                            Console.WriteLine($"{c} {b} {a}");
                    if (a == c)
                        if (a < c)
                            Console.WriteLine($"{b} {a} {a}");
                        else
                            Console.WriteLine($"{a} {a} {b}");
            }
        
        }
        void p16()
        {
            Console.WriteLine("Cerinta problemei este:");
            Console.WriteLine("Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)");
            int a, b, c, d, e, v = 1;
            Console.Write("a:");
            a = int.Parse(Console.ReadLine());
            Console.Write("b:");
            b = int.Parse(Console.ReadLine());
            Console.Write("c:");
            c = int.Parse(Console.ReadLine());
            Console.Write("d:");
            d = int.Parse(Console.ReadLine());
            Console.Write("e:");
            e = int.Parse(Console.ReadLine());
            while (v > 0)
            {
                v = 0;
                if (a > b)
                {
                    (a, b) = (b, a);
                    v++;
                }
                if (b > c)
                {
                    (b, c) = (c, b);
                    v++;
                }
                if (c > d)
                {
                    (c, d) = (d, c);
                    v++;
                }
                if (d > e)
                {
                    (d, e) = (e, d);
                    v++;
                }

            }
            Console.WriteLine($"{a} {b} {c} {d} {e}");


        }
        void p17()
        {
            Console.WriteLine("Cerinta problemei este:");
            Console.WriteLine("Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid. ");
            int n, a, b, m, x1, x2;
            Console.Write("a:");
            a = int.Parse(Console.ReadLine());
            Console.Write("b:");
            b = int.Parse(Console.ReadLine());
            x1 = a;
            x2 = b;
            while (x1 != x2)
                if (x1 > x2)
                    x1 = x1 - x2;
                else
                    x2 = x2 - x1;
            Console.WriteLine($"Cmmdc al numerelor {a} si {b} este {x1}");
            x1 = a;
            x2 = b;
            while (x1 != x2)
                if (x1 < x2)
                    x1 = x1 + a;
                else
                    x2 = x2 + b;
            Console.WriteLine($"Cmmmc al numerelor {a} si {b} este {x1}");

        }
        void p18()
        {
            Console.WriteLine("Cerinta problemei este:");
            Console.WriteLine("Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1176 afisati 2^3 x 3^1 x 7^2. ");
            int a, v, p = 2;
            Console.Write("n:");
            a = int.Parse(Console.ReadLine());
            while (a != 1)
            {
                v = 0;
                while (a % p == 0)
                {
                    a = a / p;
                    v++;
                }
                
                if (v > 0 && a != 1)
                    Console.Write($"{p}^{v}x");
                if (v > 0 && a == 1)
                    Console.Write($"{p}^{v}");
                p++;
            }
        }
        void p19()
        {
            Console.WriteLine("Cerinta problemei este:");
            Console.WriteLine("Determinati daca un numar e format doar cu 2 cifre care se pot repeta.");
            int a, v1, v2 = -1, aux;
            bool ok = true;
            Console.Write("n:");
            a = int.Parse(Console.ReadLine());
            aux = a;
            v1 = a % 10;
            while (a != 0)
            {
                if (a % 10 != v1 && v2 == -1)
                    v2 = a % 10;
                a = a / 10;
                if (a % 10 != v1 && a % 10 != v2 && v2 != -1)
                {
                    Console.WriteLine($"numarul {aux} este format din mai mult de 2 cifre");
                    ok = false;
                    break;
                }                
            }
            if (v2 == -1)
                Console.WriteLine($"numarul {aux} este format dintr-o singura cifra");
            if (ok && v2 != -1)
            {
                Console.WriteLine($"numarul {aux} este format din 2 cifre");
            }
        }
        void p20()
        {
            Console.WriteLine("Cerinta problemei este:");
            Console.WriteLine("Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul).");
            int m, n, v, aux, pc = -1, r;
            bool prs = false, prx = false;
            // prs = perioada simpla
            // prx = perioada mixta 
            // pc = prima cifra dupa punct;
            Console.Write("m:");
            m = int.Parse(Console.ReadLine());
            Console.Write("n:");
            n = int.Parse(Console.ReadLine());
            if (n > m)
                aux = m;
            else
                aux = n;
            for (int i = 2; i * i <= aux; i++)
                while (m % i == 0 && n % i == 0)
                {
                    m = m / i;
                    n = n / i;
                }
            r = m % n;
            aux = n;
            while (aux != 1)
            {
                while (aux % 5 == 0)
                    aux = aux / 5;
                while (aux % 2 == 0)
                    aux = aux / 2;
                if (aux != 1 && aux != n)
                {
                    prx = true;
                    break;
                }
                if (aux == n)
                {
                    prs = true;
                    break;
                }
            }
            if (m % n == 0)
                Console.Write($"fractia in format zecimal este {m / n}.0");
            else
                Console.Write($"fractia in format zecimal este {m / n}.");
            aux = 0;
            if (prs)
            {
                Console.Write("(");
                if (r * 10 / n == 0)
                    Console.Write("0");
                while (true)
                {
                    if (pc == r * 10 / n)
                        break;
                    if (pc == -1)
                        pc = r * 10 / n;
                    aux = aux * 10 + r * 10 / n;
                    r = r * 10 % n;
                    
                }
            }
            if (prs)
                Console.Write($"{aux})");
            int aux2 = -1; 
            aux = 0;
            if (prx)
            {
                while (true)
                {
                    
                if (aux2 == -1)
                    aux2 = r * 10 / n;
                aux = aux * 10 + r * 10 / n;
                r = r * 10 % n;
                Console.Write(aux2); 
                    if (aux2 != r * 10 / n)
                        break;
                }
            }
                Console.Write("(");
            aux = 0;
            pc = -1;
                while (true)    
                {
                    if (pc == r * 10 / n)
                        break;
                    if (pc == -1)
                            pc = r * 10 / n;
                    aux = aux * 10 + r * 10 / n;
                    r = r * 10 % n;

                }
                Console.Write($"{aux})");

            }

               
                    
        void p21()
        {
            //sunt sanse ca folosind random number sa avem mult prea multe intrebari
            Console.WriteLine("Cerinta problemei este:");
            Console.WriteLine("Ghiciti un numar intre 1 si 1024 prin intrebari de forma \"numarul este mai mare sau egal decat x?\". ");
            int x = 512, aux = 256, aux2 = 1;
            string c;
            Console.WriteLine($"numarul este mai mare, mai mic sau egal cu {x}?");
            while (true && x > 0 && x < 1025)
            {
                c = Console.ReadLine();
                if (c == "mai mare")
                {
                    x = x + aux;
                    Console.WriteLine($"numarul este mai mare, mai mic sau egal cu {x}?");
                    aux = aux / 2;
                }
                if (c == "mai mic")
                {
                    x = x - aux;
                    Console.WriteLine($"numarul este mai mare, mai mic sau egal cu {x}?");
                    aux = aux / 2;
                }
                if (c == "egal")
                {
                    break;
                }
                if (aux == 0 && aux2 == 1)
                {
                    aux = 1;
                    aux2 = 0;
                }
            }
        }
        
    }
}
