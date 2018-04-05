using System.Collections.Generic;
using IDMS.Caching.Dto;

namespace IDMS.Web.Areas.Mpa.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public IReadOnlyList<CacheDto> Caches { get; set; }
    }
}