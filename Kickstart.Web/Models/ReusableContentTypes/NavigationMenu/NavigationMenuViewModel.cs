using System.Collections.Generic;
using Kickstart.Web.Models.ReusableContentTypes.NavigationItem;

namespace Kickstart.Web.Models.ReusableContentTypes.NavigationMenu
{
    public class NavigationMenuViewModel
    {
        public string Name { get; set; }

        public IEnumerable<NavigationItemViewModel> Items { get; set; }
    }
}
