﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQGenerator
{
    public class Queue
    {
        
       
        // call both the queue and number of msgs requested

        public List<string> GetListMsgs(string queue, int msgCount)

        {
            var sample = GetSampleMsg(queue);          
            var modifiedMsgs = GetAllMessages(sample, msgCount);
            return modifiedMsgs;

        }

    

         private string GetSampleMsg(string queue)
        {

            switch (queue)

            {

                case "COMMS.DCM.CLM.INPUT":
                    return @"09/13/2021 14:09:35þ3060þFþ\\LOUQAMTX021B\Pickup\FromExtEditReq\1176_199925_199925_054ea069f5004089a455b51be060cffa.batchþ152984þ1þ";
                    
                case "COMMS.DCM.ERA.INPUT":
                    return @"11/04/2021 06:30:09þ028471966723409290665þFþ\\10.15.20.112\\zmops\era.spec\RIVERSIDEEPIC\2021\11\04\20211104_063006_2936890.gzþ153011þ1þ1556-ALL-20211104-nGNT152X-EPIC-2936890.835";
                    
                case "COMMS.NDT.CLM.BUILD.INPUT":
                    return @"11/09/2021 09:34:43þPACAID*837I5010þFILENAME=187926815.cli.gzýSUBMITTERTYPE=ZýOUTFILENAME=187926815.cli";

                case "COMMS.DCM.APLHAII.INPUT":
                    return @"COMMS.DCM.ALPHAII.INPUT, Message: 11/09/2021 05:16:08þ3338þFþ\\LOUQAMTX021A\Pickup\FromExtEditReq\1286_199925_199925_5d078c4ec1d746ae978a22ab32bba431.batchþ152984þ1þ";

                case "COMMS.MQSQLIZER.INPUT":
                    return @"11/04/2021 13:41:51þ-2147367114þFþ\\louqafs008a\Waystar\clients\passport_tr\outbound\Ovation_Pacific_Source_Claim_Status_20211103103037_0_CS.xmlþ152940þ1þOvation_Pacific_Source_Claim_Status_20211103103037_0_CS.xml";

                default:
                    return string.Empty;
            }


             
        }


        private List<string> ModifyMsg(string sampleMsg, int msgCount)
        {
            var msgFields = sampleMsg.Split('þ');
            msgFields[0] = DateTime.Now.ToString();
            var newMsg = String.Join("þ", msgFields);
            return null;
                       
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

            
            for (int i = 0; i < msgCnt; i++)
            {
                allThaMsgs.Add(ModifyMsg(sampleMsg));

                                               
                var time = 1000;
                System.Threading.Thread.Sleep(time);

                Console.WriteLine(allThaMsgs);


            }

            return allThaMsgs;

            
        }

        

    } }

    

