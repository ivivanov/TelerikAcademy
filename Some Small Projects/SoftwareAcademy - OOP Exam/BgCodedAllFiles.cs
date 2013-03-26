using System;
using System.Linq;
using System.Text;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.Reflection;

namespace SoftwareAcademy
{
    public interface ITeacher
    {
        string Name { get; set; }

        void AddCourse(ICourse course);

        string ToString();
    }

    public interface ICourse
    {
        string Name { get; set; }

        ITeacher Teacher { get; set; }

        void AddTopic(string topic);

        string ToString();
    }

    public interface ILocalCourse : ICourse
    {
        string Lab { get; set; }
    }

    public interface IOffsiteCourse : ICourse
    {
        string Town { get; set; }
    }

    public interface ICourseFactory
    {
        ITeacher CreateTeacher(string name);

        ILocalCourse CreateLocalCourse(string name, ITeacher teacher, string lab);

        IOffsiteCourse CreateOffsiteCourse(string name, ITeacher teacher, string town);
    }

    public class CourseFactory : ICourseFactory
    {
        public ITeacher CreateTeacher(string name)
        {
            //throw new NotImplementedException();
            return new Teacher(name);
        }

        public ILocalCourse CreateLocalCourse(string name, ITeacher teacher, string lab)
        {
            //throw new NotImplementedException();
            return new LocalCourse(name, teacher, lab);
        }

        public IOffsiteCourse CreateOffsiteCourse(string name, ITeacher teacher, string town)
        {
            //throw new NotImplementedException();
            return new OffsiteCourse(name, teacher, town);

        }
    }

    public class SoftwareAcademyCommandExecutor
    {
        static void Main()
        {
            string csharpCode = ReadInputCSharpCode();
            CompileAndRun(csharpCode);
        }

        private static string ReadInputCSharpCode()
        {
            StringBuilder result = new StringBuilder();
            string line;
            while ((line = Console.ReadLine()) != "")
            {
                result.AppendLine(line);
            }
            return result.ToString();
        }

        static void CompileAndRun(string csharpCode)
        {
            // Prepare a C# program for compilation
            string[] csharpClass =
            {
                @"using System;
                  using SoftwareAcademy;

                  public class RuntimeCompiledClass
                  {
                     public static void Main()
                     {" +
                csharpCode + @"
                     }
                  }"
            };

            // Compile the C# program
            CompilerParameters compilerParams = new CompilerParameters();
            compilerParams.GenerateInMemory = true;
            compilerParams.TempFiles = new TempFileCollection(".");
            compilerParams.ReferencedAssemblies.Add("System.dll");
            compilerParams.ReferencedAssemblies.Add(Assembly.GetExecutingAssembly().Location);
            CSharpCodeProvider csharpProvider = new CSharpCodeProvider();
            CompilerResults compile = csharpProvider.CompileAssemblyFromSource(
                compilerParams, csharpClass);

            // Check for compilation errors
            if (compile.Errors.HasErrors)
            {
                string errorMsg = "Compilation error: ";
                foreach (CompilerError ce in compile.Errors)
                {
                    errorMsg += "\r\n" + ce.ToString();
                }
                throw new Exception(errorMsg);
            }

            // Invoke the Main() method of the compiled class
            Assembly assembly = compile.CompiledAssembly;
            Module module = assembly.GetModules()[0];
            Type type = module.GetType("RuntimeCompiledClass");
            MethodInfo methInfo = type.GetMethod("Main");
            methInfo.Invoke(null, null);
        }
    }

    public class Course : ICourse
    {
        public string Name { get; set; }

        public ITeacher Teacher { get; set; }

        public List<string> topics;

        public List<string> Topics
        {
            get
            {
                return this.topics;
            }
            set
            {
                this.topics = value;
            }
        }

        public Course(string name, ITeacher teacher = null)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.topics = new List<string>();
        }

        public void AddTopic(string topic)
        {
            this.Topics.Add(topic);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            if (this.Teacher != null)
            {
                result.Append(String.Format("{0}: Name={1}; Teacher={2}", this.GetType().Name, this.Name, this.Teacher.Name));
            }
            else
            {
                result.Append(String.Format("{0}: Name={1}", this.GetType().Name, this.Name));
            }

            if (this.Topics.Count != 0)
            {
                result.Append("; Topics=[");
                for (int i = 0; i < this.Topics.Count; i++)
                {
                    if (i == this.Topics.Count - 1)
                    {
                        break;
                    }
                    result.Append(this.Topics[i]);
                    result.Append(", ");
                }
                result.Append(this.Topics[this.Topics.Count - 1]);
                result.Append(']');
            }

            return result.ToString();
        }
    }

    public class LocalCourse : Course, ILocalCourse
    {
        public string Lab { get; set; }

        public LocalCourse(string name, ITeacher teacher, string lab)
            : base(name, teacher)
        {
            this.Lab = lab;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(base.ToString());

            if (this.Lab != "" && this.Lab != null)
            {
                result.Append(String.Format("; Lab={0}", this.Lab));
            }

            return result.ToString();
        }
    }

    public class OffsiteCourse : Course, IOffsiteCourse
    {
        public string Town { get; set; }

        public OffsiteCourse(string name, ITeacher teacher, string town)
            : base(name, teacher)
        {
            this.Town = town;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(base.ToString());

            if (this.Town != "")
            {
                result.Append(String.Format("; Town={0}", this.Town));
            }

            return result.ToString();
        }
    }

    public class Teacher : ITeacher
    {
        public string Name { get; set; }

        public List<ICourse> courses;

        public Teacher(string name)
        {
            this.Name = name;
            courses = new List<ICourse>();
        }

        public List<ICourse> Courses
        {
            get
            {
                return this.courses;
            }
            set
            {
                this.courses = value;
            }
        }

        public void AddCourse(ICourse course)
        {
            this.Courses.Add(course);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(String.Format("Teacher: Name={0}", this.Name));
            if (this.Courses.Count != 0)
            {
                result.Append("; Courses=[");
                for (int i = 0; i < this.Courses.Count; i++)
                {
                    if (i == this.Courses.Count - 1)
                    {
                        break;
                    }
                    result.Append(this.Courses[i].Name);
                    result.Append(",");
                }
                result.Append(this.Courses[this.Courses.Count - 1].Name);
                result.Append(']');
            }
            return result.ToString();
        }
    }

}
