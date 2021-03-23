using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModularMonolith.Modules.Portfolios.Core.Entities;
using ModularMonolith.Modules.Portfolios.Core.Repositories;

namespace ModularMonolith.Modules.Portfolios.Core.DAL.Repositories
{
    internal class InMemoryMemberRepository : IMemberRepository
    {
        private readonly List<Member> _members = new();
        public Task<Member> GetAsync(Guid id) => Task.FromResult(_members.SingleOrDefault(x => x.Id == id));

        public async Task<IReadOnlyList<Member>> BrowseAsync()
        {
            await Task.CompletedTask;
            return _members;
        }

        public Task AddAsync(Member member)
        {
            _members.Add(member);
            return Task.CompletedTask;
        }
        
        public Task UpdateAsync(Member member) => Task.CompletedTask;

        public Task DeleteAsync(Member member)
        {
            _members.Remove(member);
            return Task.CompletedTask;
        }
    }
}