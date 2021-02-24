using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework
{
    public partial class OneMs : Form
    {
        int thisId = 0;
        public OneMs()
        {
            InitializeComponent();
            button1.Visible = true;
            button2.Visible = false;
        }

        public OneMs(int id)
        {
            thisId = id;
            InitializeComponent();
            button1.Visible = false;
            button2.Visible = true;

            MsContext context = new MsContext();
            MedService ms = context.MedServices.Find(thisId);
            if (ms != null)
            {
                dateTimePicker1.Value = ms.Day;
                textBox3.Text = Convert.ToString(ms.Weight);
                textBox4.Text = Convert.ToString(ms.Height);
            }
        }

        private void OneMs_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chidlGrDbDataSet.Children". При необходимости она может быть перемещена или удалена.
            this.childrenTableAdapter.Fill(this.chidlGrDbDataSet.Children);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0, m =0;
            if (!(int.TryParse(textBox3.Text, out n)) || !(int.TryParse(textBox4.Text, out m)) || (dateTimePicker1.Value >= DateTime.Now) || (n <= 0) || (m <= 0))
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Заполните все поля корректно!";
            }
            else
            {
                MsContext context = new MsContext();
                MedService medService = new MedService
                {
                    Day = dateTimePicker1.Value,
                    Weight = Convert.ToInt32(textBox3.Text),
                    Height = Convert.ToInt32(textBox4.Text),
                    ChildId = Convert.ToInt32(comboBox1.SelectedValue)
                };
                context.MedServices.Add(medService);
                context.SaveChanges();
                label1.ForeColor = Color.Green;
                label1.Text = "Новая запись добавлена в базу!";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = 0, m = 0;
            if (!(int.TryParse(textBox3.Text, out n)) || !(int.TryParse(textBox4.Text, out m)) || (dateTimePicker1.Value >= DateTime.Now) || (n <= 0) || (m <= 0))
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Заполните все поля корректно!";
            }
            else
            {
                MsContext context = new MsContext();
                MedService ms = context.MedServices.Find(thisId);
                ms.Day = dateTimePicker1.Value;
                ms.Weight = Convert.ToInt32(textBox3.Text);
                ms.Height = Convert.ToInt32(textBox4.Text);
                ms.ChildId = Convert.ToInt32(comboBox1.SelectedValue);
                context.SaveChanges();
                label1.ForeColor = Color.Green;
                label1.Text = "Запись успешно изменена!";
            }
        }
    }
}
