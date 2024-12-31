using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiltInDIContainer
{
    internal interface IMailServiceDependency
    {
        
        public void SendPremiumMail();
        public void SendNormalMail();
        public void UserConvertedToPrem();

    }
}
