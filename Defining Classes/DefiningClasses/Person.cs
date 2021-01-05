﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		private int age;

		public int Age
		{
			get { return age; }
			set { age = value; }
		}
		public Person()
		{
			this.Name = "No name";
			this.Age = 1;
		}
		public Person(int age)
			:this()
		{
			this.Age = age;
		}
		public Person(string name, int age)
			:this()
		{
			this.Name = name;
			this.Age = age;
		}

		public override string ToString()
		{
			return $"{this.Name} - {this.Age}";
		}
	}
}
