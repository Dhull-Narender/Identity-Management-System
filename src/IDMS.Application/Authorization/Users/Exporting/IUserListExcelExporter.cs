using System.Collections.Generic;
using IDMS.Authorization.Users.Dto;
using IDMS.Dto;

namespace IDMS.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}