using Aspnet_Core_Identity.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Aspnet_Core_Identity.Pages
{
    public class RegisterModel : PageModel
    {
        public Register RegisterzModel { get; set; }
        public void OnGet()
        {
        }
    }
}
