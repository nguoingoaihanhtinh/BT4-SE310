using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebQuanLySanPham.Models;

namespace WebQuanLySanPham.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            ProductDataContext context = new ProductDataContext("Server=KHOAPC;Database=Product;User Id=sa;Password=1235;");
            List<Product> dsProduct = context.Products.ToList(); // Ensure this returns a valid list

            // Check if dsCatalog is null
            if (dsProduct == null)
            {
                // Log the error or handle it accordingly
                return View("Error"); // Redirect to an error view if necessary
            }
            return View(dsProduct);
        }
    }
}