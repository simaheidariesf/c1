using System.ComponentModel.DataAnnotations;

namespace C1System.DataLayar.Entities.Base;

public class SeoEntity
{
    [Key]
    public int SeoId { get; set; }
    
    [Display(Name ="متاتگ Title")]
    [Required(ErrorMessage ="لطفا {0} را وارد کنید.")]
    [MinLength(10 , ErrorMessage ="تعداد {0} نباید کمتر از {1} باشد.")]
    [MaxLength(200 , ErrorMessage = "تعداد {0} نباید بیشتر از {1} باشد.")]
    public string TitleMetaTag { get; set; }
    
    [Display(Name ="متاتگ Description")]
    [Required(ErrorMessage ="لطفا {0} را وارد کنید.")]
    [MinLength(10 , ErrorMessage ="تعداد {0} نباید کمتر از {1} باشد.")]
    [MaxLength(500 , ErrorMessage = "تعداد {0} نباید بیشتر از {1} باشد.")]
    public string DescriptionMetaTag { get; set; }
    
    [Display(Name ="متاتگ keyword")]
    [Required(ErrorMessage ="لطفا {0} را وارد کنید.")]
    [MinLength(10 , ErrorMessage ="تعداد {0} نباید کمتر از {1} باشد.")]
    [MaxLength(1000 , ErrorMessage = "تعداد {0} نباید بیشتر از {1} باشد.")]
    public string KeywordMetaTag { get; set; }
}