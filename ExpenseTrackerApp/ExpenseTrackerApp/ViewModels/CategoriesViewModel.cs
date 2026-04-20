using System.Collections.ObjectModel;
using ExpenseTrackerApp.Models;

namespace ExpenseTrackerApp.ViewModels;

public class CategoriesViewModel
{
    public ObservableCollection<Category> Categories { get; set; }

    public CategoriesViewModel()
    {
        Categories = new ObservableCollection<Category>();
    }

    public void AddDefaultCategories()
    {
        Categories.Clear();

        Categories.Add(new Category { Name = "Food" });
        Categories.Add(new Category { Name = "Transport" });
        Categories.Add(new Category { Name = "Shopping" });
        Categories.Add(new Category { Name = "Bills" });
        Categories.Add(new Category { Name = "Entertainment" });
    }
    public void AddCategory(string name)
    {
        Categories.Add(new Category { Name = name });
    }

    public void DeleteCategory(Category category)
    {
        Categories.Remove(category);
    }
}
