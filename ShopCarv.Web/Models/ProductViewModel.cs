namespace ShopCarv.Web.Models
{
    using ShopCarv.Dato.ModelsDB.Entities;
    using System.ComponentModel.DataAnnotations;
    using Microsoft.AspNetCore.Http;
    public class ProducViewModel : Product
    {
        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }

    }
}
