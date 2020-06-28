//-------------------------------------------------------------------------------------------------
//
// Logger.cs -- The Logger class.
//
// Copyright (c) 2020. All rights reserved.
//
//-------------------------------------------------------------------------------------------------

using System;
using System.IO;

namespace BusinessRule
{
    /// <summary>
    /// Logger class
    /// </summary>
    public class Logger
    {
        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// Log file path
        /// </summary>
        static string file = Path.Combine(Environment.CurrentDirectory, "Log.txt");

        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// Log method
        /// </summary>
        /// <param name="text">string text</param>
        public static void Log(string text)
        {
            if(!string.IsNullOrWhiteSpace(text))
                File.AppendAllLines(file, new string[] { text });
        }
    }
}
