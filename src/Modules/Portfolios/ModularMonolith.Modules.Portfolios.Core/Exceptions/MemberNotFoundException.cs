using System;
using ModularMonolith.Shared.Abstractions.Exceptions;

namespace ModularMonolith.Modules.Portfolios.Core.Exceptions
{
    internal class MemberNotFoundException : CustomException
    {
        public MemberNotFoundException(Guid memberId) : base($"Member with ID: {memberId} was not found.")
        {
        }
    }
}