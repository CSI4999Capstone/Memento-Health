﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MementoHealth.Entities
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }
        public string ExternalPatientId { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public DateTime Birthday { get; set; }

        [ForeignKey("Provider")]
        public int ProviderId { get; set; }
        public virtual Provider Provider { get; set; }

        public virtual ICollection<FormSubmission> Submissions { get; set; }
    }
}