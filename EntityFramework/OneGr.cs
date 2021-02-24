using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFramework;

namespace EntityFramework
{
    public partial class OneGr : Form
    {
        int thisId = 0;
        public OneGr()
        {
            InitializeComponent();
            button1.Visible = true;
            button2.Visible = false;
        }

        public OneGr(int id)
        {
            thisId = id;
            InitializeComponent();
            button1.Visible = false;
            button2.Visible = true;

            GroupContext context = new GroupContext();
            Group group = context.Groups.Find(thisId);
            if (group != null)
            {
                textBox1.Text = group.Name;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Заполните все поля корректно!";
            }
            else
            {
                GroupContext context = new GroupContext();
                Group group = new Group
                {
                    Name = textBox1.Text
                };
                context.Groups.Add(group);
                context.SaveChanges();
                label1.ForeColor = Color.Green;
                label1.Text = "Новая запись добавлена в базу!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Заполните все поля корректно!";
            }
            else
            {
                GroupContext context = new GroupContext();
                Group group = context.Groups.Find(thisId);
                group.Name = textBox1.Text;
                context.SaveChanges();
                label1.ForeColor = Color.Green;
                label1.Text = "Запись успешно изменена!";
            }

        }
    }
}
