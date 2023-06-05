
namespace EmpManagement
{
    partial class EditEmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditEmp));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.EmpDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.bunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.EmpGenCb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.EmpEduCb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.EmpDob = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.EmpPosCb = new System.Windows.Forms.ComboBox();
            this.EmpPhoneTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.EmpAddTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.EmpNameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmpIdTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(974, 611);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "New Eden";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // EmpDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.EmpDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.EmpDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmpDGV.BackgroundColor = System.Drawing.Color.White;
            this.EmpDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmpDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmpDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmpDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EmpDGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmpDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.EmpDGV.EnableHeadersVisualStyles = false;
            this.EmpDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmpDGV.Location = new System.Drawing.Point(391, 24);
            this.EmpDGV.Name = "EmpDGV";
            this.EmpDGV.RowHeadersVisible = false;
            this.EmpDGV.RowHeadersWidth = 51;
            this.EmpDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmpDGV.Size = new System.Drawing.Size(708, 468);
            this.EmpDGV.TabIndex = 26;
            this.EmpDGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.EmpDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.EmpDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.EmpDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.EmpDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.EmpDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.EmpDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.EmpDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmpDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.OrangeRed;
            this.EmpDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.EmpDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.EmpDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.EmpDGV.ThemeStyle.HeaderStyle.Height = 25;
            this.EmpDGV.ThemeStyle.ReadOnly = false;
            this.EmpDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.EmpDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmpDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.EmpDGV.ThemeStyle.RowsStyle.Height = 22;
            this.EmpDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Coral;
            this.EmpDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.EmpDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpDGV_CellContentClick);
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
            this.bunifuThinButton24.ButtonText = "Home";
            this.bunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton24.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton24.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton24.IdleBorderThickness = 1;
            this.bunifuThinButton24.IdleCornerRadius = 20;
            this.bunifuThinButton24.IdleFillColor = System.Drawing.Color.Cyan;
            this.bunifuThinButton24.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton24.IdleLineColor = System.Drawing.Color.Cyan;
            this.bunifuThinButton24.Location = new System.Drawing.Point(227, 397);
            this.bunifuThinButton24.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton24.Name = "bunifuThinButton24";
            this.bunifuThinButton24.Size = new System.Drawing.Size(93, 44);
            this.bunifuThinButton24.TabIndex = 25;
            this.bunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton24.Click += new System.EventHandler(this.bunifuThinButton24_Click);
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
            this.bunifuThinButton22.ButtonText = "Edit";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.Cyan;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.Cyan;
            this.bunifuThinButton22.Location = new System.Drawing.Point(63, 397);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(93, 44);
            this.bunifuThinButton22.TabIndex = 23;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // EmpGenCb
            // 
            this.EmpGenCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EmpGenCb.ForeColor = System.Drawing.Color.Red;
            this.EmpGenCb.FormattingEnabled = true;
            this.EmpGenCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.EmpGenCb.Location = new System.Drawing.Point(201, 172);
            this.EmpGenCb.Name = "EmpGenCb";
            this.EmpGenCb.Size = new System.Drawing.Size(184, 28);
            this.EmpGenCb.TabIndex = 21;
            this.EmpGenCb.SelectedIndexChanged += new System.EventHandler(this.EmpGenCb_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SpringGreen;
            this.label9.Location = new System.Drawing.Point(208, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 26);
            this.label9.TabIndex = 20;
            this.label9.Text = "Employee Gender";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // EmpEduCb
            // 
            this.EmpEduCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EmpEduCb.ForeColor = System.Drawing.Color.Red;
            this.EmpEduCb.FormattingEnabled = true;
            this.EmpEduCb.Items.AddRange(new object[] {
            "Ordinary Level",
            "Advanced Level",
            "Diploma",
            "BSC"});
            this.EmpEduCb.Location = new System.Drawing.Point(197, 328);
            this.EmpEduCb.Name = "EmpEduCb";
            this.EmpEduCb.Size = new System.Drawing.Size(184, 28);
            this.EmpEduCb.TabIndex = 19;
            this.EmpEduCb.SelectedIndexChanged += new System.EventHandler(this.EmpEduCb_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SpringGreen;
            this.label8.Location = new System.Drawing.Point(208, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 26);
            this.label8.TabIndex = 18;
            this.label8.Text = "Employee Education";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SpringGreen;
            this.label7.Location = new System.Drawing.Point(27, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "Employee Phone";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // EmpDob
            // 
            this.EmpDob.Font = new System.Drawing.Font("Microsoft Yi Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpDob.Location = new System.Drawing.Point(198, 247);
            this.EmpDob.Name = "EmpDob";
            this.EmpDob.Size = new System.Drawing.Size(187, 22);
            this.EmpDob.TabIndex = 15;
            this.EmpDob.ValueChanged += new System.EventHandler(this.EmpDob_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SpringGreen;
            this.label6.Location = new System.Drawing.Point(208, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 26);
            this.label6.TabIndex = 14;
            this.label6.Text = "Employee DOB";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // EmpPosCb
            // 
            this.EmpPosCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EmpPosCb.ForeColor = System.Drawing.Color.Red;
            this.EmpPosCb.FormattingEnabled = true;
            this.EmpPosCb.Items.AddRange(new object[] {
            "Manager",
            "Accountant",
            "Cutomer service",
            "Cashier",
            "Co-Workers"});
            this.EmpPosCb.Location = new System.Drawing.Point(26, 241);
            this.EmpPosCb.Name = "EmpPosCb";
            this.EmpPosCb.Size = new System.Drawing.Size(154, 28);
            this.EmpPosCb.TabIndex = 13;
            this.EmpPosCb.SelectedIndexChanged += new System.EventHandler(this.EmpPosCb_SelectedIndexChanged);
            // 
            // EmpPhoneTb
            // 
            this.EmpPhoneTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpPhoneTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpPhoneTb.ForeColor = System.Drawing.Color.Red;
            this.EmpPhoneTb.HintForeColor = System.Drawing.Color.Empty;
            this.EmpPhoneTb.HintText = "";
            this.EmpPhoneTb.isPassword = false;
            this.EmpPhoneTb.LineFocusedColor = System.Drawing.Color.Orange;
            this.EmpPhoneTb.LineIdleColor = System.Drawing.Color.Cyan;
            this.EmpPhoneTb.LineMouseHoverColor = System.Drawing.Color.Orange;
            this.EmpPhoneTb.LineThickness = 3;
            this.EmpPhoneTb.Location = new System.Drawing.Point(31, 328);
            this.EmpPhoneTb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.EmpPhoneTb.Name = "EmpPhoneTb";
            this.EmpPhoneTb.Size = new System.Drawing.Size(139, 28);
            this.EmpPhoneTb.TabIndex = 12;
            this.EmpPhoneTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.EmpPhoneTb.OnValueChanged += new System.EventHandler(this.EmpPhoneTb_OnValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SpringGreen;
            this.label4.Location = new System.Drawing.Point(23, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Employee Position";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // EmpAddTb
            // 
            this.EmpAddTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpAddTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpAddTb.ForeColor = System.Drawing.Color.Red;
            this.EmpAddTb.HintForeColor = System.Drawing.Color.Empty;
            this.EmpAddTb.HintText = "";
            this.EmpAddTb.isPassword = false;
            this.EmpAddTb.LineFocusedColor = System.Drawing.Color.Orange;
            this.EmpAddTb.LineIdleColor = System.Drawing.Color.Cyan;
            this.EmpAddTb.LineMouseHoverColor = System.Drawing.Color.Orange;
            this.EmpAddTb.LineThickness = 3;
            this.EmpAddTb.Location = new System.Drawing.Point(27, 165);
            this.EmpAddTb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.EmpAddTb.Name = "EmpAddTb";
            this.EmpAddTb.Size = new System.Drawing.Size(157, 28);
            this.EmpAddTb.TabIndex = 10;
            this.EmpAddTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.EmpAddTb.OnValueChanged += new System.EventHandler(this.EmpAddTb_OnValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SpringGreen;
            this.label5.Location = new System.Drawing.Point(25, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Employee Address";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // EmpNameTb
            // 
            this.EmpNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpNameTb.ForeColor = System.Drawing.Color.Red;
            this.EmpNameTb.HintForeColor = System.Drawing.Color.Empty;
            this.EmpNameTb.HintText = "";
            this.EmpNameTb.isPassword = false;
            this.EmpNameTb.LineFocusedColor = System.Drawing.Color.Orange;
            this.EmpNameTb.LineIdleColor = System.Drawing.Color.Cyan;
            this.EmpNameTb.LineMouseHoverColor = System.Drawing.Color.Orange;
            this.EmpNameTb.LineThickness = 3;
            this.EmpNameTb.Location = new System.Drawing.Point(197, 101);
            this.EmpNameTb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.EmpNameTb.Name = "EmpNameTb";
            this.EmpNameTb.Size = new System.Drawing.Size(187, 28);
            this.EmpNameTb.TabIndex = 8;
            this.EmpNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.EmpNameTb.OnValueChanged += new System.EventHandler(this.EmpNameTb_OnValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SpringGreen;
            this.label3.Location = new System.Drawing.Point(208, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Employee Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // EmpIdTb
            // 
            this.EmpIdTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpIdTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpIdTb.ForeColor = System.Drawing.Color.Red;
            this.EmpIdTb.HintForeColor = System.Drawing.Color.Empty;
            this.EmpIdTb.HintText = "";
            this.EmpIdTb.isPassword = false;
            this.EmpIdTb.LineFocusedColor = System.Drawing.Color.Orange;
            this.EmpIdTb.LineIdleColor = System.Drawing.Color.Cyan;
            this.EmpIdTb.LineMouseHoverColor = System.Drawing.Color.Orange;
            this.EmpIdTb.LineThickness = 3;
            this.EmpIdTb.Location = new System.Drawing.Point(27, 101);
            this.EmpIdTb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.EmpIdTb.Name = "EmpIdTb";
            this.EmpIdTb.Size = new System.Drawing.Size(107, 28);
            this.EmpIdTb.TabIndex = 6;
            this.EmpIdTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.EmpIdTb.OnValueChanged += new System.EventHandler(this.EmpIdTb_OnValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SpringGreen;
            this.label2.Location = new System.Drawing.Point(25, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Employee ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(1081, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 25);
            this.label11.TabIndex = 11;
            this.label11.Text = "X";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.EmpDGV);
            this.panel1.Controls.Add(this.bunifuThinButton24);
            this.panel1.Controls.Add(this.bunifuThinButton22);
            this.panel1.Controls.Add(this.EmpGenCb);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.EmpEduCb);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.EmpDob);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.EmpPosCb);
            this.panel1.Controls.Add(this.EmpPhoneTb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.EmpAddTb);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.EmpNameTb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.EmpIdTb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 516);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.GreenYellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(88, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Edit Employee";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // EditEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(1110, 637);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditEmp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditEmp";
            this.Load += new System.EventHandler(this.EditEmp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2DataGridView EmpDGV;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private System.Windows.Forms.ComboBox EmpGenCb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox EmpEduCb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker EmpDob;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox EmpPosCb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox EmpPhoneTb;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox EmpAddTb;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox EmpNameTb;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox EmpIdTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}