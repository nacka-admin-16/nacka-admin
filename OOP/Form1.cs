using System;
using System.Windows.Forms;
using Message = OOP.Entities.Message;

namespace OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {            
            var message = new Message
            {
                Text = textBox1.Text
            };

            MessageBox.Show(message.ShowMessage());
        }
    }
}