using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slownik
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                Menu();
                
                
            }
        }



        private static int Menu()
        {
            bool loop = true;
            while (loop==true)
            {
                Pisz("Aby wyświetlić wpisy, wpisz:'1'");
                Pisz("Aby zakończyć, wpisz:'2'");
                Pisz("Aby wyświetlić chronologicznie tłumaczone słowa, wpisz: '3'");
                Pisz("Aby wyświetlić tylko tranlacje od najnowszej, wpisz: '4'");
                Pisz("Podaj wyraz do przetłumaczenia:");
                Pisz("");

                string x = Console.ReadLine();
                if (x=="1"){ }
                else if (x=="2"){ loop= false; }
                else if (x=="3"){ }
                else if (x=="4") { }
                else
                {
                    WpisDoSlownika t = new WpisDoSlownika(x);
                }

            }
            return 0;
        }

        class WpisDoSlownika
        {
            Dictionary<string, string> tSlownik = new Dictionary<string, string>();
            Queue<string> kolejka = new Queue<string>();
            Stack<string> stos = new Stack<string>();

            
           public WpisDoSlownika(string n)
            {
                string m = Trans(n);
                kolejka.Enqueue(n);
                stos.Push(m);
                tSlownik.Add(n, m);
                Pisz(m);
            }
               

        }
        private static string Trans(string s)
        {
            Dictionary<char, char> dic = new Dictionary<char, char>();
            dic.Add('a', 'a');
            dic.Add('e', 'i');
            dic.Add('o', 'u');
            dic.Add('m', 'n');
            dic.Add('p', 'k');
            dic.Add('u', 'u');
            dic.Add('t', 't');
            dic.Add('i', 'a');
            dic.Add('n', 's');
            dic.Add('r', 'k');
            dic.Add('s', 'r');
            dic.Add('j', 'w');
            dic.Add('ż', 'l');
            dic.Add('ź', 'l');
            dic.Add('y', 'e');

            dic.Add('A', 'A');
            dic.Add('E', 'I');
            dic.Add('O', 'U');
            dic.Add('M', 'N');
            dic.Add('P', 'K');
            dic.Add('U', 'U');
            dic.Add('T', 'T');
            dic.Add('I', 'A');
            dic.Add('N', 'S');
            dic.Add('R', 'K');
            dic.Add('S', 'R');
            dic.Add('J', 'W');
            dic.Add('Ż', 'L');
            dic.Add('Ź', 'L');
            dic.Add('Y', 'E');






            char[] ss = s.ToCharArray();
            string sss = "";


            for (int i = 0; i<s.Length; i++)
            {
                
                try
                {
                    ss[i]=dic[ss[i]];
                    sss += ss[i];

                }
                catch (System.Collections.Generic.KeyNotFoundException)
                {
                    sss += ss[i];
                    continue;
                }
                

            }

            return sss;
        }
        private static void Pisz(char slowo)
        {
            Console.WriteLine(slowo);
        }
        private static void Pisz(string cslowo)
        {
            Console.WriteLine(cslowo);
        }
    }
    
}

