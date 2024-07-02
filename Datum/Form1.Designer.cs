namespace Datum
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGratulacio = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mskdTxtSzulDatum = new System.Windows.Forms.MaskedTextBox();
            this.txtNapSorszam = new System.Windows.Forms.TextBox();
            this.txtNap = new System.Windows.Forms.TextBox();
            this.txtEvSzam = new System.Windows.Forms.TextBox();
            this.txtKesobbiDatum = new System.Windows.Forms.TextBox();
            this.lblDatum = new System.Windows.Forms.Label();
            this.txtNapSzam = new System.Windows.Forms.TextBox();
            this.btnKiir = new System.Windows.Forms.Button();
            this.btnTorol = new System.Windows.Forms.Button();
            this.btnBezár = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(66, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pontos idő és dátum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(66, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Születési dátum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(66, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ennyi éves vagy:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(399, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ilyen napon születtél:";
            // 
            // lblGratulacio
            // 
            this.lblGratulacio.AutoSize = true;
            this.lblGratulacio.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblGratulacio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGratulacio.ForeColor = System.Drawing.Color.Red;
            this.lblGratulacio.Location = new System.Drawing.Point(327, 257);
            this.lblGratulacio.Name = "lblGratulacio";
            this.lblGratulacio.Size = new System.Drawing.Size(151, 25);
            this.lblGratulacio.TabIndex = 4;
            this.lblGratulacio.Text = "Isten éltessen!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(66, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tetszőleges dátum:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(399, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ez az év ennyiedik napja:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(399, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "nappal késsőbi dátum:";
            // 
            // mskdTxtSzulDatum
            // 
            this.mskdTxtSzulDatum.Location = new System.Drawing.Point(184, 76);
            this.mskdTxtSzulDatum.Mask = "0000/00/00";
            this.mskdTxtSzulDatum.Name = "mskdTxtSzulDatum";
            this.mskdTxtSzulDatum.RejectInputOnFirstFailure = true;
            this.mskdTxtSzulDatum.Size = new System.Drawing.Size(100, 20);
            this.mskdTxtSzulDatum.TabIndex = 8;
            this.mskdTxtSzulDatum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mskdTxtSzulDatum_KeyDown);
            this.mskdTxtSzulDatum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskdTxtSzulDatum_KeyPress);
            this.mskdTxtSzulDatum.Leave += new System.EventHandler(this.mskdTxtSzulDatum_Leave);
            // 
            // txtNapSorszam
            // 
            this.txtNapSorszam.Location = new System.Drawing.Point(563, 300);
            this.txtNapSorszam.Name = "txtNapSorszam";
            this.txtNapSorszam.Size = new System.Drawing.Size(100, 20);
            this.txtNapSorszam.TabIndex = 9;
            // 
            // txtNap
            // 
            this.txtNap.Location = new System.Drawing.Point(535, 164);
            this.txtNap.Name = "txtNap";
            this.txtNap.Size = new System.Drawing.Size(100, 20);
            this.txtNap.TabIndex = 10;
            // 
            // txtEvSzam
            // 
            this.txtEvSzam.Location = new System.Drawing.Point(181, 165);
            this.txtEvSzam.Name = "txtEvSzam";
            this.txtEvSzam.Size = new System.Drawing.Size(100, 20);
            this.txtEvSzam.TabIndex = 11;
            // 
            // txtKesobbiDatum
            // 
            this.txtKesobbiDatum.Location = new System.Drawing.Point(548, 353);
            this.txtKesobbiDatum.Name = "txtKesobbiDatum";
            this.txtKesobbiDatum.Size = new System.Drawing.Size(100, 20);
            this.txtKesobbiDatum.TabIndex = 12;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDatum.Location = new System.Drawing.Point(278, 20);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(76, 25);
            this.lblDatum.TabIndex = 13;
            this.lblDatum.Text = "label9";
            // 
            // txtNapSzam
            // 
            this.txtNapSzam.Location = new System.Drawing.Point(283, 353);
            this.txtNapSzam.Name = "txtNapSzam";
            this.txtNapSzam.Size = new System.Drawing.Size(100, 20);
            this.txtNapSzam.TabIndex = 14;
            this.txtNapSzam.TextChanged += new System.EventHandler(this.txtNapSzam_TextChanged);
            // 
            // btnKiir
            // 
            this.btnKiir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKiir.Location = new System.Drawing.Point(100, 406);
            this.btnKiir.Name = "btnKiir";
            this.btnKiir.Size = new System.Drawing.Size(75, 32);
            this.btnKiir.TabIndex = 15;
            this.btnKiir.Text = "Kiír";
            this.btnKiir.UseVisualStyleBackColor = true;
            this.btnKiir.Click += new System.EventHandler(this.btnKiir_Click);
            // 
            // btnTorol
            // 
            this.btnTorol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTorol.Location = new System.Drawing.Point(332, 406);
            this.btnTorol.Name = "btnTorol";
            this.btnTorol.Size = new System.Drawing.Size(75, 32);
            this.btnTorol.TabIndex = 16;
            this.btnTorol.Text = "Töröl";
            this.btnTorol.UseVisualStyleBackColor = true;
            this.btnTorol.Click += new System.EventHandler(this.btnTorol_Click);
            // 
            // btnBezár
            // 
            this.btnBezár.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBezár.Location = new System.Drawing.Point(535, 406);
            this.btnBezár.Name = "btnBezár";
            this.btnBezár.Size = new System.Drawing.Size(75, 32);
            this.btnBezár.TabIndex = 17;
            this.btnBezár.Text = "Bezár";
            this.btnBezár.UseVisualStyleBackColor = true;
            this.btnBezár.Click += new System.EventHandler(this.btnBezár_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Location = new System.Drawing.Point(69, 353);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 22);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnBezár);
            this.Controls.Add(this.btnTorol);
            this.Controls.Add(this.btnKiir);
            this.Controls.Add(this.txtNapSzam);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.txtKesobbiDatum);
            this.Controls.Add(this.txtEvSzam);
            this.Controls.Add(this.txtNap);
            this.Controls.Add(this.txtNapSorszam);
            this.Controls.Add(this.mskdTxtSzulDatum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblGratulacio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGratulacio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mskdTxtSzulDatum;
        private System.Windows.Forms.TextBox txtNapSorszam;
        private System.Windows.Forms.TextBox txtNap;
        private System.Windows.Forms.TextBox txtEvSzam;
        private System.Windows.Forms.TextBox txtKesobbiDatum;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.TextBox txtNapSzam;
        private System.Windows.Forms.Button btnKiir;
        private System.Windows.Forms.Button btnTorol;
        private System.Windows.Forms.Button btnBezár;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Timer timer1;
    }
}

