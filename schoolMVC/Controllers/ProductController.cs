//using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization;
using schoolMVC.Data;
using schoolMVC.Models;
using Xamarin.Essentials;
namespace MVCBasics.Controllers
{

    public class ProductController : BaseController<ProductModel>
    {

        public ProductController(IBaseRepositry<ProductModel> repo) : base(repo)
        {
        }

    }
}
