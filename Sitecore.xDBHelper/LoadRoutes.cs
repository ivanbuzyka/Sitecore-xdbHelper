using Sitecore.Pipelines;
using System.Web.Mvc;
using System.Web.Routing;

namespace Sitecore.xDBHelper
{
  public class LoadRoutes
  {
    public void Process(PipelineArgs args)
    {
      RouteTable.Routes.MapRoute(
        "xdbHelperApi",
        "xdbHelperApi/{controller}/{action}/{id}",
        new { controller = "Contact", action = "Index", id = UrlParameter.Optional }
        );
      RouteConfig.RegisterRoutes(RouteTable.Routes);
    }
  }
}