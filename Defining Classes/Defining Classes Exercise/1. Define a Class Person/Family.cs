﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> people;

        public List<Person> People
        {
            get { return people; }
            set { people = value; }
        }

        public Family()
        {
            people = new List<Person>();
        }

        public void AddMember(Person member)
        {
            this.people.Add(member);
        }

        public Person GetOldestMember()
        {
            return people.OrderByDescending(p => p.Age).FirstOrDefault();
        }
    }
}
