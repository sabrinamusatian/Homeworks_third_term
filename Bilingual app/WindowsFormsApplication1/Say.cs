using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using System.Resources;
using System.Reflection;

namespace WindowsFormsApplication1
{
    public partial class Say : Form
    {
        private ResourceManager m_resourceManger = null;
        public Say()
        {
            m_resourceManger = new ResourceManager("Say.Say",
                Assembly.GetExecutingAssembly());
            InitializeComponent();
            comboBox1.Items.Add("English");
            comboBox1.Items.Add("Deutch");
        }

        private void hi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Привет!");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("de-DE");
                Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("de-DE");
                Controls.Clear();
                InitializeComponent();
                comboBox1.Items.Add("English");
                comboBox1.Items.Add("Deutch");
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
                Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                Controls.Clear();
                InitializeComponent();
                comboBox1.Items.Add("English");
                comboBox1.Items.Add("Deutch");
            }
        }

        private void howAreYou_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Как дела?");
        }

        private void myName_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Меня зовут...");
        }

        private void Goodbye_Click(object sender, EventArgs e)
        {
            MessageBox.Show("До свидания!");
        }

        private void good_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Хорошо");
        }

        private void Ilive_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Я живу в...");
        }

        private void bye_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Пока");
        }

        private void soso_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Так себе");
        }

        private void thankYou_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спасибо!");
        }
    }
}
