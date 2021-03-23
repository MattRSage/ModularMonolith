using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ModularMonolith.Modules.Portfolios.Core.DTO;
using ModularMonolith.Modules.Portfolios.Core.Entities;
using ModularMonolith.Modules.Portfolios.Core.Exceptions;
using ModularMonolith.Modules.Portfolios.Core.Repositories;

namespace ModularMonolith.Modules.Portfolios.Core.Services
{
    internal class MemberService : IMemberService
    {
        private readonly IMemberRepository _memberRepository;

        public MemberService(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }
        
        public async Task AddAsync(MemberDetailsDto dto)
        {
            dto.Id = Guid.NewGuid();
            var member = new Member
            {
                Id = dto.Id,
                Name = dto.Name,
                Description = dto.Description
            };
            await _memberRepository.AddAsync(member);
        }

        public async Task UpdateAsync(MemberDetailsDto dto)
        {
            var member = await _memberRepository.GetAsync(dto.Id);
            if (member is null)
            {
                throw new MemberNotFoundException(dto.Id);
            }

            member.Id = dto.Id;
            member.Name = dto.Name;
            member.Description = dto.Description;
            await _memberRepository.UpdateAsync(member);
        }

        public async Task DeleteAsync(Guid id)
        {
            var member = await _memberRepository.GetAsync(id);
            if (member is null)
            {
                throw new MemberNotFoundException(id);
            }

            await _memberRepository.DeleteAsync(member);
        }

        public async Task<MemberDetailsDto> GetAsync(Guid id)
        {
            var member = await _memberRepository.GetAsync(id);
            return member is not null
                ? new MemberDetailsDto
                {
                    Id = member.Id,
                    Name = member.Name,
                    Description = member.Description
                }
                : default;
        }

        public async Task<IReadOnlyList<MemberDto>> BrowseAsync()
        {
            var members = await _memberRepository.BrowseAsync();

            return members.Select(x => new MemberDto
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
        }
    }
}