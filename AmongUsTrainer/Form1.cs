using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmongUsTrainer
{
    public partial class Form1 : Form
    {
        private readonly Memory.Mem _mem;
        private readonly ProcessModule _procModule;
        public Form1(Memory.Mem mem, ProcessModule procModule)
        {
            _mem = mem;
            _procModule = procModule;
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (float.TryParse(textBox1.Text, out _))
                _mem.WriteMemory($"{_procModule.BaseAddress.ToString("X8")}+01C39098,5C,4,14", "float",
                    this.textBox1.Text);
            else
                MessageBox.Show("Value must be a float !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (float.TryParse(textBox2.Text, out _))
                _mem.WriteMemory($"{_procModule.BaseAddress.ToString("X8")}+01C39098,5C,4,18", "float", this.textBox2.Text);
            else
                MessageBox.Show("Value must be a float !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
    }
}