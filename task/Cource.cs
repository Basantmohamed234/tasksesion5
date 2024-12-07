using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    public class Cource
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string credidts { get; set; }

        [ForeignKey("teachers")]
        public int teacherId { get; set; }
        public Teachers teachers { get; set; }


        public List<Enrollment> student { get; set; }

    }
}
