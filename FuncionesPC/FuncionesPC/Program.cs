using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Management.Instrumentation;
using System.Threading;
using System.Runtime.InteropServices;
using System.Net.NetworkInformation;
using Microsoft.Win32;

namespace FuncionesPC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombreProcesoActual = Process.GetCurrentProcess().ProcessName;

            Process[] todosLocales = Process.GetProcesses();

            Console.WriteLine("Están corriendo " + todosLocales.Length + " procesos en este momento.");

            Console.WriteLine("Lista de Procesos: \n");

            foreach(Process p in todosLocales)
            {
                if (p.ProcessName == nombreProcesoActual)
                {
                    Console.WriteLine("");
                    Console.WriteLine(p.ProcessName + " es el proceso actual");
                }
                else
                {
                    Console.WriteLine(p.ProcessName);
                }
            }

            Console.Read();
        }

        public void Procesadores()
        {
            Console.WriteLine("The number of processors " + "on the computer is {0}", Environment.ProcessorCount);
            Console.WriteLine("");

            Console.Read();
        }

        public void RAM()
        {
            //ALTERNATIVA1 - AQUÍ SE DEBE AGREGAR LA REFERENCIA DE VISUALBASIC
            var pcInfo = new Microsoft.VisualBasic.Devices.ComputerInfo();
            double memoriaTotal = pcInfo.TotalPhysicalMemory;
            double disponibleRAM = pcInfo.AvailableVirtualMemory;

            double pctFisica = Math.Round(100 - ((disponibleRAM * 100) / memoriaTotal), 2);

            Console.WriteLine("Se tienen" + Convert.ToInt32(pctFisica) + " disponibles");
            Console.WriteLine("Es decir, lleva un " + Convert.ToString(pctFisica) + "% de consumo.");

            Console.WriteLine("El dispositivo cuenta con " + Convert.ToString(Math.Round(memoriaTotal / 1073741824)) + "GB de memoria.");

            Console.Read();


            //ALTERNATIVA2
            //ManagementScope oMs = new ManagementScope();
            //ObjectQuery oQuery = new ObjectQuery("SELECT Capacity FROM Win32_PhysicalMemory");
            //ManagementObjectSearcher oSearcher = new ManagementObjectSearcher(oMs, oQuery);
            //ManagementObjectCollection oCollection = oSearcher.Get();

            //int MemSize = 0;
            //int mCap = 0;

            //// In case more than one Memory sticks are installed
            //foreach (ManagementObject obj in oCollection)
            //{
            //    mCap = Convert.ToInt32(obj["Capacity"]);
            //    MemSize += mCap;
            //}
            //MemSize = (MemSize / 1024) / 1024;
            //Console.WriteLine("Memory: " + MemSize.ToString() + "MB");
            //Console.Read();

        }

        public void NIC()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();

            if (nics == null || nics.Length < 1)
            {
                Console.WriteLine("  No network interfaces found.");
            }
            else
            {
                foreach (NetworkInterface adapter in nics)
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    Console.WriteLine();
                    Console.WriteLine(adapter.Description);
                    Console.WriteLine(String.Empty.PadLeft(adapter.Description.Length, '='));
                    Console.WriteLine("  Interface type .......................... : {0}", adapter.NetworkInterfaceType);
                    Console.WriteLine("  Physical Address ........................ : {0}", adapter.GetPhysicalAddress().ToString());
                    Console.WriteLine("  Operational status ...................... : {0}", adapter.OperationalStatus);
                }
            }
            Console.Read();
        }

        public void Parches()
        {
            Console.WriteLine("Las últimas actualizaciones o parches hechos en el dispositivo son: ");

            using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey(@"SOFTWARE\Microsoft\Updates"))
            {
                foreach (string baseKeyName in baseKey.GetSubKeyNames())
                {
                    if (baseKeyName.Contains(".NET Framework"))
                    {
                        using (RegistryKey updateKey = baseKey.OpenSubKey(baseKeyName))
                        {
                            Console.WriteLine(baseKeyName);
                            foreach (string kbKeyName in updateKey.GetSubKeyNames())
                            {
                                using (RegistryKey kbKey = updateKey.OpenSubKey(kbKeyName))
                                {
                                    Console.WriteLine("  " + kbKeyName);
                                }
                            }
                        }
                    }
                }
            }
            Console.Read();
        }
    }
}
