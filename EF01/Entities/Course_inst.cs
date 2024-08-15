using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EF01.Entities
{
    [PrimaryKey(nameof(ins_Id), nameof(Course_Id))]
    internal class Course_ins
    {
        public int ins_Id { get; set; }
        public int Course_Id { get; set; }
        public int evaluate { get; set; }
    }
}
