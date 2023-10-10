namespace SoftUniBazar.Models.Ad
{
    using System.Collections.Generic;
    using SoftUniBazar.Data.Models;
    public class AllAdsViewModel
    {
        public AllAdsViewModel()
        {
            this.Ads = new HashSet<Ad>();
        }
        public ICollection<Ad> Ads { get; set; }
    }
}