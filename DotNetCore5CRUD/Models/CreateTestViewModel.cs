using System.ComponentModel.DataAnnotations;

namespace DotNetCore5CRUD.Models
{
    public class CreateTestViewModel
    {
        [Display(Name= "Name"),Required(ErrorMessage = "Required")]
        public string Name { get; set; }
    }
}
