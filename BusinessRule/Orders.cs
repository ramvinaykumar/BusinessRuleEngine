//-------------------------------------------------------------------------------------------------
//
// Orders.cs -- The Orders Model class.
//
// Copyright (c) 2020. All rights reserved.
//
//-------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace BusinessRule
{
    //----------------------------------------------------------------------------------------------
    /// <summary>
    /// Class
    /// </summary>
    public class Orders
    {
        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// OrderItemsEN object
        /// </summary>
        public List<OrderItemsEN> OrderItem { get; set; }

        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// Total amount of the product
        /// </summary>
        public decimal Total { get; set; }

        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// PaymentInfo object
        /// </summary>
        PaymentInfo objPayment = new PaymentInfo();

        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// Constructor with parameter
        /// </summary>
        public Orders(List<OrderItemsEN> orderItems)
        {
            this.OrderItem = orderItems;
        }

        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// Processing the order
        /// </summary>
        public void ProcessTheOrder()
        {
            this.Total = OrderItem.Sum(x => (x.Product.ProductMRP * x.Quantity) - x.Discount);

            bool isSuccesfulPayment = objPayment.DoThePayment(this);

            if (isSuccesfulPayment)
            {
                foreach (var orderItem in OrderItem)
                {
                    orderItem.Product.OrderExecution();
                }
            }
        }
    }
}
