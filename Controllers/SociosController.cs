
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Club2.Controllers
{
    public class SociosController : Controller
    {
        // GET: Socios
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AltaSocio() {
            
            List<TipoDniViewModel> listaDni = AD_TipoDni.ObtenerListaTipoDni();

            List<SelectListItem> Tipos = listaDni.ConvertAll(d =>{
                
                return new SelectListItem(){
                
                    Text= d.TipoDocumento,
                    Value= d.idTipoDocumento.ToString(),
                    Selected= false
                };

                });
            
            
            return View();
        }
    }
}