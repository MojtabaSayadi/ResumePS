﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumePS.Domain.Models.Web
{
    public class WebSkills
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int Percent { get; set; }
    }
}
