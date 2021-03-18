﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingLinqOne
{
    public class ListManager 
    {

        public static List<Student> LoadSampleData()
        {

            List<Student> output = new List<Student>();
                output.Add(new Student {First="Svetlana", Last="Omelchenko", ID=111, Scores= new List<int> {97, 92, 81, 60}});
                output.Add(new Student { First ="Claire", Last="O'Donnell", ID=112, Scores= new List<int> {75, 84, 91, 39}});
                output.Add(new Student { First ="Sven", Last="Mortensen", ID=113, Scores= new List<int> {88, 94, 65, 91}});
                output.Add(new Student { First ="Cesar", Last="Garcia", ID=114, Scores= new List<int> {97, 89, 85, 82}});
                output.Add(new Student { First ="Debra", Last="Garcia", ID=115, Scores= new List<int> {35, 72, 91, 70}});
                output.Add(new Student { First ="Fadi", Last="Fakhouri", ID=116, Scores= new List<int> {99, 86, 90, 94}});
                output.Add(new Student { First ="Hanying", Last="Feng", ID=117, Scores= new List<int> {93, 92, 80, 87}});
                output.Add(new Student { First ="Hugo", Last="Garcia", ID=118, Scores= new List<int> {92, 90, 83, 78}});
                output.Add(new Student { First ="Lance", Last="Tucker", ID=119, Scores= new List<int> {68, 79, 88, 92}});
                output.Add(new Student { First="Terry", Last="Adams", ID=120, Scores= new List<int> {99, 82, 81, 79}});
                output.Add(new Student { First="Eugene", Last="Zabokritski", ID=121, Scores= new List<int> {96, 85, 91, 60}});
                output.Add(new Student { First ="Michael", Last="Tucker", ID=122, Scores= new List<int> {94, 92, 91, 91}});
           
                return output;
        }
    }
}
