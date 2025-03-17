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
using System.Drawing.Imaging;

namespace _4_1
{
    public partial class Form1 : Form
    {
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string strconnection = "data source=DESKTOP-LMOVISH; initial catalog=master; integrated security=true";
            conn = new SqlConnection(strconnection);
            conn.Open();

            try
            {
                SqlCommand com1 = new SqlCommand("Create database db", conn);
                com1.ExecuteNonQuery();

                com1.Connection.ChangeDatabase("db");

                SqlCommand com2 = new SqlCommand("Create table t1 (id int primary key, name varchar(50),images image)", conn);
                com2.ExecuteNonQuery();

            }
            catch(Exception e1)
            {
                conn.ChangeDatabase("db");
            }
            da = new SqlDataAdapter("select * from t1", conn);
            SqlCommandBuilder x = new SqlCommandBuilder(da);
            da.Fill(ds,"t1");
           
            dataGridView1.DataSource = ds.Tables["t1"];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files (*.bmp; *.png; *.jpg)| *.bmp; *.png; *.jpg";
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DataRow r = ds.Tables["t1"].NewRow();
            r["id"] = int.Parse(textBox1.Text);
            r["name"] = textBox2.Text;
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms,ImageFormat.Bmp);
            byte[] arr = ms.ToArray();
            r["images"] = arr;
            ds.Tables["t1"].Rows.Add(r);
            da.Update(ds, "t1");



            clear();
        }


        void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            pictureBox1.Image.Dispose();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataRow r in ds.Tables["t1"].Rows)
            {
                if (Convert.ToInt32(r["id"])==int.Parse(textBox1.Text))
                {
                    textBox2.Text = Convert.ToString(r["name"]);
                    byte[] arr = (byte[])(r["images"]);
                    MemoryStream ms = new MemoryStream(arr);
                    Bitmap x = new Bitmap(ms);
                    pictureBox1.Image = x;

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.Tables["t1"];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
