using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Task1
{
    class SystemMonitor
    {
        public static string MachineName
        {
            get
            {
                return $"Machine name is |{Environment.MachineName}|";
            }
        }

        public static string OSVersion
        {
            get
            {
                return $"OS version is |{Environment.OSVersion}|";
            }
        }

        public static string UserName
        {
            get
            {
                return $"User name is |{Environment.UserName}|";
            }
        }

        public static string ProcessActiveNow
        {
            get
            {
                List<string> processes = new List<string>();
                foreach (var process in Process.GetProcesses())
                {
                    processes.Add(process.ProcessName);
                }

                string result = "Process active is:\n-----------\n";
                foreach (var processName in processes)
                {
                    result += processName + "\n";
                }

                return result + "-----------\n";
            }
        }


    }
}
