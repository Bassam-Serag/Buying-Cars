using GrapeCity.Documents.Pdf;
using GrapeCity.Documents.Text;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BuyCar
{
    public partial class Selling : Form
    {
        Context context = new Context();
        public Vechile SelledCar { get; set; }
        public Selling()
        {
            InitializeComponent();
            SelledCar = new Vechile();
            SelledCar.ID = -1;
        }
        private void btnNewCus_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
        void ClearViewData()
        {
            comSelCus.SelectedIndex = -1;
            comCarMake.SelectedIndex = -1;
            comCarModel.SelectedIndex = -1;
            comCarColor.SelectedIndex = -1;

        }

        private void Selling_Load(object sender, EventArgs e)
        {
            comSelCus.DataSource = context.CustomerCars.Select(c => c.SSN).ToList();
            comCarMake.DataSource = context.Vechiles.Select(c => c.Make).ToList();
            comCarModel.DataSource = context.Vechiles.Select(c => c.Model).ToList();
            comCarColor.DataSource = context.Vechiles.Select(c => c.Color).ToList();
            ClearViewData();
        }

        private void btnSearchCar_Click(object sender, EventArgs e)
        {
            if (comSelCus.SelectedIndex == -1)
            {
                MessageBox.Show(" يصحبي بطل عبط واختار الكاستومر بتاعك", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (comCarMake.SelectedIndex == -1 && comCarModel.SelectedIndex == -1 && comCarColor.SelectedIndex == -1)
            {
                MessageBox.Show(" يصحبي بطل عبط واختار السيرش بتاعك", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string SelMake = comCarMake.SelectedItem?.ToString();
                string seledModel = comCarModel.SelectedItem?.ToString();
                string seledColor = comCarColor.SelectedItem?.ToString();

                var Search = context.Vechiles.Where(x => x.IsAvaiable == true).Where(v => (SelMake == null || v.Make == SelMake) &&
                        (seledModel == null || v.Model == seledModel) &&
                        (seledColor == null || v.Color == seledColor)).ToList();
                dataGridViewCarSearch.DataSource = Search;

                comCarMake.SelectedIndex = -1;
                comCarModel.SelectedIndex = -1;
                comCarColor.SelectedIndex = -1;
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (comSelCus.SelectedIndex != -1)
            {
                if (SelledCar.ID != -1)
                {
                    CustomerCar customerCar = context.CustomerCars.Where(c => c.SSN == comSelCus.SelectedItem.ToString()).FirstOrDefault();

                    Vechile vechile = context.Vechiles.Where(v => v.ID == SelledCar.ID).FirstOrDefault();

                    Transaction t = new Transaction();
                    t.Vechile = vechile;
                    t.CustomerCar = customerCar;
                    t.DateTime = DateTime.Now;

                    context.Transactions.Add(t);
                    try
                    {
                        context.SaveChanges();
                        MessageBox.Show("ألف مبروك يصحبي انت معاك عربية", "مبرووووووووووك", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        vechile.IsAvaiable = false;
                        context.Entry(vechile).State = System.Data.Entity.EntityState.Modified;
                        context.SaveChanges();
                        comSelCus.DataSource = null;
                        ClearViewData();
                        var doc = new GcPdfDocument();
                        var page = doc.NewPage();
                        var g = page.Graphics;

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

                        Home home = new Home();
                        home.Show();
                        this.Hide();

                    }
                    catch
                    {
                        MessageBox.Show(" شوف الداتا بيز بتاعتك يصحبي", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(" انت بتعمل ايه يصحبي اختار صف يا عسكري ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show(" يصحبي بطل عبط واختار الكاستومر بتاعك", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dataGridViewCarSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                try
                {

                    SelledCar.ID = int.Parse(this.dataGridViewCarSearch[0, e.RowIndex].Value.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" يصحبي بطل عبط واختار صف مليان يعسكري", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                SelledCar.ID = -1;
            }
        }

        private void comCarColor_Click(object sender, EventArgs e)
        {
            if (comCarMake.SelectedIndex != -1)
            {
                if (comCarModel.SelectedIndex != -1)
                {
                    comCarColor.DataSource = context.Vechiles.Where(f => f.IsAvaiable == true && f.Make == comCarMake.SelectedItem.ToString() && f.Model == comCarModel.SelectedItem.ToString()).Select(c => c.Color).ToList();
                }
                else
                {
                    comCarColor.DataSource = context.Vechiles.Where(f => f.IsAvaiable == true && f.Make == comCarMake.SelectedItem.ToString()).Select(c => c.Color).ToList();
                }
            }
            else
            {
                if (comCarModel.SelectedIndex != -1)
                {
                    comCarColor.DataSource = context.Vechiles.Where(f => f.IsAvaiable == true && f.Model == comCarModel.SelectedItem.ToString()).Select(c => c.Color).ToList();
                }
                else
                {
                    comCarColor.DataSource = context.Vechiles.Select(c => c.Color).ToList();
                }
            }
        }

        private void comCarColor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comCarModel_Click(object sender, EventArgs e)
        {
            if (comCarMake.SelectedIndex != -1)
            {
                if (comCarColor.SelectedIndex != -1)
                {
                    comCarModel.DataSource = context.Vechiles.Where(f => f.IsAvaiable == true && f.Make == comCarMake.SelectedItem.ToString() && f.Color == comCarColor.SelectedItem.ToString()).Select(c => c.Model).ToList();
                }
                else
                {
                    comCarModel.DataSource = context.Vechiles.Where(f => f.IsAvaiable == true && f.Make == comCarMake.SelectedItem.ToString()).Select(c => c.Model).ToList();
                }
            }
            else
            {
                if (comCarColor.SelectedIndex != -1)
                {
                    comCarModel.DataSource = context.Vechiles.Where(f => f.IsAvaiable == true && f.Color == comCarColor.SelectedItem.ToString()).Select(c => c.Model).ToList();
                }
                else
                {
                    comCarModel.DataSource = context.Vechiles.Select(c => c.Model).ToList();
                }
            }
        }

        private void comCarMake_Click(object sender, EventArgs e)
        {
            if (comCarModel.SelectedIndex != -1)
            {
                if (comCarColor.SelectedIndex != -1)
                {
                    comCarMake.DataSource = context.Vechiles.Where(f => f.IsAvaiable == true && f.Model == comCarModel.SelectedItem.ToString() && f.Color == comCarColor.SelectedItem.ToString()).Select(c => c.Make).ToList();
                }
                else
                {
                    comCarMake.DataSource = context.Vechiles.Where(f => f.IsAvaiable == true && f.Model == comCarModel.SelectedItem.ToString()).Select(c => c.Make).ToList();
                }
            }
            else
            {
                if (comCarColor.SelectedIndex != -1)
                {
                    comCarMake.DataSource = context.Vechiles.Where(f => f.IsAvaiable == true && f.Color == comCarColor.SelectedItem.ToString()).Select(c => c.Make).ToList();
                }
                else
                {
                    comCarMake.DataSource = context.Vechiles.Select(c => c.Make).ToList();
                }
            }
        }
    }
}
