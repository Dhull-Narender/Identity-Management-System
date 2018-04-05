using Abp.Domain.Entities;

namespace IDMS.Entities
{
    public class Product:Entity
    {

        public string Name { get; set; }
        public string Code { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }

        public int Type { get; set; }

    }
}
