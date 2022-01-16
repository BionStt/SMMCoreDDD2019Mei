using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;
using SumberMas2015.Caching.Enum;

namespace SumberMas2015.Caching
{
    public interface ISumberMasCache
    {
        TItem GetOrCreate<TItem>(CacheDivision division, string key, Func<ICacheEntry, TItem> factory);
        Task<TItem> GetOrCreateAsync<TItem>(CacheDivision division, string key, Func<ICacheEntry, Task<TItem>> factory);
        void RemoveAllCache();
        void Remove(CacheDivision division);
        void Remove(CacheDivision division, string key);
    }
}
