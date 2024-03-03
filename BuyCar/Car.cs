using Org.BouncyCastle.Bcpg.Sig;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuyCar
{
    public partial class Car : Form
    {
        public Vechile UpdatedVechile { get; set; }

        Vechile newVechile = new Vechile();
        Context context = new Context();
        public Car()
        {
            InitializeComponent();
            UpdatedVechile = new Vechile();
        }
        private void Car_Load(object sender, EventArgs e)
        {
            LoadDb();
            txtId.Text = "-1";
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        //1 ADD
        void ClearViewData()
        {
            textColor.Text = "";
            textMake.Text = "";
            textModel.Text = "";
            textPrice.Text = "";
            textSeats.Text = "";
            textYear.Text = "";
            txtId.Text = "-1";
        }
        public bool Check()
        {
            if (textColor.Text == "" ||
             textMake.Text == "" ||
             textModel.Text == "" ||
             textPrice.Text == "" ||
             textSeats.Text == "" ||
             textYear.Text == "" ||
             !Regex.Match(textPrice.Text, "^[0]*[1-9][0-9]*$").Success ||
             !Regex.Match(textYear.Text, "^19[0-9]{2}$|^20[0-2][0-4]$").Success ||
             !Regex.Match(textSeats.Text, "^[0]*[1-9][0-9]*$").Success ||
             !Regex.Match(textColor.Text, "^[a-zA-Z]{3,}( [a-zA-Z]{3,})*$").Success)
                return true;

            return false;
        }

        private void btnClearCar_Click(object sender, EventArgs e)
        {
            ClearViewData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();

            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                MessageBox.Show("دخل البيانات صح يصحبي ", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                labelError.Visible = true;
                return;
            }

            txtId.Text = "-1";


            newVechile.Make = textMake.Text;
            newVechile.Year = textYear.Text;
            newVechile.Color = textColor.Text;
            newVechile.Model = textModel.Text;
            newVechile.Price = double.Parse(textPrice.Text);
            newVechile.Seats = int.Parse(textSeats.Text);
            newVechile.IsAvaiable = true;

            context.Vechiles.Add(newVechile);
            context.SaveChanges();
            ClearViewData();
            LoadDb();
            labelError.Visible = false;
            MessageBox.Show("Add Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        void LoadDb()
        {
            try
            {
                dataGridViewCar.DataSource = context.Vechiles.Where(e => e.IsAvaiable == true).ToList<Vechile>();
                dataGridViewCar.Columns[6].Visible = false;
                dataGridViewCar.Columns[8].Visible = false;
                dataGridViewCar.Columns[9].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("الداتا بيز يصحبي", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
           

            if (txtId.Text != "-1")
            {
                UpdatedVechile = context.Vechiles.Find(UpdatedVechile.ID);
                context.Vechiles.Remove(UpdatedVechile);

                try
                {
                    context.SaveChanges();

                    MessageBox.Show("Car deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDb();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("الداتا بيز يصحبي", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(" انت بتعمل ايه يصحبي اختار صف يا عسكري ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtId.Text = "-1";
        }


        private void btnUpd_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "-1")
            {
                if (Check())
                {
                    MessageBox.Show("دخل البيانات المتعدلة صح يصحبي ", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    labelError.Visible = true;
                    return;

                }

                UpdatedVechile = context.Vechiles.Find(UpdatedVechile.ID);

                UpdatedVechile.Make = textMake.Text;
                UpdatedVechile.Year = textYear.Text;
                UpdatedVechile.Color = textColor.Text;
                UpdatedVechile.Model = textModel.Text;
                UpdatedVechile.Price = double.Parse(textPrice.Text);
                UpdatedVechile.Seats = int.Parse(textSeats.Text);
                UpdatedVechile.IsAvaiable = true;

                context.Entry(UpdatedVechile).State = System.Data.Entity.EntityState.Modified;
                try
                {
                    context.SaveChanges();
                    LoadDb();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("الداتا بيز يصحبي", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            else
            {
                MessageBox.Show(" انت بتعمل ايه يصحبي اختار صف يا عسكري ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void dataGridViewCar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                try
                {
                    UpdatedVechile.ID = int.Parse(this.dataGridViewCar[0, e.RowIndex].Value.ToString());

                }
                catch (Exception ex) { }

                txtId.Text = this.dataGridViewCar[0, e.RowIndex].Value.ToString();
                textMake.Text = this.dataGridViewCar[1, e.RowIndex].Value.ToString();
                textModel.Text = this.dataGridViewCar[2, e.RowIndex].Value.ToString();
                textYear.Text = this.dataGridViewCar[3, e.RowIndex].Value.ToString();
                textColor.Text = this.dataGridViewCar[4, e.RowIndex].Value.ToString();
                textSeats.Text = this.dataGridViewCar[5, e.RowIndex].Value.ToString();
                textPrice.Text = this.dataGridViewCar[7, e.RowIndex].Value.ToString();
            }
        }


    }
}