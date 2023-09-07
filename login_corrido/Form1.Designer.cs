namespace login_corrido
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.cerrar1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nomb = new System.Windows.Forms.TextBox();
            this.contra2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mostrar = new System.Windows.Forms.CheckBox();
            this.ingreso = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonRegistro = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.cerrar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 42);
            this.panel1.TabIndex = 0;
            // 
            // cerrar1
            // 
            this.cerrar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar1.BackColor = System.Drawing.Color.Red;
            this.cerrar1.ForeColor = System.Drawing.Color.White;
            this.cerrar1.Location = new System.Drawing.Point(441, 12);
            this.cerrar1.Name = "cerrar1";
            this.cerrar1.Size = new System.Drawing.Size(27, 23);
            this.cerrar1.TabIndex = 1;
            this.cerrar1.Text = "X";
            this.cerrar1.UseVisualStyleBackColor = false;
            this.cerrar1.Click += new System.EventHandler(this.cerrar1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::login_corrido.Properties.Resources.seeeeee;
            this.pictureBox1.Location = new System.Drawing.Point(160, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // nomb
            // 
            this.nomb.Location = new System.Drawing.Point(128, 215);
            this.nomb.Multiline = true;
            this.nomb.Name = "nomb";
            this.nomb.Size = new System.Drawing.Size(182, 37);
            this.nomb.TabIndex = 2;
            this.nomb.TextChanged += new System.EventHandler(this.nomb_TextChanged);
            this.nomb.Enter += new System.EventHandler(this.nomb_Enter);
            this.nomb.Leave += new System.EventHandler(this.nomb_Leave);
            // 
            // contra2
            // 
            this.contra2.Location = new System.Drawing.Point(128, 298);
            this.contra2.Multiline = true;
            this.contra2.Name = "contra2";
            this.contra2.Size = new System.Drawing.Size(182, 38);
            this.contra2.TabIndex = 3;
            this.contra2.Enter += new System.EventHandler(this.contra_Enter);
            this.contra2.Leave += new System.EventHandler(this.contra_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "CONTRASEÑA";
            // 
            // mostrar
            // 
            this.mostrar.AutoSize = true;
            this.mostrar.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrar.Location = new System.Drawing.Point(214, 354);
            this.mostrar.Name = "mostrar";
            this.mostrar.Size = new System.Drawing.Size(96, 18);
            this.mostrar.TabIndex = 6;
            this.mostrar.Text = "MUESTRAME";
            this.mostrar.UseVisualStyleBackColor = true;
            this.mostrar.CheckedChanged += new System.EventHandler(this.mostrar_CheckedChanged);
            // 
            // ingreso
            // 
            this.ingreso.BackColor = System.Drawing.Color.Red;
            this.ingreso.ForeColor = System.Drawing.Color.White;
            this.ingreso.Location = new System.Drawing.Point(163, 389);
            this.ingreso.Name = "ingreso";
            this.ingreso.Size = new System.Drawing.Size(113, 37);
            this.ingreso.TabIndex = 7;
            this.ingreso.Text = "INGRESAR";
            this.ingreso.UseVisualStyleBackColor = false;
            this.ingreso.Click += new System.EventHandler(this.ingreso_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "¿No estas registrado?";
            // 
            // buttonRegistro
            // 
            this.buttonRegistro.FlatAppearance.BorderSize = 0;
            this.buttonRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistro.ForeColor = System.Drawing.Color.Red;
            this.buttonRegistro.Location = new System.Drawing.Point(163, 472);
            this.buttonRegistro.Name = "buttonRegistro";
            this.buttonRegistro.Size = new System.Drawing.Size(113, 32);
            this.buttonRegistro.TabIndex = 9;
            this.buttonRegistro.Text = "REGISTRARME";
            this.buttonRegistro.UseVisualStyleBackColor = true;
            this.buttonRegistro.Click += new System.EventHandler(this.buttonRegistro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 507);
            this.Controls.Add(this.buttonRegistro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ingreso);
            this.Controls.Add(this.mostrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contra2);
            this.Controls.Add(this.nomb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cerrar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox nomb;
        private System.Windows.Forms.TextBox contra2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox mostrar;
        private System.Windows.Forms.Button ingreso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonRegistro;
    }
}

