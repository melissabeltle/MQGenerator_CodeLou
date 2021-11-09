using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RabbitMQGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _queue = new Queue();

        }

        private int msgCount;
        public string queue;

        private Queue _queue;
        private readonly object finalList;

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(QueueLibrary.QueueName.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var messages = _queue.GetListMsgs(queue, msgCount);

                foreach(var singleMsg in messages)
            {
                textBox1.Text += singleMsg + Environment.NewLine;

            }
        }

       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            queue = comboBox1.Text;
        
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            msgCount = int.Parse(numericUpDown1.Value.ToString());
        }

              

    }
}
