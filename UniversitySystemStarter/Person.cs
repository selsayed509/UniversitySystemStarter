using System;

namespace UniversitySystem
{
    // {abstract} Person: the common parent of Student and Staff.
    // There is no plain "Person" in the university, so it cannot be instantiated.
    public abstract class Person
    {
        public string NationalId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public Person(string nationalId, string name, DateTime dateOfBirth, string phoneNumber, string address)
        {
            NationalId = nationalId;
            Name = name;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        // virtual: derived classes may override it.
        public virtual string GetContactInfo()
        {
            return Name + ", " + PhoneNumber + ", " + Address;
        }

        public void UpdateContactInfo(string phoneNumber, string address)
        {
            PhoneNumber = phoneNumber;
            Address = address;
        }

        // Not in the diagram: added to show an abstract method.
        // Every derived class must provide its own version.
        public abstract string GetRole();
    }
}
