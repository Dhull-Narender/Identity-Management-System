using System.Data.Entity.Migrations;

namespace IDMS.Migrations
{
    public partial class Added_LinkUserId_To_AbpUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AbpUsers", "UserLinkId", c => c.Long());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AbpUsers", "UserLinkId");
        }
    }
}
