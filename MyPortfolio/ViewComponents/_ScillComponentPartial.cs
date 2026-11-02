using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _ScillComponentPartial:ViewComponent
    {
        private readonly MyPortfolioContext portfolioContext;

        public _ScillComponentPartial(MyPortfolioContext context)
        {
            portfolioContext = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Scills.ToList();
            return View(values);
        }
    }
}
