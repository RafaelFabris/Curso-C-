using System;
using System.Collections.Generic;

namespace Dictionary1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["User"] = "Maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "997155455";
            cookies["phone"] = "895111111";

            Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies["phone"]);

            cookies.Remove("email");

            if (cookies.ContainsKey("email"))
                Console.WriteLine(cookies["email"]);
            else
                Console.WriteLine("there is no 'email' key");

            Console.WriteLine("Size:" + cookies.Count) ;

            Console.WriteLine("All Cookies");
            foreach (KeyValuePair<string , string> item in cookies)
                Console.WriteLine(item.Key + ": " + item.Value);
        }
    }
}
