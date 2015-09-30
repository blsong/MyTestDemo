using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplicationDemo
{
    public class StudentService
    {
        public static List<Student> studentList;

        static StudentService()
        {
            studentList = new List<Student>();

            studentList.Add(new Student() { UserId = 1, UserName = "包建强", Score = 100 });
            studentList.Add(new Student() { UserId = 2, UserName = "刘彦博", Score = 80 });
            studentList.Add(new Student() { UserId = 3, UserName = "丁学", Score = 70 });
            studentList.Add(new Student() { UserId = 4, UserName = "贾菡", Score = 60 });
            studentList.Add(new Student() { UserId = 5, UserName = "怪怪", Score = 50 });
        }

        public static List<Student> RetrieveStudentList()
        {
            return studentList;
        }

        public static List<Student> RetrievePassedStudentList()
        {
            return studentList.Where(x => x.Score >= 60).ToList();
        }
    }
}
