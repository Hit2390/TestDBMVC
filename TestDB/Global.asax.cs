using FinanceReport.Models.POCO;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TestDB.Models.Binder;

namespace TestDB
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ModelBinders.Binders.Add(typeof(ExpenseCategory), new ExpenseCategoryModelBinder());
        }
    }
}
