using System;
using EShop.Core.Signatures;

namespace EShop.DataAccess.Entities
{
    public class UserGroup : BaseEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsBlocked { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedUser { get; set; }
        public string UpdatedUser { get; set; }
    }
}