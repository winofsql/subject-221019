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

            print("--Sort----");

            rpg.Sort();
            foreach (var item in rpg)
            {
                print(item);
            }

            print("--ForEach--");

            rpg.ForEach((s) => {
                print(s);
            });

            print("--toArray--");

            var skill = rpg.ToArray();
            for (int i = 0; i < skill.Length; i++)
            {
                print(skill[i]);
            }

            print("----------");

            foreach (var item in skill)
            {
                print(item);
            }

            print("--Reverse-");
            Array.Reverse(skill);
            foreach (var item in skill)
            {
                print(item);
            }

            print("--ForEach-");
            Array.ForEach(skill, (s) => {
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
