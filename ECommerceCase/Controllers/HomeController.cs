using ECommerce.Application.Services;
using ECommerce.Entity.DTOS;
using ECommerce.Entity.Entities;
using ECommerceCase.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ECommerceCase.Controllers
{
    public class HomeController : Controller
    {
        #region kullanıcıoluşturmaiçinkullandım
        //private readonly IUserService _userService;

        //public HomeController(IUserService userService)
        //{
        //    this._userService = userService;
        //} 
        #endregion
        #region producteklemekiçinkullandım
        private readonly IProductService _productService;

        public HomeController(IProductService productService)
        {
            _productService = productService;
        }
        #endregion

        public async Task<IActionResult> Index()
        {
            #region KullanıcıOluşturma
            //RegisterDTO registerDTO = new()
            //{
            //    Email = "bestesyildirim@gmail.com",
            //    UserName = "sezen",
            //    Password="123Sezen."
            //};

            //await _userService.CreateUser(registerDTO);

            //registerDTO = new()
            //{
            //    Email = "bestesyildirim@gmail.com",
            //    UserName = "test",
            //    Password = "456Sezen."
            //};
            //await _userService.CreateUser(registerDTO);
            #endregion

            #region ÜrünEkleme
            //for (int i = 0; i < 20; i++)
            //{
            //    Product product = new()
            //    {
            //        ID = Guid.NewGuid(),
            //        Name = $"Product {i}",
            //        Price = i * 100,
            //        Stock = i

            //    };
            //    await _productService.AddAsync(product);

            //}
            #endregion
            var result =  _productService.GetProducts();

            return View(result);
        }

    }
}