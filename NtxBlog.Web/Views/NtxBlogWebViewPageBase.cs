using Abp.Web.Mvc.Views;

namespace NtxBlog.Web.Views
{
    public abstract class NtxBlogWebViewPageBase : NtxBlogWebViewPageBase<dynamic>
    {

    }

    public abstract class NtxBlogWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected NtxBlogWebViewPageBase()
        {
            LocalizationSourceName = NtxBlogConsts.LocalizationSourceName;
        }
    }
}