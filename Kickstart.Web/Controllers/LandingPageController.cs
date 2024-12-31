using Kentico.Content.Web.Mvc.Routing;
using Kentico.PageBuilder.Web.Mvc.PageTemplates;
using Kickstart.Web.Controllers;
using Kickstart;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[assembly: RegisterWebPageRoute(
    contentTypeName: LandingPage.CONTENT_TYPE_NAME,
    controllerType: typeof(LandingPageController))]
namespace Kickstart.Web.Controllers
{
    public class LandingPageController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return new TemplateResult();
        }
    }
}