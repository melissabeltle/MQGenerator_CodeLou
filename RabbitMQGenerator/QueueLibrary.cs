using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQGenerator
{
    public static class QueueLibrary


    {

        public static List<string> QueueName = new List<string>()

        {

            "COMMS.DCM.CLM.INPUT",
            "COMMS.DCM.ERA.INPUT",
            //"COMMS.DCM.APLHAII.INPUT",
            //"COMMS.MQSQLIZER.INPUT",
            //"COMMS.CIGNA.CM.OUTPUT",
            //"COMMS.CIGNA.CM.INPUT",
            //"COMMS.CIGNA.ELG.INPUT",
            //"COMMS.CIGNA.ELG.OUTPUT",
            //"COMMS.NDT.CLM.BUILD.INPUT",
            //"FISSBOT.BATCHPARSER.INPUT",
            //"FISSBOT.BATCHROUTER.INPUT"


         };
        private static string queueName;

        public static string GetQueueName()
        {
            return queueName;
        }

        public static void SetQueueName(string value)
        {
            queueName = value;
        }

        public static string MqMsg { get; set; }

    }
}