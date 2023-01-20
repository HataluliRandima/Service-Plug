using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinMobile
{
    public class FlyoutHomeFlyoutMenuItem
    {
        public FlyoutHomeFlyoutMenuItem()
        {
            TargetType = typeof(FlyoutHomeFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }

        public string IconSource  { get; set; }
    }
}