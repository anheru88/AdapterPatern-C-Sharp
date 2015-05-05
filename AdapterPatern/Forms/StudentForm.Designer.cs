namespace AdapterPatern.Forms
{
    partial class StudentForm
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
            this.lName = new System.Windows.Forms.Label();
            this.tName = new System.Windows.Forms.TextBox();
            this.lCode = new System.Windows.Forms.Label();
            this.tCode = new System.Windows.Forms.TextBox();
            this.lAge = new System.Windows.Forms.Label();
            this.tAge = new System.Windows.Forms.TextBox();
            this.lGender = new System.Windows.Forms.Label();
            this.rMale = new System.Windows.Forms.RadioButton();
            this.rFemale = new System.Windows.Forms.RadioButton();
            this.lAddress = new System.Windows.Forms.Label();
            this.tAddress = new System.Windows.Forms.TextBox();
            this.bSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(12, 30);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(35, 13);
            this.lName.TabIndex = 0;
            this.lName.Text = "Name";
            // 
            // tName
            // 
            this.tName.Location = new System.Drawing.Point(90, 30);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(318, 20);
            this.tName.TabIndex = 1;
            // 
            // lCode
            // 
            this.lCode.AutoSize = true;
            this.lCode.Location = new System.Drawing.Point(12, 61);
            this.lCode.Name = "lCode";
            this.lCode.Size = new System.Drawing.Size(32, 13);
            this.lCode.TabIndex = 2;
            this.lCode.Text = "Code";
            // 
            // tCode
            // 
            this.tCode.Location = new System.Drawing.Point(90, 61);
            this.tCode.Name = "tCode";
            this.tCode.Size = new System.Drawing.Size(318, 20);
            this.tCode.TabIndex = 3;
            // 
            // lAge
            // 
            this.lAge.AutoSize = true;
            this.lAge.Location = new System.Drawing.Point(12, 95);
            this.lAge.Name = "lAge";
            this.lAge.Size = new System.Drawing.Size(26, 13);
            this.lAge.TabIndex = 4;
            this.lAge.Text = "Age";
            // 
            // tAge
            // 
            this.tAge.Location = new System.Drawing.Point(90, 95);
            this.tAge.Name = "tAge";
            this.tAge.Size = new System.Drawing.Size(318, 20);
            this.tAge.TabIndex = 5;
            this.tAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tAge_KeyPress);
            // 
            // lGender
            // 
            this.lGender.AutoSize = true;
            this.lGender.Location = new System.Drawing.Point(12, 128);
            this.lGender.Name = "lGender";
            this.lGender.Size = new System.Drawing.Size(42, 13);
            this.lGender.TabIndex = 6;
            this.lGender.Text = "Gender";
            // 
            // rMale
            // 
            this.rMale.AutoSize = true;
            this.rMale.Location = new System.Drawing.Point(90, 128);
            this.rMale.Name = "rMale";
            this.rMale.Size = new System.Drawing.Size(48, 17);
            this.rMale.TabIndex = 7;
            this.rMale.TabStop = true;
            this.rMale.Tag = "";
            this.rMale.Text = "Male";
            this.rMale.UseVisualStyleBackColor = true;
            // 
            // rFemale
            // 
            this.rFemale.AutoSize = true;
            this.rFemale.Location = new System.Drawing.Point(155, 128);
            this.rFemale.Name = "rFemale";
            this.rFemale.Size = new System.Drawing.Size(59, 17);
            this.rFemale.TabIndex = 8;
            this.rFemale.TabStop = true;
            this.rFemale.Tag = "F";
            this.rFemale.Text = "Female";
            this.rFemale.UseVisualStyleBackColor = true;
            // 
            // lAddress
            // 
            this.lAddress.AutoSize = true;
            this.lAddress.Location = new System.Drawing.Point(15, 159);
            this.lAddress.Name = "lAddress";
            this.lAddress.Size = new System.Drawing.Size(45, 13);
            this.lAddress.TabIndex = 9;
            this.lAddress.Text = "Address";
            // 
            // tAddress
            // 
            this.tAddress.Location = new System.Drawing.Point(90, 159);
            this.tAddress.Name = "tAddress";
            this.tAddress.Size = new System.Drawing.Size(318, 20);
            this.tAddress.TabIndex = 10;
            // 
            // bSave
            // 
            this.bSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSave.Location = new System.Drawing.Point(90, 201);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 11;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 244);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.tAddress);
            this.Controls.Add(this.lAddress);
            this.Controls.Add(this.rFemale);
            this.Controls.Add(this.rMale);
            this.Controls.Add(this.lGender);
            this.Controls.Add(this.tAge);
            this.Controls.Add(this.lAge);
            this.Controls.Add(this.tCode);
            this.Controls.Add(this.lCode);
            this.Controls.Add(this.tName);
            this.Controls.Add(this.lName);
            this.Name = "StudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.Label lCode;
        private System.Windows.Forms.TextBox tCode;
        private System.Windows.Forms.Label lAge;
        private System.Windows.Forms.TextBox tAge;
        private System.Windows.Forms.Label lGender;
        private System.Windows.Forms.RadioButton rMale;
        private System.Windows.Forms.RadioButton rFemale;
        private System.Windows.Forms.Label lAddress;
        private System.Windows.Forms.TextBox tAddress;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button button1;
    }
}