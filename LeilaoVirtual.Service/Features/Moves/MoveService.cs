using LeilaoVirtual.Domain.Features.Moves;
using LeilaoVirtual.Domain.Features.Moves.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeilaoVirtual.Service.Features.Moves
{
    public class MoveService : IMoveService
    {
        IMoveRepository _repository;
        public MoveService(IMoveRepository repository)
        {
            _repository = repository;
        }
        public Move Add(Move entity)
        {
            entity.Validate();
            return _repository.Add(entity);
        }

        public void Update(Move entity)
        {
            entity.Validate();
            _repository.Update(entity);
        }

        public Move GetById(long id)
        {
            return _repository.GetById(id);
        }

        public IList<Move> GetAll()
        {
            return _repository.GetAll();
        }

        public void Delete(Move entity)
        {
            _repository.Delete(entity);
        }

      
    }
}
