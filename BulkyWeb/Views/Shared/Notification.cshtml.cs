using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace BulkyWeb.Views.Shared
{
    public class Notification : PageModel
    {
        private readonly ILogger<Notification> _logger;

        public Notification(ILogger<Notification> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}