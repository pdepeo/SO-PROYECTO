namespace Cliente
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.conectar = new System.Windows.Forms.Button();
            this.desconectar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inicia_sesion = new System.Windows.Forms.Button();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Registro = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.TextBox();
            this.partidas_ganadas = new System.Windows.Forms.Button();
            this.partida_maslarga = new System.Windows.Forms.Button();
            this.partidas_compartidas = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.jugador1 = new System.Windows.Forms.TextBox();
            this.jugador2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // conectar
            // 
            this.conectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.conectar.Location = new System.Drawing.Point(23, 12);
            this.conectar.Name = "conectar";
            this.conectar.Size = new System.Drawing.Size(112, 33);
            this.conectar.TabIndex = 0;
            this.conectar.Text = "Conectar";
            this.conectar.UseVisualStyleBackColor = true;
            this.conectar.Click += new System.EventHandler(this.conectar_Click);
            // 
            // desconectar
            // 
            this.desconectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.desconectar.Location = new System.Drawing.Point(141, 12);
            this.desconectar.Name = "desconectar";
            this.desconectar.Size = new System.Drawing.Size(112, 33);
            this.desconectar.TabIndex = 1;
            this.desconectar.Text = "Desconectar";
            this.desconectar.UseVisualStyleBackColor = true;
            this.desconectar.Click += new System.EventHandler(this.desconectar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.inicia_sesion);
            this.groupBox1.Controls.Add(this.contraseña);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Registro);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 202);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peticion";
            // 
            // inicia_sesion
            // 
            this.inicia_sesion.Location = new System.Drawing.Point(223, 146);
            this.inicia_sesion.Name = "inicia_sesion";
            this.inicia_sesion.Size = new System.Drawing.Size(89, 23);
            this.inicia_sesion.TabIndex = 8;
            this.inicia_sesion.Text = "Iniciar Sesión ";
            this.inicia_sesion.UseVisualStyleBackColor = true;
            this.inicia_sesion.Click += new System.EventHandler(this.inicia_sesion_Click);
            // 
            // contraseña
            // 
            this.contraseña.Location = new System.Drawing.Point(148, 74);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(164, 20);
            this.contraseña.TabIndex = 7;
            this.contraseña.TextChanged += new System.EventHandler(this.contraseña_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            // 
            // Registro
            // 
            this.Registro.Location = new System.Drawing.Point(34, 146);
            this.Registro.Name = "Registro";
            this.Registro.Size = new System.Drawing.Size(89, 23);
            this.Registro.TabIndex = 5;
            this.Registro.Text = "Crear Usuario";
            this.Registro.UseVisualStyleBackColor = true;
            this.Registro.Click += new System.EventHandler(this.Registro_Click_1);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(148, 30);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(164, 20);
            this.nombre.TabIndex = 3;
            this.nombre.TextChanged += new System.EventHandler(this.nombre_TextChanged);
            // 
            // partidas_ganadas
            // 
            this.partidas_ganadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.partidas_ganadas.Location = new System.Drawing.Point(401, 119);
            this.partidas_ganadas.Name = "partidas_ganadas";
            this.partidas_ganadas.Size = new System.Drawing.Size(112, 27);
            this.partidas_ganadas.TabIndex = 16;
            this.partidas_ganadas.Text = "P.Ganadas";
            this.partidas_ganadas.UseVisualStyleBackColor = true;
            this.partidas_ganadas.Click += new System.EventHandler(this.partidas_ganadas_Click_1);
            // 
            // partida_maslarga
            // 
            this.partida_maslarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.partida_maslarga.Location = new System.Drawing.Point(401, 152);
            this.partida_maslarga.Name = "partida_maslarga";
            this.partida_maslarga.Size = new System.Drawing.Size(112, 25);
            this.partida_maslarga.TabIndex = 14;
            this.partida_maslarga.Text = "P.MasLarga";
            this.partida_maslarga.UseVisualStyleBackColor = true;
            this.partida_maslarga.Click += new System.EventHandler(this.partida_maslarga_Click_1);
            // 
            // partidas_compartidas
            // 
            this.partidas_compartidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.partidas_compartidas.Location = new System.Drawing.Point(401, 183);
            this.partidas_compartidas.Name = "partidas_compartidas";
            this.partidas_compartidas.Size = new System.Drawing.Size(137, 29);
            this.partidas_compartidas.TabIndex = 17;
            this.partidas_compartidas.Text = "P.Compartidas";
            this.partidas_compartidas.UseVisualStyleBackColor = true;
            this.partidas_compartidas.Click += new System.EventHandler(this.partida_compartidas_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Jugador1";
            // 
            // jugador1
            // 
            this.jugador1.Location = new System.Drawing.Point(432, 6);
            this.jugador1.Name = "jugador1";
            this.jugador1.Size = new System.Drawing.Size(100, 20);
            this.jugador1.TabIndex = 19;
            // 
            // jugador2
            // 
            this.jugador2.Location = new System.Drawing.Point(432, 32);
            this.jugador2.Name = "jugador2";
            this.jugador2.Size = new System.Drawing.Size(100, 20);
            this.jugador2.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Jugador2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 295);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.jugador2);
            this.Controls.Add(this.jugador1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.partidas_compartidas);
            this.Controls.Add(this.partidas_ganadas);
            this.Controls.Add(this.partida_maslarga);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.desconectar);
            this.Controls.Add(this.conectar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button conectar;
        private System.Windows.Forms.Button desconectar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button inicia_sesion;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Registro;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Button partidas_ganadas;
        private System.Windows.Forms.Button partida_maslarga;
        private System.Windows.Forms.Button partidas_compartidas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox jugador1;
        private System.Windows.Forms.TextBox jugador2;
        private System.Windows.Forms.Label label4;
    }
}

