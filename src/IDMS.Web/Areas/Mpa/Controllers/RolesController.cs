﻿using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Abp.Application.Services.Dto;
using Abp.Web.Mvc.Authorization;
using IDMS.Authorization;
using IDMS.Authorization.Permissions;
using IDMS.Authorization.Roles;
using IDMS.Web.Areas.Mpa.Models.Roles;
using IDMS.Web.Controllers;

namespace IDMS.Web.Areas.Mpa.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Roles)]
    public class RolesController : IDMSControllerBase
    {
        private readonly IRoleAppService _roleAppService;
        private readonly IPermissionAppService _permissionAppService;

        public RolesController(
            IRoleAppService roleAppService,
            IPermissionAppService permissionAppService)
        {
            _roleAppService = roleAppService;
            _permissionAppService = permissionAppService;
        }

        public ActionResult Index()
        {
            var permissions = _permissionAppService.GetAllPermissions()
                                                   .Items
                                                   .Select(p => new ComboboxItemDto(p.Name, new string('-', p.Level * 2) + " " + p.DisplayName))
                                                   .ToList();

            permissions.Insert(0, new ComboboxItemDto("", ""));
            var model = new RoleListViewModel
            {
                Permissions = permissions
            };

            return View(model);
        }

        [AbpMvcAuthorize(AppPermissions.Pages_Administration_Roles_Create, AppPermissions.Pages_Administration_Roles_Edit)]
        public async Task<PartialViewResult> CreateOrEditModal(int? id)
        {
            var output = await _roleAppService.GetRoleForEdit(new NullableIdDto { Id = id });
            var viewModel = new CreateOrEditRoleModalViewModel(output);

            return PartialView("_CreateOrEditModal", viewModel);
        }
    }
}