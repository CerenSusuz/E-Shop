using EShop.Core.Signatures;

namespace EShop.Business.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class GenderDto : IBaseDto
    {
        public string Description { get; set; }
        public bool IsBlocked { get; set; }
    }
}