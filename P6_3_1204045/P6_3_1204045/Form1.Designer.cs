namespace P6_3_1204045
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.npm = new NumericTextBox.NumericTextBox();
            this.nama = new CharTextBox.CharTextBox();
            this.ttl = new System.Windows.Forms.DateTimePicker();
            this.pria = new System.Windows.Forms.RadioButton();
            this.wanita = new System.Windows.Forms.RadioButton();
            this.alamat = new System.Windows.Forms.TextBox();
            this.tlp = new NumericTextBox.NumericTextBox();
            this.prodi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORM INPUT DATA MAHASISWA";
            // 
            // npm
            // 
            this.npm.Location = new System.Drawing.Point(201, 83);
            this.npm.Name = "npm";
            this.npm.Size = new System.Drawing.Size(123, 20);
            this.npm.TabIndex = 1;
            this.npm.TextChanged += new System.EventHandler(this.npm_TextChanged);
            // 
            // nama
            // 
            this.nama.Location = new System.Drawing.Point(201, 124);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(207, 20);
            this.nama.TabIndex = 2;
            // 
            // ttl
            // 
            this.ttl.Location = new System.Drawing.Point(201, 178);
            this.ttl.Name = "ttl";
            this.ttl.Size = new System.Drawing.Size(207, 20);
            this.ttl.TabIndex = 3;
            // 
            // pria
            // 
            this.pria.AutoSize = true;
            this.pria.Location = new System.Drawing.Point(201, 221);
            this.pria.Name = "pria";
            this.pria.Size = new System.Drawing.Size(43, 17);
            this.pria.TabIndex = 4;
            this.pria.TabStop = true;
            this.pria.Text = "Pria";
            this.pria.UseVisualStyleBackColor = true;
            // 
            // wanita
            // 
            this.wanita.AutoSize = true;
            this.wanita.Location = new System.Drawing.Point(274, 221);
            this.wanita.Name = "wanita";
            this.wanita.Size = new System.Drawing.Size(59, 17);
            this.wanita.TabIndex = 5;
            this.wanita.TabStop = true;
            this.wanita.Text = "Wanita";
            this.wanita.UseVisualStyleBackColor = true;
            // 
            // alamat
            // 
            this.alamat.Location = new System.Drawing.Point(201, 268);
            this.alamat.Multiline = true;
            this.alamat.Name = "alamat";
            this.alamat.Size = new System.Drawing.Size(207, 64);
            this.alamat.TabIndex = 6;
            // 
            // tlp
            // 
            this.tlp.Location = new System.Drawing.Point(201, 357);
            this.tlp.Name = "tlp";
            this.tlp.Size = new System.Drawing.Size(123, 20);
            this.tlp.TabIndex = 7;
            // 
            // prodi
            // 
            this.prodi.FormattingEnabled = true;
            this.prodi.Location = new System.Drawing.Point(201, 398);
            this.prodi.Name = "prodi";
            this.prodi.Size = new System.Drawing.Size(132, 21);
            this.prodi.TabIndex = 8;
            this.prodi.Text = "– Pilih Program Studi –";
            this.prodi.SelectedIndexChanged += new System.EventHandler(this.prodi_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(182, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(182, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(104, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "NPM";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(104, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Nama";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(104, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Tanggal Lahir";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(104, 221);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Jenis Kelamin";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(104, 268);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Alamat";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(104, 357);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "No Telepon";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(104, 398);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Program Studi";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(159, 449);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 23;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(312, 449);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 484);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prodi);
            this.Controls.Add(this.tlp);
            this.Controls.Add(this.alamat);
            this.Controls.Add(this.wanita);
            this.Controls.Add(this.pria);
            this.Controls.Add(this.ttl);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.npm);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Master Mahasiswa";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private NumericTextBox.NumericTextBox npm;
        private CharTextBox.CharTextBox nama;
        private System.Windows.Forms.DateTimePicker ttl;
        private System.Windows.Forms.RadioButton pria;
        private System.Windows.Forms.RadioButton wanita;
        private System.Windows.Forms.TextBox alamat;
        private NumericTextBox.NumericTextBox tlp;
        private System.Windows.Forms.ComboBox prodi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

