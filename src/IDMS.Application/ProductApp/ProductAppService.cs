using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Linq.Extensions;
using AutoMapper;
using IDMS.IRepositories;
using IDMS.ProductApp.Dto;

namespace IDMS.ProductApp
{
    public class ProductAppService : IDMSAppServiceBase, IProductAppService
    {
        private readonly IProductRepository _productRepository;
        public ProductAppService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<PagedResultDto<ProductOutput>> GetProductListAsync(GetProductsInput input)
        {
            try
            {
                var query = _productRepository.GetAll()
                .WhereIf(!string.IsNullOrWhiteSpace(input.Name), p => p.Name.Contains(input.Name));

                var items = Mapper.Map<List<ProductOutput>>(query);
                var count = await query.CountAsync();
                return new PagedResultDto<ProductOutput>(count, items.ToList());






            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Task<PagedResultDto<ProductOutput>> GetProductListAsync()
        {
            throw new NotImplementedException();
        }

        //public  Task<PagedResultDto<ProductOutput>> GetProducts()
        //{
        //    //throw new NotImplementedException();
        //    //创建映射
        //    //Mapper.CreateMap<Product, ProductOutput>();
        //    var result = _productRepository.GetAllList();
        //    int totalCount = result.Count;
        //    //return new PagedResultDto<ProductOutput>(
        //    //    totalCount,
        //    //    Mapper.Map<List<ProductOutput>>(result)
        //    //    );


        //    //return new PagedResultDto<ProductOutput>(
        //    //    totalCount,
        //    //      Mapper.Map<List<ProductOutput>>(result)
        //    //    );


        //}
        //public Task<PagedResultDto<ProductOutput>> GetProducts()
        //{

        //}
    }
}
