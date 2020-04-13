﻿using System;
using Aula__121_StringBuilder.Entities;
using System.Collections.Generic;

namespace Aula__121_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that's awesome!");
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Travel to New Zeleand",
                "I'm going to visit this wonderful contry",
                12);
            p1.AddComments(c1);
            p1.AddComments(c2);
            
            Comment c3 = new Comment("Good Night");
            Comment c4 = new Comment("May the force be with you");
            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good nigh guys",
                "See you tomorrow",
                5);
            p2.AddComments(c3);
            p2.AddComments(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

            Console.ReadLine();
        }
    }
}
