using Abp.Notifications;
using IDMS.Dto;

namespace IDMS.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }
    }
}