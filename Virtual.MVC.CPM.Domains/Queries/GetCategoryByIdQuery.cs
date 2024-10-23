
using MediatR;
using Virtual.MVC.CPM.Models;

namespace Virtual.MVC.CPM.Domains.Queries;

public class GetCategoryByIdQuery : IRequest<CategoryModel>
{

    public GetCategoryByIdQuery(int Id)
    {
        this.Id = Id;
            
    }
    public int Id { get; set; }
}
