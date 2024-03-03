using System.Drawing;
using System.Windows.Forms;

namespace BuyCar
{
    partial class Customer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textSSNCus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textNameCus = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBackCus = new System.Windows.Forms.Button();
            this.btnUpdCus = new System.Windows.Forms.Button();
            this.btnDelCus = new System.Windows.Forms.Button();
            this.btnAddCus = new System.Windows.Forms.Button();
            this.dataGridViewMangeCus = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.btnClearCus = new System.Windows.Forms.Button();
            this.comGender = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelError = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMangeCus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 80);
            this.panel1.TabIndex = 3;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(109, 34);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(151, 22);
            this.txtId.TabIndex = 43;
            this.txtId.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(764, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 31);
            this.button1.TabIndex = 40;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(285, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 35);
            this.label1.TabIndex = 13;
            this.label1.Text = "Manage Customer";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(824, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 26);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(307, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 57);
            this.label4.TabIndex = 4;
            this.label4.Text = "Buy Cars";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(34, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 30);
            this.label2.TabIndex = 15;
            this.label2.Text = "Gender : ";
            // 
            // textSSNCus
            // 
            this.textSSNCus.Location = new System.Drawing.Point(124, 215);
            this.textSSNCus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textSSNCus.Name = "textSSNCus";
            this.textSSNCus.Size = new System.Drawing.Size(151, 22);
            this.textSSNCus.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(60, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 30);
            this.label6.TabIndex = 19;
            this.label6.Text = "SSN : ";
            // 
            // textNameCus
            // 
            this.textNameCus.Location = new System.Drawing.Point(124, 157);
            this.textNameCus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textNameCus.Name = "textNameCus";
            this.textNameCus.Size = new System.Drawing.Size(151, 22);
            this.textNameCus.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(46, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 30);
            this.label7.TabIndex = 21;
            this.label7.Text = "Name : ";
            // 
            // btnBackCus
            // 
            this.btnBackCus.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBackCus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackCus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBackCus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackCus.ForeColor = System.Drawing.Color.White;
            this.btnBackCus.Location = new System.Drawing.Point(63, 440);
            this.btnBackCus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackCus.Name = "btnBackCus";
            this.btnBackCus.Size = new System.Drawing.Size(71, 34);
            this.btnBackCus.TabIndex = 7;
            this.btnBackCus.Text = "BACK";
            this.btnBackCus.UseVisualStyleBackColor = false;
            this.btnBackCus.Click += new System.EventHandler(this.btnBackCus_Click);
            // 
            // btnUpdCus
            // 
            this.btnUpdCus.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdCus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdCus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdCus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdCus.ForeColor = System.Drawing.Color.White;
            this.btnUpdCus.Location = new System.Drawing.Point(196, 379);
            this.btnUpdCus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdCus.Name = "btnUpdCus";
            this.btnUpdCus.Size = new System.Drawing.Size(88, 37);
            this.btnUpdCus.TabIndex = 5;
            this.btnUpdCus.Text = "UPDATE";
            this.btnUpdCus.UseVisualStyleBackColor = false;
            this.btnUpdCus.Click += new System.EventHandler(this.btnUpdCus_Click);
            // 
            // btnDelCus
            // 
            this.btnDelCus.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDelCus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelCus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelCus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelCus.ForeColor = System.Drawing.Color.White;
            this.btnDelCus.Location = new System.Drawing.Point(109, 379);
            this.btnDelCus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelCus.Name = "btnDelCus";
            this.btnDelCus.Size = new System.Drawing.Size(81, 37);
            this.btnDelCus.TabIndex = 4;
            this.btnDelCus.Text = "DELETE";
            this.btnDelCus.UseVisualStyleBackColor = false;
            this.btnDelCus.Click += new System.EventHandler(this.btnDelCus_Click);
            // 
            // btnAddCus
            // 
            this.btnAddCus.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAddCus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddCus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCus.ForeColor = System.Drawing.Color.White;
            this.btnAddCus.Location = new System.Drawing.Point(20, 379);
            this.btnAddCus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCus.Name = "btnAddCus";
            this.btnAddCus.Size = new System.Drawing.Size(81, 37);
            this.btnAddCus.TabIndex = 3;
            this.btnAddCus.Text = "ADD";
            this.btnAddCus.UseVisualStyleBackColor = false;
            this.btnAddCus.Click += new System.EventHandler(this.btnAddCus_Click);
            // 
            // dataGridViewMangeCus
            // 
            this.dataGridViewMangeCus.AllowUserToDeleteRows = false;
            this.dataGridViewMangeCus.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMangeCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMangeCus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NameCar,
            this.SSN,
            this.Gender});
            this.dataGridViewMangeCus.Location = new System.Drawing.Point(317, 157);
            this.dataGridViewMangeCus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewMangeCus.Name = "dataGridViewMangeCus";
            this.dataGridViewMangeCus.ReadOnly = true;
            this.dataGridViewMangeCus.RowHeadersWidth = 51;
            this.dataGridViewMangeCus.Size = new System.Drawing.Size(467, 310);
            this.dataGridViewMangeCus.TabIndex = 38;
            this.dataGridViewMangeCus.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMangeCus_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // NameCar
            // 
            this.NameCar.DataPropertyName = "Name";
            this.NameCar.HeaderText = "Name";
            this.NameCar.MinimumWidth = 6;
            this.NameCar.Name = "NameCar";
            this.NameCar.ReadOnly = true;
            this.NameCar.Width = 125;
            // 
            // SSN
            // 
            this.SSN.DataPropertyName = "SSN";
            this.SSN.HeaderText = "SSN";
            this.SSN.MinimumWidth = 6;
            this.SSN.Name = "SSN";
            this.SSN.ReadOnly = true;
            this.SSN.Width = 125;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "_Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Width = 125;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label12.Location = new System.Drawing.Point(481, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 31);
            this.label12.TabIndex = 39;
            this.label12.Text = "Customer List";
            // 
            // btnClearCus
            // 
            this.btnClearCus.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnClearCus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearCus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearCus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCus.ForeColor = System.Drawing.Color.White;
            this.btnClearCus.Location = new System.Drawing.Point(163, 440);
            this.btnClearCus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearCus.Name = "btnClearCus";
            this.btnClearCus.Size = new System.Drawing.Size(71, 34);
            this.btnClearCus.TabIndex = 6;
            this.btnClearCus.Text = "CLEAR";
            this.btnClearCus.UseVisualStyleBackColor = false;
            this.btnClearCus.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // comGender
            // 
            this.comGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comGender.FormattingEnabled = true;
            this.comGender.Items.AddRange(new object[] {
            " Male",
            " Female"});
            this.comGender.Location = new System.Drawing.Point(124, 272);
            this.comGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comGender.Name = "comGender";
            this.comGender.Size = new System.Drawing.Size(151, 24);
            this.comGender.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 518);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 34);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(57, 322);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(198, 31);
            this.labelError.TabIndex = 42;
            this.labelError.Text = "دخل البيانات صح يصحبي";
            this.labelError.Visible = false;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.comGender);
            this.Controls.Add(this.btnClearCus);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridViewMangeCus);
            this.Controls.Add(this.btnBackCus);
            this.Controls.Add(this.btnUpdCus);
            this.Controls.Add(this.btnDelCus);
            this.Controls.Add(this.btnAddCus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textNameCus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textSSNCus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMangeCus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Button btnClose;
        private Label label4;
        private Label label2;
        private TextBox textSSNCus;
        private Label label6;
        private TextBox textNameCus;
        private Label label7;
        private PictureBox pictureBox1;
        private Button btnBackCus;
        private Button btnUpdCus;
        private Button btnDelCus;
        private Button btnAddCus;
        private DataGridView dataGridViewMangeCus;
        private Label label12;
        private Button button1;
        private Button btnClearCus;
        private ComboBox comGender;
        private Label labelError;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NameCar;
        private DataGridViewTextBoxColumn SSN;
        private DataGridViewTextBoxColumn Gender;
        private TextBox txtId;
    }
}