using System;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Contratos
{
    /// <summary>
    /// Define uma interface que só vai trabalhar somente com TEntity, que é uma classe.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IBaseRepositorio<TEntity> : IDisposable where TEntity : class
    {
        // definirá o nome de todos os métodos base para contratos, serão usados pela camada repositório.
        // o nome "TEntity", acima, poderia ser qualquer outro nome.
        // 
        void Adicionar(TEntity entity);
        TEntity ObterPorId(int id);
        IEnumerable<TEntity> ObterTodos();
        void Atualizar(TEntity entity);
        void Remover(TEntity entity);
    }
}
