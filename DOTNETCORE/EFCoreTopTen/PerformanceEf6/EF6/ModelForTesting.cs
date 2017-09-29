﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PerformanceEf6.EF6
{
    public class ModelForTesting
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId { get; set; }
        public string Class { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string CategoryName { get; set; }
        public string Email { get; set; }

    }
}
