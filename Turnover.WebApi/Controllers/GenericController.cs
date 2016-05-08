using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Turnover.Command.Contract;
using Turnover.Command.Contract.GenericCommands;
using Turnover.Command.Implementation.GenericCommands;
using Turnover.PersistentModel;
using Turnover.Query.Contract;

namespace Turnover.WebApi.Controllers
{
    public class GenericController<TEntity> : ApiController where TEntity : class, IEntity
    {
        private readonly IQueryableDatabase _database;
        private readonly ICommandHandler<IGenericCreateCommand<TEntity>> _createProductCommandHandler;
        private readonly ICommandHandler<IGenericUpdateCommand<TEntity>> _updateProductCommandHandler;
        private readonly ICommandHandler<IGenericDeleteCommand<TEntity>> _deleteProductCommandHandler;

        protected GenericController(IQueryableDatabase database,
            ICommandHandler<IGenericCreateCommand<TEntity>> createProductCommandHandler,
            ICommandHandler<IGenericUpdateCommand<TEntity>> updateProductCommandHandler,
            ICommandHandler<IGenericDeleteCommand<TEntity>> deleteProductCommandHandler)
        {
            _database = database;
            _createProductCommandHandler = createProductCommandHandler;
            _updateProductCommandHandler = updateProductCommandHandler;
            _deleteProductCommandHandler = deleteProductCommandHandler;
        }

        public object Get()
        {
            List<TEntity> entities = _database.Query<TEntity>().Take(10).ToList();
            return entities;
        }

        public object Get(Guid id)
        {
            TEntity entity = _database.Query<TEntity>().FirstOrDefault(product => product.Id == id);
            return entity;
        }

        public void Post(TEntity entity)
        {
            _createProductCommandHandler.Handle(new GenericCreateCommand<TEntity>(entity));
        }

        public void Put(TEntity entity)
        {
            _updateProductCommandHandler.Handle(new GenericUpdateCommand<TEntity>(entity));
        }

        public void Delete(Guid id)
        {
            _deleteProductCommandHandler.Handle(new GenericDeleteCommand<TEntity>(id));
        }
    }
}
