// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CSharpPerformancePlaybook.EFCore
{
    // SalesTerritoryHistory
    public class Sales_SalesTerritoryHistoryConfiguration : IEntityTypeConfiguration<Sales_SalesTerritoryHistory>
    {
        public void Configure(EntityTypeBuilder<Sales_SalesTerritoryHistory> builder)
        {
            builder.ToTable("SalesTerritoryHistory", "Sales");
            builder.HasKey(x => new { x.BusinessEntityId, x.StartDate, x.TerritoryId }).HasName("PK_SalesTerritoryHistory_BusinessEntityID_StartDate_TerritoryID").IsClustered();

            builder.Property(x => x.BusinessEntityId).HasColumnName(@"BusinessEntityID").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.TerritoryId).HasColumnName(@"TerritoryID").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.StartDate).HasColumnName(@"StartDate").HasColumnType("datetime").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.EndDate).HasColumnName(@"EndDate").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Rowguid).HasColumnName(@"rowguid").HasColumnType("uniqueidentifier").IsRequired();
            builder.Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            // Foreign keys
            builder.HasOne(a => a.Sales_SalesPerson).WithMany(b => b.Sales_SalesTerritoryHistories).HasForeignKey(c => c.BusinessEntityId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_SalesTerritoryHistory_SalesPerson_BusinessEntityID");
            builder.HasOne(a => a.Sales_SalesTerritory).WithMany(b => b.Sales_SalesTerritoryHistories).HasForeignKey(c => c.TerritoryId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_SalesTerritoryHistory_SalesTerritory_TerritoryID");

            builder.HasIndex(x => x.Rowguid).HasDatabaseName("AK_SalesTerritoryHistory_rowguid").IsUnique();
        }
    }

}
// </auto-generated>