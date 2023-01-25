using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileReader_MunaShabab
{
    //author: Muna Shabab
    //ID:624191
    //Date:12-1-19
    //Goal:to demonstrate file reading of user specified file

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            try
            {
                //declare a streamReader object
                StreamReader inputFile;
                inputFile = File.OpenText(fileNameTextBox.Text);

                //clear the content of the listBox
                displayListBox.Items.Clear();

                //while the file is not done 
                while(!inputFile.EndOfStream)
                {
                    //read a line
                    string line;
                    line=inputFile.ReadLine();

                    //and display it in the listBox
                    displayListBox.Items.Add(line);
                }

                //close the file
                inputFile.Close();
            }
          
            //show the error message
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            {
                //the code below opens the file browser dialog
                //and tracks if the user clicked on Open or Cancel when looking at Files
                //if they clicked on Open the file path will be placed the fileNameTextBox on the form
                //if they click on Cancel the fileNameTextBox will be set to blank
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fileNameTextBox.Text = openFileDialog1.FileName;
                }
                else
                {
                    //do nothing, user canceled out of selecting a file
                   fileNameTextBox.Text = "";
                }
            }
        }
    }
}
