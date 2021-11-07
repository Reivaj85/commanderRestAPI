using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Commander.Data.Mapping {
    internal abstract class EntityMappingConfiguration<T> : IEntityMappingConfiguration<T> where T : class {
        public abstract void Map(EntityTypeBuilder<T> builder);

        public void Map(ModelBuilder builder) {
            Map(builder.Entity<T>());
        }
    }
}
