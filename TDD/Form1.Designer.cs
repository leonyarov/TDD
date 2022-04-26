namespace TDD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.workerTable = new System.Windows.Forms.DataGridView();
            this.calcTaxBtn = new System.Windows.Forms.Button();
            this.newWorkerBtn = new System.Windows.Forms.Button();
            this.addAlotBtn = new System.Windows.Forms.Button();
            this.sortBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.idText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.familyText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.adressText = new System.Windows.Forms.TextBox();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.salaryText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.incomeLbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.timeLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bubbleSortBtn = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.workerBar = new System.Windows.Forms.ProgressBar();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.workerTable)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // workerTable
            // 
            this.workerTable.AllowUserToAddRows = false;
            this.workerTable.AllowUserToDeleteRows = false;
            this.workerTable.AllowUserToResizeRows = false;
            this.workerTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.workerTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.workerTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(183)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.workerTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.workerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workerTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.id,
            this.phone,
            this.mail,
            this.address,
            this.salary});
            this.workerTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workerTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(183)))), ((int)(((byte)(182)))));
            this.workerTable.Location = new System.Drawing.Point(3, 16);
            this.workerTable.MultiSelect = false;
            this.workerTable.Name = "workerTable";
            this.workerTable.ReadOnly = true;
            this.workerTable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.workerTable.RowHeadersVisible = false;
            this.workerTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.workerTable.Size = new System.Drawing.Size(717, 536);
            this.workerTable.TabIndex = 0;
            // 
            // calcTaxBtn
            // 
            this.calcTaxBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(247)))), ((int)(((byte)(99)))));
            this.calcTaxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calcTaxBtn.Location = new System.Drawing.Point(346, 28);
            this.calcTaxBtn.Name = "calcTaxBtn";
            this.calcTaxBtn.Size = new System.Drawing.Size(75, 23);
            this.calcTaxBtn.TabIndex = 1;
            this.calcTaxBtn.Text = "חישוב מס";
            this.calcTaxBtn.UseVisualStyleBackColor = false;
            this.calcTaxBtn.Click += new System.EventHandler(this.calcTaxBtn_Click);
            // 
            // newWorkerBtn
            // 
            this.newWorkerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(247)))), ((int)(((byte)(99)))));
            this.newWorkerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newWorkerBtn.Location = new System.Drawing.Point(80, 104);
            this.newWorkerBtn.Name = "newWorkerBtn";
            this.newWorkerBtn.Size = new System.Drawing.Size(100, 23);
            this.newWorkerBtn.TabIndex = 2;
            this.newWorkerBtn.Text = "הוסף עובד";
            this.newWorkerBtn.UseVisualStyleBackColor = false;
            this.newWorkerBtn.Click += new System.EventHandler(this.newWorkerBtn_Click);
            // 
            // addAlotBtn
            // 
            this.addAlotBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(247)))), ((int)(((byte)(99)))));
            this.addAlotBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAlotBtn.Location = new System.Drawing.Point(285, 3);
            this.addAlotBtn.Name = "addAlotBtn";
            this.addAlotBtn.Size = new System.Drawing.Size(133, 24);
            this.addAlotBtn.TabIndex = 3;
            this.addAlotBtn.Text = "הוספת 10000 עובדים";
            this.addAlotBtn.UseVisualStyleBackColor = false;
            this.addAlotBtn.Click += new System.EventHandler(this.addAlotBtn_Click);
            // 
            // sortBtn
            // 
            this.sortBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(247)))), ((int)(((byte)(99)))));
            this.sortBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortBtn.Location = new System.Drawing.Point(288, 19);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(133, 24);
            this.sortBtn.TabIndex = 3;
            this.sortBtn.Text = "מיון לפי משכורת";
            this.sortBtn.UseVisualStyleBackColor = false;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.addAlotBtn);
            this.flowLayoutPanel1.Controls.Add(this.showBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(429, 67);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // idText
            // 
            this.idText.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.idText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idText.Location = new System.Drawing.Point(262, 31);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(100, 13);
            this.idText.TabIndex = 5;
            // 
            // nameText
            // 
            this.nameText.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.nameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameText.Location = new System.Drawing.Point(262, 57);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(100, 13);
            this.nameText.TabIndex = 5;
            // 
            // familyText
            // 
            this.familyText.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.familyText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.familyText.Location = new System.Drawing.Point(262, 83);
            this.familyText.Name = "familyText";
            this.familyText.Size = new System.Drawing.Size(100, 13);
            this.familyText.TabIndex = 5;
            // 
            // emailText
            // 
            this.emailText.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.emailText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailText.Location = new System.Drawing.Point(262, 109);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(100, 13);
            this.emailText.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.label1.Location = new System.Drawing.Point(368, 31);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ת\"ז";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.label2.Location = new System.Drawing.Point(368, 57);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "שם פרטי";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.label3.Location = new System.Drawing.Point(368, 83);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "שם משפחה";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.label4.Location = new System.Drawing.Point(368, 109);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "אימייל";
            // 
            // adressText
            // 
            this.adressText.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.adressText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adressText.Location = new System.Drawing.Point(80, 27);
            this.adressText.Name = "adressText";
            this.adressText.Size = new System.Drawing.Size(100, 13);
            this.adressText.TabIndex = 5;
            // 
            // phoneText
            // 
            this.phoneText.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.phoneText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneText.Location = new System.Drawing.Point(80, 53);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(100, 13);
            this.phoneText.TabIndex = 5;
            // 
            // salaryText
            // 
            this.salaryText.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.salaryText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.salaryText.Location = new System.Drawing.Point(80, 79);
            this.salaryText.Name = "salaryText";
            this.salaryText.Size = new System.Drawing.Size(100, 13);
            this.salaryText.TabIndex = 5;
            this.salaryText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salaryText_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.label5.Location = new System.Drawing.Point(186, 27);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "כתובת";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.label6.Location = new System.Drawing.Point(186, 53);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "טלפון";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.label7.Location = new System.Drawing.Point(186, 79);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "משכורת";
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(247)))), ((int)(((byte)(99)))));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Location = new System.Drawing.Point(351, 152);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "יציאה";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(229, 33);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "מס הכנסה חודשי:";
            // 
            // incomeLbl
            // 
            this.incomeLbl.AutoSize = true;
            this.incomeLbl.Location = new System.Drawing.Point(80, 33);
            this.incomeLbl.Name = "incomeLbl";
            this.incomeLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.incomeLbl.Size = new System.Drawing.Size(42, 13);
            this.incomeLbl.TabIndex = 6;
            this.incomeLbl.Text = "XXXXX";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(380, 46);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "זמן מיון:";
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Location = new System.Drawing.Point(130, 46);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.timeLbl.Size = new System.Drawing.Size(14, 13);
            this.timeLbl.TabIndex = 6;
            this.timeLbl.Text = "X";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.groupBox1.Controls.Add(this.adressText);
            this.groupBox1.Controls.Add(this.newWorkerBtn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.idText);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.nameText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.familyText);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.phoneText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.salaryText);
            this.groupBox1.Controls.Add(this.emailText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(435, 138);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "הוספת עובד חדש";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.groupBox2.Controls.Add(this.workerTable);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(723, 555);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "רשימת עובדים";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.groupBox3.Controls.Add(this.flowLayoutPanel1);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(0, 147);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(435, 86);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "כלים";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.groupBox4.Controls.Add(this.bubbleSortBtn);
            this.groupBox4.Controls.Add(this.sortBtn);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.timeLbl);
            this.groupBox4.Location = new System.Drawing.Point(0, 239);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(435, 70);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "מיון";
            // 
            // bubbleSortBtn
            // 
            this.bubbleSortBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(247)))), ((int)(((byte)(99)))));
            this.bubbleSortBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bubbleSortBtn.Location = new System.Drawing.Point(130, 19);
            this.bubbleSortBtn.Name = "bubbleSortBtn";
            this.bubbleSortBtn.Size = new System.Drawing.Size(152, 24);
            this.bubbleSortBtn.TabIndex = 3;
            this.bubbleSortBtn.Text = "מיון בועות לפי משכורת";
            this.bubbleSortBtn.UseVisualStyleBackColor = false;
            this.bubbleSortBtn.Click += new System.EventHandler(this.bubbleSortBtn_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.groupBox5.Controls.Add(this.incomeLbl);
            this.groupBox5.Controls.Add(this.calcTaxBtn);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(0, 315);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox5.Size = new System.Drawing.Size(435, 62);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "חישוב מס";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.groupBox1);
            this.flowLayoutPanel2.Controls.Add(this.groupBox3);
            this.flowLayoutPanel2.Controls.Add(this.groupBox4);
            this.flowLayoutPanel2.Controls.Add(this.groupBox5);
            this.flowLayoutPanel2.Controls.Add(this.panel1);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(740, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(438, 566);
            this.flowLayoutPanel2.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Controls.Add(this.workerBar);
            this.panel1.Location = new System.Drawing.Point(-5, 383);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 183);
            this.panel1.TabIndex = 13;
            // 
            // workerBar
            // 
            this.workerBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.workerBar.Location = new System.Drawing.Point(0, 0);
            this.workerBar.Margin = new System.Windows.Forms.Padding(0);
            this.workerBar.Maximum = 10000;
            this.workerBar.Name = "workerBar";
            this.workerBar.Size = new System.Drawing.Size(440, 23);
            this.workerBar.Step = 1;
            this.workerBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.workerBar.TabIndex = 4;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1182, 581);
            this.flowLayoutPanel3.TabIndex = 14;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.groupBox2);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(731, 566);
            this.flowLayoutPanel4.TabIndex = 13;
            // 
            // name
            // 
            this.name.HeaderText = "שם";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "ת\"ז";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.HeaderText = "טלפון";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // mail
            // 
            this.mail.HeaderText = "אימייל";
            this.mail.Name = "mail";
            this.mail.ReadOnly = true;
            // 
            // address
            // 
            this.address.HeaderText = "כתובת";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // salary
            // 
            this.salary.HeaderText = "משכורת";
            this.salary.Name = "salary";
            this.salary.ReadOnly = true;
            // 
            // showBtn
            // 
            this.showBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(247)))), ((int)(((byte)(99)))));
            this.showBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showBtn.Location = new System.Drawing.Point(127, 3);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(152, 24);
            this.showBtn.TabIndex = 3;
            this.showBtn.Text = "הצג רשימת עובדים";
            this.showBtn.UseVisualStyleBackColor = false;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(140)))), ((int)(((byte)(142)))));
            this.ClientSize = new System.Drawing.Size(1182, 581);
            this.Controls.Add(this.flowLayoutPanel3);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(80)))), ((int)(((byte)(88)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "מערכת עובדים";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workerTable)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView workerTable;
        private System.Windows.Forms.Button calcTaxBtn;
        private System.Windows.Forms.Button newWorkerBtn;
        private System.Windows.Forms.Button addAlotBtn;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox familyText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adressText;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.TextBox salaryText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label incomeLbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bubbleSortBtn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.ProgressBar workerBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
    }
}

