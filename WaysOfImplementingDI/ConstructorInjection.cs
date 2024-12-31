using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiltInDIContainer
{
    internal class ConstructorInjection
    {
        IMailServiceDependency _mailService;
        public ConstructorInjection(IMailServiceDependency mailService)
        {
            _mailService = mailService;
        }

        public void SendPremMessage()
        {
            _mailService.SendPremiumMail();
        }
    }
}
