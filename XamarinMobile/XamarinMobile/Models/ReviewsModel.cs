using Javax.Crypto.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinMobile.Models
{
    public class ReviewsModel
    {
        public int ReviewId { get; set; }
        public string ReviewRating { get; set; }
        public string ReviewMessage { get; set; }
        public int UserId { get; set; }
        public int MerchId { get; set; }
        public int JobId { get; set; }
        public int Job { get; set; }
        public int User { get; set; }



        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string UserEmail { get; set; }
    }

    //"reviewId": 16,
    //"reviewRating": "",
    //"reviewMessage": "",
    //"userId": 1,
    //"merchId": 1,
    //"jobId": 1,
    //"job": null,
    //"merch": null,
    //"user": null
}
