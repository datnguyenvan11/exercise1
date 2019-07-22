using System;

namespace Exercise1
{
    public class People
    {
        public string Name { get; set; }
        public bool Gender { get; set; }
        public int Age { get; set; }

        public People()
        {
        }

        public People(string name, bool gender, int age)
        {
            Name = name;
            Gender = gender;
            Age = age;
        }

        public override string ToString()
        {
            var gennder = Gender ? "Male" : "female";
            return $"Name = {Name},  Gender = {gennder},  Age = {Age}";
        }
    }
}