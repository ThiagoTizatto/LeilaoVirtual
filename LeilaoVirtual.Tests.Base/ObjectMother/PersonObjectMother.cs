using LeilaoVirtual.Domain.Features.Persons;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeilaoVirtual.Tests.Base.ObjectMother
{
    public static class PersonObjectMother
    {

        public static Person Defaut
        {
            get
            {
                var person = new Person()
                {
                    Name = "Person",
                    Age = 2
                };

                return person;
            }
        }

        public static Person Defaut2
        {
            get
            {
                var person = new Person()
                {
                    Name = "Thiago",
                    Age = 26
                };

                return person;
            }
        }

        public static Person Defaut3
        {
            get
            {
                var person = new Person()
                {
                    Name = "Joao",
                    Age = 75
                };

                return person;
            }
        }

        public static Person InvalidName
        {
            get
            {
                var person = new Person()
                {
                   
                    Age = 26
                };

                return person;
            }
        }

        public static Person InvalidAge
        {
            get
            {
                var person = new Person()
                {
                    Name = "Person",
                };

                return person;
            }
        }
    }
}
