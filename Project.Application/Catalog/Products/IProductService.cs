using Project.ViewModel.Catalog.Products;
using Project.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Catalog.Products
{
    public interface IProductService
    {
        Task<List<ProductVm>> GetAll();

        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProductUpdateRequest request);

        Task<int> Delete(int productId);

        Task<ProductVm> GetById(int productId, string languageId);

        Task<PagedResult<ProductVm>> GetAllPaging(GetManageProductPagingRequest request);
    }
}