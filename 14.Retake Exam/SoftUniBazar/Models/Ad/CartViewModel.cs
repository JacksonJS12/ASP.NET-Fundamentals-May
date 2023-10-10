namespace SoftUniBazar.Models.Ad
{
    using System;
    using System.Collections.Generic;
    using SoftUniBazar.Data.Models;


    public class CartViewModel
    {
        public CartViewModel()
        {
            this.AdsInCart = new HashSet<Ad>();
        }
        public ICollection<Ad> AdsInCart { get; set; }
    }
}