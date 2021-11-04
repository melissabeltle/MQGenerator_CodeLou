using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQGenerator
{
    public class Queue
    {
        
        //{
        //    string message = "Test Message";

        //    public string Message { get => message; set => message = value; }



        //create method that call both the queue from combo and the number - call it in the button method instead of the GetSampleMsg that is there now

        public List<string> GetListMsgs(string queue, int msgCount)

        {
            var sample = GetSampleMsg(queue);

            //TODO: call to get multiple messages and return them
            return new List<string>();

        }

    


         private string GetSampleMsg(string queue)
        {

            switch (queue)

            {

                case "COMMS.DCM.CLM.INPUT":
                    return @"09/13/2021 14:09:35þ3060þFþ\\LOUQAMTX021B\Pickup\FromExtEditReq\1176_199925_199925_054ea069f5004089a455b51be060cffa.batchþ152984þ1þ";


                case "COMMS.DCM.ERA.INTPUT":
                    return @"11/04/2021 06:30:09þ028471966723409290665þFþ\\10.15.20.112\zmops\era.spec\RIVERSIDEEPIC\2021\11\04\20211104_063006_2936890.gzþ153011þ1þ1556-ALL-20211104-nGNT152X-EPIC-2936890.835";


                default:
                    return string.Empty;
            }





       
        }


        private List<string> ModifyMsg(string sampleMsg, int msgCount)
        {
            var msgFields = sampleMsg.Split('þ');
            msgFields[0] = DateTime.Now.ToString();
            var newMsg = String.Join("þ", msgFields);
        }


        private string ModifyMsg(string sampleMsg)
        {
            var msgFields = sampleMsg.Split('þ');
            msgFields[0] = DateTime.Now.ToString();
            return String.Join("þ", msgFields);
        }

        private List<string> GetAllMessages(string sampleMsg, int msgCnt)
        {
            var allThaMsgs = new List<string>();

            //TODO: make a loop
            for (int i = 0; i < msgCnt; i++)
            {
                allThaMsgs.Add(ModifyMsg(sampleMsg));

                //TODO add delay of 1 sec to prevent overlap of timestamp
                var time = '3000';
                Thread.Sleep(time);


                    

                
                
            }

            return allThaMsgs;
        }

        //methods to increment and produce messages

        //public string NewMsg(string int) => List<string>;

        //    {
        //        return;
        //    }


        //Rabbit


    } }

    

