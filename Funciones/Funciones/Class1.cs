using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Management;
using System.Management.Instrumentation;

namespace Funciones
{
    public class Class1
    {
        static void Main(String[] args)
        {
            ManagementObjectSearcher Buscar = new ManagementObjectSearcher("SELECT * FROM Win32_DisplayConfiguration");
            Console.Read();

            foreach (ManagementObject obj in Buscar.Get())
            {
                foreach(PropertyData prop in obj.Properties)
                {
                    if(prop.Name == "Description"){
                        Console.WriteLine("Su tarjeta gráfica es: {0}", prop.Value.ToString());
                    }
                }
            }
        }
    }
}