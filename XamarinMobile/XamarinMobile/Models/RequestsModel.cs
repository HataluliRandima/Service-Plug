using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinMobile.Models
{
    public class RequestsModel
    {
        public int BookId { get; set; }
        public string BookStatus { get; set; }
      //  public DateTime BookDatetime { get; set; }
        public int UserId { get; set; }
        public int MerchId { get; set; }

        public string BookMessage { get; set; }
        public DateTime BookDate { get; set; }
        public TimeSpan BookTime { get; set; }
    }


}
