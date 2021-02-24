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
    public partial class Editor : Form
    {
        public Editor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gr gr = new Gr();
            gr.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ch ch = new Ch();
            ch.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ms ms = new Ms();
            ms.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) 
            {
                OneGr gr = new OneGr();
                gr.ShowDialog();
            }

            if (radioButton2.Checked)
            {
                OneCh ch = new OneCh();
                ch.ShowDialog();
            }

            if (radioButton3.Checked)
            {
                OneMs ms = new OneMs();
                ms.ShowDialog();
            }
        }

        // изменение
        private void button7_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                OneGr gr = new OneGr(Convert.ToInt32(comboBox3.SelectedValue));
                gr.ShowDialog();
                
            }

            if (radioButton2.Checked)
            {
                OneCh ch = new OneCh(Convert.ToInt32(comboBox2.SelectedValue));
                ch.ShowDialog();
            }

            if (radioButton3.Checked)
            {
                OneMs ms = new OneMs(Convert.ToInt32(comboBox4.SelectedValue));
                ms.ShowDialog();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                try
                {
                    GroupContext context = new GroupContext();
                    Group group = context.Groups.Find(Convert.ToInt32(comboBox3.SelectedValue));
                    context.Groups.Remove(group);
                    context.SaveChanges();
                    label6.ForeColor = Color.Green;
                    label6.Text = "Строка с данным индексом успешно удалена!";
                }
                catch
                {
                    label6.ForeColor = Color.Red;
                    label6.Text = "Операция отклонена. Есть зависимые данные.";
                }
            }

            if (radioButton2.Checked)
            {
                try
                {
                    ChildContext context = new ChildContext();
                    Child child = context.Children.Find(Convert.ToInt32(comboBox2.SelectedValue));
                    context.Children.Remove(child);
                    context.SaveChanges();
                    label6.ForeColor = Color.Green;
                    label6.Text = "Строка с данным индексом успешно удалена!";
                }
                catch
                {
                    label6.ForeColor = Color.Red;
                    label6.Text = "Операция отклонена. Есть зависимые данные.";
                }
            }

            if (radioButton3.Checked)
            {
                try
                {
                    MsContext context = new MsContext();
                    MedService ms = context.MedServices.Find(Convert.ToInt32(comboBox4.SelectedValue));
                    context.MedServices.Remove(ms);
                    context.SaveChanges();
                    label6.ForeColor = Color.Green;
                    label6.Text = "Строка с данным индексом успешно удалена!";
                }
                catch
                {
                    label6.ForeColor = Color.Red;
                    label6.Text = "Операция отклонена. Есть зависимые данные.";
                }
            }
        }

        private void Editor_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chidlGrDbDataSet.MedServices". При необходимости она может быть перемещена или удалена.
            this.medServicesTableAdapter.Fill(this.chidlGrDbDataSet.MedServices);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chidlGrDbDataSet.Groups". При необходимости она может быть перемещена или удалена.
            this.groupsTableAdapter.Fill(this.chidlGrDbDataSet.Groups);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chidlGrDbDataSet.Children". При необходимости она может быть перемещена или удалена.
            this.childrenTableAdapter.Fill(this.chidlGrDbDataSet.Children);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (label5.Visible == false) label5.Visible = true;
            comboBox2.Visible = false;
            comboBox3.Visible = true;
            comboBox4.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (label5.Visible == false) label5.Visible = true;
            comboBox2.Visible = true;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (label5.Visible == false) label5.Visible = true;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Norms norms = new Norms();
            norms.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Norms norms = new Norms();
            norms.ShowDialog();
        }
    }
}
