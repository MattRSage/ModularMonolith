using System.ComponentModel.DataAnnotations;

namespace ModularMonolith.Modules.Portfolios.Core.DTO
{
    public class MemberDetailsDto : MemberDto
    {
        [StringLength(1000,MinimumLength = 3)]
        public string Description { get; set; }
    }
}