using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo.DataAccess
{
    [Table("Make")]
    public class Make
    {
        public long MakeId { get; set; }

        [Required, MaxLength(400)]
        public string Name { get; set; }

        [Required, MaxLength(400)]
        public string FactoryPhone { get; set; }

        public List<Model> Models { get; set; }


    }
}
