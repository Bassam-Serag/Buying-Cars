using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static BuyCar.CustomerCar;

namespace BuyCar
{
    public partial class Customer : Form
    {
        CustomerCar customerCar = new CustomerCar();
        Context context = new Context();

        public CustomerCar UpdatedCustomer { get; set; }

        public Customer()
        {
            InitializeComponent();
            UpdatedCustomer = new CustomerCar();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }
        private void btnBackCus_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            LoadDb();
            txtId.Text = "-1";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearViewData();
        }
        void ClearViewData()
        {
            textNameCus.Text = "";
            textSSNCus.Text = "";
            txtId.Text = "-1";

            comGender.SelectedItem = null;
        }
        public bool Check()
        {
            if (textNameCus.Text == "" ||
             textSSNCus.Text == "" ||
             comGender.SelectedItem == null ||
             !Regex.Match(textSSNCus.Text, "^[0-9]{14}$").Success ||
             !Regex.Match(textNameCus.Text, "^[a-zA-Z]{3,}( [a-zA-Z]{3,})*$").Success
             )
                return true;
            return false;
        }

        private void btnAddCus_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                MessageBox.Show("دخل البيانات صح يصحبي ", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                labelError.Visible = true;
                return;
            }

            txtId.Text = "-1";

            customerCar.Name = textNameCus.Text;
            customerCar.SSN = textSSNCus.Text;
            customerCar._Gender = (Gender)Enum.Parse(typeof(Gender), comGender.SelectedItem.ToString());


            context.CustomerCars.Add(customerCar);
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
                dataGridViewMangeCus.DataSource = context.CustomerCars.ToList<CustomerCar>();
                dataGridViewMangeCus.Columns[4].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("الداتا بيز يصحبي", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDelCus_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "-1")
            {
                UpdatedCustomer = context.CustomerCars.Where(c => c.ID == UpdatedCustomer.ID).FirstOrDefault();
                context.CustomerCars.Remove(UpdatedCustomer);

                try
                {
                    context.SaveChanges();

                    MessageBox.Show("Customer deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadDb();
                    ClearViewData();
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

        private void btnUpdCus_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "-1")
            {
                if (Check())
                {
                    MessageBox.Show("دخل البيانات المتعدلة صح يصحبي ", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    labelError.Visible = true;
                    return;

                }

                UpdatedCustomer = context.CustomerCars.Find(UpdatedCustomer.ID);

                UpdatedCustomer.Name = textNameCus.Text;
                UpdatedCustomer.SSN = textSSNCus.Text;
                UpdatedCustomer._Gender = (Gender)Enum.Parse(typeof(Gender), comGender.SelectedItem.ToString());
                context.Entry(UpdatedCustomer).State = System.Data.Entity.EntityState.Detached;
                context.Entry(UpdatedCustomer).State = System.Data.Entity.EntityState.Modified;
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

        private void dataGridViewMangeCus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                try
                {
                    UpdatedCustomer.ID = int.Parse(this.dataGridViewMangeCus[0, e.RowIndex].Value.ToString());

                }
                catch (Exception ex) { }

                txtId.Text = this.dataGridViewMangeCus[0, e.RowIndex].Value.ToString();
                textNameCus.Text = this.dataGridViewMangeCus[1, e.RowIndex].Value.ToString();
                textSSNCus.Text = this.dataGridViewMangeCus[2, e.RowIndex].Value.ToString();
                comGender.Text = this.dataGridViewMangeCus[3, e.RowIndex].Value.ToString();
            }
        }
    }
}

