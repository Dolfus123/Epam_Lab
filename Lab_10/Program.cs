using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = "У меня 10 долларов и 3 яблока.";
            const string w = "йуеаоя"; 
            Regex r = new Regex(@"\wй|у|е|а|о|я|\.|\*|\+|\?");
            //MatchCollection mc = r.Matches(a);
            var v = a.Split(' ');
             string[] result = new string[v.Length];
             for (int i = 0; i < v.Length; i++)
             {
                 var g = string.Empty;
                 var s = string.Empty;
                 foreach (var c in v[i])
                 {
                     if (r.Matches(c.ToString()).Count != 0)
                         g += c.ToString();
                     else
                         s += c.ToString();
                 }
                 a = s + g;
                 result[i] = a;
             }
             var d = string.Join(" ", result);
             Console.WriteLine(d);//У мнея 10 дллрвоао и 3 блкяоа.
            /*
                        string s = "У меня 10 долларов и 3 яблока.";
                        Console.WriteLine(s);
                        Console.WriteLine("-----------------------");
                        Regex r = new Regex(@"\wй|у|е|а|о|я");
                        //Просто замена, в т.ч. можно использовать $номер для групп:
                        MatchCollection mc = r.Matches(s);
                        string so = r.Replace(s, "");
                        Console.WriteLine(so);
                        //r.Match(s);
                        MatchEvaluator ma = new MatchEvaluator(myReplace);
                        so = r.Replace(so, ma);
                        Console.WriteLine(so);
                        Console.WriteLine("------------!!!!-----------");
                        foreach (Match m in mc)
                        {

                            so = r.Replace(s, m.Value);

                        }

                        Console.WriteLine(so);

                        Console.WriteLine("-----------------------");
                        //поиск того, что соответствует шаблону:

                        foreach (Match m in mc)
                        {
                            Console.WriteLine(m.Value);
                        }

                        Console.WriteLine("-----------------------");
                        //замена текста:
                        //MatchEvaluator ma = new MatchEvaluator(myReplace);
                        so = r.Replace(s, ma);
                        Console.WriteLine(so);*/
          /* string s = "У меня 10 рублей, 3 яблока, 155 апельсинов.";
            Console.WriteLine(s);
            Console.WriteLine("-----------------------");
            Regex r = new Regex(@"\wй|у|е|а|о|я");
            //Просто замена, в т.ч. можно использовать $номер для групп:
            string so = r.Replace(s, "");


            Console.WriteLine(so);

            Console.WriteLine("-----------------------");
            //поиск того, что соответствует шаблону:
            MatchCollection mc = r.Matches(s);
            foreach (Match m in mc)
            {
                Console.WriteLine(m.Value);
            }

            Console.WriteLine("-----------------------");
            //замена текста:
            MatchEvaluator ma = new MatchEvaluator(myReplace);
            so = r.Replace(s, ma);
            Console.WriteLine(so);*/

        }

        static string myReplace(Match m)
        {
            return m.ToString();
        }

    }
}
