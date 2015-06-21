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
    public partial class tagsForm : Form
    {
        string categoryB; //what folder?
        public tagsForm(string category) //getting the info in the boxes
        {
            InitializeComponent();
            testOut.Text = category;
            categoryB = category;
            string[] names = Directory.GetFiles(@"g:\ztms\" + category); //find the folder, put it into the listbox
            
            foreach (string file in names)
            {
                fileSelectionDrop.Items.Add(Path.GetFileName(file)); //ALL the files, please
            }


        }

        private void TaskSelectionDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            int counter = 0;
            int toggle; //save the tag metadata in the form
            string selected = fileSelectionDrop.GetItemText(fileSelectionDrop.SelectedItem); //which file?
            StreamReader sr = new StreamReader(@"g:\ztms\" + categoryB + "/" + selected); // the folder it's in and the filepath
            while (counter < 5) //only the first five lines    
            {
                toggle = Convert.ToInt32(sr.ReadLine());
                switch (counter)
                {
                    case 0: // priority?
                        if (toggle == 1)
                        {
                            tagsCheckbox.SetItemCheckState(0, CheckState.Checked);
                        }
                        else tagsCheckbox.SetItemCheckState(0, CheckState.Unchecked);
                        break;

                    case 1: // group?
                        if (toggle == 1)
                        {
                            tagsCheckbox.SetItemCheckState(1, CheckState.Checked);
                        }
                        else tagsCheckbox.SetItemCheckState(1, CheckState.Unchecked);

                        break;

                    case 2: // age?
                        if (toggle == 1) //new?
                        {
                            tagsCheckbox.SetItemCheckState(2, CheckState.Checked);
                            tagsCheckbox.SetItemCheckState(3, CheckState.Unchecked);
                        }
                        else if (toggle == 2) //almost done?
                        {
                            tagsCheckbox.SetItemCheckState(3, CheckState.Checked);
                            tagsCheckbox.SetItemCheckState(2, CheckState.Unchecked);
                        }
                        else if (toggle == 0) // middle of being done
                        {
                            tagsCheckbox.SetItemCheckState(2, CheckState.Unchecked);
                            tagsCheckbox.SetItemCheckState(3, CheckState.Unchecked);
                        }
                        break;

                    case 3: // need mats?
                        if (toggle == 1)
                        {
                            tagsCheckbox.SetItemCheckState(4, CheckState.Checked);
                        }
                        else tagsCheckbox.SetItemCheckState(4, CheckState.Unchecked);

                        break;

                    case 4: // need skill?
                        if (toggle == 1)
                        {
                            tagsCheckbox.SetItemCheckState(5, CheckState.Checked);
                        }
                        else tagsCheckbox.SetItemCheckState(5, CheckState.Unchecked);

                        break;

                    default:
                        MessageBox.Show("File not formatted properly.");
                        break;
                }
                ++counter;
            }
            sr.Close();
        }

        private void tagsCheckbox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e) //save any changes made to the tags
        {
            int counter = 0;
            string line;
            string temp = ""; //hold the txt file contents for retagging/editing
            string selected = fileSelectionDrop.GetItemText(fileSelectionDrop.SelectedItem); //which file?
            StreamReader sr = new StreamReader(@"g:\ztms\" + categoryB + "/" + selected); //reader filepath
            while ( ( line = sr.ReadLine()) != null)
            {
                if (counter < 5)
                {
                    ++counter;
                }
                else temp = temp + "\r\n" + line;
            }
            sr.Close();
            StreamWriter sw = new StreamWriter(@"g:\ztms\" + categoryB + "/" + selected, false);

            if (tagsCheckbox.GetItemCheckState(5) == CheckState.Checked) //checked lacking skil? save it.
            {
                temp = "1\r\n" + temp;
            }
            else temp = "0\r\n" + temp;

            if (tagsCheckbox.GetItemCheckState(4) == CheckState.Checked) //checked lacking mats? save it.
            {
                temp = "1\r\n" + temp;
            }
            else temp = "0\r\n" + temp;

            if (tagsCheckbox.GetItemCheckState(3) == CheckState.Checked) //checked almost done? save it. Unless...
            {
                temp = "2\r\n" + temp;
            }
            else if (tagsCheckbox.GetItemCheckState(2) == CheckState.Checked) //checked new? save it.
            {
                temp = "1\r\n" + temp;
            }
            else temp = "0\r\n" + temp;

            if (tagsCheckbox.GetItemCheckState(1) == CheckState.Checked) //checked group? save it.
            {
                temp = "1\r\n" + temp;
            }
            else temp = "0\r\n" + temp;

            if (tagsCheckbox.GetItemCheckState(0) == CheckState.Checked) //checked priority? save it.
            {
                temp = "1\r\n" + temp;
            }
            else temp = "0\r\n" + temp;
            sw.WriteLine(temp);
            sw.Close();
        }


    }
}
