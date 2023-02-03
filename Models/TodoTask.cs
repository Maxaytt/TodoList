﻿using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ToDo.Models
{
    public class TodoTask
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        [Range(1,10)]
        public int Priority { get; set; }
        public bool IsCompleted { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        public DateTime CompletedAt { get; set; }
        public DateTime Deadline { get; set; }

    }
}