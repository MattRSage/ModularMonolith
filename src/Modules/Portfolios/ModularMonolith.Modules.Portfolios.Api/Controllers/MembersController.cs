using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModularMonolith.Modules.Portfolios.Core.DTO;
using ModularMonolith.Modules.Portfolios.Core.Services;

namespace ModularMonolith.Modules.Portfolios.Api.Controllers
{
    internal class MembersController : BaseController
    {
        private readonly IMemberService _memberService;

        public MembersController(IMemberService memberService)
        {
            _memberService = memberService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MemberDetailsDto>> Get(Guid id)
        {
            var member = await _memberService.GetAsync(id);
            if (member is null)
            {
                return NotFound();
            }

            return Ok(member);
        }
        
        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<MemberDto>>> BrowseAsync()
            => Ok(await _memberService.BrowseAsync());

        [HttpPost]
        public async Task<ActionResult> AddAsync(MemberDetailsDto dto)
        {
            await _memberService.AddAsync(dto);
            return CreatedAtAction(nameof(Get), new { id = dto.Id}, null);
        }
        
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateAsync(Guid id, MemberDetailsDto dto)
        {
            dto.Id = id;
            await _memberService.UpdateAsync(dto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(Guid id)
        {
            await _memberService.DeleteAsync(id);
            return NoContent();
        }
    }
}