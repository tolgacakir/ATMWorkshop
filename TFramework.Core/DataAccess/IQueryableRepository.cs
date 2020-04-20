﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TFramework.Core.Entities;

namespace TFramework.Core.DataAccess
{
    public interface IQueryableRepository<T>
        where T: class, IEntity, new()
    {
        IQueryable<T> Table { get; }
    }
}
