//-------------------------------------------------------------------------------------------------
//
// Virtual.cs -- The Virtual class.
//
// Copyright (c) 2020. All rights reserved.
//
//-------------------------------------------------------------------------------------------------

using System;

namespace BusinessRule
{
    //----------------------------------------------------------------------------------------------
    /// <summary>
    /// Class for Virtual
    /// </summary>
    public abstract class Virtual : IProducts
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
            Console.WriteLine("Execute default delivery.");
        }
    }
}
