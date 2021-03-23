using System;
using System.ComponentModel.DataAnnotations;

namespace ModularMonolith.Modules.Portfolios.Core.DTO
{
    public class MemberDto
    {
        public Guid Id { get; set; }
        
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }
    }
}