using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using BlogManagement.Application.Contract.Article;
using BlogManagement.Application.Contract.ArticleCategory;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace ServiceHost.Areas.Administration.Pages.Blog.Articles
{
    //[Authorize(Roles = "1, 3")]
    public class IndexModel : PageModel
    {
        public ArticleSearchModel SearchModel;
        public List<ArticleViewModel> Articles;
        public SelectList ArticleCategories;

        private readonly IArticleApplication _articleApplication;
        private readonly IArticleCategoryApplication _articleCategoryApplication;

        public IndexModel(IArticleApplication articleApplication, IArticleCategoryApplication articleCategoryApplication)
        {
            _articleApplication = articleApplication;
            _articleCategoryApplication = articleCategoryApplication;
        }

        public void OnGet(ArticleSearchModel searchModel)
        {
            ArticleCategories = new SelectList(_articleCategoryApplication.GetArticleCategories(), "Id", "Name");
            Articles = _articleApplication.Search(searchModel);
        }
    }
}