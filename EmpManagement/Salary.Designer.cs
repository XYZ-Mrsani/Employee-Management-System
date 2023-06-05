namespace EmpManagement
{
    partial class Salary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.SalarySlip = new System.Windows.Forms.RichTextBox();
            this.bunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label7 = new System.Windows.Forms.Label();
            this.WorkedTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.EmpPosTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.EmpNameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmpIdTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(1081, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 25);
            this.label11.TabIndex = 12;
            this.label11.Text = "X";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(70, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Salary";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.SalarySlip);
            this.panel1.Controls.Add(this.bunifuThinButton24);
            this.panel1.Controls.Add(this.bunifuThinButton23);
            this.panel1.Controls.Add(this.bunifuThinButton22);
            this.panel1.Controls.Add(this.bunifuThinButton21);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.WorkedTb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.EmpPosTb);
            this.panel1.Controls.Add(this.EmpNameTb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.EmpIdTb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 516);
            this.panel1.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.ForestGreen;
            this.label5.Location = new System.Drawing.Point(705, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Calculate Salary";
            // 
            // SalarySlip
            // 
            this.SalarySlip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SalarySlip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalarySlip.ForeColor = System.Drawing.Color.Navy;
            this.SalarySlip.Location = new System.Drawing.Point(415, 37);
            this.SalarySlip.Name = "SalarySlip";
            this.SalarySlip.Size = new System.Drawing.Size(679, 399);
            this.SalarySlip.TabIndex = 26;
            this.SalarySlip.Text = "";
            this.SalarySlip.TextChanged += new System.EventHandler(this.SalarySlip_TextChanged);
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
            this.bunifuThinButton24.Location = new System.Drawing.Point(19, 444);
            this.bunifuThinButton24.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton24.Name = "bunifuThinButton24";
            this.bunifuThinButton24.Size = new System.Drawing.Size(93, 44);
            this.bunifuThinButton24.TabIndex = 25;
            this.bunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton24.Click += new System.EventHandler(this.bunifuThinButton24_Click);
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.Orange;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.Orange;
            this.bunifuThinButton23.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuThinButton23.ButtonText = "Fetch Data";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.Cyan;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.Cyan;
            this.bunifuThinButton23.Location = new System.Drawing.Point(195, 317);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(116, 44);
            this.bunifuThinButton23.TabIndex = 24;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.Orange;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.Orange;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuThinButton22.ButtonText = "View";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.Cyan;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.Cyan;
            this.bunifuThinButton22.Location = new System.Drawing.Point(119, 444);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(93, 44);
            this.bunifuThinButton22.TabIndex = 23;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
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
            this.bunifuThinButton21.Location = new System.Drawing.Point(748, 444);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(93, 44);
            this.bunifuThinButton21.TabIndex = 22;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.ForestGreen;
            this.label7.Location = new System.Drawing.Point(15, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "Worked Days";
            // 
            // WorkedTb
            // 
            this.WorkedTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.WorkedTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkedTb.ForeColor = System.Drawing.Color.Red;
            this.WorkedTb.HintForeColor = System.Drawing.Color.Empty;
            this.WorkedTb.HintText = "";
            this.WorkedTb.isPassword = false;
            this.WorkedTb.LineFocusedColor = System.Drawing.Color.Brown;
            this.WorkedTb.LineIdleColor = System.Drawing.Color.Cyan;
            this.WorkedTb.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.WorkedTb.LineThickness = 3;
            this.WorkedTb.Location = new System.Drawing.Point(19, 333);
            this.WorkedTb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.WorkedTb.Name = "WorkedTb";
            this.WorkedTb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WorkedTb.Size = new System.Drawing.Size(144, 28);
            this.WorkedTb.TabIndex = 12;
            this.WorkedTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.ForestGreen;
            this.label4.Location = new System.Drawing.Point(15, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Employee Position";
            // 
            // EmpPosTb
            // 
            this.EmpPosTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpPosTb.Enabled = false;
            this.EmpPosTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpPosTb.ForeColor = System.Drawing.Color.Red;
            this.EmpPosTb.HintForeColor = System.Drawing.Color.Empty;
            this.EmpPosTb.HintText = "";
            this.EmpPosTb.isPassword = false;
            this.EmpPosTb.LineFocusedColor = System.Drawing.Color.Brown;
            this.EmpPosTb.LineIdleColor = System.Drawing.Color.Cyan;
            this.EmpPosTb.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.EmpPosTb.LineThickness = 3;
            this.EmpPosTb.Location = new System.Drawing.Point(19, 256);
            this.EmpPosTb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.EmpPosTb.Name = "EmpPosTb";
            this.EmpPosTb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EmpPosTb.Size = new System.Drawing.Size(144, 28);
            this.EmpPosTb.TabIndex = 10;
            this.EmpPosTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // EmpNameTb
            // 
            this.EmpNameTb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EmpNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpNameTb.Enabled = false;
            this.EmpNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpNameTb.ForeColor = System.Drawing.Color.Red;
            this.EmpNameTb.HintForeColor = System.Drawing.Color.Empty;
            this.EmpNameTb.HintText = "";
            this.EmpNameTb.isPassword = false;
            this.EmpNameTb.LineFocusedColor = System.Drawing.Color.Brown;
            this.EmpNameTb.LineIdleColor = System.Drawing.Color.Cyan;
            this.EmpNameTb.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.EmpNameTb.LineThickness = 3;
            this.EmpNameTb.Location = new System.Drawing.Point(19, 166);
            this.EmpNameTb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.EmpNameTb.Name = "EmpNameTb";
            this.EmpNameTb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EmpNameTb.Size = new System.Drawing.Size(121, 28);
            this.EmpNameTb.TabIndex = 8;
            this.EmpNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(15, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Employee Name";
            // 
            // EmpIdTb
            // 
            this.EmpIdTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpIdTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpIdTb.ForeColor = System.Drawing.Color.Black;
            this.EmpIdTb.HintForeColor = System.Drawing.Color.Empty;
            this.EmpIdTb.HintText = "";
            this.EmpIdTb.isPassword = false;
            this.EmpIdTb.LineFocusedColor = System.Drawing.Color.Brown;
            this.EmpIdTb.LineIdleColor = System.Drawing.Color.Cyan;
            this.EmpIdTb.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.EmpIdTb.LineThickness = 3;
            this.EmpIdTb.Location = new System.Drawing.Point(19, 84);
            this.EmpIdTb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.EmpIdTb.Name = "EmpIdTb";
            this.EmpIdTb.Size = new System.Drawing.Size(121, 28);
            this.EmpIdTb.TabIndex = 6;
            this.EmpIdTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(15, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Employee Id";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(990, 608);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "New Eden";
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(1110, 637);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Salary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary";
            this.Load += new System.EventHandler(this.Salary_Load);
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
        private System.Windows.Forms.RichTextBox SalarySlip;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox WorkedTb;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox EmpPosTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox EmpNameTb;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox EmpIdTb;
        private System.Windows.Forms.Label label2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
    }
}