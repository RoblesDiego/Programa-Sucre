using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;

namespace ScadaCharcas
{
    public partial class Form2 : Form
    {
        ModbusClient modbusClient;
        public Form2()
        {
            InitializeComponent();
            modbusClient = new ModbusClient("192.168.0.100", 502); //dirección estática del plc
            modbusClient.Connect();
        }
        public static bool[] leer_M;
        public static int[] leer_MW;
        public static bool[] escribir_M;
        public static int[] escribir_MW;

        private void btn_vibr1_On_Click(object sender, EventArgs e)
        {
            btn_vibr1_On.Enabled = false;
            btn_vibr1_Off.Enabled = true;
            modbusClient.WriteSingleCoil(34, true);
        }

        private void btn_vibr1_Off_Click(object sender, EventArgs e)
        {
            btn_vibr1_On.Enabled = true;
            btn_vibr1_Off.Enabled = false;
            modbusClient.WriteSingleCoil(34, false);
        }
    }
}
