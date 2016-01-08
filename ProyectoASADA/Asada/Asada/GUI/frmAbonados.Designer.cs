namespace Asada2015.GUI
{
    partial class frmAbonados
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MtxtIdentification = new System.Windows.Forms.MaskedTextBox();
            this.MtxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtFirstN = new System.Windows.Forms.TextBox();
            this.TxtLastN = new System.Windows.Forms.TextBox();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.btnSaveUpdate = new System.Windows.Forms.Button();
            this.btnSerch = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MtxtMovil = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cédula:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 49);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nacionalidad";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(100, 18);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(86, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Extranjero";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(80, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nacional";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton1_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "1er Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "2do Apellido:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Dirección:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Teléfono:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fecha de Registro:";
            // 
            // MtxtIdentification
            // 
            this.MtxtIdentification.BackColor = System.Drawing.Color.White;
            this.MtxtIdentification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtxtIdentification.Location = new System.Drawing.Point(103, 67);
            this.MtxtIdentification.Mask = "00-0000-0000";
            this.MtxtIdentification.Name = "MtxtIdentification";
            this.MtxtIdentification.Size = new System.Drawing.Size(130, 22);
            this.MtxtIdentification.TabIndex = 2;
            // 
            // MtxtPhone
            // 
            this.MtxtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtxtPhone.Location = new System.Drawing.Point(103, 179);
            this.MtxtPhone.Mask = "0000-0000";
            this.MtxtPhone.Name = "MtxtPhone";
            this.MtxtPhone.Size = new System.Drawing.Size(130, 22);
            this.MtxtPhone.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(137, 318);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(103, 95);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(130, 22);
            this.TxtName.TabIndex = 3;
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // TxtFirstN
            // 
            this.TxtFirstN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFirstN.Location = new System.Drawing.Point(103, 123);
            this.TxtFirstN.Name = "TxtFirstN";
            this.TxtFirstN.Size = new System.Drawing.Size(130, 22);
            this.TxtFirstN.TabIndex = 4;
            this.TxtFirstN.TextChanged += new System.EventHandler(this.TxtFirstN_TextChanged);
            // 
            // TxtLastN
            // 
            this.TxtLastN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLastN.Location = new System.Drawing.Point(103, 151);
            this.TxtLastN.Name = "TxtLastN";
            this.TxtLastN.Size = new System.Drawing.Size(130, 22);
            this.TxtLastN.TabIndex = 5;
            this.TxtLastN.TextChanged += new System.EventHandler(this.TxtLastN_TextChanged);
            // 
            // TxtAddress
            // 
            this.TxtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAddress.Location = new System.Drawing.Point(103, 265);
            this.TxtAddress.Multiline = true;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(299, 45);
            this.TxtAddress.TabIndex = 9;
            this.TxtAddress.TextChanged += new System.EventHandler(this.TxtAddress_TextChanged);
            // 
            // btnSaveUpdate
            // 
            this.btnSaveUpdate.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSaveUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveUpdate.Image = global::Asada.Properties.Resources.edit_add;
            this.btnSaveUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveUpdate.Location = new System.Drawing.Point(111, 346);
            this.btnSaveUpdate.Name = "btnSaveUpdate";
            this.btnSaveUpdate.Size = new System.Drawing.Size(98, 41);
            this.btnSaveUpdate.TabIndex = 12;
            this.btnSaveUpdate.Text = "Guardar";
            this.btnSaveUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveUpdate.UseVisualStyleBackColor = false;
            this.btnSaveUpdate.Click += new System.EventHandler(this.btnSaveUpdate_Click);
            // 
            // btnSerch
            // 
            this.btnSerch.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSerch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerch.Image = global::Asada.Properties.Resources.buscar;
            this.btnSerch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSerch.Location = new System.Drawing.Point(15, 346);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(90, 41);
            this.btnSerch.TabIndex = 11;
            this.btnSerch.Text = "Buscar";
            this.btnSerch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSerch.UseVisualStyleBackColor = false;
            this.btnSerch.Click += new System.EventHandler(this.btnSerch_Click);
            // 
            // btnOut
            // 
            this.btnOut.BackColor = System.Drawing.Color.Gainsboro;
            this.btnOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOut.Image = global::Asada.Properties.Resources.salir;
            this.btnOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOut.Location = new System.Drawing.Point(321, 346);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(78, 41);
            this.btnOut.TabIndex = 14;
            this.btnOut.Text = "Salir";
            this.btnOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOut.UseVisualStyleBackColor = false;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::Asada.Properties.Resources.cancel;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(215, 346);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 41);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(239, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 180);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // MtxtMovil
            // 
            this.MtxtMovil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtxtMovil.Location = new System.Drawing.Point(103, 207);
            this.MtxtMovil.Mask = "0000-0000";
            this.MtxtMovil.Name = "MtxtMovil";
            this.MtxtMovil.Size = new System.Drawing.Size(130, 22);
            this.MtxtMovil.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Movil:";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(103, 235);
            this.TxtEmail.Multiline = true;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(299, 24);
            this.TxtEmail.TabIndex = 8;
            this.TxtEmail.TextChanged += new System.EventHandler(this.TxtEmail_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "Email:";
            // 
            // frmAbonados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(427, 397);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.MtxtMovil);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSaveUpdate);
            this.Controls.Add(this.btnSerch);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.TxtLastN);
            this.Controls.Add(this.TxtFirstN);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.MtxtPhone);
            this.Controls.Add(this.MtxtIdentification);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAbonados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logitech GML - Abonados";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAbonados_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox MtxtIdentification;
        private System.Windows.Forms.MaskedTextBox MtxtPhone;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtFirstN;
        private System.Windows.Forms.TextBox TxtLastN;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnSerch;
        private System.Windows.Forms.Button btnSaveUpdate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox MtxtMovil;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label9;
    }
}