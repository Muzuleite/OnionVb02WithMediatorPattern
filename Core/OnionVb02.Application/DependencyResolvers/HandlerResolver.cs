using Microsoft.Extensions.DependencyInjection;
using OnionVb02.Application.CqrsAndMediatr.CQRS.Handlers.Modify.CategoryHandlers;
using OnionVb02.Application.CqrsAndMediatr.CQRS.Handlers.Read.CategoryQueryHandlers;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Modify.AppUserCommandHandlers;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Modify.AppUserProfileCommandHandlers;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Modify.OrderCommandHandlers;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Modify.OrderDetailCommandHandlers;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Modify.ProductAttributeCommandHandlers;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Modify.ProductAttributeValueCommandHandlers;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Modify.ProductCommandHandlers;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Read.AppUserProfileQueryHandlers;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Read.AppUserQueryHandlers;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Read.OrderDetailQueryHandlers;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Read.OrderQueryHandlers;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Read.ProductAttributeQueryHandlers;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Read.ProductAttributeValueQueryHandlers;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Read.ProductQueryHandlers;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Queries.ProductAttributeQueries;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Queries.ProductAttributeValueQueries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionVb02.Application.DependencyResolvers
{
    
    public static class HandlerResolver
    {
        public static void AddHandlerService(this IServiceCollection services)
        {
            services.AddScoped<GetCategoryQueryHandler>();
            services.AddScoped<GetCategoryByIdQueryHandler>();
            services.AddScoped<CreateCategoryCommandHandler>();
            services.AddScoped<UpdateCategoryCommandHandler>();
            services.AddScoped<RemoveCategoryCommandHandler>();

            services.AddScoped<GetAppUserQueryHandler>();
            services.AddScoped<GetAppUserByIdQueryHandler>();
            services.AddScoped<CreateAppUserCommandHandler>();
            services.AddScoped<UpdateAppUserCommandHandler>();
            services.AddScoped<RemoveAppUserCommandHandler>();


            services.AddScoped<GetAppUserProfileQueryHandler>();
            services.AddScoped<GetAppUserProfileByIdQueryHandler>();
            services.AddScoped<CreateAppUserProfileCommandHandler>();
            services.AddScoped<UpdateAppUserProfileCommandHandler>();
            services.AddScoped<RemoveAppUserProfileCommandHandler>();



            services.AddScoped<GetProductQueryHandler>();
            services.AddScoped<GetProductByIdQueryHandler>();
            services.AddScoped<CreateProductCommandHandler>();
            services.AddScoped<UpdateProductCommandHandler>();
            services.AddScoped<RemoveProductCommandHandler>();



            services.AddScoped<GetOrderQueryHandler>();
            services.AddScoped<GetOrderByIdQueryHandler>();
            services.AddScoped<CreateOrderCommandHandler>();
            services.AddScoped<UpdateOrderCommandHandler>();
            services.AddScoped<RemoveOrderCommandHandler>();

            services.AddScoped<GetOrderDetailQueryHandler>();
            services.AddScoped<GetOrderDetailByIdQueryHandler>();
            services.AddScoped<CreateOrderDetailCommandHandler>();
            services.AddScoped<UpdateOrderDetailCommandHandler>();
            services.AddScoped<RemoveOrderDetailCommandHandler>();


            services.AddScoped<GetProductAttributeByIdQueryHandler>();
            services.AddScoped<GetProductAttributeQueryHandler>();
            services.AddScoped<CreateProductAttributeCommandHandler>();
            services.AddScoped<RemoveProductAttributeCommandHandler>();
            services.AddScoped<UpdateProductAttributeCommandHandler>();

            services.AddScoped<GetProductAttributeValueByIdQueryHandler>();
            services.AddScoped<GetProductAttributeValueQueryHandler>();
            services.AddScoped<CreateProductAttributeValueCommandHandler>();
            services.AddScoped<RemoveProductAttributeValueCommandHandler>();
            services.AddScoped<UpdateProductAttributeValueCommandHandler>();


            services.AddMediatR(x => x.RegisterServicesFromAssembly(typeof(GetCategoryByIdQueryHandler).Assembly));
        }
    }
}
