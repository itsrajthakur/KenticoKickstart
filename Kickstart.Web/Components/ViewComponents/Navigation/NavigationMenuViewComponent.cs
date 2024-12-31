using CMS.ContentEngine;
using CMS.Websites.Routing;
using Kentico.Content.Web.Mvc.Routing;
using Kickstart.Web.Models.ReusableContentTypes.NavigationMenu;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Kickstart.Web.Components.ViewComponents.Navigation
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private readonly INavigationService navigationService;
        private readonly IContentQueryExecutor contentQueryExecutor;
        private readonly IWebsiteChannelContext webSiteChannelContext;
        private readonly IPreferredLanguageRetriever preferredLanguageRetriever;

        public NavigationMenuViewComponent(
            INavigationService navigationService,
            IContentQueryExecutor contentQueryExecutor,
            IWebsiteChannelContext webSiteChannelContext,
            IPreferredLanguageRetriever preferredLanguageRetriever)
        {
            this.navigationService = navigationService;
            this.contentQueryExecutor = contentQueryExecutor;
            this.webSiteChannelContext = webSiteChannelContext;
            this.preferredLanguageRetriever = preferredLanguageRetriever;
        }

        public async Task<IViewComponentResult> InvokeAsync(string navigationMenuCodeName)
        {
            // A placeholder representing the logic that retrieves the `NavigationMenu` item from the database.
            var menu = await RetrieveMenu(navigationMenuCodeName);

            if (menu == null)
            {
                // We will define this view in the next step.
                return View("~/Components/ViewComponents/Navigation/NavigationMenuViewComponent.cshtml", new NavigationMenuViewModel());
            }

            var model = await navigationService.GetNavigationMenuViewModel(menu);

            return View("~/Components/ViewComponents/Navigation/NavigationMenuViewComponent.cshtml", model);
        }
        private async Task<NavigationMenu> RetrieveMenu(string navigationMenuCodeName)
        {
            var builder = new ContentItemQueryBuilder()
                .ForContentType(NavigationMenu.CONTENT_TYPE_NAME,
                config => config
                    .Where(where => where.WhereEquals(nameof(NavigationMenu.NavigationMenuCodeName), navigationMenuCodeName))
                    .WithLinkedItems(2))
                .InLanguage(preferredLanguageRetriever.Get());

            var queryExecutorOptions = new ContentQueryExecutionOptions
            {
                ForPreview = webSiteChannelContext.IsPreview
            };

            var items = await contentQueryExecutor.GetMappedResult<NavigationMenu>(builder, queryExecutorOptions);

            return items.FirstOrDefault();
        }
    }
}
