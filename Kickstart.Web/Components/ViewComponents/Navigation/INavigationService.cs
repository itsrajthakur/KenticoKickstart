using System.Threading.Tasks;
using Kickstart.Web.Models.ReusableContentTypes.NavigationItem;
using Kickstart.Web.Models.ReusableContentTypes.NavigationMenu;

namespace Kickstart.Web.Components.ViewComponents.Navigation
{
    public interface INavigationService
    {
        Task<NavigationItemViewModel> GetNavigationItemViewModel(NavigationItem navigationItem);

        Task<NavigationMenuViewModel> GetNavigationMenuViewModel(NavigationMenu navigationMenu);
    }
}
