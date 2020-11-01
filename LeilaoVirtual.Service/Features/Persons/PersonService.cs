using LeilaoVirtual.Domain.Features.Persons;
using LeilaoVirtual.Domain.Features.Persons.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeilaoVirtual.Service.Features.Persons
{
    public class PersonService : IPersonService
    {
        IPersonRepository _repository;
        public PersonService(IPersonRepository repository)
        {
            _repository = repository;
        }
        public Person Add(Person entity)
        {
            entity.Validate();
            return _repository.Add(entity);
        }

        public void Update(Person entity)
        {
            entity.Validate();
            _repository.Update(entity);
        }

        public Person GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public IList<Person> GetAll()
        {
            return _repository.GetAll();
        }

        public void Delete(Person entity)
        {
            _repository.Delete(entity);
        }
    }
}
