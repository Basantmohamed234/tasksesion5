using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    public class Enrollment
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("grade")]
        public int gradeId { get; set; }
        public Grade grade { get; set; }

        [ForeignKey("cource")]
        public int courceId { get; set; }
        public Cource cource { get; set; }

        [ForeignKey("student")]
        public int studentId { get; set; }
        public Student student { get; set; }

    }
}
