namespace ScadaCharcas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contenedor11 = new ScadaControles.Contenedor1();
            this.contenedor12 = new ScadaControles.Contenedor1();
            this.banda_transportadora1 = new ScadaControles.Banda_transportadora();
            this.tanque21 = new ScadaControles.Tanque2();
            this.contenedor13 = new ScadaControles.Contenedor1();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PB_apertura3 = new System.Windows.Forms.PictureBox();
            this.PB_apertura2 = new System.Windows.Forms.PictureBox();
            this.PB_apertura1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tm1 = new System.Windows.Forms.TextBox();
            this.btn_confTm1 = new System.Windows.Forms.Button();
            this.lbl_time1 = new System.Windows.Forms.Label();
            this.lbl_time2 = new System.Windows.Forms.Label();
            this.btn_confTm2 = new System.Windows.Forms.Button();
            this.txt_tm2 = new System.Windows.Forms.TextBox();
            this.btn_Conectar = new System.Windows.Forms.Button();
            this.btn_desconectar = new System.Windows.Forms.Button();
            this.btn_iniciarMonitoreo = new System.Windows.Forms.Button();
            this.btn_finMonitoreo = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_Configuraciones = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB_apertura3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_apertura2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_apertura1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // contenedor11
            // 
            this.contenedor11.Location = new System.Drawing.Point(839, 195);
            this.contenedor11.Name = "contenedor11";
            this.contenedor11.Size = new System.Drawing.Size(176, 167);
            this.contenedor11.TabIndex = 1;
            // 
            // contenedor12
            // 
            this.contenedor12.Location = new System.Drawing.Point(1012, 195);
            this.contenedor12.Name = "contenedor12";
            this.contenedor12.Size = new System.Drawing.Size(177, 167);
            this.contenedor12.TabIndex = 2;
            // 
            // banda_transportadora1
            // 
            this.banda_transportadora1.Location = new System.Drawing.Point(76, 523);
            this.banda_transportadora1.Name = "banda_transportadora1";
            this.banda_transportadora1.Size = new System.Drawing.Size(433, 61);
            this.banda_transportadora1.TabIndex = 3;
            // 
            // tanque21
            // 
            this.tanque21.Location = new System.Drawing.Point(1137, 12);
            this.tanque21.Name = "tanque21";
            this.tanque21.Size = new System.Drawing.Size(244, 214);
            this.tanque21.TabIndex = 4;
            // 
            // contenedor13
            // 
            this.contenedor13.Location = new System.Drawing.Point(917, 359);
            this.contenedor13.Name = "contenedor13";
            this.contenedor13.Size = new System.Drawing.Size(177, 167);
            this.contenedor13.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(551, 69);
            this.label1.TabIndex = 8;
            this.label1.Text = "Control De Proceso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1179, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tanque de agua";
            // 
            // PB_apertura3
            // 
            this.PB_apertura3.Image = global::ScadaCharcas.Properties.Resources.cuadro_rojo;
            this.PB_apertura3.Location = new System.Drawing.Point(984, 517);
            this.PB_apertura3.Name = "PB_apertura3";
            this.PB_apertura3.Size = new System.Drawing.Size(42, 19);
            this.PB_apertura3.TabIndex = 12;
            this.PB_apertura3.TabStop = false;
            // 
            // PB_apertura2
            // 
            this.PB_apertura2.Image = global::ScadaCharcas.Properties.Resources.cuadro_rojo;
            this.PB_apertura2.Location = new System.Drawing.Point(1079, 343);
            this.PB_apertura2.Name = "PB_apertura2";
            this.PB_apertura2.Size = new System.Drawing.Size(42, 19);
            this.PB_apertura2.TabIndex = 11;
            this.PB_apertura2.TabStop = false;
            // 
            // PB_apertura1
            // 
            this.PB_apertura1.Image = global::ScadaCharcas.Properties.Resources.cuadro_rojo;
            this.PB_apertura1.Location = new System.Drawing.Point(904, 343);
            this.PB_apertura1.Name = "PB_apertura1";
            this.PB_apertura1.Size = new System.Drawing.Size(42, 19);
            this.PB_apertura1.TabIndex = 10;
            this.PB_apertura1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ScadaCharcas.Properties.Resources.contenedor3;
            this.pictureBox1.Location = new System.Drawing.Point(76, 359);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 144);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ScadaCharcas.Properties.Resources.tornillo_sin_fin_a_colores;
            this.pictureBox2.Location = new System.Drawing.Point(375, 208);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(596, 309);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tiempo de llenado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tiempo de llenado";
            // 
            // txt_tm1
            // 
            this.txt_tm1.Location = new System.Drawing.Point(64, 153);
            this.txt_tm1.Name = "txt_tm1";
            this.txt_tm1.Size = new System.Drawing.Size(32, 20);
            this.txt_tm1.TabIndex = 15;
            // 
            // btn_confTm1
            // 
            this.btn_confTm1.Enabled = false;
            this.btn_confTm1.Location = new System.Drawing.Point(102, 151);
            this.btn_confTm1.Name = "btn_confTm1";
            this.btn_confTm1.Size = new System.Drawing.Size(40, 23);
            this.btn_confTm1.TabIndex = 16;
            this.btn_confTm1.Text = "Conf.";
            this.btn_confTm1.UseVisualStyleBackColor = true;
            this.btn_confTm1.Click += new System.EventHandler(this.btn_confTm1_Click);
            // 
            // lbl_time1
            // 
            this.lbl_time1.AutoSize = true;
            this.lbl_time1.Location = new System.Drawing.Point(75, 135);
            this.lbl_time1.Name = "lbl_time1";
            this.lbl_time1.Size = new System.Drawing.Size(48, 13);
            this.lbl_time1.TabIndex = 17;
            this.lbl_time1.Text = "lbl_time1";
            // 
            // lbl_time2
            // 
            this.lbl_time2.AutoSize = true;
            this.lbl_time2.Location = new System.Drawing.Point(75, 193);
            this.lbl_time2.Name = "lbl_time2";
            this.lbl_time2.Size = new System.Drawing.Size(48, 13);
            this.lbl_time2.TabIndex = 20;
            this.lbl_time2.Text = "lbl_time2";
            // 
            // btn_confTm2
            // 
            this.btn_confTm2.Enabled = false;
            this.btn_confTm2.Location = new System.Drawing.Point(102, 209);
            this.btn_confTm2.Name = "btn_confTm2";
            this.btn_confTm2.Size = new System.Drawing.Size(40, 23);
            this.btn_confTm2.TabIndex = 19;
            this.btn_confTm2.Text = "Conf.";
            this.btn_confTm2.UseVisualStyleBackColor = true;
            this.btn_confTm2.Click += new System.EventHandler(this.btn_confTm2_Click);
            // 
            // txt_tm2
            // 
            this.txt_tm2.Location = new System.Drawing.Point(64, 211);
            this.txt_tm2.Name = "txt_tm2";
            this.txt_tm2.Size = new System.Drawing.Size(32, 20);
            this.txt_tm2.TabIndex = 18;
            // 
            // btn_Conectar
            // 
            this.btn_Conectar.Location = new System.Drawing.Point(38, 9);
            this.btn_Conectar.Name = "btn_Conectar";
            this.btn_Conectar.Size = new System.Drawing.Size(75, 23);
            this.btn_Conectar.TabIndex = 21;
            this.btn_Conectar.Text = "Conectar";
            this.btn_Conectar.UseVisualStyleBackColor = true;
            this.btn_Conectar.Click += new System.EventHandler(this.btn_Conectar_Click);
            // 
            // btn_desconectar
            // 
            this.btn_desconectar.Enabled = false;
            this.btn_desconectar.Location = new System.Drawing.Point(134, 9);
            this.btn_desconectar.Name = "btn_desconectar";
            this.btn_desconectar.Size = new System.Drawing.Size(82, 23);
            this.btn_desconectar.TabIndex = 22;
            this.btn_desconectar.Text = "Desconectar";
            this.btn_desconectar.UseVisualStyleBackColor = true;
            this.btn_desconectar.Click += new System.EventHandler(this.btn_desconectar_Click);
            // 
            // btn_iniciarMonitoreo
            // 
            this.btn_iniciarMonitoreo.Enabled = false;
            this.btn_iniciarMonitoreo.Location = new System.Drawing.Point(38, 39);
            this.btn_iniciarMonitoreo.Name = "btn_iniciarMonitoreo";
            this.btn_iniciarMonitoreo.Size = new System.Drawing.Size(75, 40);
            this.btn_iniciarMonitoreo.TabIndex = 23;
            this.btn_iniciarMonitoreo.Text = "Iniciar Monitoreo";
            this.btn_iniciarMonitoreo.UseVisualStyleBackColor = true;
            this.btn_iniciarMonitoreo.Click += new System.EventHandler(this.btn_iniciarMonitoreo_Click);
            // 
            // btn_finMonitoreo
            // 
            this.btn_finMonitoreo.Enabled = false;
            this.btn_finMonitoreo.Location = new System.Drawing.Point(134, 39);
            this.btn_finMonitoreo.Name = "btn_finMonitoreo";
            this.btn_finMonitoreo.Size = new System.Drawing.Size(70, 40);
            this.btn_finMonitoreo.TabIndex = 24;
            this.btn_finMonitoreo.Text = "Fin Monitoreo";
            this.btn_finMonitoreo.UseVisualStyleBackColor = true;
            this.btn_finMonitoreo.Click += new System.EventHandler(this.btn_finMonitoreo_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(226, 38);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(70, 40);
            this.btn_salir.TabIndex = 25;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_Configuraciones
            // 
            this.btn_Configuraciones.Enabled = false;
            this.btn_Configuraciones.Location = new System.Drawing.Point(203, 108);
            this.btn_Configuraciones.Name = "btn_Configuraciones";
            this.btn_Configuraciones.Size = new System.Drawing.Size(93, 40);
            this.btn_Configuraciones.TabIndex = 26;
            this.btn_Configuraciones.Text = "Configuraciones";
            this.btn_Configuraciones.UseVisualStyleBackColor = true;
            this.btn_Configuraciones.Click += new System.EventHandler(this.btn_Configuraciones_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 650);
            this.Controls.Add(this.btn_Configuraciones);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_finMonitoreo);
            this.Controls.Add(this.btn_iniciarMonitoreo);
            this.Controls.Add(this.btn_desconectar);
            this.Controls.Add(this.btn_Conectar);
            this.Controls.Add(this.lbl_time2);
            this.Controls.Add(this.btn_confTm2);
            this.Controls.Add(this.txt_tm2);
            this.Controls.Add(this.lbl_time1);
            this.Controls.Add(this.btn_confTm1);
            this.Controls.Add(this.txt_tm1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PB_apertura3);
            this.Controls.Add(this.PB_apertura2);
            this.Controls.Add(this.PB_apertura1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contenedor13);
            this.Controls.Add(this.banda_transportadora1);
            this.Controls.Add(this.contenedor12);
            this.Controls.Add(this.contenedor11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tanque21);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PB_apertura3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_apertura2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_apertura1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private ScadaControles.Contenedor1 contenedor11;
        private ScadaControles.Contenedor1 contenedor12;
        private ScadaControles.Banda_transportadora banda_transportadora1;
        private ScadaControles.Tanque2 tanque21;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ScadaControles.Contenedor1 contenedor13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PB_apertura1;
        private System.Windows.Forms.PictureBox PB_apertura2;
        private System.Windows.Forms.PictureBox PB_apertura3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tm1;
        private System.Windows.Forms.Button btn_confTm1;
        private System.Windows.Forms.Label lbl_time1;
        private System.Windows.Forms.Label lbl_time2;
        private System.Windows.Forms.Button btn_confTm2;
        private System.Windows.Forms.TextBox txt_tm2;
        private System.Windows.Forms.Button btn_Conectar;
        private System.Windows.Forms.Button btn_desconectar;
        private System.Windows.Forms.Button btn_iniciarMonitoreo;
        private System.Windows.Forms.Button btn_finMonitoreo;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_Configuraciones;

    }
}

