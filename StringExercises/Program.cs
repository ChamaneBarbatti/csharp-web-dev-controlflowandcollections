﻿using System;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them with a mouse.";
            string[] words = sentence.Split(" ");


            Console.WriteLine(string.Join("/",words));
        }
    }
}
