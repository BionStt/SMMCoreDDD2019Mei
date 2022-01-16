using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;
using SumberMas2015.Caching.Enum;

namespace SumberMas2015.Caching.Filters
{
    public class ClearSumberMasCache: ActionFilterAttribute
    {
        private readonly ISumberMasCache _cache;

        private readonly string _cacheKey;
        private readonly CacheDivision _division;
        private readonly SumberMasCacheType _type = SumberMasCacheType.None;

        public ClearSumberMasCache(SumberMasCacheType type, ISumberMasCache cache)
        {
            _cache = cache;
            _type = type;
        }

        public ClearSumberMasCache(CacheDivision division, string cacheKey, ISumberMasCache cache)
        {
            _division = division;
            _cacheKey = cacheKey;
            _cache = cache;
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            base.OnActionExecuted(context);
            switch (_type)
            {
                case SumberMasCacheType.None:
                    _cache.Remove(_division, _cacheKey);
                    break;
                case SumberMasCacheType.Subscription:
                    _cache.Remove(CacheDivision.General, "rss");
                    _cache.Remove(CacheDivision.General, "atom");
                    _cache.Remove(CacheDivision.RssCategory);
                    break;
                case SumberMasCacheType.SiteMap:
                    _cache.Remove(CacheDivision.General, "sitemap");
                    break;
                case SumberMasCacheType.PagingCount:
                    _cache.Remove(CacheDivision.General, "postcount");
                    _cache.Remove(CacheDivision.PostCountCategory);
                    _cache.Remove(CacheDivision.PostCountTag);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
