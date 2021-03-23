using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ModularMonolith.Modules.Portfolios.Core.DTO;

namespace ModularMonolith.Modules.Portfolios.Core.Services
{
    public interface IMemberService
    {
        Task<MemberDetailsDto> GetAsync(Guid id);
        Task<IReadOnlyList<MemberDto>> BrowseAsync();
        Task AddAsync(MemberDetailsDto dto);
        Task UpdateAsync(MemberDetailsDto dto);
        Task DeleteAsync(Guid id);
    }
}