using System.ComponentModel.DataAnnotations;

namespace DefaultNamespace;

public class CustomerSuccess
{
    [Key]
    public Guid CustomerSuccessId { get; set; }
    
    [Display(Name ="نام مدیرعامل")]
    [Required(ErrorMessage ="لطفا {0} را وارد کنید.")]
    [MinLength(10 , ErrorMessage ="تعداد {0} نباید کمتر از {1} باشد.")]
    [MaxLength(80 , ErrorMessage = "تعداد {0} نباید بیشتر از {1} باشد.")]
    public string Title { get; set; }
    
    [Display(Name ="سمت مدیرعامل")]
    [Required(ErrorMessage ="لطفا {0} را وارد کنید .")]
    [MinLength(20 , ErrorMessage ="تعداد {0} نباید کمتر از {1} باشد.")]
    [MaxLength(250 , ErrorMessage = "تعداد {0} نباید بیشتر از {1} باشد.")]
    public string Side { get; set; }
    
    [Display(Name ="متن خلاصه")]
    [Required(ErrorMessage ="لطفا {0} را وارد کنید .")]
    [MinLength(15 , ErrorMessage ="تعداد {0} نباید کمتر از {1} باشد.")]
    [MaxLength(250 , ErrorMessage = "تعداد {0} نباید بیشتر از {1} باشد.")]
    public string SummaryDescription { get; set; }

    [Display(Name ="نام شرکت")]
    [Required(ErrorMessage ="لطفا {0} را وارد کنید .")]
    [MinLength(5 , ErrorMessage ="تعداد {0} نباید کمتر از {1} باشد.")]
    [MaxLength(100 , ErrorMessage = "تعداد {0} نباید بیشتر از {1} باشد.")]
    public string CompanyName { get; set; }
    
    [Display(Name ="نام استارتاپ")]
    [Required(ErrorMessage ="لطفا {0} را وارد کنید .")]
    [MinLength(5 , ErrorMessage ="تعداد {0} نباید کمتر از {1} باشد.")]
    [MaxLength(100 , ErrorMessage = "تعداد {0} نباید بیشتر از {1} باشد.")]
    public string StartupName { get; set; }
    
    [Display(Name ="حوزه فعالیت")]
    [Required(ErrorMessage ="لطفا {0} را وارد کنید .")]
    [MinLength(5 , ErrorMessage ="تعداد {0} نباید کمتر از {1} باشد.")]
    [MaxLength(400 , ErrorMessage = "تعداد {0} نباید بیشتر از {1} باشد.")]
    public string ActivityName { get; set; }

    [Display(Name = "لوگو شرکت")]
    public string? CompanyLogo { get; set; }
    
    [Display(Name = "سخن مدیر")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
    public string ManagerSpeech { get; set; }
    
    [Display(Name = "توضیحات")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
    public string Description { get; set; }
    
    [Display(Name = "فایل ویدئو")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
    public string VideoFile { get; set; }
    
    [Display(Name ="عنوان ویدئو")]
    [Required(ErrorMessage ="لطفا {0} را وارد کنید .")]
    [MinLength(5 , ErrorMessage ="تعداد {0} نباید کمتر از {1} باشد.")]
    [MaxLength(100 , ErrorMessage = "تعداد {0} نباید بیشتر از {1} باشد.")]
    public string VideoTitle { get; set; }
    
    [Display(Name ="زیرعنوان ویدئو")]
    [Required(ErrorMessage ="لطفا {0} را وارد کنید .")]
    [MinLength(15 , ErrorMessage ="تعداد {0} نباید کمتر از {1} باشد.")]
    [MaxLength(350 , ErrorMessage = "تعداد {0} نباید بیشتر از {1} باشد.")]
    public string VideoSubTitle { get; set; }
    
    [Display(Name ="آدرس سایت")]
    [Url(ErrorMessage = "لطفا {0} معتبر وارد کنید.")]
    public string? SiteAddress { get; set; }
    
    [Display(Name ="لینک گوگل پلی")]
    [Url(ErrorMessage = "لطفا {0} معتبر وارد کنید.")]
    public string? GooglePlayDownloadLink { get; set; }
    
    [Display(Name ="لینک اپ استور")]
    [Url(ErrorMessage = "لطفا {0} معتبر وارد کنید.")]
    public string? AppStoreDownloadLink { get; set; }
    
    [Display(Name = "عکس کاور ویدئو")]
    public string? CoverVideoImage { get; set; }
    
    [Display(Name = "گالری تصاویر")]
    public string Media { get; set; }
    
    [Display(Name = "عکس مدیرعامل")]
    public string? ManagerImage { get; set; }
}