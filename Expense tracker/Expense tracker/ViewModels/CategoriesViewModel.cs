using System.Collections.ObjectModel;
using ExpenseTracker.Models;

namespace ExpenseTracker.ViewModels;

public class CategoryViewModel
{
    public ObservableCollection<Category> Categories { get; set; }

    public CategoryViewModel()
    {
        Categories = new ObservableCollection<Category>
        {
            new Category { Name = "Food" },
            new Category { Name = "Travel" },
            new Category { Name = "Shopping" }
        };
    }
}