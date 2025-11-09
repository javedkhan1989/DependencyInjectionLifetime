using DependencyInjectionLifetime.Models;
using DependencyInjectionLifetime.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DependencyInjectionLifetime.Controllers
{
    public class HomeController : Controller
    {
        private readonly TransientMessageService _transient1;
        private readonly TransientMessageService _transient2;
        private readonly ScopedMessageService _scoped1;
        private readonly ScopedMessageService _scoped2;
        private readonly SingletonMessageService _singleton1;
        private readonly SingletonMessageService _singleton2;

        public HomeController(
            TransientMessageService transient1,
            TransientMessageService transient2,
            ScopedMessageService scoped1,
            ScopedMessageService scoped2,
            SingletonMessageService singleton1,
            SingletonMessageService singleton2)
        {
            _transient1 = transient1;
            _transient2 = transient2;
            _scoped1 = scoped1;
            _scoped2 = scoped2;
            _singleton1 = singleton1;
            _singleton2 = singleton2;
        }

        public IActionResult Index()
        {
            var messages = new[]
            {
            _transient1.GetMessage(),
            _transient2.GetMessage(),
            _scoped1.GetMessage(),
            _scoped2.GetMessage(),
            _singleton1.GetMessage(),
            _singleton2.GetMessage()
        };

            return Content(string.Join("\n", messages));
        }
    }
}
