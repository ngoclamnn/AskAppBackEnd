using System;
using System.Data.Entity;

namespace AskAppBackEnd.Core
{
    public interface IUnitOfWork : IDisposable
    {
        DbContext DbContext { get; }
        DbSet<T> Set<T>() where T : class;
        void Save();

    }
}