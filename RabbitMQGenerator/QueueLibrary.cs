using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQGenerator
{
    public class QueueLibrary


    {

        public List<string> QueueNames = new List<string>()

        {

            "COMMS.DCM.CLM.INPUT",
            "COMMS.DCM.ERA.INPUT",
            "COMMS.DCM.APLHAII.INPUT",
            "COMMS.MQSQLIZER.INPUT",
            "COMMS.CIGNA.CM.OUTPUT",
            "COMMS.CIGNA.CM.INPUT",
            "COMMS.CIGNA.ELG.INPUT",
            "COMMS.CIGNA.ELG.OUTPUT",
            "COMMS.NDT.CLM.BUILD.INPUT",
            "FISSBOT.BATCHPARSER.INPUT",
            "FISSBOT.BATCHROUTER.INPUT"


         };




        public string QueueName { get; set; }
        public string MqMsg { get; set; }

    }
}