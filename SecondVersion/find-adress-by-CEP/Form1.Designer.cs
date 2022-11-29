namespace find_adress_by_CEP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnClearAdressSearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFindAdress = new System.Windows.Forms.Button();
            this.gpboxDataFound = new System.Windows.Forms.GroupBox();
            this.txtboxStreet = new System.Windows.Forms.TextBox();
            this.txtboxDistrict = new System.Windows.Forms.TextBox();
            this.txtboxCity = new System.Windows.Forms.TextBox();
            this.txtboxState = new System.Windows.Forms.TextBox();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.masktxtboxCEP = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpboxDataFound.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Gold;
            this.pnlMain.Controls.Add(this.btnClearAdressSearch);
            this.pnlMain.Controls.Add(this.pictureBox1);
            this.pnlMain.Controls.Add(this.btnFindAdress);
            this.pnlMain.Controls.Add(this.gpboxDataFound);
            this.pnlMain.Controls.Add(this.masktxtboxCEP);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(579, 299);
            this.pnlMain.TabIndex = 0;
            // 
            // btnClearAdressSearch
            // 
            this.btnClearAdressSearch.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnClearAdressSearch.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAdressSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(63)))), ((int)(((byte)(126)))));
            this.btnClearAdressSearch.Location = new System.Drawing.Point(343, 30);
            this.btnClearAdressSearch.Name = "btnClearAdressSearch";
            this.btnClearAdressSearch.Size = new System.Drawing.Size(92, 33);
            this.btnClearAdressSearch.TabIndex = 6;
            this.btnClearAdressSearch.Text = "Limpar ";
            this.btnClearAdressSearch.UseVisualStyleBackColor = false;
            this.btnClearAdressSearch.Click += new System.EventHandler(this.btnClearAdressSearch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(457, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnFindAdress
            // 
            this.btnFindAdress.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnFindAdress.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindAdress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(63)))), ((int)(((byte)(126)))));
            this.btnFindAdress.Location = new System.Drawing.Point(237, 30);
            this.btnFindAdress.Name = "btnFindAdress";
            this.btnFindAdress.Size = new System.Drawing.Size(100, 33);
            this.btnFindAdress.TabIndex = 4;
            this.btnFindAdress.Text = "Buscar";
            this.btnFindAdress.UseVisualStyleBackColor = false;
            this.btnFindAdress.Click += new System.EventHandler(this.btnFindAdress_Click);
            // 
            // gpboxDataFound
            // 
            this.gpboxDataFound.Controls.Add(this.txtboxStreet);
            this.gpboxDataFound.Controls.Add(this.txtboxDistrict);
            this.gpboxDataFound.Controls.Add(this.txtboxCity);
            this.gpboxDataFound.Controls.Add(this.txtboxState);
            this.gpboxDataFound.Controls.Add(this.lblDistrict);
            this.gpboxDataFound.Controls.Add(this.lblStreet);
            this.gpboxDataFound.Controls.Add(this.lblCity);
            this.gpboxDataFound.Controls.Add(this.lblState);
            this.gpboxDataFound.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpboxDataFound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(63)))), ((int)(((byte)(126)))));
            this.gpboxDataFound.Location = new System.Drawing.Point(30, 84);
            this.gpboxDataFound.Name = "gpboxDataFound";
            this.gpboxDataFound.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gpboxDataFound.Size = new System.Drawing.Size(519, 202);
            this.gpboxDataFound.TabIndex = 3;
            this.gpboxDataFound.TabStop = false;
            this.gpboxDataFound.Text = "Dados buscados";
            // 
            // txtboxStreet
            // 
            this.txtboxStreet.Enabled = false;
            this.txtboxStreet.Font = new System.Drawing.Font("Consolas", 15F);
            this.txtboxStreet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(63)))), ((int)(((byte)(126)))));
            this.txtboxStreet.Location = new System.Drawing.Point(117, 156);
            this.txtboxStreet.Name = "txtboxStreet";
            this.txtboxStreet.Size = new System.Drawing.Size(385, 31);
            this.txtboxStreet.TabIndex = 9;
            // 
            // txtboxDistrict
            // 
            this.txtboxDistrict.Enabled = false;
            this.txtboxDistrict.Font = new System.Drawing.Font("Consolas", 15F);
            this.txtboxDistrict.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(63)))), ((int)(((byte)(126)))));
            this.txtboxDistrict.Location = new System.Drawing.Point(117, 113);
            this.txtboxDistrict.Name = "txtboxDistrict";
            this.txtboxDistrict.Size = new System.Drawing.Size(385, 31);
            this.txtboxDistrict.TabIndex = 8;
            // 
            // txtboxCity
            // 
            this.txtboxCity.Enabled = false;
            this.txtboxCity.Font = new System.Drawing.Font("Consolas", 15F);
            this.txtboxCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(63)))), ((int)(((byte)(126)))));
            this.txtboxCity.Location = new System.Drawing.Point(117, 69);
            this.txtboxCity.Name = "txtboxCity";
            this.txtboxCity.Size = new System.Drawing.Size(385, 31);
            this.txtboxCity.TabIndex = 7;
            // 
            // txtboxState
            // 
            this.txtboxState.Enabled = false;
            this.txtboxState.Font = new System.Drawing.Font("Consolas", 15F);
            this.txtboxState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(63)))), ((int)(((byte)(126)))));
            this.txtboxState.Location = new System.Drawing.Point(117, 26);
            this.txtboxState.Name = "txtboxState";
            this.txtboxState.Size = new System.Drawing.Size(385, 31);
            this.txtboxState.TabIndex = 6;
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistrict.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(63)))), ((int)(((byte)(126)))));
            this.lblDistrict.Location = new System.Drawing.Point(8, 112);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(104, 32);
            this.lblDistrict.TabIndex = 5;
            this.lblDistrict.Text = "Bairro";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(63)))), ((int)(((byte)(126)))));
            this.lblStreet.Location = new System.Drawing.Point(53, 155);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(59, 32);
            this.lblStreet.TabIndex = 4;
            this.lblStreet.Text = "Rua";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(63)))), ((int)(((byte)(126)))));
            this.lblCity.Location = new System.Drawing.Point(8, 68);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(104, 32);
            this.lblCity.TabIndex = 3;
            this.lblCity.Text = "Cidade";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(63)))), ((int)(((byte)(126)))));
            this.lblState.Location = new System.Drawing.Point(8, 25);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(104, 32);
            this.lblState.TabIndex = 2;
            this.lblState.Text = "Estado";
            // 
            // masktxtboxCEP
            // 
            this.masktxtboxCEP.Font = new System.Drawing.Font("Consolas", 15F);
            this.masktxtboxCEP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(63)))), ((int)(((byte)(126)))));
            this.masktxtboxCEP.Location = new System.Drawing.Point(112, 31);
            this.masktxtboxCEP.Mask = "00000-000";
            this.masktxtboxCEP.Name = "masktxtboxCEP";
            this.masktxtboxCEP.Size = new System.Drawing.Size(119, 31);
            this.masktxtboxCEP.TabIndex = 2;
            this.masktxtboxCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.masktxtboxCEP.TextChanged += new System.EventHandler(this.masktxtboxCEP_TextChanged);
            this.masktxtboxCEP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.masktxtboxCEP_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(63)))), ((int)(((byte)(126)))));
            this.label1.Location = new System.Drawing.Point(47, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "CEP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(577, 298);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(63)))), ((int)(((byte)(126)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar endereço pelo CEP";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpboxDataFound.ResumeLayout(false);
            this.gpboxDataFound.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.MaskedTextBox masktxtboxCEP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFindAdress;
        private System.Windows.Forms.GroupBox gpboxDataFound;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtboxStreet;
        private System.Windows.Forms.TextBox txtboxDistrict;
        private System.Windows.Forms.TextBox txtboxCity;
        private System.Windows.Forms.TextBox txtboxState;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClearAdressSearch;
    }
}

