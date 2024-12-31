using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInDependency
{
    internal interface IMainService
    {

        public string ServiceType { get; set; }
        public string MainServiceType { get; set; }
        public void ShowInternalService();
        public void ShowMainService();
        public void ShowBothService();

    }
}
