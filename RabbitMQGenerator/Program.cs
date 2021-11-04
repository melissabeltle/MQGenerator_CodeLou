using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RabbitMQGenerator
{
    static class Program
    {
        private static bool message;

        public static bool Message { get => message; set => message = value; }

        static void Main(string[] args)
        {
            Application.Run(new Form1());
            
        }

        

       
    }

    
}




//DoSomethingWithQueue(comboBox1.Text);
//_queueName = comboBox1.Text;


//            ConnecttoRabbit(_queueName);

