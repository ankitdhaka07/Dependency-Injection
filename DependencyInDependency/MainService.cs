
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInDependency
{
    internal class MainService : IMainService
    {
        private readonly IService _service;
        public string ServiceType { get; set; } = "Not Provided";
        public string MainServiceType { get; set; } = "Not Provided";
        private GuidClass mainGuid;
        private GuidClass serviceGuid;
        private List<Guid> mainGuidList;
        private List<Guid> serviceGuidList;
        public MainService(IService service)
        {
            mainGuid = new GuidClass();
            mainGuidList = mainGuid.GuidList();
            _service = service;
            serviceGuidList = service.GoGuid();
        }
        public void ShowInternalService()
        {
            Console.WriteLine($"Service LifeTime => {ServiceType}");

            for (int i = 0; i < serviceGuidList.Count; i++)
            {
                Console.WriteLine($"{i}th element : {serviceGuidList[i]}");
            }
        }

        public void ShowMainService()
        {
            Console.WriteLine($"MainService LifeTime => {MainServiceType}");

            for (int i = 0; i < mainGuidList.Count; i++)
            {
                Console.WriteLine($"{i}th element : {mainGuidList[i]}");
            }
        }

        public void ShowBothService()
        {
            ShowInternalService();
            ShowMainService();
        }

    }
}
