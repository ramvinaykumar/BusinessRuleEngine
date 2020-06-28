//-------------------------------------------------------------------------------------------------
//
// UnitTest.cs -- The UnitTest class.
//
// Copyright (c) 2020. All rights reserved.
//
//-------------------------------------------------------------------------------------------------

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;

namespace BusinessRule.Test
{
    //----------------------------------------------------------------------------------------------
    /// <summary>
    /// The UnitTest class
    /// </summary>
    [TestClass]
    public class UnitTest
    {
        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// Log file path
        /// </summary>
        string file = Path.Combine(Environment.CurrentDirectory, "Log.txt");

        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// Tear Down
        /// </summary>
        [TestCleanup]
        public void TearDown()
        {
            File.WriteAllText(file, "");
        }

        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// Test Physical Product
        /// </summary>
        public void TestPhysicalProduct()
        {
            OrderItemsEN orderItem = new OrderItemsEN();
            orderItem.Product = new PhysicalProduct { ProductId = 1, ProductName = "Physical Item", ProductMRP = 10 };
            orderItem.Quantity = 1;

            Orders order = new Orders(new List<OrderItemsEN> { orderItem });

            order.ProcessTheOrder();

            string[] lines = File.ReadAllLines(file);

            Assert.AreEqual(lines.Length, 2);
            Assert.AreEqual(lines[0], "Generate a packing slip for shipping.");
            Assert.AreEqual(lines[1], "Generate a commission payment to the agent.");
        }

        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// Test Book Process
        /// </summary>
        [TestMethod]
        public void TestBookProcess()
        {
            OrderItemsEN orderItem = new OrderItemsEN();
            orderItem.Product = new Book { ProductId = 1, ProductName = "Book", ProductMRP = 10 };
            orderItem.Quantity = 1;

            Orders order = new Orders(new List<OrderItemsEN> { orderItem });

            order.ProcessTheOrder();

            string[] lines = File.ReadAllLines(file);

            Assert.AreEqual(lines.Length, 2);
            Assert.AreEqual(lines[0], "Create a duplicate packing slip for the royalty department.");
            Assert.AreEqual(lines[1], "Generate a commission payment to the agent.");
        }

        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// Test Membership Active
        /// </summary>
        [TestMethod]
        public void TestMembershipActive()
        {
            OrderItemsEN orderItem = new OrderItemsEN();
            orderItem.Product = new Membership(true) { ProductId = 1, ProductName = "Active Membership", ProductMRP = 10 };
            orderItem.Quantity = 1;

            Orders order = new Orders(new List<OrderItemsEN> { orderItem });

            order.ProcessTheOrder();

            string[] lines = File.ReadAllLines(file);

            Assert.AreEqual(lines.Length, 2);
            Assert.AreEqual(lines[0], "Activate that membership.");
            Assert.AreEqual(lines[1], "E-mail the owner and inform them of the activation/upgrade.");
        }

        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// Test Membership Upgrade
        /// </summary>
        [TestMethod]
        public void TestMembershipUpgrade()
        {
            OrderItemsEN orderItem = new OrderItemsEN();
            orderItem.Product = new Membership(false) { ProductId = 1, ProductName = "Active Membership", ProductMRP = 10 };
            orderItem.Quantity = 1;

            Orders order = new Orders(new List<OrderItemsEN> { orderItem });
            order.ProcessTheOrder();

            string[] lines = File.ReadAllLines(file);
            Assert.AreEqual(lines.Length, 2);
            Assert.AreEqual(lines[0], "Apply the upgrade.");
            Assert.AreEqual(lines[1], "E-mail the owner and inform them of the activation/upgrade.");
        }

        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// Test the video
        /// </summary>
        [TestMethod]
        public void TestVideo()
        {
            OrderItemsEN orderItem = new OrderItemsEN();
            orderItem.Product = new Video { ProductId = 1, ProductName = "Other videos", ProductMRP = 10 };
            orderItem.Quantity = 1;

            Orders order = new Orders(new List<OrderItemsEN> { orderItem });
            order.ProcessTheOrder();

            string[] lines = File.ReadAllLines(file);
            Assert.AreEqual(lines.Length, 1);
            Assert.AreEqual(lines[0], "Execute default delivery");
        }

        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// Test the video learing to ski
        /// </summary>
        [TestMethod]
        public void TestVideoLearningToSki()
        {
            OrderItemsEN orderItem = new OrderItemsEN();
            orderItem.Product = new Video { ProductId = 1, ProductName = "Learning to Ski,", ProductMRP = 10 };
            orderItem.Quantity = 1;

            Orders order = new Orders(new List<OrderItemsEN> { orderItem });
            order.ProcessTheOrder();

            string[] lines = File.ReadAllLines(file);
            Assert.AreEqual(lines.Length, 1);
            Assert.AreEqual(lines[0], "First Aid");
        }
    }
}
