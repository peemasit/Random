﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random1 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Please enter your question!");
            Console.ReadLine();
            Random yesNoMaybe = new Random();
            int answerNum;
            answerNum = yesNoMaybe.Next(1, 4);
            if (answerNum == 1) {
                Console.WriteLine("Yes");
            } else if (answerNum == 2) {
                Console.WriteLine("Maybe");
            } else {
                Console.WriteLine("No");
            }
            
            Console.ReadKey();
        }
    }
}
