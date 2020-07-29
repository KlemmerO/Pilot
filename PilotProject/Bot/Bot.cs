using System;
using System.Collections.Generic;
using System.Text;

namespace Bot
{
    public delegate void ProposalDelegate(int commonprice, string message);
        public class Bot
    {
        private ProposalDelegate _proposalDelegate;
        private const int basicPrice = 15;
        public static int CommonPrice { get; set; }
        public Bot(ProposalDelegate proposalDelegate)
        {
            _proposalDelegate = proposalDelegate;
            Return();
        }
        void Return()
        { 
            if(CommonPrice >= basicPrice)
            {
                Proposal();
            }
        }
        void Proposal()
        {
            _proposalDelegate.Invoke(CommonPrice, message:"You have the free delivery");
        }
        
    }
}
