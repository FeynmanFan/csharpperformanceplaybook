// <auto-generated>
// ReSharper disable All

using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpPerformancePlaybook.EFCore
{
    // ****************************************************************************************************
    // This is not a commercial licence, therefore only a few tables/views/stored procedures are generated.
    // ****************************************************************************************************

    public class MyDbContext : DbContext, IMyDbContext
    {
        public MyDbContext()
        {
        }

        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public DbSet<Sales_SalesPerson> Sales_SalesPersons { get; set; } // SalesPerson
        public DbSet<Sales_SalesPersonQuotaHistory> Sales_SalesPersonQuotaHistories { get; set; } // SalesPersonQuotaHistory
        public DbSet<Sales_SalesReason> Sales_SalesReasons { get; set; } // SalesReason
        public DbSet<Sales_SalesTaxRate> Sales_SalesTaxRates { get; set; } // SalesTaxRate
        public DbSet<Sales_SalesTerritory> Sales_SalesTerritories { get; set; } // SalesTerritory
        public DbSet<Sales_SalesTerritoryHistory> Sales_SalesTerritoryHistories { get; set; } // SalesTerritoryHistory
        public DbSet<Sales_ShoppingCartItem> Sales_ShoppingCartItems { get; set; } // ShoppingCartItem
        public DbSet<Sales_SpecialOffer> Sales_SpecialOffers { get; set; } // SpecialOffer
        public DbSet<Sales_SpecialOfferProduct> Sales_SpecialOfferProducts { get; set; } // SpecialOfferProduct
        public DbSet<Sales_Store> Sales_Stores { get; set; } // Store

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=.\SQLExpress;Initial Catalog=AdventureWorks2022b;Trusted_Connection=yes;TrustServerCertificate=True");
            }
        }

        public bool IsSqlParameterNull(SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == DBNull.Value);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new Sales_SalesPersonConfiguration());
            modelBuilder.ApplyConfiguration(new Sales_SalesPersonQuotaHistoryConfiguration());
            modelBuilder.ApplyConfiguration(new Sales_SalesReasonConfiguration());
            modelBuilder.ApplyConfiguration(new Sales_SalesTaxRateConfiguration());
            modelBuilder.ApplyConfiguration(new Sales_SalesTerritoryConfiguration());
            modelBuilder.ApplyConfiguration(new Sales_SalesTerritoryHistoryConfiguration());
            modelBuilder.ApplyConfiguration(new Sales_ShoppingCartItemConfiguration());
            modelBuilder.ApplyConfiguration(new Sales_SpecialOfferConfiguration());
            modelBuilder.ApplyConfiguration(new Sales_SpecialOfferProductConfiguration());
            modelBuilder.ApplyConfiguration(new Sales_StoreConfiguration());
        }

    }
}
// </auto-generated>