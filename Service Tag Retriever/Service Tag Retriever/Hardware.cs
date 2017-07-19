using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Diagnostics;

namespace Service_Tag_Retriever
{
    class Hardware
    {
        public static string GetBIOSserNo()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS");

            foreach (ManagementObject wmi in searcher.Get())
            {
                try
                {
                    return wmi.GetPropertyValue("SerialNumber").ToString();

                }

                catch { }
            }
            return "BIOS Serial Number: Unknown";
        }

        public static string GetUser()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT Username FROM Win32_ComputerSystem");
            ManagementObjectCollection collection = searcher.Get();
            string username = (string)collection.Cast<ManagementBaseObject>().First()["UserName"];
            return username;
            
        }
     
    }
}
