namespace Asada2015.GUI
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asociadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previstasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatoDeCédulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumenMensualDeCostosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nosotrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.archivoToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.nosotrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(766, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.sistemaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(79, 25);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.logInToolStripMenuItem.Text = "Log in";
            this.logInToolStripMenuItem.Click += new System.EventHandler(this.logInToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.logOutToolStripMenuItem.Text = "Salir";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asociadosToolStripMenuItem,
            this.previstasToolStripMenuItem,
            this.pagosToolStripMenuItem,
            this.formatoDeCédulaToolStripMenuItem});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(78, 25);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // asociadosToolStripMenuItem
            // 
            this.asociadosToolStripMenuItem.Name = "asociadosToolStripMenuItem";
            this.asociadosToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.asociadosToolStripMenuItem.Text = "Asociados";
            this.asociadosToolStripMenuItem.Click += new System.EventHandler(this.asociadosToolStripMenuItem_Click);
            // 
            // previstasToolStripMenuItem
            // 
            this.previstasToolStripMenuItem.Name = "previstasToolStripMenuItem";
            this.previstasToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.previstasToolStripMenuItem.Text = "Previstas";
            this.previstasToolStripMenuItem.Click += new System.EventHandler(this.previstasToolStripMenuItem_Click);
            // 
            // pagosToolStripMenuItem
            // 
            this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            this.pagosToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.pagosToolStripMenuItem.Text = "Pagos";
            // 
            // formatoDeCédulaToolStripMenuItem
            // 
            this.formatoDeCédulaToolStripMenuItem.Name = "formatoDeCédulaToolStripMenuItem";
            this.formatoDeCédulaToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.formatoDeCédulaToolStripMenuItem.Text = "Formato de Cédula";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resumenMensualDeCostosToolStripMenuItem});
            this.reportesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(89, 25);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // resumenMensualDeCostosToolStripMenuItem
            // 
            this.resumenMensualDeCostosToolStripMenuItem.Name = "resumenMensualDeCostosToolStripMenuItem";
            this.resumenMensualDeCostosToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.resumenMensualDeCostosToolStripMenuItem.Text = "Resumen Mensual de Costos";
            // 
            // nosotrosToolStripMenuItem
            // 
            this.nosotrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empresaToolStripMenuItem});
            this.nosotrosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.nosotrosToolStripMenuItem.Name = "nosotrosToolStripMenuItem";
            this.nosotrosToolStripMenuItem.Size = new System.Drawing.Size(90, 25);
            this.nosotrosToolStripMenuItem.Text = "Nosotros";
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.empresaToolStripMenuItem.Text = "Empresa";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(766, 403);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asociadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previstasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumenMensualDeCostosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatoDeCédulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nosotrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;

    }
}