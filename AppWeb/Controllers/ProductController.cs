using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models;
using Repository.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace AppWeb.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _productRepository;
        private ICategoryRepository _categoryRepository;
        private IBrandRepository _brandRepository;
        private ISupplierRepository _supplierRepository;

        public ProductController(IProductRepository productRepository,
                                 ICategoryRepository categoryRepository,
                                 IBrandRepository brandRepository,
                                 ISupplierRepository supplierRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _brandRepository = brandRepository;
            _supplierRepository = supplierRepository;
        }
        public IActionResult Index()
        {
            var products = _productRepository.GetProducts();
            return View(products);
        }

        public IActionResult CreateProduct()
        {
            var codeBrand = _brandRepository.GetBrands();
            var codeCategory = _categoryRepository.GetCategories();
            var codeSupplier = _supplierRepository.GetSuppliers();

            ViewBag.IdBrand = codeBrand;
            ViewBag.IdCategory= codeCategory;
            ViewBag.IdSupplier = codeSupplier;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                _productRepository.Create(product);
                return RedirectToAction("Index");
            }

            return View(product);
        }

        public IActionResult updateProduct(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }
            var productToEdit = _productRepository.GetProductById(id);
            var codeBrand = _brandRepository.GetBrands();
            var codeCategory = _categoryRepository.GetCategories();
            var codeSupplier = _supplierRepository.GetSuppliers();

            ViewBag.IdBrand = codeBrand;
            ViewBag.IdCategory = codeCategory;
            ViewBag.IdSupplier = codeSupplier;

            return View(productToEdit);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                _productRepository.Update(product);
                return RedirectToAction("Index");
            }

            return View(product);
        }

        public IActionResult DeleteProduct(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }

            var productToDelete = _productRepository.GetProductById(id);

            _productRepository.Delete(productToDelete);

            return RedirectToAction("Index");
        }
    }
}
