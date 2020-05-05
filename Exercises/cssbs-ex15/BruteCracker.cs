using System;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace cssbs_ex15
{
    internal class BruteCracker
    {
        private string pass;
        private const int limiter = 12;

        public BruteCracker(string pass)
        {
            this.pass = pass;
        }

        internal bool Crack()
        {
            var builder = new StringBuilder(0);
            var sw = new Stopwatch();
            sw.Start();
            var tasks = new Task<string>[limiter];
            for(int i = 0; i < limiter; i++)
            {
                tasks[i] = Task.Run(() => Generate(pass, (ulong)i));
            }
            int result = Task.WaitAny(tasks);
            Console.WriteLine($"{((double)sw.ElapsedMilliseconds) / 1000} seconds");
            string cracked = tasks[result].Result;
            if (cracked == pass) return true;
            else return false;
        }

        private static string Generate(string pass, ulong i)
        {
            var builder = new StringBuilder(0);
            while (builder.ToString() != pass)
            {
                builder.Clear();
                foreach (var n in numToChars(i))
                {
                    builder.Append((char)n);
                }
                i += limiter;
            }
            return builder.ToString();
        }
        private static int[] numToChars(ulong input)
        {
            int len = 0;
            var temp = input;
            if (temp == 0) temp = 1;
            while (temp > 0)
            {
                temp /= 95;
                len++;
            }
            var result = new int[len];
            for (int i = 0; i < len; i++)
            {
                if (len - i == 0) result[i] = (int)(32 + input);
                else
                {
                    result[i] = (int)(32 + (input / Math.Pow(95, len - 1 - i)));
                    input %= (ulong)Math.Pow(95, len - 1 - i);
                }
            }
            return result;
        }
    }
}