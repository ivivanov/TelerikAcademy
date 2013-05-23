using System;
using System.Collections.Generic;
using System.Text;

namespace task1School
{
    public class School
    {
        private const int FirstStudentId = 10000;
        private const int LastStudentId = 99999;

        private string name;

        /// <summary>
        /// Student from the list can be get only by his ID.
        /// </summary>
        private Dictionary<int, Student> Students { get; set; }

        /// <summary>
        /// Course from the list can be get only by its registration name.
        /// </summary>
        private Dictionary<string, Course> Courses { get; set; }

        /// <summary>
        /// This field assure that each new student will have unique id.
        /// </summary>
        private int CurrentFreeId { get; set; }

        public School(string name)
        {
            this.Name = name;
            this.Students = new Dictionary<int, Student>();
            this.Courses = new Dictionary<string, Course>();
            this.CurrentFreeId = FirstStudentId;
        }

        /// <summary>
        /// School name
        /// </summary>
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
                    throw new ArgumentException("School name cannot be null or empty");
                }

                this.name = value;
            }
        }

        /// <summary>
        /// Adds new students in the school
        /// First of all one student should be registered in particular school before attending any courses.
        /// </summary>
        /// <param name="student"></param>
        public void AddStudent(string name)
        {
            int id = this.GetNextFreeId();
            Student newStudent = new Student(name, id);
            this.Students.Add(id, newStudent);
        }

        /// <summary>
        /// Adds new courses in the school
        /// In order to become school there should be some courses registered.
        /// </summary>
        /// <param name="name"></param>
        public void AddCourse(string name)
        {
            Course newCourse = new Course(name);
            this.Courses.Add(name, newCourse);
        }

        /// <summary>
        /// Returns string of all students in the school.
        /// </summary>
        /// <returns></returns>
        public string StudentsList()
        {
            if (this.Students.Count == 0)
            {
                return "Sorry, there are no students in this school";
            }

            StringBuilder result = new StringBuilder();
            foreach (var student in this.Students)
            {
                result.AppendLine(String.Format("Id: {0}  Name: {1}", student.Value.Id, student.Value.Name));
            }

            return result.ToString();
        }

        /// <summary>
        /// Returns strign of all courses in the school.
        /// </summary>
        /// <returns></returns>
        public string CoursesList()
        {
            if (this.Courses.Count == 0)
            {
                return "Sorry, there are no courses in this school";
            }

            StringBuilder result = new StringBuilder();
            foreach (var course in this.Courses)
            {
                result.AppendLine(String.Format("Course Name: {0} Enrolled Students: {1}", course.Value.Name, course.Value.Students.Count));
            }

            return result.ToString();
        }

        /// <summary>
        /// Adds stundent to the course students list
        /// </summary>
        /// <param name="courseName"></param>
        /// <param name="studentId"></param>
        public void EnrollStudentToCourse(string courseName, int studentId)
        {
            if (String.IsNullOrEmpty(courseName))
            {
                throw new ArgumentException("Course Name cannot be null or empty");
            }

            if (studentId < FirstStudentId || studentId >= this.CurrentFreeId)
            {
                throw new ArgumentOutOfRangeException(String.Format("Invalid student id. Id must be between first id: {0} and last assigned id: {1}", FirstStudentId, this.CurrentFreeId));
            }

            this.Courses[courseName].EnrollStudent(this.Students[studentId]);
        }

        /// <summary>
        /// Removes student from the course students list
        /// </summary>
        /// <param name="courseName"></param>
        /// <param name="studentId"></param>
        public void DismissStudentFromCourse(string courseName, int studentId)
        {
            if (String.IsNullOrEmpty(courseName))
            {
                throw new ArgumentException("Course Name cannot be null or empty");
            }

            if (studentId < FirstStudentId || studentId >= this.CurrentFreeId)
            {
                throw new ArgumentOutOfRangeException(String.Format("Invalid student id. Id must be between first id: {0} and last assigned id: {1}", FirstStudentId, this.CurrentFreeId));
            }

            this.Courses[courseName].DismissStudent(this.Students[studentId]);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(this.CoursesList());
            result.AppendLine(this.StudentsList());

            return result.ToString();
        }

        private int GetNextFreeId()
        {
            if (this.CurrentFreeId > LastStudentId)
            {
                throw new ArgumentOutOfRangeException(String.Format("Student Id limit reached. Id can be from {0} to {1}", FirstStudentId, LastStudentId));
            }
            int id = this.CurrentFreeId;
            this.CurrentFreeId++;
            return id;
        }
    }
}