﻿using System.Collections.Generic;
using Abp.Application.Services.Dto;
using IDMS.Configuration.Tenants.Dto;

namespace IDMS.Web.Areas.Mpa.Models.Settings
{
    public class SettingsViewModel
    {
        public TenantSettingsEditDto Settings { get; set; }
        
        public List<ComboboxItemDto> TimezoneItems { get; set; }
    }
}