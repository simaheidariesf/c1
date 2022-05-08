using System.ComponentModel.DataAnnotations;

namespace C1System.DataLayar.Entities.Base;

public class Banner
{
    [Key]
    public int BannerId { get; set; }
    
    [Display(Name ="عنوان")]
    [Required(ErrorMessage ="لطفا {0} را وارد کنید.")]
    [MinLength(10 , ErrorMessage ="تعداد {0} نباید کمتر از {1} باشد.")]
    [MaxLength(250 , ErrorMessage = "تعداد {0} نباید بیشتر از {1} باشد.")]
    public string Title { get; set; }
    
    [Display(Name ="توضیحات")]
    [Required(ErrorMessage ="لطفا {0} را وارد کنید.")]
    [MinLength(25 , ErrorMessage ="تعداد {0} نباید کمتر از {1} باشد.")]
    [MaxLength(1000 , ErrorMessage = "تعداد {0} نباید بیشتر از {1} باشد.")]
    public string Description { get; set; }
    
    [Display(Name ="تصویر بنر")]
    [Required(ErrorMessage ="لطفا {0} را وارد کنید .")]
    public string Image { get; set; }
    
    //todo blog
    //todo podcast
    //todo careeropportunities
    //todo customersuccess
}