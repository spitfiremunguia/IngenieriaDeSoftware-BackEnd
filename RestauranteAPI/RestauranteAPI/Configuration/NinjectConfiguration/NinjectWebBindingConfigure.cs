﻿using System;
using AutoMapper;
using Ninject;
using RestauranteAPI.Models.Mapping;
using RestauranteAPI.Repositories;
using RestauranteAPI.Repositories.Injections;
using RestauranteAPI.Services;
using RestauranteAPI.Services.Injections;

namespace RestauranteAPI.Configuration.NinjectConfiguration
{
    public static class NinjectWebBindingConfigure
    {
        
        public static void BindClasses(StandardKernel kernel, Func<Ninject.Activation.IContext, object> requestScope) 
        {
            //Mapping configuration

            kernel.Bind<IMapper>().ToMethod(x =>
                new MapperConfiguration(mc => { mc.AddProfile(new MappingProfile()); }).CreateMapper());
            //services
            kernel.Bind<IUserService>().To<UserService>().InScope(requestScope);
            kernel.Bind<IProductService>().To<ProductService>().InScope(requestScope);
            kernel.Bind<IOrderService>().To<OrderService>().InScope(requestScope);
            //repositories
            kernel.Bind<ITestRepository>().To<TestRepository>().InScope(requestScope);
            kernel.Bind<IUserRepository>().To<UserRepository>().InScope(requestScope);
            kernel.Bind<IProductRepository>().To<ProductRepository>().InScope(requestScope);
            kernel.Bind<IOrderRepository>().To<OrderRepository>().InScope(requestScope);
        }
    }
}
