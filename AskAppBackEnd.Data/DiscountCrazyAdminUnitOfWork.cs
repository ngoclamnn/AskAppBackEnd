using DiscountCrazyAdmin.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DiscountCrazyAdmin.Data
{
    public class DiscountCrazyAdminUnitOfWork : UnitOfWork, IUnitOfWork
    {
        public DiscountCrazyAdminUnitOfWork(DbContext context) : base(context)
        {
        }
    }
}
