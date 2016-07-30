using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Practice: Develop a custom console application for formatting input data.
User inputs a value (e.g. “12”, “23/05/2016”), then he inputs a value type (e.g. “String”, “DateTime”)
and then application displays different representations of a value.
*/

namespace SeventhTask
{
    class Textformat
    {
        public string Text { get; set; }
        public string Format { get; set; }

        public void Formatting()
        {
            try
            {
                if (string.Equals(Format, "String", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(Text.ToString().ToUpperInvariant());
                    Console.WriteLine(Text.ToString().ToLower());
                }
                else if (string.Equals(Format, "DateTime", StringComparison.OrdinalIgnoreCase))
                {
                    DateTime dt = DateTime.Parse(Text);
                    Console.WriteLine(dt.ToString("d"));
                    Console.WriteLine(dt.ToString("D"));
                    Console.WriteLine(dt.ToString("F"));
                    Console.WriteLine(dt.ToString("t"));
                    Console.WriteLine(dt.ToString("U"));
                    Console.WriteLine(dt.ToString("o"));
                }
                else if (string.Equals(Format, "TimeSpan", StringComparison.OrdinalIgnoreCase))
                {
                    TimeSpan ts = TimeSpan.FromDays(double.Parse(Text)) - TimeSpan.FromMinutes(double.Parse(Text));
                    Console.WriteLine(ts.Hours);
                    Console.WriteLine(ts.TotalDays);

                    Console.WriteLine(TimeSpan.FromHours(double.Parse(Text)));
                    Console.WriteLine(TimeSpan.FromSeconds(double.Parse(Text)));
                    Console.WriteLine(TimeSpan.FromMilliseconds(double.Parse(Text)));

                    Console.WriteLine(new TimeSpan(long.Parse(Text)));
                }
                else if (string.Equals(Format, "DateTimeOffset", StringComparison.OrdinalIgnoreCase))
                {
                    DateTimeOffset dto = DateTimeOffset.Parse(Text);
                    Console.WriteLine(dto.ToString("r"));
                    Console.WriteLine(dto.ToString("G"));
                    Console.WriteLine(dto.ToString("s"));
                }
                else if (string.Equals(Format, "Int", StringComparison.OrdinalIgnoreCase))
                {
                    int aa = int.Parse(Text);
                    Console.WriteLine(aa.ToString("C"));
                    Console.WriteLine(aa.ToString("G"));
                    Console.WriteLine(aa.ToString("P"));
                    Console.WriteLine(aa.ToString("X"));
                }
                else
                    Console.WriteLine(Text.ToString());
            }
            catch
            {
                Console.WriteLine("Сan't be formatted.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Textformat tt = new Textformat();
            tt.Text = Convert.ToString(Console.ReadLine());
            tt.Format = Convert.ToString(Console.ReadLine());

            tt.Formatting();

            Console.ReadKey();
        }
    }
}
