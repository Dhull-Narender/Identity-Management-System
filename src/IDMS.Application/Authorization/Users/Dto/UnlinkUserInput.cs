using Abp;

namespace IDMS.Authorization.Users.Dto
{
    public class UnlinkUserInput
    {
        public int? TenantId { get; set; }

        public long UserId { get; set; }

        public UserIdentifier ToUserIdentifier() => new UserIdentifier(TenantId, UserId);
    }
}