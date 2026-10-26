using System.Collections.Generic;

namespace UniversitySystem
{
    public class University
    {
        public string Name { get; set; }
        public string Location { get; set; }

        // Composition (filled diamond): the University creates and owns its
        // departments. Removing a department removes it from the system.
        private List<Department> departments = new List<Department>();

        public University(string name, string location)
        {
            Name = name;
            Location = location;
        }

        // The diagram shows addDepartment(d: Department). Creating the
        // department here instead makes the ownership explicit.
        public Department AddDepartment(string name, string school)
        {
            Department d = new Department(name, school);
            departments.Add(d);
            return d;
        }

        public void RemoveDepartment(Department d)
        {
            departments.Remove(d);
        }

        public Department GetDepartment(string name)
        {
            foreach (Department d in departments)
            {
                if (d.Name == name)
                    return d;
            }
            return null;
        }
    }
}
