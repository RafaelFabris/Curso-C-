using System;
using System.Globalization;

namespace SpecialC
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(1, 30, 10);
            TimeSpan t2 = new TimeSpan(0, 10, 5);

            /*TimeSpan t = new TimeSpan(2 , 3 , 5 , 7 , 11);
            Console.WriteLine("Days: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine("Milliseconds: " + t.Milliseconds);
            Console.WriteLine("Seconds: " + t.Seconds);
            Console.WriteLine("Ticks: " + t.Ticks);
            Console.WriteLine("TotalDays: " + t.TotalDays);
            Console.WriteLine("TotalHours: " + t.TotalHours);
            Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);*/



            /*DateTime d1 = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            DateTime d2 = d1.AddHours(2);
            DateTime d3 = d1.AddMinutes(3);
            TimeSpan t = d2.Subtract(d1);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(t);*/


            /*
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);*/

            //TimeSpan t1 = new TimeSpan(0, 1, 30);
            /*TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(2, 11, 21);
            TimeSpan t4 = new TimeSpan(1 , 2 , 11 , 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);
            TimeSpan t6 = TimeSpan.FromDays(1.5);
            TimeSpan t7 = TimeSpan.FromHours(1.5);
            TimeSpan t8 = TimeSpan.FromMinutes(1.5);
            TimeSpan t9 = TimeSpan.FromSeconds(1.5);
            TimeSpan t10 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t11 = TimeSpan.FromTicks(900000000L);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
            Console.WriteLine(t7);
            Console.WriteLine(t8);
            Console.WriteLine(t9);
            Console.WriteLine(t10);
            Console.WriteLine(t11);*/






            /*DateTime d1 = DateTime.Parse("2000-08-15");
            DateTime d2 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d3 = DateTime.Parse("15/08/2000 13:05:58");
            DateTime d4 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d5 = DateTime.ParseExact("15-08-2000 13:05:58", "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);*/

            /*DateTime d2 = new DateTime(2018 , 11 , 25);
            Console.WriteLine(d2);
            DateTime d3 = new DateTime(2018, 11, 25  , 20 , 45 , 03);
            Console.WriteLine(d3);
            DateTime d4 = new DateTime(2018, 11, 25, 20, 45, 03 , 500);
            Console.WriteLine(d4);

            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            DateTime d5 = DateTime.Today;
            Console.WriteLine(d5);
            DateTime d6 = DateTime.UtcNow;
            Console.WriteLine(d6);*/





            /*string original = "abcde FGHIJ ABC abc DEFG   ";
            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();
            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");
            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);
            string s6 = original.Replace('a' , 'x');
            string s7 = original.Replace("abc", "xy");
            bool b1 = string.IsNullOrEmpty(original);
            bool b2 = string.IsNullOrWhiteSpace(original);



            Console.WriteLine("Original -" + original + "-");
            Console.WriteLine("To Upper -" + s1 + "-");
            Console.WriteLine("To Lower -" + s2 + "-");
            Console.WriteLine("TRIM -" + s3 + "-");
            Console.WriteLine("IndexOF(bc) -" + n1 + "-");
            Console.WriteLine("LastIndexOF(bc) -" + n2 + "-");
            Console.WriteLine("SubString (3) -" + s4 + "-");
            Console.WriteLine("SubString (3 , 5) -" + s5 + "-");
            Console.WriteLine("Replace (a , x) -" + s6 + "-");
            Console.WriteLine("Replace (abc , xy) -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty -" + b1 + "-");
            Console.WriteLine("IsNullOrWhiteSpace -" + b2 + "-");*/




            /*double price = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);

            double discount = (price<20) ? price * 0.1 : price * 0.05;

            Console.WriteLine(discount);*/



            /* int x = int.Parse(Console.ReadLine());
             string day;
             switch (x)
             {
                 case 1:
                     day = "Domingo";
                     break;

                 case 2:

                     day = "Segunda-Feira";
                     break;

                 case 3:
                     day = "Terça-Feira";
                     break;


                 case 4:
                     day = "Quarta-Feira";
                     break;
                 case 5:
                     day = "Quinta-Feira";
                     break;
                 case 6:
                     day = "Sexta-Feira";
                     break;
                 case 7:
                     day = "Domingo";
                     break;
                 default:
                     day = "Valor Invalido";
                     break;
             }
             Console.WriteLine(day);*/

            /*
            var x = 10;
            var y = 20.0;
            var z = "maria";

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            */
        }
    }
}
