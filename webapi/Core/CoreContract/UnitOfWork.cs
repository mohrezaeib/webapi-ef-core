using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.Core.CoreContract
{
    interface UnitOfWork
    {
        public ICarRepository Car { get; set; }
        public IUserRepository User { get; set; }
    }
}
