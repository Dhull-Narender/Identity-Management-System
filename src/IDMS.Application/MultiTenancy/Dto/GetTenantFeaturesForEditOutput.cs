using System.Collections.Generic;
using Abp.Application.Services.Dto;
using IDMS.Editions.Dto;

namespace IDMS.MultiTenancy.Dto
{
    public class GetTenantFeaturesForEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}