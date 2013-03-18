/*
* Create a class Person with two fields – name and age. Age can be left unspecified 
* (may contain null value. Override ToString() to display the information of a person and if age is not specified – to say so. 
* Write a program to test this functionality.
*/

using System;

namespace Person
{
    public class Person
    {
        #region Fields
        
        private string name;
        private byte? age;
        
        #endregion
        
        #region Constructors
        
        public Person(string name, byte? age = null)
        {
            this.name = name;
            this.age = age;
        }
        
        #endregion
        
        #region Properties
        
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
        
        public byte? Age
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
        
        #endregion
        
        #region Methods
        
        public override string ToString()
        {
            if (age == null)
            {
                return name + ", age: unknown";
            }
            return name + ", age: " + age;
        }
    
        #endregion
    }
}
