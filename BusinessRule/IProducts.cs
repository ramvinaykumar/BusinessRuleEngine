//-------------------------------------------------------------------------------------------------
//
// IProducts.cs -- The IProducts Inteface class.
//
// Copyright (c) 2020. All rights reserved.
//
//-------------------------------------------------------------------------------------------------

namespace BusinessRule
{
    //----------------------------------------------------------------------------------------------
    /// <summary>
    /// IProducts interface with property and method
    /// </summary>
    public interface IProducts
    {
        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// Product ID
        /// </summary>
        int ProductId { get; set; }

        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// Product Name
        /// </summary>
        string ProductName { get; set; }

        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// It tell what is the product MRP
        /// </summary>
        decimal ProductMRP { get; set; }

        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// Order Execution method
        /// </summary>
        void OrderExecution();
    }
}
