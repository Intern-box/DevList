using System;
using System.IO;

namespace LogSpace
{
    public static class Log
    {
        public static void ErrorHandler(string errorDescription)
        {
            File.AppendAllText($"{Environment.CurrentDirectory}\\DevList.log", $"{DateTime.Now} - {errorDescription}\r\n");
        }
    }
}
