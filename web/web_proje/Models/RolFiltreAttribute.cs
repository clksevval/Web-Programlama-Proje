using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace web_proje.Models
{
    public class RolFiltreAttribute : ActionFilterAttribute
    {
        private readonly int _requiredRoleId;

        // Bu filtreye hangi RolId'ye sahip kullanıcıların erişebileceğini belirlemek için
        // bir parametre alıyoruz.
        public RolFiltreAttribute(int requiredRoleId)
        {
            _requiredRoleId = requiredRoleId;
        }


        // Bu metod, action metodu çalışmadan önce çağrılır.
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            // Kullanıcı rolünü session'dan alıyoruz.
            var rolId = context.HttpContext.Session.GetInt32("RolId");


            // Eğer rolId bulunmazsa veya eşleşme olmazsa, kullanıcıyı login sayfasına yönlendiriyoruz.
            if (rolId == null || rolId != _requiredRoleId)
            {
                // Yetkisiz erişim
                context.Result = new RedirectToActionResult("LoginSayfa", "Login", null);
            }

            base.OnActionExecuting(context);
        }
    }

}
