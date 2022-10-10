using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Management.Instrumentation;
using System.Threading;
using System.Runtime.InteropServices;
using System.Net.NetworkInformation;
using Microsoft.Win32;
using System.Diagnostics;

namespace Procesos
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void frm1_Load(object sender, EventArgs e)
        {
            LoadProcess();
        }

        public void LoadProcess()
        {
            lvwProcesos.Items.Clear();

            Process[] processList = Process.GetProcesses();

            foreach (Process pro in processList)
            {
                ListViewItem item = new ListViewItem(pro.ProcessName);
                item.SubItems.Add(pro.ProcessName);
                item.Tag = pro;
                lvwProcesos.Items.Add(item);
            }
        }

        private void btnKill_Click(object sender, EventArgs e)
        {
            ListViewItem item = lvwProcesos.SelectedItems[0];            
            Process pro = (Process)item.Tag;
            pro.Kill();
            LoadProcess();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            LoadProcess();
        }
    }
}
