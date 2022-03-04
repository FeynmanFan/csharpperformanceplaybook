// <auto-generated>
// ReSharper disable All

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpPerformancePlaybook.EFCore
{
    // SpecialOfferProduct
    /// <summary>
    /// Cross-reference table mapping products to special offer discounts.
    /// </summary>
    public class Sales_SpecialOfferProduct
    {
        /// <summary>
        /// Primary key for SpecialOfferProduct records.
        /// </summary>
        public int SpecialOfferId { get; set; } // SpecialOfferID (Primary key)

        /// <summary>
        /// Product identification number. Foreign key to Product.ProductID.
        /// </summary>
        public int ProductId { get; set; } // ProductID (Primary key)

        /// <summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        /// </summary>
        public Guid Rowguid { get; set; } // rowguid

        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Foreign keys

        /// <summary>
        /// Parent Sales_SpecialOffer pointed by [SpecialOfferProduct].([SpecialOfferId]) (FK_SpecialOfferProduct_SpecialOffer_SpecialOfferID)
        /// </summary>
        public virtual Sales_SpecialOffer Sales_SpecialOffer { get; set; } // FK_SpecialOfferProduct_SpecialOffer_SpecialOfferID

        public Sales_SpecialOfferProduct()
        {
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
        }
    }

}
// </auto-generated>