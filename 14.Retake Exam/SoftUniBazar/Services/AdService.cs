namespace SoftUniBazar.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using SoftUniBazar.Data;
    using SoftUniBazar.Data.Models;
    using SoftUniBazar.Services.Interfaces;

    public class AdService : IAdService
    {
        private readonly BazarDbContext _context;

        public AdService(BazarDbContext context)
        {
            _context = context;
        }

        public List<Ad> GetAllAds()
        {
            return _context.Ads.ToList();
        }

        public Ad GetAdById(int id)
        {
            return _context.Ads.FirstOrDefault(ad => ad.Id == id);
        }

        public void AddAd(Ad ad)
        {
            _context.Ads.Add(ad);
            _context.SaveChanges();
        }

        public void EditAd(Ad ad)
        {
            _context.Ads.Update(ad);
            _context.SaveChanges();
        }

        public void RemoveAd(Ad ad)
        {
            _context.Ads.Remove(ad);
            _context.SaveChanges();
        }

        public List<Ad> GetAdsInCartForUser(string userId)
        {
            return _context.AdBuyers
                .Where(ab => ab.BuyerId == userId)
                .Select(ab => ab.Ad)
                .ToList();
        }
    }
}