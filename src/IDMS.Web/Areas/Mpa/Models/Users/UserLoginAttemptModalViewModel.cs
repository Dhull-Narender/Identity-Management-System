using System.Collections.Generic;
using IDMS.Authorization.Users.Dto;

namespace IDMS.Web.Areas.Mpa.Models.Users
{
    public class UserLoginAttemptModalViewModel
    {
        public List<UserLoginAttemptDto> LoginAttempts { get; set; }
    }
}