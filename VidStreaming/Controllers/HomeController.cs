using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.SqlServer;
using VidStreaming.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace VidStreaming.Controllers
{
    public class HomeController : Controller
    {
        private readonly VidStreamingContext context;
        public HomeController(VidStreamingContext context)
        {
            this.context = context;
        }
        public async Task<IActionResult> Index()
        {
            ViewModel model = new ViewModel();
            model.Users = await context.User.ToListAsync();
            model.Videos = await context.Video.ToListAsync();
            model.Comments = await context.Comment.ToListAsync();
            return View(model);
        }
    }
}
