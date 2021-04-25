//using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization;
using schoolMVC.Data;
using schoolMVC.Models;
using Xamarin.Essentials;
namespace MVCBasics.Controllers
{
   // [Authorize]
    public class OrderController : BaseController<OrderModel>
    {

        public OrderController(IBaseRepositry<OrderModel> repo) : base(repo)
        {
        }

    }
}
