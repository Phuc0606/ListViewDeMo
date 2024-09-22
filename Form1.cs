using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void formatLíViewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             ListViewItem item = new ListViewItem(txtLastName.Text);
             item.SubItems.Add(txtFirstName.Text);
             item.SubItems.Add(txtPhone.Text);
             listView1.Items.Add(item);
            /*if (!string.IsNullOrWhiteSpace(txtLastName.Text) &&
             !string.IsNullOrWhiteSpace(txtFirstName.Text) &&
             !string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                ListViewItem item = new ListViewItem(txtLastName.Text);
                item.SubItems.Add(txtFirstName.Text);
                item.SubItems.Add(txtPhone.Text);
                listView1.Items.Add(item);
                txtLastName.Clear();
                txtFirstName.Clear();
                txtPhone.Clear();
            }
            else
            {
                MessageBox.Show("Please fill in all fields before adding.");
            }*/
        
    }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                item.SubItems[0].Text = txtLastName.Text;
                item.SubItems[1].Text = txtFirstName.Text;
                item.SubItems[2].Text = txtPhone.Text;
            }
        }
    }
}
