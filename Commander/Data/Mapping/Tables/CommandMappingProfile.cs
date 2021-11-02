using Commander.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Commander.Data.Mapping.Tables {
    internal class CommandMappingProfile : EntityMappingConfiguration<Command> {
        public override void Map(EntityTypeBuilder<Command> builder) {
            builder.ToTable("dbo.Commanders");
            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("smallint").IsRequired(true);
            builder.Property(x => x.HowTo).HasColumnName(@"HowTo").HasColumnType("nvarchar").HasMaxLength(250).IsRequired(true);
            builder.Property(x => x.Line).HasColumnName(@"Line").HasColumnType("nvarchar").HasMaxLength(250).IsRequired(true);
            builder.Property(x => x.Platform).HasColumnName(@"Platform").HasColumnType("nvarchar").HasMaxLength(50).IsRequired(true);
        }
    }
}
