using System;
using System.IO;

namespace LogSpace
{
    public static class Log
    {
        public static void ErrorHandler(string Folder, string errorDescription)
        {
            File.AppendAllText($"{Folder}\\DevList.log", $"{DateTime.Now} - {errorDescription}\r\n");
        }
    }
}