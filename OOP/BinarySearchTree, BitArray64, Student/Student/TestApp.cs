using System;

namespace Student
{
    class TestApp
    {
        static void Main(string[] args)
        {
            Student ahs = new Student("Asd", "Dasd", "Fad", "FN34534", "Sofia, 1400", "+359888888888", "asfd@asf.bg", 3, Specialties.Biologia, Universities.SU, Faculties.FHF);
            Student asd = new Student("Asd", "Dasd", "Fad", "FN34534", "Sofia, 1400", "+359888888888", "asfd@asf.bg", 3, Specialties.Biologia, Universities.SU, Faculties.FHF);
            Student clone = asd.Clone();
            Student notclone = asd;
            clone.FirstName = "AAAAAAAAAAA";
            notclone.FirstName = "ddd";
            Console.WriteLine(asd.FirstName);
            Console.WriteLine(clone.FirstName);
            Console.WriteLine(ahs.CompareTo(clone) == 0);
            Console.WriteLine(ahs.CompareTo(asd));
        }
    }
}
