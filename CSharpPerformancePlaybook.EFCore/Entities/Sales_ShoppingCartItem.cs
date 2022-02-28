// <auto-generated>
// ReSharper disable All

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpPerformancePlaybook.EFCore
{
    // ShoppingCartItem
    /// <summary>
    /// Contains online customer orders until the order is submitted or cancelled.
    /// </summary>
    public class Sales_ShoppingCartItem
    {
        /// <summary>
        /// Primary key for ShoppingCartItem records.
        /// </summary>
        public int ShoppingCartItemId { get; set; } // ShoppingCartItemID (Primary key)

        /// <summary>
        /// Shopping cart identification number.
        /// </summary>
        public string ShoppingCartId { get; set; } // ShoppingCartID (length: 50)

        /// <summary>
        /// Product quantity ordered.
        /// </summary>
        public int Quantity { get; set; } // Quantity

        /// <summary>
        /// Product ordered. Foreign key to Product.ProductID.
        /// </summary>
        public int ProductId { get; set; } // ProductID

        /// <summary>
        /// Date the time the record was created.
        /// </summary>
        public DateTime DateCreated { get; set; } // DateCreated

        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        public Sales_ShoppingCartItem()
        {
            Quantity = 1;
            DateCreated = DateTime.Now;
            ModifiedDate = DateTime.Now;
        }
    }

}
// </auto-generated>
