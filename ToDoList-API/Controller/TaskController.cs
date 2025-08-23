using Microsoft.AspNetCore.Mvc;

namespace ToDoList_API.Controller;

public class TaskController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}