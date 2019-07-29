using Sales.Common.Models;
using System.Web;

namespace Sales.Backend.Models
{
    public class ProductView : Product
    {
        public HttpPostedFileBase ImageFile { get; set; }
    }
}