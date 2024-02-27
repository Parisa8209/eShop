﻿
using AutoMapper;
using eShop.Data.Contexts;

namespace eShop.Data.Services;

public class CategoryDbService(eShopContext db, IMapper mapper) : DbService(db, mapper)
{
    public override async Task<List<TDto>> GetAsync<TEntity, TDto>()
    {
        //IncludeNavigationsFor<Filter>();
        //IncludeNavigationsFor<Product>();
        return await base.GetAsync<TEntity, TDto>();
       
    }
}
