using MediatR;
using Virtual.MVC.CPM.Models;

namespace Virtual.MVC.CPM.Domains.Commands
{
    public class DeleteCategoryCommand : IRequest<CategoryModel>
    {
        public int Id { get; set; }
    }
}
