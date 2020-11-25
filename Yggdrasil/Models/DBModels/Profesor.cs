using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Yggdrasil.Models.DBModels
{
    public class Profesor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProfesor { get; set; }
        public string NameProfesor { get; set; }
        public DateTime EnrollDate { get; set; }
    }
}
