using System;
using System.Data.Entity;

namespace DiscountCrazyAdmin.Core
{
    public interface IUnitOfWork : IDisposable
    {
        DbContext DbContext { get; }
        DbSet<T> Set<T>() where T : class;
        void Save();

    }
}