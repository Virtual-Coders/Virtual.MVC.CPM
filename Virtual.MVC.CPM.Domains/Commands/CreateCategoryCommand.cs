using MediatR;
using Virtual.MVC.CPM.Models;

namespace Virtual.MVC.CPM.Domains.Commands;


public class CreateCategoryCommand : IRequest<CategoryModel> 
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Code { get; set; }
    public bool IsActive { get; set; }
    public bool IsDelete { get; set; }
}
