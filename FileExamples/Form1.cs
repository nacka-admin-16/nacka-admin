using System;
using System.Windows.Forms;
using FileExamples.interfaces;

namespace FileExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void GetAge()
        {
            IPerson person = new Person();
            person.GetAge();
            person.GetName();
        }

        private void cmdShowFiles_Click(object sender, EventArgs e)
        {
            var fileInfo = FileHandler.FileHandler.ListFiles(txtBoxDirectory.Text);

            foreach (var info in fileInfo)
            {
                lstFiles.Items.Add(info.Directory + "\\" + info.Name);
            }
        }        
    }
}