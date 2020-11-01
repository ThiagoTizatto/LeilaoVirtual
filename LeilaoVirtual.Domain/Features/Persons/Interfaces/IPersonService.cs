using System;
using System.Collections.Generic;
using System.Text;

namespace LeilaoVirtual.Domain.Features.Persons.Interfaces
{
    public interface IPersonService
    {
        Person Add(Person entity);
        Person GetById(Guid id);
        IList<Person> GetAll();
        void Update(Person entity);
        void Delete(Person entity);
    }
}
