using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class Student
    {
        public string name;
        public string course;
        public string phoneNum;

        public Student(string name, string course, string phoneNum)
        {
            this.name = name;
            this.course = course;  
            this.phoneNum = phoneNum;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Course
        {
            get { return course; }
            set { course = value; }
        }

        public string PhoneNum
        {
            get { return phoneNum; }
            set { phoneNum = value; }
        }
    }
}
