//-------------------------------------------------------------------------------------------------
//
// Membership.cs -- The Membership class.
//
// Copyright (c) 2020. All rights reserved.
//
//-------------------------------------------------------------------------------------------------

using System;

namespace BusinessRule
{
    //----------------------------------------------------------------------------------------------
    /// <summary>
    /// Class for Membership
    /// </summary>
    public class Membership : Virtual
    {
        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// It will whether active or not
        /// </summary>
        private bool isActive = true;

        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// Membership constructor (Parameterized constructor)
        /// </summary>
        public Membership(bool isActive)
        {
            this.isActive = isActive;
        }

        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// Execute the order process
        /// </summary>
        public override void OrderExecution()
        {
            if (isActive)
            {
                ActivateMemebership();
            }
            else
            {
                UpdgradeMemebership();
            }

            Console.WriteLine("Send E-mail to the owner and inform them of the activation/upgrade.");
        }

        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// Activate Memebership
        /// </summary>
        private void ActivateMemebership()
        {
            Console.WriteLine("Activate that membership.");
        }

        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// Updgrade Memebership
        /// </summary>
        private void UpdgradeMemebership()
        {
            Console.WriteLine("Apply for upgrade.");
        }
    }
}
