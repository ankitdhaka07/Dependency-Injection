using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiltInDIContainer
{
    internal class PropertyInjection
    {
        public IMailServiceDependency _mailService { get; set; }


        public void SendPremMessage()
        {
            _mailService.SendPremiumMail();
        }
    }
}
