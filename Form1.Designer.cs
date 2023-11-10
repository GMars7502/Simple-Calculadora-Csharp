namespace Calculadora3._0
{
    partial class Cuerpo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cuerpo));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pantalla = new System.Windows.Forms.TextBox();
            this.BTac = new System.Windows.Forms.Button();
            this.BTc = new System.Windows.Forms.Button();
            this.BTmulti = new System.Windows.Forms.Button();
            this.BTdivi = new System.Windows.Forms.Button();
            this.BT7 = new System.Windows.Forms.Button();
            this.BT8 = new System.Windows.Forms.Button();
            this.BT9 = new System.Windows.Forms.Button();
            this.BTmen = new System.Windows.Forms.Button();
            this.BT4 = new System.Windows.Forms.Button();
            this.BT5 = new System.Windows.Forms.Button();
            this.BT6 = new System.Windows.Forms.Button();
            this.BTmas = new System.Windows.Forms.Button();
            this.BT1 = new System.Windows.Forms.Button();
            this.BT2 = new System.Windows.Forms.Button();
            this.BT3 = new System.Windows.Forms.Button();
            this.BTigual = new System.Windows.Forms.Button();
            this.BT0 = new System.Windows.Forms.Button();
            this.BTpunto = new System.Windows.Forms.Button();
            this.BTmm = new System.Windows.Forms.Button();
            this.calculadora10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hechoPorUngatoprogramadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(317, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadora10ToolStripMenuItem,
            this.hechoPorUngatoprogramadorToolStripMenuItem});
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.versionToolStripMenuItem.Text = "Version y detalles";
            this.versionToolStripMenuItem.Click += new System.EventHandler(this.versionToolStripMenuItem_Click);
            // 
            // pantalla
            // 
            this.pantalla.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pantalla.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pantalla.ForeColor = System.Drawing.Color.LawnGreen;
            this.pantalla.Location = new System.Drawing.Point(13, 28);
            this.pantalla.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pantalla.MaxLength = 2;
            this.pantalla.Multiline = true;
            this.pantalla.Name = "pantalla";
            this.pantalla.ReadOnly = true;
            this.pantalla.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pantalla.Size = new System.Drawing.Size(296, 63);
            this.pantalla.TabIndex = 1;
            this.pantalla.TextChanged += new System.EventHandler(this.pantalla_TextChanged);
            // 
            // BTac
            // 
            this.BTac.Location = new System.Drawing.Point(13, 97);
            this.BTac.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BTac.Name = "BTac";
            this.BTac.Size = new System.Drawing.Size(70, 49);
            this.BTac.TabIndex = 2;
            this.BTac.Text = "AC";
            this.BTac.UseVisualStyleBackColor = true;
            this.BTac.Click += new System.EventHandler(this.BTac_Click);
            // 
            // BTc
            // 
            this.BTc.Location = new System.Drawing.Point(89, 97);
            this.BTc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BTc.Name = "BTc";
            this.BTc.Size = new System.Drawing.Size(74, 49);
            this.BTc.TabIndex = 3;
            this.BTc.Text = "←";
            this.BTc.UseVisualStyleBackColor = true;
            this.BTc.Click += new System.EventHandler(this.BTc_Click);
            // 
            // BTmulti
            // 
            this.BTmulti.Location = new System.Drawing.Point(170, 97);
            this.BTmulti.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BTmulti.Name = "BTmulti";
            this.BTmulti.Size = new System.Drawing.Size(70, 49);
            this.BTmulti.TabIndex = 4;
            this.BTmulti.Text = "X";
            this.BTmulti.UseVisualStyleBackColor = true;
            this.BTmulti.Click += new System.EventHandler(this.BTmulti_Click);
            // 
            // BTdivi
            // 
            this.BTdivi.Location = new System.Drawing.Point(246, 97);
            this.BTdivi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BTdivi.Name = "BTdivi";
            this.BTdivi.Size = new System.Drawing.Size(62, 49);
            this.BTdivi.TabIndex = 5;
            this.BTdivi.Text = "/";
            this.BTdivi.UseVisualStyleBackColor = true;
            this.BTdivi.Click += new System.EventHandler(this.BTdivi_Click);
            // 
            // BT7
            // 
            this.BT7.Location = new System.Drawing.Point(13, 152);
            this.BT7.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BT7.Name = "BT7";
            this.BT7.Size = new System.Drawing.Size(70, 49);
            this.BT7.TabIndex = 6;
            this.BT7.Text = "7";
            this.BT7.UseVisualStyleBackColor = true;
            this.BT7.Click += new System.EventHandler(this.BT7_Click);
            // 
            // BT8
            // 
            this.BT8.Location = new System.Drawing.Point(89, 152);
            this.BT8.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BT8.Name = "BT8";
            this.BT8.Size = new System.Drawing.Size(74, 49);
            this.BT8.TabIndex = 7;
            this.BT8.Text = "8";
            this.BT8.UseVisualStyleBackColor = true;
            this.BT8.Click += new System.EventHandler(this.BT8_Click);
            // 
            // BT9
            // 
            this.BT9.Location = new System.Drawing.Point(170, 152);
            this.BT9.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BT9.Name = "BT9";
            this.BT9.Size = new System.Drawing.Size(70, 49);
            this.BT9.TabIndex = 8;
            this.BT9.Text = "9";
            this.BT9.UseVisualStyleBackColor = true;
            this.BT9.Click += new System.EventHandler(this.BT9_Click);
            // 
            // BTmen
            // 
            this.BTmen.Location = new System.Drawing.Point(246, 152);
            this.BTmen.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BTmen.Name = "BTmen";
            this.BTmen.Size = new System.Drawing.Size(62, 49);
            this.BTmen.TabIndex = 9;
            this.BTmen.Text = "-";
            this.BTmen.UseVisualStyleBackColor = true;
            this.BTmen.Click += new System.EventHandler(this.BTmen_Click);
            // 
            // BT4
            // 
            this.BT4.Location = new System.Drawing.Point(13, 207);
            this.BT4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BT4.Name = "BT4";
            this.BT4.Size = new System.Drawing.Size(70, 49);
            this.BT4.TabIndex = 10;
            this.BT4.Text = "4";
            this.BT4.UseVisualStyleBackColor = true;
            this.BT4.Click += new System.EventHandler(this.BT4_Click);
            // 
            // BT5
            // 
            this.BT5.Location = new System.Drawing.Point(89, 207);
            this.BT5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BT5.Name = "BT5";
            this.BT5.Size = new System.Drawing.Size(74, 49);
            this.BT5.TabIndex = 11;
            this.BT5.Text = "5";
            this.BT5.UseVisualStyleBackColor = true;
            this.BT5.Click += new System.EventHandler(this.BT5_Click);
            // 
            // BT6
            // 
            this.BT6.Location = new System.Drawing.Point(170, 207);
            this.BT6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BT6.Name = "BT6";
            this.BT6.Size = new System.Drawing.Size(70, 49);
            this.BT6.TabIndex = 12;
            this.BT6.Text = "6";
            this.BT6.UseVisualStyleBackColor = true;
            this.BT6.Click += new System.EventHandler(this.BT6_Click);
            // 
            // BTmas
            // 
            this.BTmas.Location = new System.Drawing.Point(246, 207);
            this.BTmas.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BTmas.Name = "BTmas";
            this.BTmas.Size = new System.Drawing.Size(62, 49);
            this.BTmas.TabIndex = 13;
            this.BTmas.Text = "+";
            this.BTmas.UseVisualStyleBackColor = true;
            this.BTmas.Click += new System.EventHandler(this.BTmas_Click);
            // 
            // BT1
            // 
            this.BT1.Location = new System.Drawing.Point(13, 262);
            this.BT1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BT1.Name = "BT1";
            this.BT1.Size = new System.Drawing.Size(70, 49);
            this.BT1.TabIndex = 14;
            this.BT1.Text = "1";
            this.BT1.UseVisualStyleBackColor = true;
            this.BT1.Click += new System.EventHandler(this.BT1_Click);
            // 
            // BT2
            // 
            this.BT2.Location = new System.Drawing.Point(89, 262);
            this.BT2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BT2.Name = "BT2";
            this.BT2.Size = new System.Drawing.Size(74, 49);
            this.BT2.TabIndex = 15;
            this.BT2.Text = "2";
            this.BT2.UseVisualStyleBackColor = true;
            this.BT2.Click += new System.EventHandler(this.BT2_Click);
            // 
            // BT3
            // 
            this.BT3.Location = new System.Drawing.Point(170, 262);
            this.BT3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BT3.Name = "BT3";
            this.BT3.Size = new System.Drawing.Size(70, 49);
            this.BT3.TabIndex = 16;
            this.BT3.Text = "3";
            this.BT3.UseVisualStyleBackColor = true;
            this.BT3.Click += new System.EventHandler(this.BT3_Click);
            // 
            // BTigual
            // 
            this.BTigual.Location = new System.Drawing.Point(246, 262);
            this.BTigual.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BTigual.Name = "BTigual";
            this.BTigual.Size = new System.Drawing.Size(62, 118);
            this.BTigual.TabIndex = 17;
            this.BTigual.Text = "=";
            this.BTigual.UseVisualStyleBackColor = true;
            this.BTigual.Click += new System.EventHandler(this.BTigual_Click);
            // 
            // BT0
            // 
            this.BT0.Location = new System.Drawing.Point(13, 317);
            this.BT0.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BT0.Name = "BT0";
            this.BT0.Size = new System.Drawing.Size(70, 63);
            this.BT0.TabIndex = 18;
            this.BT0.Text = "0";
            this.BT0.UseVisualStyleBackColor = true;
            this.BT0.Click += new System.EventHandler(this.BT0_Click);
            // 
            // BTpunto
            // 
            this.BTpunto.Location = new System.Drawing.Point(89, 317);
            this.BTpunto.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BTpunto.Name = "BTpunto";
            this.BTpunto.Size = new System.Drawing.Size(74, 63);
            this.BTpunto.TabIndex = 19;
            this.BTpunto.Text = ".";
            this.BTpunto.UseVisualStyleBackColor = true;
            this.BTpunto.Click += new System.EventHandler(this.BTpunto_Click);
            // 
            // BTmm
            // 
            this.BTmm.Location = new System.Drawing.Point(170, 317);
            this.BTmm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BTmm.Name = "BTmm";
            this.BTmm.Size = new System.Drawing.Size(70, 63);
            this.BTmm.TabIndex = 20;
            this.BTmm.Text = "+/-";
            this.BTmm.UseVisualStyleBackColor = true;
            this.BTmm.Click += new System.EventHandler(this.BTmm_Click);
            // 
            // calculadora10ToolStripMenuItem
            // 
            this.calculadora10ToolStripMenuItem.Name = "calculadora10ToolStripMenuItem";
            this.calculadora10ToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.calculadora10ToolStripMenuItem.Text = "Calculadora 1.0";
            // 
            // hechoPorUngatoprogramadorToolStripMenuItem
            // 
            this.hechoPorUngatoprogramadorToolStripMenuItem.Name = "hechoPorUngatoprogramadorToolStripMenuItem";
            this.hechoPorUngatoprogramadorToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.hechoPorUngatoprogramadorToolStripMenuItem.Text = "Hecho por Ungatoprogramador";
            // 
            // Cuerpo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(317, 390);
            this.Controls.Add(this.BTmm);
            this.Controls.Add(this.BTpunto);
            this.Controls.Add(this.BT0);
            this.Controls.Add(this.BTigual);
            this.Controls.Add(this.BT3);
            this.Controls.Add(this.BT2);
            this.Controls.Add(this.BT1);
            this.Controls.Add(this.BTmas);
            this.Controls.Add(this.BT6);
            this.Controls.Add(this.BT5);
            this.Controls.Add(this.BT4);
            this.Controls.Add(this.BTmen);
            this.Controls.Add(this.BT9);
            this.Controls.Add(this.BT8);
            this.Controls.Add(this.BT7);
            this.Controls.Add(this.BTdivi);
            this.Controls.Add(this.BTmulti);
            this.Controls.Add(this.BTc);
            this.Controls.Add(this.BTac);
            this.Controls.Add(this.pantalla);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Cuerpo";
            this.RightToLeftLayout = true;
            this.Text = "Calculadora 2000.3";
            this.Load += new System.EventHandler(this.Cuerpo_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.TextBox pantalla;
        private System.Windows.Forms.Button BTac;
        private System.Windows.Forms.Button BTc;
        private System.Windows.Forms.Button BTmulti;
        private System.Windows.Forms.Button BTdivi;
        private System.Windows.Forms.Button BT7;
        private System.Windows.Forms.Button BT8;
        private System.Windows.Forms.Button BT9;
        private System.Windows.Forms.Button BTmen;
        private System.Windows.Forms.Button BT4;
        private System.Windows.Forms.Button BT5;
        private System.Windows.Forms.Button BT6;
        private System.Windows.Forms.Button BTmas;
        private System.Windows.Forms.Button BT1;
        private System.Windows.Forms.Button BT2;
        private System.Windows.Forms.Button BT3;
        private System.Windows.Forms.Button BTigual;
        private System.Windows.Forms.Button BT0;
        private System.Windows.Forms.Button BTpunto;
        private System.Windows.Forms.Button BTmm;
        private System.Windows.Forms.ToolStripMenuItem calculadora10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hechoPorUngatoprogramadorToolStripMenuItem;
    }
}

