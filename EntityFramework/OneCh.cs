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
    public partial class OneCh : Form
    {
        int thisId = 0;
        public OneCh()
        {
            InitializeComponent();
            button1.Visible = true;
            button2.Visible = false;
        }
        public OneCh(int id)
        {
            thisId = id;
            InitializeComponent();
            button1.Visible = false;
            button2.Visible = true;

            ChildContext context = new ChildContext();
            Child child = context.Children.Find(thisId);
            if (child != null)
            {
                textBox2.Text = child.Name;
                dateTimePicker1.Value = child.BirthDay;
            }
        }
        private void OneCh_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chidlGrDbDataSet.Groups". При необходимости она может быть перемещена или удалена.
            this.groupsTableAdapter.Fill(this.chidlGrDbDataSet.Groups);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "") || (dateTimePicker1.Value >= DateTime.Now))
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Заполните все поля корректно!";
            }
            else
            {
                ChildContext context = new ChildContext();
                Child child = new Child
                {
                    Name = textBox2.Text,
                    BirthDay = dateTimePicker1.Value,
                    GroupId = Convert.ToInt32(comboBox1.SelectedValue)
                };
                context.Children.Add(child);
                context.SaveChanges();
                label1.ForeColor = Color.Green;
                label1.Text = "Новая запись добавлена в базу!";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {           

            if ((textBox2.Text == "") || (dateTimePicker1.Value >= DateTime.Now))
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Заполните все поля корректно!";
            }
            else
            {
                ChildContext context = new ChildContext();
                Child child = context.Children.Find(thisId);
                child.Name = textBox2.Text;
                child.BirthDay = dateTimePicker1.Value;
                child.GroupId = Convert.ToInt32(comboBox1.SelectedValue);
                context.SaveChanges();
                label1.ForeColor = Color.Green;
                label1.Text = "Запись успешно изменена!";
            }
        }
    }
}
