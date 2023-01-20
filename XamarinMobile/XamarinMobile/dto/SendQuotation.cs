using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinMobile.dto
{
    public class SendQuotation
    {
        public int BookId { get; set; }
        public int MerchId { get; set; }
        public int UserId { get; set; }
        public string QuotAmount { get; set; }
        public string QuotDescription { get; set; }
    }
}
