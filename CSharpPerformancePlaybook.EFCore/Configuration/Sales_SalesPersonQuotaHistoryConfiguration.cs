// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CSharpPerformancePlaybook.EFCore
{
    // SalesPersonQuotaHistory
    public class Sales_SalesPersonQuotaHistoryConfiguration : IEntityTypeConfiguration<Sales_SalesPersonQuotaHistory>
    {
        public void Configure(EntityTypeBuilder<Sales_SalesPersonQuotaHistory> builder)
        {
            builder.ToTable("SalesPersonQuotaHistory", "Sales");
            builder.HasKey(x => new { x.BusinessEntityId, x.QuotaDate }).HasName("PK_SalesPersonQuotaHistory_BusinessEntityID_QuotaDate").IsClustered();

            builder.Property(x => x.BusinessEntityId).HasColumnName(@"BusinessEntityID").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.QuotaDate).HasColumnName(@"QuotaDate").HasColumnType("datetime").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.SalesQuota).HasColumnName(@"SalesQuota").HasColumnType("money").IsRequired();
            builder.Property(x => x.Rowguid).HasColumnName(@"rowguid").HasColumnType("uniqueidentifier").IsRequired();
            builder.Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            // Foreign keys
            builder.HasOne(a => a.Sales_SalesPerson).WithMany(b => b.Sales_SalesPersonQuotaHistories).HasForeignKey(c => c.BusinessEntityId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_SalesPersonQuotaHistory_SalesPerson_BusinessEntityID");

            builder.HasIndex(x => x.Rowguid).HasDatabaseName("AK_SalesPersonQuotaHistory_rowguid").IsUnique();
        }
    }

}
// </auto-generated>
