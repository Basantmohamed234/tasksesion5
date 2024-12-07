using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    public class Teachers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("department")]
        public int departmentId { get; set; }
        public Department department { get; set; }

        public List<Cource> cource { get; set; }
    }
}
