namespace DaciaCarShowroom
{
    partial class frmQuote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuote));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radAmbiance = new System.Windows.Forms.RadioButton();
            this.radMidnight = new System.Windows.Forms.RadioButton();
            this.radPetrol = new System.Windows.Forms.RadioButton();
            this.radDiesel = new System.Windows.Forms.RadioButton();
            this.chkFinance = new System.Windows.Forms.CheckBox();
            this.btnQuote = new System.Windows.Forms.Button();
            this.lblQuote = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get your own personlaised quote\r\nfor Dacia Sandero";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(292, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 100);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 98);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Enter your details!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(104, 27);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(183, 22);
            this.txtFirstName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Surname:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(104, 60);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(183, 22);
            this.txtSurname.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radDiesel);
            this.groupBox2.Controls.Add(this.radPetrol);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(36, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 98);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2. Select engine size";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radMidnight);
            this.groupBox3.Controls.Add(this.radAmbiance);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(36, 356);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 98);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3. Select trim";
            // 
            // radAmbiance
            // 
            this.radAmbiance.AutoSize = true;
            this.radAmbiance.Location = new System.Drawing.Point(25, 25);
            this.radAmbiance.Name = "radAmbiance";
            this.radAmbiance.Size = new System.Drawing.Size(87, 20);
            this.radAmbiance.TabIndex = 0;
            this.radAmbiance.TabStop = true;
            this.radAmbiance.Text = "Ambiance";
            this.radAmbiance.UseVisualStyleBackColor = true;
            this.radAmbiance.CheckedChanged += new System.EventHandler(this.radAmbiance_CheckedChanged);
            // 
            // radMidnight
            // 
            this.radMidnight.AutoSize = true;
            this.radMidnight.Location = new System.Drawing.Point(25, 51);
            this.radMidnight.Name = "radMidnight";
            this.radMidnight.Size = new System.Drawing.Size(76, 20);
            this.radMidnight.TabIndex = 1;
            this.radMidnight.TabStop = true;
            this.radMidnight.Text = "Midnight";
            this.radMidnight.UseVisualStyleBackColor = true;
            this.radMidnight.CheckedChanged += new System.EventHandler(this.radMidnight_CheckedChanged);
            // 
            // radPetrol
            // 
            this.radPetrol.AutoSize = true;
            this.radPetrol.Location = new System.Drawing.Point(25, 26);
            this.radPetrol.Name = "radPetrol";
            this.radPetrol.Size = new System.Drawing.Size(105, 20);
            this.radPetrol.TabIndex = 2;
            this.radPetrol.TabStop = true;
            this.radPetrol.Text = "1.2 litre Petrol";
            this.radPetrol.UseVisualStyleBackColor = true;
            this.radPetrol.CheckedChanged += new System.EventHandler(this.radPetrol_CheckedChanged);
            // 
            // radDiesel
            // 
            this.radDiesel.AutoSize = true;
            this.radDiesel.Location = new System.Drawing.Point(25, 52);
            this.radDiesel.Name = "radDiesel";
            this.radDiesel.Size = new System.Drawing.Size(109, 20);
            this.radDiesel.TabIndex = 3;
            this.radDiesel.TabStop = true;
            this.radDiesel.Text = "1.6 litre Diesel";
            this.radDiesel.UseVisualStyleBackColor = true;
            this.radDiesel.CheckedChanged += new System.EventHandler(this.radDiesel_CheckedChanged);
            // 
            // chkFinance
            // 
            this.chkFinance.AutoSize = true;
            this.chkFinance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFinance.Location = new System.Drawing.Point(92, 475);
            this.chkFinance.Name = "chkFinance";
            this.chkFinance.Size = new System.Drawing.Size(206, 20);
            this.chkFinance.TabIndex = 4;
            this.chkFinance.Text = "I would like a finance package";
            this.chkFinance.UseVisualStyleBackColor = true;
            // 
            // btnQuote
            // 
            this.btnQuote.BackColor = System.Drawing.Color.PeachPuff;
            this.btnQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuote.Location = new System.Drawing.Point(117, 509);
            this.btnQuote.Name = "btnQuote";
            this.btnQuote.Size = new System.Drawing.Size(145, 32);
            this.btnQuote.TabIndex = 6;
            this.btnQuote.Text = "Get Quote!";
            this.btnQuote.UseVisualStyleBackColor = false;
            this.btnQuote.Click += new System.EventHandler(this.btnQuote_Click);
            // 
            // lblQuote
            // 
            this.lblQuote.AutoSize = true;
            this.lblQuote.Location = new System.Drawing.Point(17, 27);
            this.lblQuote.Name = "lblQuote";
            this.lblQuote.Size = new System.Drawing.Size(0, 16);
            this.lblQuote.TabIndex = 8;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblQuote);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(36, 558);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(328, 117);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Your Quote:";
            // 
            // frmQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(405, 696);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnQuote);
            this.Controls.Add(this.chkFinance);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmQuote";
            this.Text = "Dacia Quote Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radAmbiance;
        private System.Windows.Forms.RadioButton radMidnight;
        private System.Windows.Forms.RadioButton radPetrol;
        private System.Windows.Forms.RadioButton radDiesel;
        private System.Windows.Forms.CheckBox chkFinance;
        private System.Windows.Forms.Button btnQuote;
        private System.Windows.Forms.Label lblQuote;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

