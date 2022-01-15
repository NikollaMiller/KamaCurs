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
    public partial class MAIN : Form
    {

        private int selectedButton = 0;
        private int dataSelected = 0;
        public static int changerSelected = 0;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
           int left,
           int top,
           int right,
           int bottom,
           int width,
           int height
           );

        public MAIN()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 8, 8));
        }

        private void MAIN_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oKVUZDataSet1.Кафедра". При необходимости она может быть перемещена или удалена.
            this.кафедраTableAdapter.Fill(this.oKVUZDataSet1.Кафедра);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oKVUZDataSet3.Управляющие_Приложением". При необходимости она может быть перемещена или удалена.
            this.управляющие_ПриложениемTableAdapter1.Fill(this.oKVUZDataSet3.Управляющие_Приложением);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedButton = 0;
            Selectedpage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedButton = 1;
            Selectedpage();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectedButton = 2;
            Selectedpage();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Auth auth = new Auth();
            auth.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bloked block = new Bloked();
            block.Show();
            this.Hide();
        }

        private void Selectedpage()
        {
            Panel[] panels = { Profile, Shower, Instruction};

            for (int i = 0; i < panels.Length; i++)
            {
                if (selectedButton == i)
                {
                    panels[i].BringToFront();
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            dataSelected--;
            if (dataSelected == 1)
            {
                SqlConnection sqlConnection = new SqlConnection(@"Data Source = DESKTOP-0C6CLET\SQLEXPRESS;Initial Catalog = OKVUZ;Integrated Security = True");
                sqlConnection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * FROM Группы", sqlConnection);

                DataTable table = new DataTable();

                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }
            else if (dataSelected == 2)
            {
                SqlConnection sqlConnection = new SqlConnection(@"Data Source = DESKTOP-0C6CLET\SQLEXPRESS;Initial Catalog = OKVUZ;Integrated Security = True");
                sqlConnection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * FROM Кафедра", sqlConnection);

                DataTable table = new DataTable();

                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }
            else if (dataSelected == 3)
            {
                SqlConnection sqlConnection = new SqlConnection(@"Data Source = DESKTOP-0C6CLET\SQLEXPRESS;Initial Catalog = OKVUZ;Integrated Security = True");

                sqlConnection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("Select * FROM Сотрудники", sqlConnection);

                DataTable table = new DataTable();

                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }
            else if (dataSelected == 4)
            {
                SqlConnection sqlConnection = new SqlConnection(@"Data Source = DESKTOP-0C6CLET\SQLEXPRESS;Initial Catalog = OKVUZ;Integrated Security = True");

                sqlConnection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("Select * FROM Студенты", sqlConnection);

                DataTable table = new DataTable();

                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }
            else if (dataSelected == 5)
            {
                SqlConnection sqlConnection = new SqlConnection(@"Data Source = DESKTOP-0C6CLET\SQLEXPRESS;Initial Catalog = OKVUZ;Integrated Security = True");

                sqlConnection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("Select * FROM Должности", sqlConnection);

                DataTable table = new DataTable();

                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }

            if (dataSelected <= 0)
            {
                dataSelected = 0;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            dataSelected++;
            if (dataSelected == 1)
            {
                SqlConnection sqlConnection = new SqlConnection(@"Data Source = DESKTOP-0C6CLET\SQLEXPRESS;Initial Catalog = OKVUZ;Integrated Security = True");
                sqlConnection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * FROM Группы", sqlConnection);

                DataTable table = new DataTable();

                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }
            else if (dataSelected == 2)
            {
                SqlConnection sqlConnection = new SqlConnection(@"Data Source = DESKTOP-0C6CLET\SQLEXPRESS;Initial Catalog = OKVUZ;Integrated Security = True");
                sqlConnection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * FROM Кафедра", sqlConnection);

                DataTable table = new DataTable();

                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }
            else if (dataSelected == 3)
            {
                SqlConnection sqlConnection = new SqlConnection(@"Data Source = DESKTOP-0C6CLET\SQLEXPRESS;Initial Catalog = OKVUZ;Integrated Security = True");
                sqlConnection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * FROM Сотрудники", sqlConnection);

                DataTable table = new DataTable();

                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }
            else if (dataSelected == 4)
            {
                SqlConnection sqlConnection = new SqlConnection(@"Data Source = DESKTOP-0C6CLET\SQLEXPRESS;Initial Catalog = OKVUZ;Integrated Security = True");
                sqlConnection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * FROM Студенты", sqlConnection);

                DataTable table = new DataTable();

                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }
            else if (dataSelected == 5)
            {
                SqlConnection sqlConnection = new SqlConnection(@"Data Source = DESKTOP-0C6CLET\SQLEXPRESS;Initial Catalog = OKVUZ;Integrated Security = True");

                sqlConnection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("Select * FROM Должности", sqlConnection);

                DataTable table = new DataTable();

                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }

            if (dataSelected>= 5)
            {
                dataSelected = 5;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ChangeDelete changer = new ChangeDelete();
            changerSelected = 1;
            changer.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ChangeDelete changer = new ChangeDelete();
            changerSelected = 2;
            changer.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ChangeDelete changer = new ChangeDelete();
            changerSelected = 3;
            changer.ShowDialog();
        }
    }
}
