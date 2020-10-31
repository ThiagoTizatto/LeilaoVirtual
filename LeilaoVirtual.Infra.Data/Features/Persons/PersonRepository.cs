using LeilaoVirtual.Domain.Features.Persons;
using LeilaoVirtual.Domain.Features.Persons.Interfaces;
using LeilaoVirtual.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeilaoVirtual.Infra.Data.Features.Persons
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        public PersonRepository(LeilaoDbContext db) : base(db)
        {
        }
    }
}
