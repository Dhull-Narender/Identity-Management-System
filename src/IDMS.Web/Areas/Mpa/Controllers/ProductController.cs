using System.Threading.Tasks;
using System.Web.Mvc;
using IDMS.ProductApp;
using IDMS.Web.Controllers;

namespace IDMS.Web.Areas.Mpa.Controllers
{
    public class ProductController : IDMSControllerBase
    {
        private readonly IProductAppService _productAppService;

        public ProductController(
           IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }
        public async Task<ActionResult> IndexAsync()
        {
            var output = await _productAppService.GetProductListAsync();
            //var model = new ProductApp
            //{
            //    LoginAttempts = output.Items.ToList()
            //};
           // return PartialView("_LoginAttemptsModal", model);
            return View();
        }
       
    }
}