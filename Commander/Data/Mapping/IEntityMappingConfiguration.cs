using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Commander.Data.Mapping {
    internal interface IEntityMappingConfiguration {
        void Map(ModelBuilder builder);
    }
    internal interface IEntityMappingConfiguration<T> : IEntityMappingConfiguration where T : class {
        void Map(EntityTypeBuilder<T> builder);
    }
}
