using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=LAPTOP-046J60K3\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True";
        SqlConnection con;

        public Form1()
        {
            InitializeComponent();
            LoadData();
            textBox1.Enabled = false;
        }

        private void LoadData()
        {
            con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT id, nume, medie FROM Student", con);
            SqlDataReader reader = cmd.ExecuteReader();

            dataGridViewStudent.Columns.Clear();
            dataGridViewStudent.Columns.Add("ID", "ID");
            dataGridViewStudent.Columns.Add("NUME", "NUME");
            dataGridViewStudent.Columns.Add("MEDIE", "MEDIE");

            while (reader.Read())
            {
                long id = reader.GetInt64(0);
                string nume = reader.GetString(1);
                double medie = reader.GetDouble(2);

                dataGridViewStudent.Rows.Add(id, nume, medie);
            }

            con.Close();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
            con.Open();

            try
            {
                string nume = textBoxNume.Text;
                double medie = double.Parse(textBoxMedie.Text);

                SqlCommand insertCmd = new SqlCommand("INSERT INTO Student (nume, medie) VALUES (@nume, @medie)", con);

                insertCmd.Parameters.AddWithValue("@nume", nume);
                insertCmd.Parameters.AddWithValue("@medie", medie);
                insertCmd.ExecuteNonQuery();

                LoadData();
                con.Close();

                textBox1.Clear();
                textBoxMedie.Clear();
                textBoxNume.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la adaugare: " + ex.Message);
            }

        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
            con.Open();

            try
            {
                long id = long.Parse(textBox1.Text);

                SqlCommand insertCmd = new SqlCommand("DELETE FROM Student WHERE @id = id", con);

                insertCmd.Parameters.AddWithValue("@id", id);
                insertCmd.ExecuteNonQuery();

                LoadData();
                con.Close();

                textBox1.Clear();
                textBoxNume.Clear();
                textBoxMedie.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la adaugare: " + ex.Message);
            }
        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
            con.Open();

            try
            {
                long id = long.Parse(textBox1.Text);
                string nume = textBoxNume.Text;
                double medie = double.Parse(textBoxMedie.Text);

                SqlCommand insertCmd = new SqlCommand("UPDATE Student SET nume = @nume, medie = @medie WHERE @id = id", con);

                insertCmd.Parameters.AddWithValue("@id", id);
                insertCmd.Parameters.AddWithValue("@nume", nume);
                insertCmd.Parameters.AddWithValue("@medie", medie);
                insertCmd.ExecuteNonQuery();

                LoadData();
                con.Close();

                textBox1.Clear();
                textBoxNume.Clear();
                textBoxMedie.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la adaugare: " + ex.Message);
            }
        }
        private void dataGridViewStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewStudent.Rows[e.RowIndex];

                if (row.Cells["ID"].Value != null) 
                {
                    textBox1.Text = row.Cells["ID"].Value.ToString();
                    textBoxNume.Text = row.Cells["NUME"].Value.ToString();
                    textBoxMedie.Text = row.Cells["MEDIE"].Value.ToString();
                }
                else
                {
                    textBox1.Clear();
                    textBoxNume.Clear();
                    textBoxMedie.Clear();
                }
            }
        }
    }
}