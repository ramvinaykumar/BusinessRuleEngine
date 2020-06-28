//-------------------------------------------------------------------------------------------------
//
// OrderItemsEN.cs -- The OrderItemsEN Model class.
//
// Copyright (c) 2020. All rights reserved.
//
//-------------------------------------------------------------------------------------------------

namespace BusinessRule
{
    //----------------------------------------------------------------------------------------------
    /// <summary>
    /// Class for property of OrderItems Entity
    /// </summary>
    public class OrderItemsEN
    {
        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// Product Interface 
        /// </summary>
        public IProducts Product { get; set; }

        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// Product quantity
        /// </summary>
        public int Quantity { get; set; }

        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// Total amount of the product
        /// </summary>
        public decimal TotalAmount { get; set; }

        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// Discount on product
        /// </summary>
        public decimal Discount { get; set; }
    }
}
