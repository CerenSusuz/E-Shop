using EShop.Core.Signatures;

namespace EShop.Business.Models
{
        public class GendersDto : IBaseListDto
        {
            public int Id { get; set; }
            public string Description { get; set; }
            public bool IsBlocked { get; set; }
        }

}