using System.Collections.Generic;

namespace UniversitySystem
{
    public class Department
    {
        public string Name { get; set; }
        public string School { get; set; }

        // Aggregation (hollow diamond): students exist independently of the
        // department. They are created outside and passed in.
        public List<Student> Students { get; } = new List<Student>();

        // Composition with University: by design, only University.AddDepartment()
        // creates a Department. Nothing else in the program should call this.
        public Department(string name, string school)
        {
            Name = name;
            School = school;
        }

        // Records the "registers" association on both sides.
        public void AddStudent(Student s)
        {
            if (!Students.Contains(s))
            {
                Students.Add(s);
                s.Department = this;
            }
        }

        public Student GetStudent(string name)
        {
            foreach (Student s in Students)
            {
                if (s.Name == name)
                    return s;
            }
            return null;
        }
    }
}
