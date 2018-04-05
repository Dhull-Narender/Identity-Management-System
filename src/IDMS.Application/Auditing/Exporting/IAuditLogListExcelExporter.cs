using System.Collections.Generic;
using IDMS.Auditing.Dto;
using IDMS.Dto;

namespace IDMS.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);
    }
}
