using System;

namespace Student
{
    class StudentInfo
    {
        private string studentId;
        private string lastName;
        private string firstName;

        public StudentInfo(string _studentId, string _lastName, string _firstName)
        {
            this.studentId = _studentId;
            this.lastName = _lastName;
            this.firstName = _firstName;
        }
        public StudentInfo(string _studentId, string _lastName, string _firstName, string _initMessage)
        {
            // this constructor is really unnecessary but STI wants us to do this so... here it is
            this.studentId = _studentId;
            this.lastName = _lastName;
            this.firstName = _firstName;

            Console.WriteLine(_initMessage);
        }


        public string StudentId
        {
            get { return studentId; }
            set { this.studentId = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { this.lastName = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { this.firstName = value; }
        }
    }
}
