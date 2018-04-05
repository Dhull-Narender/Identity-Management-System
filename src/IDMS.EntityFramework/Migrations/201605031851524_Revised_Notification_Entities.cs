using System.Data.Entity.Migrations;

namespace IDMS.Migrations
{
    public partial class Revised_Notification_Entities : DbMigration
    {
        public override void Up()
        {
            RenameColumn("dbo.AbpUserNotifications", "NotificationId", "TenantNotificationId");
        }
        
        public override void Down()
        {
            RenameColumn("dbo.AbpUserNotifications", "TenantNotificationId", "NotificationId");
        }
    }
}
