﻿using System.ComponentModel.DataAnnotations;

namespace Inventory_Backend.Database.Entities
{
    public class DynamicEntity
    {
        [Key]
        public Guid Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
