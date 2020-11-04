using System;
using System.Collections.Generic;
using System.Text;

namespace LeilaoVirtual.Domain.Features.Persons.Interfaces
{
    public interface IPersonService
    {
        Person Add(Person entity);
        Person GetById(long id);
        IList<Person> GetAll();
        void Update(Person entity);
        void Delete(Person entity);
    }
}
