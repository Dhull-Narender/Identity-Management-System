using System.Collections.Generic;
using Abp.Application.Services.Dto;
using IDMS.Editions.Dto;

namespace IDMS.Web.Areas.Mpa.Models.Common
{
    public interface IFeatureEditViewModel
    {
        List<NameValueDto> FeatureValues { get; set; }

        List<FlatFeatureDto> Features { get; set; }
    }
}