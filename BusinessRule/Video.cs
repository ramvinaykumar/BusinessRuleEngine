//-------------------------------------------------------------------------------------------------
//
// Video.cs -- The Video class.
//
// Copyright (c) 2020. All rights reserved.
//
//-------------------------------------------------------------------------------------------------

using System;

namespace BusinessRule
{
    //----------------------------------------------------------------------------------------------
    /// <summary>
    /// Class for Video
    /// </summary>
    public class Video : Virtual
    {
        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// Execute the order process
        /// </summary>
        public override void OrderExecution()
        {
            if (ProductName.Equals("Learning to Ski,"))
            {
                Console.WriteLine("First Aid");
            }
        }
    }
}
