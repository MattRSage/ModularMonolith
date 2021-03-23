using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using ModularMonolith.Modules.Portfolios.Core.Entities;

namespace ModularMonolith.Modules.Portfolios.Core.Repositories
{
    public interface IMemberRepository
    {
        Task<Member> GetAsync(Guid id);
        Task<IReadOnlyList<Member>> BrowseAsync();
        Task AddAsync(Member member);
        Task DeleteAsync(Member member);
        Task UpdateAsync(Member member);
    }
}