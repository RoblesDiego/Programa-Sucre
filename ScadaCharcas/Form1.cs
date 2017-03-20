using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenOPC;
using EasyModbus;

namespace ScadaCharcas
{
    public partial class Form1 : Form
    {
        ModbusClient modbusClient;
        public Form1()
        {
            InitializeComponent();
        }
        public static bool[] leer_M;
        public static int[] leer_MW;
        public static bool[] escribir_M;
        public static int[] escribir_MW;

        public string confTime1;
        public int SetTime1;
        public string confTime2;
        public int SetTime2;
        private void conectarPLC()
        {
            //try { 
            modbusClient = new ModbusClient("192.168.0.100", 502); //dirección estática del plc
            modbusClient.Connect();
            MessageBox.Show("Conexión establecida.");
            timer1.Start();
            //}
            //catch {
  
            //}
 
        }
        private void iniciarCaptura()
        {
            timer2.Start();
        }
        private void detenerLectura()
        {
            timer2.Stop();
        }
        private void btn_Conectar_Click(object sender, EventArgs e)
        {
            try
            {
                this.conectarPLC();

                btn_Conectar.Enabled = false;
                btn_desconectar.Enabled = true;
                btn_iniciarMonitoreo.Enabled = true;
                btn_finMonitoreo.Enabled = false;
                btn_salir.Enabled = false;
            }
            catch
            {
                MessageBox.Show("No se pudo conectar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Revise su conexion e IP del PLC", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop);  
         }
        }

        private void btn_desconectar_Click(object sender, EventArgs e)
        {
            btn_Conectar.Enabled = true;
            btn_desconectar.Enabled = false;
            btn_iniciarMonitoreo.Enabled = false;
            btn_finMonitoreo.Enabled = false;
            btn_salir.Enabled = true;
            modbusClient.Disconnect();
            MessageBox.Show("Conexion cerrada");
            timer1.Stop(); 
        }

        private void btn_iniciarMonitoreo_Click(object sender, EventArgs e)
        {
            btn_Conectar.Enabled = false;
            btn_desconectar.Enabled = false;
            btn_iniciarMonitoreo.Enabled = false;
            btn_finMonitoreo.Enabled = true;
            btn_confTm1.Enabled = true;
            btn_confTm2.Enabled = true;
            this.iniciarCaptura();
        }

        private void btn_finMonitoreo_Click(object sender, EventArgs e)
        {
            this.detenerLectura();

            btn_Conectar.Enabled = false;
            btn_desconectar.Enabled = true;
            btn_iniciarMonitoreo.Enabled = true;
            btn_finMonitoreo.Enabled = false;
            btn_confTm1.Enabled = false;
            btn_confTm2.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            try
            {
                leer_M = modbusClient.ReadCoils(0, 100);
                leer_MW = modbusClient.ReadHoldingRegisters(0, 100);
            }
            catch
            {

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Start();
            try { 
            lbl_time1.Text = leer_MW[0].ToString();
            lbl_time2.Text = leer_MW[2].ToString();
                
                }
            catch { }

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_confTm1_Click(object sender, EventArgs e)
        {
            try { 
            confTime1 = txt_tm1.Text;
            SetTime1 = Int32.Parse(confTime1);
            modbusClient.WriteSingleRegister(0, SetTime1);
            txt_tm1.Clear();
                }
            catch
            {
                MessageBox.Show("No se pudo enviar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Asegurese de introducir solo numeros enteros", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txt_tm1.Clear();
            }
          
        }

        private void btn_confTm2_Click(object sender, EventArgs e)
        {
            try{
            confTime2 = txt_tm2.Text;
            SetTime2 = Int32.Parse(confTime2);
            modbusClient.WriteSingleRegister(2, SetTime2);
            txt_tm2.Clear();
             }
            catch
            {
                MessageBox.Show("No se pudo enviar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Asegurese de introducir solo numeros enteros", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txt_tm2.Clear();
            }
        }
    }
}
