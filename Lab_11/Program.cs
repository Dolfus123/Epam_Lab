using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab_11
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = "У меня 10 долларов и 3 яблока.";
            Regex r = new Regex(@"\wй|у|е|а|о|я|\.|\*|\+|\?");
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
        }

    }
}
