using System.Web.Http;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;
using DenCreation.Dev.EveningApi.Models;

namespace DenCreation.Dev.EveningApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            ODataModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<Movie>("Movies");
            config.MapODataServiceRoute(
                routeName: "Movies",
                routePrefix: null,
                model: builder.GetEdmModel()
                );
        }
    }
}
