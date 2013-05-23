using System;
using System.Collections.Generic;

namespace task1School
{
    public class Course
    {
        private const int MaxStudentsCount = 30;

        private string name;
        private IList<Student> students;

        public Course(string name)
        {
            this.Name = name;
            this.students = new List<Student>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Course name cannot be null or empty");
                }
                this.name = value;
            }
        }

        public IList<Student> Students
        {
            get
            {
                return this.students;
            }
        }

        public void EnrollStudent(Student student)
        {
            foreach (Student iStudent in this.Students)
            {
                if (iStudent.Id == student.Id)
                {
                    throw new InvalidOperationException("The student you are trying to enroll is allready enrolled in this course");
                }
            }

            if (this.Students.Contains(student))
            {
                throw new InvalidOperationException("The student you are trying to enroll is allready enrolled in this course");
            }

            if (this.Students.Count == MaxStudentsCount)
            {
                throw new InvalidOperationException(string.Format("No more students can be enrolled. Max capacity of {0} student was reached", MaxStudentsCount));
            }

            this.Students.Add(student);
        }

        public void DismissStudent(Student student)
        {
            foreach (Student iStudent in this.Students)
            {
                if (iStudent.Id == student.Id)
                {
                    this.Students.Remove(student);

                    return;
                }
            }
            throw new InvalidOperationException("There is no such student in this course");
        }
    }
}