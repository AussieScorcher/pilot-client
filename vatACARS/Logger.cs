﻿using System;
using System.IO;

namespace vatACARS
{
    public class Logger
    {
        private string dirPath = $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\\vatACARS";
        private string name;

        public Logger(string Name)
        {
            name = Name;
        }

        public void Log(string msg)
        {
            try
            {
                using (StreamWriter w = File.AppendText($"{dirPath}\\PilotClient.log"))
                {
                    w.WriteLine("{0} [{1}]: {2}", DateTime.UtcNow.ToLongTimeString(), name, msg);
                }
            }
            catch
            {
            }
        }
    }
}