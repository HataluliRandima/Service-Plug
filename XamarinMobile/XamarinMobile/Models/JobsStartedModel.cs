using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinMobile.Models
{
    public class JobsStartedModel
    {
        public int JobId { get; set; }
        public string JobStatus { get; set; }
        public DateTime BookDatetime { get; set; }
        public int UserId { get; set; }
        public int MerchId { get; set; }
        public int BookId { get; set; }


        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string UserEmail { get; set; }
    }
}
