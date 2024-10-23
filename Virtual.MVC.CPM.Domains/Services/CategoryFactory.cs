using Virtual.MVC.CPM.Data;
using Virtual.MVC.CPM.Models;

namespace Virtual.MVC.CPM.Domains.Services;

public static class CategoryFactory
{
    public static CategoryModel ConvertToCategoryModel(Category category)
    {
        var categoryModel = new CategoryModel();
        categoryModel.Name = category.Name;
        categoryModel.Id = category.Id;
        categoryModel.Code = category.Code;
        categoryModel.IsActive = category.IsActive;
        categoryModel.IsDelete = category.IsDelete;
        return categoryModel;
    }

    public static List<CategoryModel> ConvertToCategoryListModel(List<Category> categories)
    {

        List<CategoryModel> list = new List<CategoryModel>();
        foreach (var category in categories)
        {
            var item = ConvertToCategoryModel(category);
            list.Add(item);
        }
        return list;
    }

}
