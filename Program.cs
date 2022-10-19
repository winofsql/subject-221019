using System.Diagnostics;
using System;
using System.Collections.Generic;

namespace cs_1019_1
{
    class Program
    {
        static void Main(string[] args)
        {

            var rpg = new List<string>();

            rpg.Add("3:勇者");
            rpg.Add("2:賢者");
            rpg.Add("1:魔導士");

            for (int i = 0; i < rpg.Count; i++)
            {
                print(rpg[i]);
            }

            print("----------");

            foreach (var item in rpg)
            {
                print(item);
            }

            print("----------");

            rpg.Sort();
            foreach (var item in rpg)
            {
                print(item);
            }

            print("----------");

            rpg.ForEach((s) => {
                print(s);
            });

        }


        private static void print(string v)
        {
            Console.WriteLine(v);
            Debug.WriteLine( $"DBG:{v}" );
        }
    }
}
