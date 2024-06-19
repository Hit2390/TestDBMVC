/*
 * Register the custom model binder in the Application_Start method gloabl.aspx
 * Use the custom model binder in your controller actions
 */
using FinanceReport.Models.POCO;
using System.Web.Mvc;

namespace TestDB.Models.Binder
{
    public class ExpenseCategoryModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var request = controllerContext.HttpContext.Request;

            var categoryIdValue = request.Form.Get("inputId");
            var categoryNameValue = request.Form.Get("inputText");

            int.TryParse(categoryIdValue, out var categoryId);

            return new ExpenseCategory
            {
                ExpenseCategoryId = categoryId,
                ExpenseCategoryName = categoryNameValue
            };
        }
    }
}