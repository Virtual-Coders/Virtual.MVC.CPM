
using MediatR;
using Virtual.MVC.CPM.Models;


namespace Virtual.MVC.CPM.Domains.Queries;

public class GetAllCategoryQuery : IRequest<IEnumerable<CategoryModel>>
{
    public GetAllCategoryQuery()
    {
    }
}
