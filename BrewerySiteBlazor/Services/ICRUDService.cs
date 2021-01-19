﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrewerySiteBlazor.Services
{
        public interface ICRUDService<T, K>
    {
        Task<T[]> GetList();
        Task<K> GetNew();
        Task<K> Get(int id);
        Task Create(K item);
        Task Update(K item);
        Task Delete(int id);
    }
}
