namespace EmpManagement
{
    partial class ViewEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEmployee));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Empgenlbl = new System.Windows.Forms.Label();
            this.empedulbl = new System.Windows.Forms.Label();
            this.empdoblbl = new System.Windows.Forms.Label();
            this.empnamelbl = new System.Windows.Forms.Label();
            this.empphonelbl = new System.Windows.Forms.Label();
            this.empposlbl = new System.Windows.Forms.Label();
            this.empaddlbl = new System.Windows.Forms.Label();
            this.Empidlbl = new System.Windows.Forms.Label();
            this.bunifuThinButton25 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.EmpidTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.bunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(1005, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 25);
            this.label11.TabIndex = 9;
            this.label11.Text = "X";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(77, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 34);
            this.label1.TabIndex = 8;
            this.label1.Text = "Employee Details";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Empgenlbl);
            this.panel1.Controls.Add(this.empedulbl);
            this.panel1.Controls.Add(this.empdoblbl);
            this.panel1.Controls.Add(this.empnamelbl);
            this.panel1.Controls.Add(this.empphonelbl);
            this.panel1.Controls.Add(this.empposlbl);
            this.panel1.Controls.Add(this.empaddlbl);
            this.panel1.Controls.Add(this.Empidlbl);
            this.panel1.Controls.Add(this.bunifuThinButton25);
            this.panel1.Controls.Add(this.EmpidTb);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.bunifuThinButton24);
            this.panel1.Controls.Add(this.bunifuThinButton21);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 516);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Empgenlbl
            // 
            this.Empgenlbl.AutoSize = true;
            this.Empgenlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empgenlbl.ForeColor = System.Drawing.Color.Navy;
            this.Empgenlbl.Location = new System.Drawing.Point(770, 185);
            this.Empgenlbl.Name = "Empgenlbl";
            this.Empgenlbl.Size = new System.Drawing.Size(137, 20);
            this.Empgenlbl.TabIndex = 36;
            this.Empgenlbl.Text = "Employee Gender";
            this.Empgenlbl.Visible = false;
            // 
            // empedulbl
            // 
            this.empedulbl.AutoSize = true;
            this.empedulbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empedulbl.ForeColor = System.Drawing.Color.Navy;
            this.empedulbl.Location = new System.Drawing.Point(770, 330);
            this.empedulbl.Name = "empedulbl";
            this.empedulbl.Size = new System.Drawing.Size(155, 20);
            this.empedulbl.TabIndex = 35;
            this.empedulbl.Text = "Employee Education";
            this.empedulbl.Visible = false;
            // 
            // empdoblbl
            // 
            this.empdoblbl.AutoSize = true;
            this.empdoblbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empdoblbl.ForeColor = System.Drawing.Color.Navy;
            this.empdoblbl.Location = new System.Drawing.Point(770, 250);
            this.empdoblbl.Name = "empdoblbl";
            this.empdoblbl.Size = new System.Drawing.Size(118, 20);
            this.empdoblbl.TabIndex = 34;
            this.empdoblbl.Text = "Employee DOB";
            this.empdoblbl.Visible = false;
            // 
            // empnamelbl
            // 
            this.empnamelbl.AutoSize = true;
            this.empnamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empnamelbl.ForeColor = System.Drawing.Color.Navy;
            this.empnamelbl.Location = new System.Drawing.Point(770, 119);
            this.empnamelbl.Name = "empnamelbl";
            this.empnamelbl.Size = new System.Drawing.Size(125, 20);
            this.empnamelbl.TabIndex = 33;
            this.empnamelbl.Text = "Employee Name";
            this.empnamelbl.Visible = false;
            // 
            // empphonelbl
            // 
            this.empphonelbl.AutoSize = true;
            this.empphonelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empphonelbl.ForeColor = System.Drawing.Color.Navy;
            this.empphonelbl.Location = new System.Drawing.Point(325, 327);
            this.empphonelbl.Name = "empphonelbl";
            this.empphonelbl.Size = new System.Drawing.Size(129, 20);
            this.empphonelbl.TabIndex = 32;
            this.empphonelbl.Text = "Employee Phone";
            this.empphonelbl.Visible = false;
            // 
            // empposlbl
            // 
            this.empposlbl.AutoSize = true;
            this.empposlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empposlbl.ForeColor = System.Drawing.Color.Navy;
            this.empposlbl.Location = new System.Drawing.Point(325, 247);
            this.empposlbl.Name = "empposlbl";
            this.empposlbl.Size = new System.Drawing.Size(139, 20);
            this.empposlbl.TabIndex = 31;
            this.empposlbl.Text = "Employee Position";
            this.empposlbl.Visible = false;
            // 
            // empaddlbl
            // 
            this.empaddlbl.AutoSize = true;
            this.empaddlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empaddlbl.ForeColor = System.Drawing.Color.Navy;
            this.empaddlbl.Location = new System.Drawing.Point(325, 181);
            this.empaddlbl.Name = "empaddlbl";
            this.empaddlbl.Size = new System.Drawing.Size(142, 20);
            this.empaddlbl.TabIndex = 30;
            this.empaddlbl.Text = "Employee Address";
            this.empaddlbl.Visible = false;
            // 
            // Empidlbl
            // 
            this.Empidlbl.AutoSize = true;
            this.Empidlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empidlbl.ForeColor = System.Drawing.Color.Navy;
            this.Empidlbl.Location = new System.Drawing.Point(325, 119);
            this.Empidlbl.Name = "Empidlbl";
            this.Empidlbl.Size = new System.Drawing.Size(97, 20);
            this.Empidlbl.TabIndex = 29;
            this.Empidlbl.Text = "Employee Id";
            this.Empidlbl.Visible = false;
            // 
            // bunifuThinButton25
            // 
            this.bunifuThinButton25.ActiveBorderThickness = 1;
            this.bunifuThinButton25.ActiveCornerRadius = 20;
            this.bunifuThinButton25.ActiveFillColor = System.Drawing.Color.Orange;
            this.bunifuThinButton25.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton25.ActiveLineColor = System.Drawing.Color.Orange;
            this.bunifuThinButton25.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton25.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton25.BackgroundImage")));
            this.bunifuThinButton25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuThinButton25.ButtonText = "Search";
            this.bunifuThinButton25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton25.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton25.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton25.IdleBorderThickness = 1;
            this.bunifuThinButton25.IdleCornerRadius = 20;
            this.bunifuThinButton25.IdleFillColor = System.Drawing.Color.Cyan;
            this.bunifuThinButton25.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton25.IdleLineColor = System.Drawing.Color.Cyan;
            this.bunifuThinButton25.Location = new System.Drawing.Point(582, 22);
            this.bunifuThinButton25.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton25.Name = "bunifuThinButton25";
            this.bunifuThinButton25.Size = new System.Drawing.Size(93, 44);
            this.bunifuThinButton25.TabIndex = 28;
            this.bunifuThinButton25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton25.Click += new System.EventHandler(this.bunifuThinButton25_Click);
            // 
            // EmpidTb
            // 
            this.EmpidTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpidTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpidTb.ForeColor = System.Drawing.Color.SpringGreen;
            this.EmpidTb.HintForeColor = System.Drawing.Color.Empty;
            this.EmpidTb.HintText = "";
            this.EmpidTb.isPassword = false;
            this.EmpidTb.LineFocusedColor = System.Drawing.Color.Brown;
            this.EmpidTb.LineIdleColor = System.Drawing.Color.Cyan;
            this.EmpidTb.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.EmpidTb.LineThickness = 3;
            this.EmpidTb.Location = new System.Drawing.Point(468, 33);
            this.EmpidTb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.EmpidTb.Name = "EmpidTb";
            this.EmpidTb.Size = new System.Drawing.Size(107, 28);
            this.EmpidTb.TabIndex = 27;
            this.EmpidTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.EmpidTb.OnValueChanged += new System.EventHandler(this.EmpidTb_OnValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Californian FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Turquoise;
            this.label10.Location = new System.Drawing.Point(340, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 26);
            this.label10.TabIndex = 26;
            this.label10.Text = "Employee ID";
            // 
            // bunifuThinButton24
            // 
            this.bunifuThinButton24.ActiveBorderThickness = 1;
            this.bunifuThinButton24.ActiveCornerRadius = 20;
            this.bunifuThinButton24.ActiveFillColor = System.Drawing.Color.Orange;
            this.bunifuThinButton24.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton24.ActiveLineColor = System.Drawing.Color.Orange;
            this.bunifuThinButton24.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton24.BackgroundImage")));
            this.bunifuThinButton24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuThinButton24.ButtonText = "Home";
            this.bunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton24.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton24.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.IdleBorderThickness = 1;
            this.bunifuThinButton24.IdleCornerRadius = 20;
            this.bunifuThinButton24.IdleFillColor = System.Drawing.Color.Cyan;
            this.bunifuThinButton24.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton24.IdleLineColor = System.Drawing.Color.Cyan;
            this.bunifuThinButton24.Location = new System.Drawing.Point(572, 414);
            this.bunifuThinButton24.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton24.Name = "bunifuThinButton24";
            this.bunifuThinButton24.Size = new System.Drawing.Size(93, 44);
            this.bunifuThinButton24.TabIndex = 25;
            this.bunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton24.Click += new System.EventHandler(this.bunifuThinButton24_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.Orange;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.Orange;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuThinButton21.ButtonText = "Print";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Cyan;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Cyan;
            this.bunifuThinButton21.Location = new System.Drawing.Point(368, 414);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(93, 44);
            this.bunifuThinButton21.TabIndex = 22;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Californian FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Turquoise;
            this.label9.Location = new System.Drawing.Point(578, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 26);
            this.label9.TabIndex = 20;
            this.label9.Text = "Employee Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Californian FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Turquoise;
            this.label8.Location = new System.Drawing.Point(578, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 26);
            this.label8.TabIndex = 18;
            this.label8.Text = "Employee Education";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Californian FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Turquoise;
            this.label7.Location = new System.Drawing.Point(144, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "Employee Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Californian FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Turquoise;
            this.label6.Location = new System.Drawing.Point(578, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 26);
            this.label6.TabIndex = 14;
            this.label6.Text = "Employee DOB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Californian FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Turquoise;
            this.label4.Location = new System.Drawing.Point(142, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Employee Position";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Californian FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Turquoise;
            this.label5.Location = new System.Drawing.Point(144, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Employee Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Californian FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Turquoise;
            this.label3.Location = new System.Drawing.Point(578, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Employee Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Californian FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Turquoise;
            this.label2.Location = new System.Drawing.Point(144, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Employee ID";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(914, 608);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "New Eden";
            // 
            // ViewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(1034, 637);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewEmployee";
            this.Load += new System.EventHandler(this.ViewEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton25;
        private Bunifu.Framework.UI.BunifuMaterialTextbox EmpidTb;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label empphonelbl;
        private System.Windows.Forms.Label empposlbl;
        private System.Windows.Forms.Label empaddlbl;
        private System.Windows.Forms.Label Empidlbl;
        private System.Windows.Forms.Label Empgenlbl;
        private System.Windows.Forms.Label empedulbl;
        private System.Windows.Forms.Label empdoblbl;
        private System.Windows.Forms.Label empnamelbl;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label12;
    }
}