using AskAppBackEnd.Core;
using System.Data.Entity;

namespace AskAppBackEnd.Data
{
    public class AskAppUnitOfWork : UnitOfWork, IUnitOfWork
    {
        public AskAppUnitOfWork(DbContext context) : base(context)
        {
        }
    }
}
