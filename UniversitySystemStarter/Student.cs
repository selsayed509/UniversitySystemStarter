using System;

namespace UniversitySystem
{
    // Student is-a Person (inheritance).
    public class Student : Person
    {
        public string StudentId { get; set; }
        public string Course { get; set; }

        // "registers": each student is registered with one Department.
        public Department Department { get; set; }

        // : base(...) runs Person's constructor first, then this one.
        public Student(string nationalId, string name, DateTime dateOfBirth,
                       string phoneNumber, string address, string studentId, string course)
            : base(nationalId, name, dateOfBirth, phoneNumber, address)
        {
            StudentId = studentId;
            Course = course;
        }

        // Required, because GetRole() is abstract in Person.
        public override string GetRole()
        {
            return "Student";
        }
    }
}
