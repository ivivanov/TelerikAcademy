/*
* Create a class student with properties FirstName, LastName, FN, Tel, Email, Marks (a List<int>), GroupNumber. 
* Create a List<Student> with sample students.
*/

using System.Collections.Generic;

namespace ClassStudent
{
    public class Student
    {
        public string FName { get; set; }

        public string LName { get; set; }

        public byte Age { get; set; }

        public int FN { get; set; }

        public string Tel { get; set; }

        public string Email { get; set; }

        public List<byte> Marks { get; set; }

        public byte GroupNumber { get; set; }

        public Group Group { get; set; }

        public override string ToString()
        {
            return FName + " " + LName;
        }

        public static List<Student> students = new List<Student>
        {
            new Student { FName = "Sasho", LName = "Zashev", Age = 18, GroupNumber = 1, Email = "sasho@abv.bg", Tel = "+359887060606", Marks = new List<byte> { 2, 3, 5, 6 }, FN = 111106, Group = new Group { GroupNumber = 1, DepartmentName = "Mathematics" } },
            new Student { FName = "Pesho", LName = "Peshev", Age = 14, GroupNumber = 2, Email = "pesho@gmail.bg", Tel = "+35928686060", Marks = new List<byte> { 2, 3, 5, 5 }, FN = 111107, Group = new Group { GroupNumber = 2, DepartmentName = "Mathematics" } },
            new Student { FName = "Niki", LName = "Nikov", Age = 3, GroupNumber = 1, Email = "niki@yahoo.bg", Tel = "028686601", Marks = new List<byte> { 2, 3, 5, 6, 2, 2, 2, 2 }, FN = 111107, Group = new Group { GroupNumber = 1, DepartmentName = "Informatics" } },
            new Student { FName = "Gosho", LName = "Goshev", Age = 54, GroupNumber = 3, Email = "gosh@anna.bg", Tel = "+359287060606", Marks = new List<byte> { 2, 2, 5, 5 }, FN = 111106, Group = new Group { GroupNumber = 3, DepartmentName = "Informatics" } },
            new Student { FName = "Asen", LName = "Zashev", Age = 22, GroupNumber = 2, Email = "asen@abv.bg", Tel = "0228680606", Marks = new List<byte> { 6, 2, 3, 5, 6 }, FN = 111105, Group = new Group { GroupNumber = 2, DepartmentName = "Mathematics" } }
        };
    }
}
