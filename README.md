# CMP205 Lab 6: University System Starter

Starter project for CMP205 Lab 6, built in the Lecture 6 live demo. It implements part of the
university class diagram from the lecture: `Person`, `Student`, `Department` and `University`. The rest of the design (`Staff`,
`Module`, `Enrolment`) is for you to build in the lab.

Open `UniversitySystemStarter.sln` in Visual Studio 2022 (.NET 8 console app) and build it once
(Build > Build Solution) before using Class View or the class diagram.

## Build order used in the demo

1. **Adding classes.** Project > Add > Class, one class per file, file name = class name.
2. **Person.** Abstract class with properties, a constructor, a virtual `GetContactInfo()` and an
   abstract `GetRole()`. Trying `new Person(...)` gives a compiler error.
3. **Student.** Inherits from `Person`, calls its constructor with `: base(...)`, and overrides
   `GetRole()`.
4. **Department.** Aggregation: students are created outside and added with `AddStudent()`,
   which also records the department on the student.
5. **University.** Composition: `AddDepartment()` creates the department itself.
6. **Main.** Build a small scenario and run it. Then right-click the project > View > View Class
   Diagram, and use Show as Association / Show as Collection Association on properties to draw
   the relationships. Visual Studio does not show aggregation, composition or multiplicities.

## Where the code differs from the diagram

- `GetRole()` is not in the diagram. It is there to show an abstract method.
- `AddDepartment(name, school)` creates the department instead of taking one as a parameter,
  so the University owns it (composition).
- Names follow C# conventions (PascalCase methods and properties).

## Expected output

```
Student: Amira, 07000 000003, 3 Perth Road
Student: Ben, 07000 000004, 4 Perth Road
Ben is registered with Games
Games department found: False
Ben still exists: Ben
```
