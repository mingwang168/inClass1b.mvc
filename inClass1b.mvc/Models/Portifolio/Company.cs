﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace inClass1b.mvc.Models.Portifolio
{
    public class Company
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public virtual ICollection<InterviewRequest> InterviewRequests { get; set; }

    }
}
