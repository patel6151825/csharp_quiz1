using System;
using System.Collections.Generic;
using System.Text;

namespace payal_csharp_quiz1
{
    class Student
    {
        // declare delegate 
        public delegate void GraduateEvent();

        //declare event of type delegate
        public event GraduateEvent GEvent;

        public void PrintMessage(int grade)
        {
            //call delegate method before going to print
            if (GEvent != null)
                GEvent();

            Console.WriteLine("Student is graduating with grade {0}", grade);
        }
    }

}
