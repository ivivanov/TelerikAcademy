using System;
namespace task3_ClassAnimal
{
    public enum Gender
    { 
        female,
        male
    }
    public class Animal
    {
        #region Fields
        
        private byte age;
        private string name;
        private Gender sex;
        
        #endregion
        
        #region Constructors
        
        public Animal(byte age, string name, Gender sex)
        {
            this.age = age;
            this.name = name;
            this.sex = sex;
        }

        #endregion
        
        #region Properties
            
        public Gender Sex
        {
            get
            {
                return this.sex;
            }
            set
            {
                this.sex = value;
            }
        }

        public byte Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }
            
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
            
 
        #endregion

        #region Methods

        #endregion
    }
}
