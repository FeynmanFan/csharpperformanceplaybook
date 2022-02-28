// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CSharpPerformancePlaybook.EFCore
{
    // ShoppingCartItem
    public class Sales_ShoppingCartItemConfiguration : IEntityTypeConfiguration<Sales_ShoppingCartItem>
    {
        public void Configure(EntityTypeBuilder<Sales_ShoppingCartItem> builder)
        {
            builder.ToTable("ShoppingCartItem", "Sales");
            builder.HasKey(x => x.ShoppingCartItemId).HasName("PK_ShoppingCartItem_ShoppingCartItemID").IsClustered();

            builder.Property(x => x.ShoppingCartItemId).HasColumnName(@"ShoppingCartItemID").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.ShoppingCartId).HasColumnName(@"ShoppingCartID").HasColumnType("nvarchar(50)").IsRequired().HasMaxLength(50);
            builder.Property(x => x.Quantity).HasColumnName(@"Quantity").HasColumnType("int").IsRequired();
            builder.Property(x => x.ProductId).HasColumnName(@"ProductID").HasColumnType("int").IsRequired();
            builder.Property(x => x.DateCreated).HasColumnName(@"DateCreated").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            builder.HasIndex(x => new { x.ShoppingCartId, x.ProductId }).HasDatabaseName("IX_ShoppingCartItem_ShoppingCartID_ProductID");
        }
    }

}
// </auto-generated>
