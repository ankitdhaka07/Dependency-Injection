namespace ServiceLifetimeDI
{
    internal class Service
    {
        private string _serviceLifetime;
        private Guid _guid;
        public Service (string serviceLifeTime)
        {
            _guid = Guid.NewGuid();
            _serviceLifetime = serviceLifeTime;
        }
        public void GoGuid()
        {
            Console.WriteLine($"\n {_serviceLifetime} : {_guid}\n");
        }
    }
}