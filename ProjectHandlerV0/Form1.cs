using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectHandlerV0
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string[] names = Directory.GetFiles(@"g:\ztms\", "#*.txt"); //find the folder, put it into the listbox
            foreach (string file in names)
            {
                tagSortedList.Items.Add(Path.GetFileName(file)); //ALL the files, please
            }
            names = Directory.GetFiles(@"g:\ztms\Projects", "#*.txt");
            foreach (string file in names)
            {
                tagSortedList.Items.Add(Path.GetFileName(file)); //ALL the files, please
            }
            names = Directory.GetFiles(@"g:\ztms\Program", "#*.txt");
            foreach (string file in names)
            {
                tagSortedList.Items.Add(Path.GetFileName(file)); //ALL the files, please
            }
            names = Directory.GetFiles(@"g:\ztms\Tasks", "#*.txt");
            foreach (string file in names)
            {
                tagSortedList.Items.Add(Path.GetFileName(file)); //ALL the files, please
            }
            names = Directory.GetFiles(@"g:\ztms\Skills", "#*.txt");
            foreach (string file in names)
            {
                tagSortedList.Items.Add(Path.GetFileName(file)); //ALL the files, please
            }
        }

        private void tasksButton_Click(object sender, EventArgs e)
        {
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button category = (Button)sender;
            tagsForm tagsForm = new tagsForm(category.Text);
            tagsForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tagSortedList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zxyphorean Task Management System v1.0\r\n\r\nSETUP:\r\nEvery File MUST have 5 separate lines of 0's before putting the task into the system.");
        }
    }
}
