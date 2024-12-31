namespace DependencyInDependency
{
    public class Service:IService
    {
        private GuidClass _guid;
        public Service ()
        {
            _guid = new GuidClass();
        }
        public List<Guid> GoGuid()
        {
            return _guid.GuidList();
        }
    }
}