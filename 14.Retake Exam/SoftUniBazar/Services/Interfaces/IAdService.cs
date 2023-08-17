namespace SoftUniBazar.Services.Interfaces
{
    using System.Collections.Generic;
    using SoftUniBazar.Data.Models;

    public interface IAdService
    {
        List<Ad> GetAllAds();
        Ad GetAdById(int id);
        void AddAd(Ad ad);
        void EditAd(Ad ad);
        void RemoveAd(Ad ad);
        List<Ad> GetAdsInCartForUser(string userId);
    }
}