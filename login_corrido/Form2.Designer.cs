namespace login_corrido
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cerrar1 = new System.Windows.Forms.Button();
            this.nomb2 = new System.Windows.Forms.TextBox();
            this.pass2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.registrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.cerrar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 41);
            this.panel1.TabIndex = 0;
            // 
            // cerrar1
            // 
            this.cerrar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar1.BackColor = System.Drawing.Color.Red;
            this.cerrar1.ForeColor = System.Drawing.Color.White;
            this.cerrar1.Location = new System.Drawing.Point(345, 12);
            this.cerrar1.Name = "cerrar1";
            this.cerrar1.Size = new System.Drawing.Size(27, 23);
            this.cerrar1.TabIndex = 2;
            this.cerrar1.Text = "X";
            this.cerrar1.UseVisualStyleBackColor = false;
            // 
            // nomb2
            // 
            this.nomb2.Location = new System.Drawing.Point(121, 134);
            this.nomb2.Multiline = true;
            this.nomb2.Name = "nomb2";
            this.nomb2.Size = new System.Drawing.Size(182, 37);
            this.nomb2.TabIndex = 3;
            // 
            // pass2
            // 
            this.pass2.Location = new System.Drawing.Point(121, 220);
            this.pass2.Multiline = true;
            this.pass2.Name = "pass2";
            this.pass2.Size = new System.Drawing.Size(182, 37);
            this.pass2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "CONTRASEÑA";
            // 
            // registrar
            // 
            this.registrar.BackColor = System.Drawing.Color.Red;
            this.registrar.ForeColor = System.Drawing.Color.White;
            this.registrar.Location = new System.Drawing.Point(152, 281);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(113, 37);
            this.registrar.TabIndex = 8;
            this.registrar.Text = "REGISTRAR";
            this.registrar.UseVisualStyleBackColor = false;
            this.registrar.Click += new System.EventHandler(this.registrar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 342);
            this.Controls.Add(this.registrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pass2);
            this.Controls.Add(this.nomb2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cerrar1;
        private System.Windows.Forms.TextBox nomb2;
        private System.Windows.Forms.TextBox pass2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button registrar;
    }
}