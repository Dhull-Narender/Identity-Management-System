// <auto-generated />

using System.CodeDom.Compiler;
using System.Data.Entity.Migrations.Infrastructure;
using System.Resources;

namespace IDMS.Migrations
{
    [GeneratedCode("EntityFramework.Migrations", "6.1.3-40302")]
    public sealed partial class Added_TenantId_To_BinaryObject : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(Added_TenantId_To_BinaryObject));
        
        string IMigrationMetadata.Id
        {
            get { return "201605051327136_Added_TenantId_To_BinaryObject"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}
