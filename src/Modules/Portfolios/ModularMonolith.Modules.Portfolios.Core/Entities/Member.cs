using System;

namespace ModularMonolith.Modules.Portfolios.Core.Entities
{
    public class Member
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}