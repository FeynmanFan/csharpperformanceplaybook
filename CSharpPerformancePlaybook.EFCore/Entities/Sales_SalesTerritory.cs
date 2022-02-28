// <auto-generated>
// ReSharper disable All

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpPerformancePlaybook.EFCore
{
    // SalesTerritory
    /// <summary>
    /// Sales territory lookup table.
    /// </summary>
    public class Sales_SalesTerritory
    {
        /// <summary>
        /// Primary key for SalesTerritory records.
        /// </summary>
        public int TerritoryId { get; set; } // TerritoryID (Primary key)

        /// <summary>
        /// Sales territory description
        /// </summary>
        public string Name { get; set; } // Name (length: 50)

        /// <summary>
        /// ISO standard country or region code. Foreign key to CountryRegion.CountryRegionCode.
        /// </summary>
        public string CountryRegionCode { get; set; } // CountryRegionCode (length: 3)

        /// <summary>
        /// Geographic area to which the sales territory belong.
        /// </summary>
        public string Group { get; set; } // Group (length: 50)

        /// <summary>
        /// Sales in the territory year to date.
        /// </summary>
        public decimal SalesYtd { get; set; } // SalesYTD

        /// <summary>
        /// Sales in the territory the previous year.
        /// </summary>
        public decimal SalesLastYear { get; set; } // SalesLastYear

        /// <summary>
        /// Business costs in the territory year to date.
        /// </summary>
        public decimal CostYtd { get; set; } // CostYTD

        /// <summary>
        /// Business costs in the territory the previous year.
        /// </summary>
        public decimal CostLastYear { get; set; } // CostLastYear

        /// <summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        /// </summary>
        public Guid Rowguid { get; set; } // rowguid

        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation

        /// <summary>
        /// Child Sales_SalesPersons where [SalesPerson].[TerritoryID] point to this entity (FK_SalesPerson_SalesTerritory_TerritoryID)
        /// </summary>
        public virtual ICollection<Sales_SalesPerson> Sales_SalesPersons { get; set; } // SalesPerson.FK_SalesPerson_SalesTerritory_TerritoryID

        /// <summary>
        /// Child Sales_SalesTerritoryHistories where [SalesTerritoryHistory].[TerritoryID] point to this entity (FK_SalesTerritoryHistory_SalesTerritory_TerritoryID)
        /// </summary>
        public virtual ICollection<Sales_SalesTerritoryHistory> Sales_SalesTerritoryHistories { get; set; } // SalesTerritoryHistory.FK_SalesTerritoryHistory_SalesTerritory_TerritoryID

        public Sales_SalesTerritory()
        {
            SalesYtd = 0.00m;
            SalesLastYear = 0.00m;
            CostYtd = 0.00m;
            CostLastYear = 0.00m;
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
            Sales_SalesPersons = new List<Sales_SalesPerson>();
            Sales_SalesTerritoryHistories = new List<Sales_SalesTerritoryHistory>();
        }
    }

}
// </auto-generated>
