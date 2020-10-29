﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProj
{
    class Program
    {   
        static void Main(string[] args)
        {

            CustomList<int> dupeMe = new CustomList<int>() { 2, 2, 4, 4, 6 };

            dupeMe.RemoveDuplicates(dupeMe);

            foreach (var item in dupeMe)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();


            CustomList<int> odd = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> even = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> contain = new CustomList<int>();
            contain = contain.Zip(odd, even);

            foreach (var item in contain)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            
            
            CustomList<string> ACE = new CustomList<string>() { "A", "C", "E" };
            CustomList<string> BDF = new CustomList<string>() { "B", "D" , "F" };
            CustomList<string> resultstring = new CustomList<string>();
            resultstring = resultstring.Merge(ACE, BDF);

            foreach (var item in resultstring)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            


        }
    }
}
