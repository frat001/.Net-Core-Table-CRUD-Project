﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsess.Model
{
    [Table("PersonelDepartman")]
    public class PersonelDepartman
    {
        [Key]
        public int Id { get; set; }
        public int PersonelID { get; set; }

        public String Departman { get; set; }

        public string Gorevi { get; set; }
    }

}

