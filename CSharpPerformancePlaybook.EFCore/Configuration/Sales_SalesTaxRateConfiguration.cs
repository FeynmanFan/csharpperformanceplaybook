// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CSharpPerformancePlaybook.EFCore
{
    // SalesTaxRate
    public class Sales_SalesTaxRateConfiguration : IEntityTypeConfiguration<Sales_SalesTaxRate>
    {
        public void Configure(EntityTypeBuilder<Sales_SalesTaxRate> builder)
        {
            builder.ToTable("SalesTaxRate", "Sales");
            builder.HasKey(x => x.SalesTaxRateId).HasName("PK_SalesTaxRate_SalesTaxRateID").IsClustered();

            builder.Property(x => x.SalesTaxRateId).HasColumnName(@"SalesTaxRateID").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.StateProvinceId).HasColumnName(@"StateProvinceID").HasColumnType("int").IsRequired();
            builder.Property(x => x.TaxType).HasColumnName(@"TaxType").HasColumnType("tinyint").IsRequired();
            builder.Property(x => x.TaxRate).HasColumnName(@"TaxRate").HasColumnType("smallmoney").IsRequired();
            builder.Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar(50)").IsRequired().HasMaxLength(50);
            builder.Property(x => x.Rowguid).HasColumnName(@"rowguid").HasColumnType("uniqueidentifier").IsRequired();
            builder.Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            builder.HasIndex(x => x.Rowguid).HasDatabaseName("AK_SalesTaxRate_rowguid").IsUnique();
            builder.HasIndex(x => new { x.StateProvinceId, x.TaxType }).HasDatabaseName("AK_SalesTaxRate_StateProvinceID_TaxType").IsUnique();
        }
    }

}
// </auto-generated>