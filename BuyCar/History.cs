using GrapeCity.Documents.Pdf;
using GrapeCity.Documents.Text;
using System;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BuyCar
{
    public partial class History : Form
    {
        Context context = new Context();
        public Transaction WantedTransaction { get; set; }
        public History()
        {
            InitializeComponent();
            WantedTransaction = new Transaction();
            WantedTransaction.ID = -1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void btnBackhome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btnSearchCar_Click(object sender, EventArgs e)
        {
            if (dateTimeFrom.Value <= dateTimeTo.Value)
            {
                var data = context.Transactions.Include("CustomerCar").Include("Vechile").Where(v => v.Vechile.IsAvaiable == false).ToList();

                foreach (var item in data)
                {
                    dataGridViewCarHistory.Rows.Add(item.ID, item.DateTime, item.Vechile.Price, item.CustomerCar.SSN, item.CustomerCar.Name, item.Vechile.Make, item.Vechile.Model, item.Vechile.Year);
                }
            }
            else
            {
                MessageBox.Show("أختار التاريخ الأول وصح يصحبي ", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (WantedTransaction.ID != -1)
            {
                // Create a new PDF document
                var doc = new GcPdfDocument();

                // Add a page to the document
                var page = doc.NewPage();

                // Create a graphics object for drawing on the page
                var g = page.Graphics;

                Transaction t = context.Transactions.Include("CustomerCar").Include("Vechile").Where(tt => tt.ID == WantedTransaction.ID).FirstOrDefault();

                string text;
                var font = StandardFonts.Helvetica;
                var fontSize = 24;
                var textFormat = new TextFormat()


                {
                    Font = font,
                    FontSize = fontSize,
                };

                text = "Transaction ID: " + t.ID.ToString() + "\n";
                g.DrawString(text, textFormat, new PointF(50, 50));


                text = "Sell Date: " + t.DateTime.ToString() + "\n";
                g.DrawString(text, textFormat, new PointF(50, 100));

                text = "Price: " + t.Vechile.Price.ToString() + "\n";
                g.DrawString(text, textFormat, new PointF(50, 150));

                text = "Customer SSN: " + t.CustomerCar.SSN.ToString() + "\n";
                g.DrawString(text, textFormat, new PointF(50, 200));

                text = "Customer Name: " + t.CustomerCar.Name.ToString() + "\n";
                g.DrawString(text, textFormat, new PointF(50, 250));

                text = "Make: " + t.Vechile.Make.ToString() + "\n";
                g.DrawString(text, textFormat, new PointF(50, 300));

                text = "Model: " + t.Vechile.Model.ToString() + "\n";
                g.DrawString(text, textFormat, new PointF(50, 350));

                text = "Year: " + t.Vechile.Year.ToString() + "\n";
                g.DrawString(text, textFormat, new PointF(50, 400));


                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Save the document to the selected file
                    doc.Save(saveFileDialog.FileName);
                }

                MessageBox.Show("الريبورت بتاعك جاهز يصحبي", "مبرووووووك", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Home home = new Home();
                //home.Show();
                //this.Hide();
            }
            else
            {
                MessageBox.Show(" بتعمل اي يصحبي اختار صف يعسكري", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dataGridViewCarHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                try
                {

                    WantedTransaction.ID = int.Parse(this.dataGridViewCarHistory[0, e.RowIndex].Value.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" يصحبي بطل عبط واختار صف مليان يعسكري", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                WantedTransaction.ID = -1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewCarHistory.Rows.Count > 0) // Check if there are rows in the DataGridView
            {
                // Create a new PDF document
                var doc = new GcPdfDocument();

                // Add a page to the document
                var page = doc.NewPage();
                page.Landscape = true;

                // Create a graphics object for drawing on the page
                var g = page.Graphics;

                // Define text format
                var font = StandardFonts.Helvetica;
                var fontSize = 12;
                var textFormat = new TextFormat()
                {
                    Font = font,
                    FontSize = fontSize,
                };

                // Define initial position
                float x = 20;
                float y = 50;

                string[] headers =
                {
                    "ID",
                    "Date",
                    "Price",
                    "Customer SSn",
                    "Customer Name",
                    "Make",
                    "Model",
                    "Year"
                };

                foreach (var item in headers)
                {
                    string cellValue = item;


                    // Draw the cell value on the PDF
                    g.DrawString(cellValue, textFormat, new PointF(x, y));

                    // Move to the next column
                    x += 105; // Adjust the position as needed
                }

                y += 20; // Adjust the position as needed
                x = 20; // Reset x position for the next row


                // Loop through rows and columns of the DataGridView
                foreach (DataGridViewRow row in dataGridViewCarHistory.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        // Get the cell value
                        string cellValue = cell.Value?.ToString();
                        if (cell.Value.GetType() == typeof(DateTime))
                        {
                            cellValue = cellValue.Substring(0, 10);
                        }

                        // Draw the cell value on the PDF
                        g.DrawString(cellValue, textFormat, new PointF(x, y));

                        // Move to the next column
                        x += 105; // Adjust the position as needed
                    }

                    // Move to the next row
                    y += 20; // Adjust the position as needed
                    x = 20; // Reset x position for the next row
                }


                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Save the document to the selected file
                    doc.Save(saveFileDialog.FileName);
                }

                MessageBox.Show("الريبورت بتاعك جاهز يصحبي", "مبرووووووك", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Home home = new Home();
                //home.Show();
                //this.Hide();

            }
            else
            {
                MessageBox.Show("DataGridView is empty.", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
