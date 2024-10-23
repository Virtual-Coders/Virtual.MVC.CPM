
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Virtual.MVC.CPM.Domains.Commands;
using Virtual.MVC.CPM.Domains.Queries;
using Virtual.MVC.CPM.Models;

namespace Virtual.MVC.CPM.MVC.Controllers;

public class CategoryController : Controller
{
    private readonly IMediator mediator;

    public CategoryController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    // GET: Category
    public ActionResult Index()
    {
        var query = new GetAllCategoryQuery();
        var response =  mediator.Send(query);
      
        return View(response.Result);
    }

    // GET: Category/Details/5
    public ActionResult Details(int Id)
    {
        var query = new GetCategoryByIdQuery(Id);
        var response =  mediator.Send(query);
        return View(response.Result);
    }

    // GET: Category/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: Category/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(CategoryModel data)
    {
        try
        {
            var CreateCategoryCommand = new CreateCategoryCommand() { 
                Id = data.Id,
                Name= data.Name,
                Code=data.Code,
                IsActive=data.IsActive,
                IsDelete =data.IsDelete,
            };
            var response =  mediator.Send(CreateCategoryCommand);
            return RedirectToAction(nameof(Index));

        }
        catch
        {
            return View();
        }
       
    }

    //GET: Category/Edit/5
    public ActionResult Edit(int id)
    {
        var query = new GetCategoryByIdQuery(id);
        var response = mediator.Send(query);
        return View(response.Result);
    }

    // POST: Category/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(int id, CategoryModel data)
    {
        try
        {
            var EditCategoryCommand = new EditCategoryCommand()
            {
                Id = data.Id,
                Name = data.Name,
                Code = data.Code,
                IsActive = data.IsActive,
                IsDelete = data.IsDelete,
            };
            var response = mediator.Send(EditCategoryCommand);
            return RedirectToAction(nameof(Index));
           
        }
        catch
        {
            return View();
        }
    }

    // GET: Category/Delete/5
    public ActionResult Delete(int id)
    {

        var query = new GetCategoryByIdQuery(id);
        var response = mediator.Send(query);
      
        return View(response.Result);
    }

    // POST: Category/Delete/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int id, CategoryModel data)
    {
        try
        {
            var DeleteCategoryCommand = new DeleteCategoryCommand()
            {
                Id = data.Id,
            };
            var response = mediator.Send(DeleteCategoryCommand);
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }
}
