using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiltInDIContainer
{
    internal class MailServiceDependency : IMailServiceDependency
    {

        public void SendNormalMail()
        {
            Console.WriteLine( "Premium users have higher chances of success. Try Premium for free for the first month. \n");
        }

        public void SendPremiumMail()
        {
            Console.WriteLine( "Here is a user report showing how you're interaction is 10x better then normal users. \n");
        }

        public void UserConvertedToPrem()
        {
            Console.WriteLine("Your payment was successfull and you're are a premium user now. \n");
        }
    }
}
