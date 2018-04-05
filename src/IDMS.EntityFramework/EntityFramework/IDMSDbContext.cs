using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using IDMS.Authorization.Roles;
using IDMS.Authorization.Users;
using IDMS.Chat;
using IDMS.Entities;
using IDMS.Friendships;
using IDMS.MultiTenancy;
using IDMS.Storage;

namespace IDMS.EntityFramework
{
    /* Constructors of this DbContext is important and each one has it's own use case.
     * - Default constructor is used by EF tooling on design time.
     * - constructor(nameOrConnectionString) is used by ABP on runtime.
     * - constructor(existingConnection) is used by unit tests.
     * - constructor(existingConnection,contextOwnsConnection) can be used by ABP if DbContextEfTransactionStrategy is used.
     * See http://www.aspnetboilerplate.com/Pages/Documents/EntityFramework-Integration for more.
     */

    public class IDMSDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        /* Define an IDbSet for each entity of the application */

        public virtual IDbSet<BinaryObject> BinaryObjects { get; set; }

        public virtual IDbSet<Product> Products { get; set; }

        public virtual IDbSet<Friendship> Friendships { get; set; }

        public virtual IDbSet<ChatMessage> ChatMessages { get; set; }

        public IDMSDbContext()
            : base("Default")
        {
            
        }

        public IDMSDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        public IDMSDbContext(DbConnection existingConnection)
           : base(existingConnection, false)
        {

        }

        public IDMSDbContext(DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
