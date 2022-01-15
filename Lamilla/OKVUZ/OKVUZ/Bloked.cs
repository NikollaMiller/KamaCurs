using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OKVUZ
{
    public partial class Bloked : Form
    {
        private bool isShow;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
           int left,
           int top,
           int right,
           int bottom,
           int width,
           int height
           );

        public Bloked()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 8, 8));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            isShow = !isShow;

            if (isShow)
            {
                textBox1.PasswordChar = '\0';
            }
            else
            {
                textBox1.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source = DESKTOP-0C6CLET\SQLEXPRESS;Initial Catalog = OKVUZ;Integrated Security = True");

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select Count (*) From dbo.Управляющие_Приложением where КодПароль = '" + textBox1.Text + "'", sqlConnection);

            DataTable dt = new DataTable();

            sqlDataAdapter.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                MAIN main = new MAIN();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Введите верный логин или пароль!");
            }
        }
    }
}
