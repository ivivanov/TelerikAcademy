/*
* Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address,
* mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties. 
* Override the standard methods, inherited by  System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
* Add implementations of the ICloneable interface. 
* The Clone() method should deeply copy all object's fields into a new object of type Student.
* Implement the  IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) and by 
* social security number (as second criteria, in increasing order).
*/
using System;
using System.Linq;

namespace Student
{
    public class Student : ICloneable, IComparable<Student>
    {
        #region Fields
        
        private string firstName;
        private string middleName;
        private string lastName;
        private string ssn;
        private string address;
        private string mobilePhone;
        private string email;
        private byte course;
        private Specialties specialty;
        private Universities university;
        private Faculties faculty;
        
        #endregion
        
        #region Constructors
        
        public Student(
            string firstName,
            string middleName,
            string lastName,
            string ssn,
            string address,
            string mobilePhone,
            string email,
            byte course,
            Specialties specialty,
            Universities university,
            Faculties faculty)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.ssn = ssn;
            this.address = address;
            this.mobilePhone = mobilePhone;
            this.email = email;
            this.course = course;
            this.specialty = specialty;
            this.university = university;
            this.faculty = faculty;
        }
        
        private Student() : this(null,null,null,null,null,null,null,0,Specialties.Unknown,Universities.Unknown,Faculties.Unknown)
        {
        }
        
        #endregion
        
        #region Properties
        
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }
        
        public string MiddleName
        {
            get
            {
                return this.middleName;
            }
            set
            {
                this.middleName = value;
            }
        }
        
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }
        
        public string SSN
        {
            get
            {
                return this.ssn;
            }
            set
            {
                this.ssn = value;
            }
        }
        
        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                this.address = value;
            }
        }
        
        public string MobilePhone
        {
            get
            {
                return this.mobilePhone;
            }
            set
            {
                this.mobilePhone = value;
            }
        }
        
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }
        
        public byte Course
        {
            get
            {
                return this.course;
            }
            set
            {
                this.course = value;
            }
        }
        
        public Specialties Specialty
        {
            get
            {
                return this.specialty;
            }
            set
            {
                this.specialty = value;
            }
        }
        
        public Universities University
        {
            get
            {
                return this.university;
            }
            set
            {
                this.university = value;
            }
        }
        
        public Faculties Faculty
        {
            get
            {
                return this.faculty;
            }
            set
            {
                this.faculty = value;
            }
        }
        
        #endregion
        
        #region Methods
        
        public override bool Equals(object param)
        {
            Student student = param as Student;
            if (student == null)
            {
                return false;
            }
            
            if (!(Object.Equals(this.firstName, student.firstName) &&
                  Object.Equals(this.middleName, student.middleName) &&
                  Object.Equals(this.lastName, student.lastName) &&
                  Object.Equals(this.ssn, student.ssn) &&
                  Object.Equals(this.address, student.address) &&
                  Object.Equals(this.mobilePhone, student.mobilePhone) &&
                  Object.Equals(this.email, student.email) &&
                  (this.course == student.course) &&
                  Object.Equals(this.specialty, student.specialty) &&
                  Object.Equals(this.university, student.university) &&
                  Object.Equals(this.faculty, student.faculty)))
            {
                return false;
            }
            return true;
        }
        
        public override string ToString()
        {
            return String.Format("Name: {0} {1} {2}\nUniversity: {3}, {4}, {5}, course: {6}, SSN: {7}\nPersonal info: {8}, {9}, {10} ",
                this.firstName, //{0}
                this.middleName, //{1}
                this.lastName, //{2}
                this.university, //{3}
                this.faculty, //{4}
                this.specialty, //{5}
                this.course, //{6}
                this.ssn, //{7}
                this.address, //{8}
                this.mobilePhone, //{9}
                this.email);//{10}
        }
        
        public override int GetHashCode()
        {
            return new { A = FirstName, B = MiddleName, C = LastName, D = SSN, E = Address, F = MobilePhone, G = Email, H = Course, J = University, K = Faculty, L = Specialty }.GetHashCode();
        }
        
        public static bool operator ==(Student a, Student b)
        {
            return Student.Equals(a, b);
        }
        
        public static bool operator !=(Student a, Student b)
        {
            return !Student.Equals(a, b);
        }
        
        public Student Clone()
        {
            Student clone = new Student();
            clone.firstName = (string)this.firstName.Clone();
            clone.middleName = (string)this.middleName.Clone();
            clone.lastName = (string)this.lastName.Clone();
            clone.ssn = (string)this.ssn.Clone();
            clone.address = (string)this.address.Clone();
            clone.mobilePhone = (string)this.mobilePhone.Clone();
            clone.email = (string)this.email.Clone();
            clone.course = this.course;
            clone.specialty = this.specialty;
            clone.university = this.university;
            clone.faculty = this.faculty;
            return clone;
        }
        
        object ICloneable.Clone()
        {
            return this.Clone();
        }
        
        public int CompareTo(Student other)
        {
            if (this == other)
            {
                return 0;
            }
            Student[] students = { this, other };
            var compareResult = from student in students
                                orderby student.firstName, student.middleName, student.lastName, student.ssn
                                select student;
            if (compareResult.First().Equals(this))
            {
                return -1;
            }
            return 1;
        }
    
        #endregion
    }
}
