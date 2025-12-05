using MediatR;
using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Entities;
using OnionVb02.Domain.Enums;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Modify.CategoryCommandHandlers
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand>
    {
        private readonly ICategoryRepository _repository;

        public CreateCategoryCommandHandler(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Category
            {
                CreatedDate = DateTime.Now,
                Status = DataStatus.Inserted,
                CategoryName = request.CategoryName,
                Description = request.Description
            });
        }
    }

    
}
