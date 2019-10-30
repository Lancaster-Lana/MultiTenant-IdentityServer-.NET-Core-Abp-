using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using IS.Core;

namespace IS.Web.Views
{
    public abstract class ISRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected ISRazorPage()
        {
            LocalizationSourceName = ISConsts.LocalizationSourceName;
        }
    }
}
