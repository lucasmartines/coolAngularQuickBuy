using System;

namespace QuickBuy.Dominio.Contratos
{
    public interface IBaseRepositorio<TEntity>:IDisposable where TEntity:class
    {
        TEntity ObterPorId(int Id);
        IEquatable<TEntity> ObterTodos();

        void Atualizar(TEntity entity);
        void Remover(TEntity entity);
        void Adicionar(TEntity e);

    }
}
