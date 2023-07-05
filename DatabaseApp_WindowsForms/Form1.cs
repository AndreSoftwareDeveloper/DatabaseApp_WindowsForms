using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.klientTableAdapter.Fill(this.wypozyczalniaDataSet.klient);
            this.pojazdTableAdapter.Fill(this.wypozyczalniaDataSet.pojazd);

            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
        }
        
        public static byte[] ImageToByte(string filePath)
        {
            var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            var reader = new BinaryReader(stream);
            var photo = reader.ReadBytes((int)stream.Length);
            reader.Close();
            stream.Close();
            return photo;
        }

        private void gToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Marka";
            label2.Text = "Model";
            label3.Text = "Nr. rejestracyjny";           

            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            cena.Visible = true;
            textBox4.Visible = true;
        }

        private void klienciToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            label1.Text = "Nazwisko";
            label2.Text = "Imię";
            label3.Text = "Nr. telefonu";

            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            cena.Visible = false;
            textBox4.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Visible == true && dataGridView2.CurrentRow != null)
            {
                dataGridView2.CurrentRow.Selected = true;
                dataGridView2.Rows.Remove(dataGridView2.SelectedRows[0]);
            }
            else if (dataGridView1.Visible == true && dataGridView1.CurrentRow != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.klientTableAdapter.Update(this.wypozyczalniaDataSet.klient);
                this.pojazdTableAdapter.Update(this.wypozyczalniaDataSet.pojazd);
                MessageBox.Show("Zmiany zostały zapisane.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas zapisywania zmian: " + ex.Message);
            }
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Visible == true)
            {
                String surname = textBox1.Text;
                String name = textBox2.Text;
                int phone = Int32.Parse(textBox3.Text);

                try
                {
                    this.klientTableAdapter.Insert(surname, name, phone);
                    MessageBox.Show("Zmiany zostały zapisane.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas zapisywania zmian: " + ex.Message);
                }
            }
            else
            {
                String marka = textBox1.Text;
                String model = textBox2.Text;
                String rejestracja = textBox3.Text;
                int cena = Int32.Parse(textBox4.Text);

                try
                {
                    this.pojazdTableAdapter.Insert(marka, model, rejestracja, cena, ImageToByte("C:\\tmp\\error.jpg"), -1);
                    MessageBox.Show("Zmiany zostały zapisane.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas zapisywania zmian: " + ex.Message);
                }
            }
        }

        private void klienciToolStripMenuItem_Click(object sender, EventArgs e) {}
        private void textBox1_TextChanged(object sender, EventArgs e) {}
        private void textBox4_TextChanged(object sender, EventArgs e) {}
        private void cena_Click(object sender, EventArgs e) {}
    }
}
