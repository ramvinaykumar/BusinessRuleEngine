//-------------------------------------------------------------------------------------------------
//
// Book.cs -- The Book class.
//
// Copyright (c) 2020. All rights reserved.
//
//-------------------------------------------------------------------------------------------------

using System;

namespace BusinessRule
{
    //----------------------------------------------------------------------------------------------
    /// <summary>
    /// Class for Book
    /// </summary>
    public class Book : PhysicalProduct
    {
        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// Execute the order process
        /// </summary>
        public override void OrderExecution()
        {
            Console.WriteLine("Create a duplicate packing slip for the royalty department.");

            base.CommisionProcess();
        }
    }
}
