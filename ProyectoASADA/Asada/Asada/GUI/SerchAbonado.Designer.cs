namespace Asada2015.GUI
{
    partial class SerchAbonado
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RbParentsName = new System.Windows.Forms.RadioButton();
            this.RbName = new System.Windows.Forms.RadioButton();
            this.RbIdentification = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbParentsName);
            this.groupBox1.Controls.Add(this.RbName);
            this.groupBox1.Controls.Add(this.RbIdentification);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por:";
            // 
            // RbParentsName
            // 
            this.RbParentsName.AutoSize = true;
            this.RbParentsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbParentsName.Location = new System.Drawing.Point(176, 18);
            this.RbParentsName.Name = "RbParentsName";
            this.RbParentsName.Size = new System.Drawing.Size(83, 20);
            this.RbParentsName.TabIndex = 2;
            this.RbParentsName.TabStop = true;
            this.RbParentsName.Text = "Apellidos";
            this.RbParentsName.UseVisualStyleBackColor = true;
            // 
            // RbName
            // 
            this.RbName.AutoSize = true;
            this.RbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbName.Location = new System.Drawing.Point(95, 18);
            this.RbName.Name = "RbName";
            this.RbName.Size = new System.Drawing.Size(75, 20);
            this.RbName.TabIndex = 1;
            this.RbName.TabStop = true;
            this.RbName.Text = "Nombre";
            this.RbName.UseVisualStyleBackColor = true;
            // 
            // RbIdentification
            // 
            this.RbIdentification.AutoSize = true;
            this.RbIdentification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbIdentification.Location = new System.Drawing.Point(20, 19);
            this.RbIdentification.Name = "RbIdentification";
            this.RbIdentification.Size = new System.Drawing.Size(69, 20);
            this.RbIdentification.TabIndex = 0;
            this.RbIdentification.TabStop = true;
            this.RbIdentification.Text = "Cédula";
            this.RbIdentification.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(871, 327);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Criterio de busqueda:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(309, 29);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 30);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Image = global::Asada.Properties.Resources.salir;
            this.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExit.Location = new System.Drawing.Point(779, 18);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(104, 41);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Text = "Cancelar";
            this.BtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnAccept
            // 
            this.BtnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAccept.Image = global::Asada.Properties.Resources.ok;
            this.BtnAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAccept.Location = new System.Drawing.Point(680, 18);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(93, 41);
            this.BtnAccept.TabIndex = 4;
            this.BtnAccept.Text = "Aceptar";
            this.BtnAccept.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAccept.UseVisualStyleBackColor = true;
            this.BtnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // SerchAbonado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(895, 405);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnAccept);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "SerchAbonado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logitech GML -  Buscador Abonado ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SerchAbonado_FormClosed);
            this.Load += new System.EventHandler(this.SerchAbonado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbParentsName;
        private System.Windows.Forms.RadioButton RbName;
        private System.Windows.Forms.RadioButton RbIdentification;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.Button BtnExit;
    }
}