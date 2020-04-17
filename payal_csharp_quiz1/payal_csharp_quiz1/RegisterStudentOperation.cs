using System;
using System.Collections.Generic;
using System.Text;

namespace payal_csharp_quiz1
{
    class RegisterStudentOperation
    {
        private Student student;
        private int grade;
        public RegisterStudentOperation(int val)
        {
            grade = val;

            student = new Student();
            //subscribe to beforePrintEvent event
            student.GEvent += student_graduateEvent;
        }
        //beforePrintevent handler
        void student_graduateEvent()
        {
            Console.WriteLine("EventHandler: Student is going to print");
        }

        public int Value
        {
            get { return grade; }
            set { grade = value; }
        }

    }
}
