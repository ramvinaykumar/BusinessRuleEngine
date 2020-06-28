//-------------------------------------------------------------------------------------------------
//
// PhysicalProduct.cs -- The PhysicalProduct class.
//
// Copyright (c) 2020. All rights reserved.
//
//-------------------------------------------------------------------------------------------------

using System;

namespace BusinessRule
{
    //----------------------------------------------------------------------------------------------
    /// <summary>
    /// Class for PhysicalProduct
    /// </summary>
    public class PhysicalProduct : IProducts
    {
        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// Product ID
        /// </summary>
        public int ProductId { get; set; }

        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// Product Name
        /// </summary>
        public string ProductName { get; set; }

        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// It tell what is the product MRP
        /// </summary>
        public decimal ProductMRP { get; set; }

        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// Execute the order process
        /// </summary>
        public virtual void OrderExecution()
        {
            Console.WriteLine("Generate a packing slip for shipping.");

            this.CommisionProcess();
        }

        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// Generate Commision
        /// </summary>
        protected void CommisionProcess()
        {
            Console.WriteLine("Generate a commission from the payment to the agent.");
        }
    }
}
