using Abp.AutoMapper;
using IDMS.Authorization.Users;
using IDMS.Authorization.Users.Dto;
using IDMS.Web.Areas.Mpa.Models.Common;

namespace IDMS.Web.Areas.Mpa.Models.Users
{
    [AutoMapFrom(typeof(GetUserPermissionsForEditOutput))]
    public class UserPermissionsEditViewModel : GetUserPermissionsForEditOutput, IPermissionsEditViewModel
    {
        public User User { get; private set; }

        public UserPermissionsEditViewModel(GetUserPermissionsForEditOutput output, User user)
        {
            User = user;
            output.MapTo(this);
        }
    }
}