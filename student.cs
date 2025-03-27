using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeAndQuickSort
{
    internal class student
    {
        public int StudentID
        { get; set; }
        public string StudentName
        { get; set; }

        public string StudentMajor
        { get; set; }

        public string StudentYear
        {
            get; set;

        }

        public student(int studentID, string studentName, string studentMajor, string studentYear)
        {
            StudentID = studentID;
            StudentName = studentName;
            StudentMajor = studentMajor;
            StudentYear = studentYear;
        }

        public void DisplayStudent()
        {
            Console.Write(StudentID + " | ");
            Console.Write(StudentName + " | ");
            Console.Write(StudentMajor + " | ");
            Console.Write(StudentYear);
            Console.WriteLine();
        }
    }
}
