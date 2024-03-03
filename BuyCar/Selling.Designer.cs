using System.Drawing;
using System.Windows.Forms;

namespace BuyCar
{
    partial class Selling
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comSelCus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewCus = new System.Windows.Forms.Button();
            this.comCarMake = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comCarModel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comCarColor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearchCar = new System.Windows.Forms.Button();
            this.dataGridViewCarSearch = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Make = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorCar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuy = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 87);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(785, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 30);
            this.button1.TabIndex = 44;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(349, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 35);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sale Cars";
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
            this.label4.Location = new System.Drawing.Point(327, -7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 57);
            this.label4.TabIndex = 4;
            this.label4.Text = "Buy Cars";
            // 
            // comSelCus
            // 
            this.comSelCus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comSelCus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comSelCus.FormattingEnabled = true;
            this.comSelCus.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comSelCus.Location = new System.Drawing.Point(200, 111);
            this.comSelCus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comSelCus.Name = "comSelCus";
            this.comSelCus.Size = new System.Drawing.Size(143, 24);
            this.comSelCus.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(21, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 30);
            this.label7.TabIndex = 30;
            this.label7.Text = "Select Customer : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(384, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 30);
            this.label2.TabIndex = 32;
            this.label2.Text = "Not Found ? Add new ";
            // 
            // btnNewCus
            // 
            this.btnNewCus.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnNewCus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewCus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewCus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCus.ForeColor = System.Drawing.Color.White;
            this.btnNewCus.Location = new System.Drawing.Point(621, 108);
            this.btnNewCus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewCus.Name = "btnNewCus";
            this.btnNewCus.Size = new System.Drawing.Size(147, 32);
            this.btnNewCus.TabIndex = 34;
            this.btnNewCus.Text = "ADD";
            this.btnNewCus.UseVisualStyleBackColor = false;
            this.btnNewCus.Click += new System.EventHandler(this.btnNewCus_Click);
            // 
            // comCarMake
            // 
            this.comCarMake.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comCarMake.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comCarMake.FormattingEnabled = true;
            this.comCarMake.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comCarMake.Location = new System.Drawing.Point(117, 175);
            this.comCarMake.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comCarMake.Name = "comCarMake";
            this.comCarMake.Size = new System.Drawing.Size(145, 24);
            this.comCarMake.TabIndex = 1;
            this.comCarMake.Click += new System.EventHandler(this.comCarMake_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(3, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 26);
            this.label3.TabIndex = 35;
            this.label3.Text = "Select Make : ";
            // 
            // comCarModel
            // 
            this.comCarModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comCarModel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comCarModel.FormattingEnabled = true;
            this.comCarModel.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comCarModel.Location = new System.Drawing.Point(404, 175);
            this.comCarModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comCarModel.Name = "comCarModel";
            this.comCarModel.Size = new System.Drawing.Size(145, 24);
            this.comCarModel.TabIndex = 2;
            this.comCarModel.Click += new System.EventHandler(this.comCarModel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(275, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 26);
            this.label5.TabIndex = 37;
            this.label5.Text = "Select Model : ";
            // 
            // comCarColor
            // 
            this.comCarColor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comCarColor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comCarColor.FormattingEnabled = true;
            this.comCarColor.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comCarColor.Location = new System.Drawing.Point(665, 175);
            this.comCarColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comCarColor.Name = "comCarColor";
            this.comCarColor.Size = new System.Drawing.Size(145, 24);
            this.comCarColor.TabIndex = 3;
            this.comCarColor.SelectedIndexChanged += new System.EventHandler(this.comCarColor_SelectedIndexChanged);
            this.comCarColor.Click += new System.EventHandler(this.comCarColor_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(557, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 26);
            this.label6.TabIndex = 39;
            this.label6.Text = "Select Color : ";
            // 
            // btnSearchCar
            // 
            this.btnSearchCar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSearchCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchCar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchCar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCar.ForeColor = System.Drawing.Color.White;
            this.btnSearchCar.Location = new System.Drawing.Point(325, 226);
            this.btnSearchCar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchCar.Name = "btnSearchCar";
            this.btnSearchCar.Size = new System.Drawing.Size(147, 39);
            this.btnSearchCar.TabIndex = 4;
            this.btnSearchCar.Text = "SEARCH";
            this.btnSearchCar.UseVisualStyleBackColor = false;
            this.btnSearchCar.Click += new System.EventHandler(this.btnSearchCar_Click);
            // 
            // dataGridViewCarSearch
            // 
            this.dataGridViewCarSearch.AllowUserToAddRows = false;
            this.dataGridViewCarSearch.AllowUserToDeleteRows = false;
            this.dataGridViewCarSearch.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCarSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Make,
            this.Model,
            this.Year,
            this.ColorCar,
            this.Seats,
            this.SellPrice});
            this.dataGridViewCarSearch.Location = new System.Drawing.Point(5, 299);
            this.dataGridViewCarSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewCarSearch.Name = "dataGridViewCarSearch";
            this.dataGridViewCarSearch.ReadOnly = true;
            this.dataGridViewCarSearch.RowHeadersWidth = 51;
            this.dataGridViewCarSearch.Size = new System.Drawing.Size(803, 199);
            this.dataGridViewCarSearch.TabIndex = 42;
            this.dataGridViewCarSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCarSearch_CellClick);
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
            // Make
            // 
            this.Make.DataPropertyName = "Make";
            this.Make.HeaderText = "Make";
            this.Make.MinimumWidth = 6;
            this.Make.Name = "Make";
            this.Make.ReadOnly = true;
            this.Make.Width = 125;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Model";
            this.Model.MinimumWidth = 6;
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            this.Model.Width = 125;
            // 
            // Year
            // 
            this.Year.DataPropertyName = "Year";
            this.Year.HeaderText = "Year";
            this.Year.MinimumWidth = 6;
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            this.Year.Width = 125;
            // 
            // ColorCar
            // 
            this.ColorCar.DataPropertyName = "Color";
            this.ColorCar.HeaderText = "Color";
            this.ColorCar.MinimumWidth = 6;
            this.ColorCar.Name = "ColorCar";
            this.ColorCar.ReadOnly = true;
            this.ColorCar.Width = 125;
            // 
            // Seats
            // 
            this.Seats.DataPropertyName = "Seats";
            this.Seats.HeaderText = "Seats";
            this.Seats.MinimumWidth = 6;
            this.Seats.Name = "Seats";
            this.Seats.ReadOnly = true;
            this.Seats.Width = 125;
            // 
            // SellPrice
            // 
            this.SellPrice.DataPropertyName = "Price";
            this.SellPrice.HeaderText = "Price";
            this.SellPrice.MinimumWidth = 6;
            this.SellPrice.Name = "SellPrice";
            this.SellPrice.ReadOnly = true;
            this.SellPrice.Width = 125;
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.ForeColor = System.Drawing.Color.White;
            this.btnBuy.Location = new System.Drawing.Point(699, 515);
            this.btnBuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(111, 38);
            this.btnBuy.TabIndex = 43;
            this.btnBuy.Text = "Sell";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MidnightBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(5, 515);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 38);
            this.button2.TabIndex = 44;
            this.button2.Text = "BACK";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 566);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(821, 34);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Selling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(821, 600);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.dataGridViewCarSearch);
            this.Controls.Add(this.comCarColor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comCarModel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comCarMake);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNewCus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comSelCus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearchCar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Selling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selling";
            this.Load += new System.EventHandler(this.Selling_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Button btnClose;
        private Label label4;
        private PictureBox pictureBox1;
        private ComboBox comSelCus;
        private Label label7;
        private Label label2;
        private Button btnNewCus;
        private ComboBox comCarMake;
        private Label label3;
        private ComboBox comCarModel;
        private Label label5;
        private ComboBox comCarColor;
        private Label label6;
        private Button btnSearchCar;
        private DataGridView dataGridViewCarSearch;
        private Button btnBuy;
        private Button button1;
        private Button button2;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Make;
        private DataGridViewTextBoxColumn Model;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn ColorCar;
        private DataGridViewTextBoxColumn Seats;
        private DataGridViewTextBoxColumn SellPrice;
    }
}