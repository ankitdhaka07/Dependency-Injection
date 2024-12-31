using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInDependency
{
    public class GuidClass
    {
        public Guid guid1, guid2;
        List<Guid> guidList;
        public GuidClass()
        {
            guid1 = Guid.NewGuid();
            guid2 = Guid.NewGuid();
            guidList = new List<Guid>() { guid1, guid2 };
        }
        public List<Guid> GuidList()
        {
            return guidList;
        }
    }
}
