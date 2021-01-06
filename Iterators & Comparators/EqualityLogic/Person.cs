using System;
using System.Collections.Generic;
using System.Text;

namespace EqualityLogic
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }

        public int Age { get; set; }


        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override bool Equals(object obj)
        {
            if(this.GetHashCode() == obj.GetHashCode())
            {
                return true;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return this.Name.GetHashCode() + this.Age.GetHashCode();
        }
        public int CompareTo(Person other)
        {
            if (this.Name.CompareTo(other.Name) != 0)
            {
                return this.Name.CompareTo(other.Name);
            }
            if (this.Age.CompareTo(other.Age) != 0)
            {
                return this.Age.CompareTo(other.Age);
            }
            
            return 0;
        }
    }
}
