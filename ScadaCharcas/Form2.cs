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
            //btn_vibr1_On.Enabled = false;
            btn_vibr1_Off.Enabled = true;
            modbusClient.WriteSingleCoil(34, true);
        }

        private void btn_vibr1_Off_Click(object sender, EventArgs e)
        {
            btn_vibr1_On.Enabled = true;
            btn_vibr1_Off.Enabled = false;
            modbusClient.WriteSingleCoil(34, false);
        }

        private void btn_vibr2_On_Click_1(object sender, EventArgs e)
        {
            btn_vibr2_On.Enabled = false;
            btn_vibr2_Off.Enabled = true;
            modbusClient.WriteSingleCoil(35, true);
        }

        private void btn_vibr2_Off_Click_1(object sender, EventArgs e)
        {
            btn_vibr2_On.Enabled = true;
            btn_vibr2_Off.Enabled = false;
            modbusClient.WriteSingleCoil(35, false);
        }

        private void btn_vibr3_On_Click_1(object sender, EventArgs e)
        {
            btn_vibr3_On.Enabled = false;
            btn_vibr3_Off.Enabled = true;
            modbusClient.WriteSingleCoil(36, true);
        }

        private void btn_vibr3_Off_Click_1(object sender, EventArgs e)
        {
            btn_vibr3_On.Enabled = true;
            btn_vibr3_Off.Enabled = false;
            modbusClient.WriteSingleCoil(36, false);
        }

        private void btn_vibr4_On_Click(object sender, EventArgs e)
        {
            btn_vibr4_On.Enabled = false;
            btn_vibr4_Off.Enabled = true;
            modbusClient.WriteSingleCoil(37, true);
        }

        private void btn_vibr4_Off_Click(object sender, EventArgs e)
        {
            btn_vibr4_On.Enabled = true;
            btn_vibr4_Off.Enabled = false;
            modbusClient.WriteSingleCoil(37, false);
        }

        private void btn_vibr5_On_Click(object sender, EventArgs e)
        {
            btn_vibr5_On.Enabled = false;
            btn_vibr5_Off.Enabled = true;
            modbusClient.WriteSingleCoil(38, true);
        }

        private void btn_vibr5_Off_Click(object sender, EventArgs e)
        {
            btn_vibr5_On.Enabled = true;
            btn_vibr5_Off.Enabled = false;
            modbusClient.WriteSingleCoil(38, false);
        }

        private void btn_vibr6_On_Click(object sender, EventArgs e)
        {
            btn_vibr6_On.Enabled = false;
            btn_vibr6_Off.Enabled = true;
            modbusClient.WriteSingleCoil(39, true);
        }

        private void btn_vibr6_Off_Click(object sender, EventArgs e)
        {
            btn_vibr6_On.Enabled = true;
            btn_vibr6_Off.Enabled = false;
            modbusClient.WriteSingleCoil(39, false);
        }

        private void btn_vibr7_On_Click(object sender, EventArgs e)
        {
            btn_vibr7_On.Enabled = false;
            btn_vibr7_Off.Enabled = true;
            modbusClient.WriteSingleCoil(40, true);
        }

        private void btn_vibr7_Off_Click(object sender, EventArgs e)
        {
            btn_vibr7_On.Enabled = true;
            btn_vibr7_Off.Enabled = false;
            modbusClient.WriteSingleCoil(40, false);
        }

        private void btn_vibr8_On_Click(object sender, EventArgs e)
        {
            btn_vibr8_On.Enabled = false;
            btn_vibr8_Off.Enabled = true;
            modbusClient.WriteSingleCoil(41, true);
        }

        private void btn_vibr8_Off_Click(object sender, EventArgs e)
        {
            btn_vibr8_On.Enabled = true;
            btn_vibr8_Off.Enabled = false;
            modbusClient.WriteSingleCoil(41, false);
        }

        private void btn_vibr9_On_Click(object sender, EventArgs e)
        {
            btn_vibr9_On.Enabled = false;
            btn_vibr9_Off.Enabled = true;
            modbusClient.WriteSingleCoil(42, true);
        }

        private void btn_vibr9_Off_Click(object sender, EventArgs e)
        {
            btn_vibr9_On.Enabled = true;
            btn_vibr9_Off.Enabled = false;
            modbusClient.WriteSingleCoil(42, false);
        }

        private void btn_vibr10_On_Click(object sender, EventArgs e)
        {
            btn_vibr10_On.Enabled = false;
            btn_vibr10_Off.Enabled = true;
            modbusClient.WriteSingleCoil(43, true);
        }

        private void btn_vibr10_Off_Click(object sender, EventArgs e)
        {
            btn_vibr10_On.Enabled = true;
            btn_vibr10_Off.Enabled = false;
            modbusClient.WriteSingleCoil(43, false);
        }

        private void btn_vibr11_On_Click(object sender, EventArgs e)
        {
            btn_vibr11_On.Enabled = false;
            btn_vibr11_Off.Enabled = true;
            modbusClient.WriteSingleCoil(44, true);
        }

        private void btn_vibr11_Off_Click(object sender, EventArgs e)
        {
            btn_vibr11_On.Enabled = true;
            btn_vibr11_Off.Enabled = false;
            modbusClient.WriteSingleCoil(44, false);
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            //leer_M = modbusClient.ReadCoils(0, 100);
            //leer_MW = modbusClient.ReadHoldingRegisters(0, 100);

            //if ( leer_M [34] == true)
            //{
            //    btn_vibr1_On.Enabled = false;
            //    btn_vibr1_Off.Enabled = true;
            //}
            //if (leer_M[35] == true)
            //{
            //    btn_vibr2_On.Enabled = false;
            //    btn_vibr2_Off.Enabled = true;
            //}
            //if (leer_M[36] == true)
            //{
            //    btn_vibr3_On.Enabled = false;
            //    btn_vibr3_Off.Enabled = true;
            //}
            //if (leer_M[37] == true)
            //{
            //    btn_vibr4_On.Enabled = false;
            //    btn_vibr4_Off.Enabled = true;
            //}
            //if (leer_M[38] == true)
            //{
            //    btn_vibr4_On.Enabled = false;
            //    btn_vibr4_Off.Enabled = true;
            //}
            //if (leer_M[39] == true)
            //{
            //    btn_vibr5_On.Enabled = false;
            //    btn_vibr5_Off.Enabled = true;
            //}
            //if (leer_M[40] == true)
            //{
            //    btn_vibr6_On.Enabled = false;
            //    btn_vibr6_Off.Enabled = true;
            //}
            //if (leer_M[41] == true)
            //{
            //    btn_vibr7_On.Enabled = false;
            //    btn_vibr7_Off.Enabled = true;
            //}
            //if (leer_M[42] == true)
            //{
            //    btn_vibr8_On.Enabled = false;
            //    btn_vibr8_Off.Enabled = true;
            //}
            //if (leer_M[43] == true)
            //{
            //    btn_vibr9_On.Enabled = false;
            //    btn_vibr9_Off.Enabled = true;
            //}
            //if (leer_M[44] == true)
            //{
            //    btn_vibr10_On.Enabled = false;
            //    btn_vibr10_Off.Enabled = true;
            //}
            //if (leer_M[45] == true)
            //{
            //    btn_vibr11_On.Enabled = false;
            //    btn_vibr11_Off.Enabled = true;
            //}

            ////===============================================================================================
            //if (leer_M[34] == false)
            //{
            //    btn_vibr1_On.Enabled = true;
            //    btn_vibr1_Off.Enabled = false;
            //}
            //if (leer_M[35] == false)
            //{
            //    btn_vibr2_On.Enabled = true;
            //    btn_vibr2_Off.Enabled = false;
            //}
            //if (leer_M[36] == false)
            //{
            //    btn_vibr3_On.Enabled = true;
            //    btn_vibr3_Off.Enabled = false;
            //}
            //if (leer_M[37] == false)
            //{
            //    btn_vibr4_On.Enabled = true;
            //    btn_vibr4_Off.Enabled = false;
            //}
            //if (leer_M[38] == false)
            //{
            //    btn_vibr4_On.Enabled = true;
            //    btn_vibr4_Off.Enabled = false;
            //}
            //if (leer_M[39] == false)
            //{
            //    btn_vibr5_On.Enabled = true;
            //    btn_vibr5_Off.Enabled = false;
            //}
            //if (leer_M[40] == false)
            //{
            //    btn_vibr6_On.Enabled = true;
            //    btn_vibr6_Off.Enabled = false;
            //}
            //if (leer_M[41] == false)
            //{
            //    btn_vibr7_On.Enabled = true;
            //    btn_vibr7_Off.Enabled = false;
            //}
            //if (leer_M[42] == false)
            //{
            //    btn_vibr8_On.Enabled = true;
            //    btn_vibr8_Off.Enabled = false;
            //}
            //if (leer_M[43] == false)
            //{
            //    btn_vibr9_On.Enabled = true;
            //    btn_vibr9_Off.Enabled = false;
            //}
            //if (leer_M[44] == false)
            //{
            //    btn_vibr10_On.Enabled = true;
            //    btn_vibr10_Off.Enabled = false;
            //}
            //if (leer_M[45] == false)
            //{
            //    btn_vibr11_On.Enabled = true;
            //    btn_vibr11_Off.Enabled = false;
            //}
        }
    }
}
