using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo.DataAccess
{
    public class Model
    {
        public long ModelId { get; set; }
        public string Name { get; set; }

        public long MakeId { get; set; }
        public Make Make { get; set; }
        public int ModelYear { get; set; }
        public BodyType BodyType { get; set; }

        public List<Trim> Trims { get; set; }
    }
}
