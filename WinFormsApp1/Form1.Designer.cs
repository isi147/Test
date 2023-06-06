namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textFather = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.radioFam = new System.Windows.Forms.RadioButton();
            this.labelAnket = new System.Windows.Forms.Label();
            this.Form = new System.Windows.Forms.GroupBox();
            this.Form.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(33, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(193, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(140, 22);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(195, 23);
            this.textName.TabIndex = 2;
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(140, 80);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(195, 23);
            this.textSurname.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "FatherN";
            // 
            // textFather
            // 
            this.textFather.Location = new System.Drawing.Point(140, 137);
            this.textFather.Name = "textFather";
            this.textFather.Size = new System.Drawing.Size(195, 23);
            this.textFather.TabIndex = 7;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(140, 206);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(195, 23);
            this.date.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Birthday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(11, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gender";
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(160, 276);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(51, 19);
            this.radioMale.TabIndex = 11;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // radioFam
            // 
            this.radioFam.AutoSize = true;
            this.radioFam.Location = new System.Drawing.Point(238, 276);
            this.radioFam.Name = "radioFam";
            this.radioFam.Size = new System.Drawing.Size(63, 19);
            this.radioFam.TabIndex = 12;
            this.radioFam.TabStop = true;
            this.radioFam.Text = "Famale";
            this.radioFam.UseVisualStyleBackColor = true;
            // 
            // labelAnket
            // 
            this.labelAnket.AutoSize = true;
            this.labelAnket.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAnket.Location = new System.Drawing.Point(371, 12);
            this.labelAnket.Name = "labelAnket";
            this.labelAnket.Size = new System.Drawing.Size(0, 28);
            this.labelAnket.TabIndex = 13;
            // 
            // Form
            // 
            this.Form.Controls.Add(this.label1);
            this.Form.Controls.Add(this.textName);
            this.Form.Controls.Add(this.radioFam);
            this.Form.Controls.Add(this.label2);
            this.Form.Controls.Add(this.radioMale);
            this.Form.Controls.Add(this.textSurname);
            this.Form.Controls.Add(this.textFather);
            this.Form.Controls.Add(this.label5);
            this.Form.Controls.Add(this.button2);
            this.Form.Controls.Add(this.date);
            this.Form.Controls.Add(this.button1);
            this.Form.Controls.Add(this.label4);
            this.Form.Controls.Add(this.label3);
            this.Form.Location = new System.Drawing.Point(12, 33);
            this.Form.Name = "Form";
            this.Form.Size = new System.Drawing.Size(359, 410);
            this.Form.TabIndex = 14;
            this.Form.TabStop = false;
            this.Form.Text = "Form";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 486);
            this.Controls.Add(this.Form);
            this.Controls.Add(this.labelAnket);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Form.ResumeLayout(false);
            this.Form.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textName;
        private TextBox textSurname;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textFather;
        private DateTimePicker date;
        private Label label4;
        private Label label5;
        private RadioButton radioMale;
        private RadioButton radioFam;
        private Label labelAnket;
        private GroupBox Form;
    }
}