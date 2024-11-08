using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models{
    public class UserInfo{

        
        public int Id{get;set;}

         [Required(ErrorMessage = "Ad alanı boş bırakılamaz")]
        public string? Name{get;set;}

         [Required(ErrorMessage ="Telefon alanı boş bırakılamaz")]
        public string? Phone{get;set;}   
        
         [Required(ErrorMessage ="Email alanı boş bırakılamaz")]
         [EmailAddress(ErrorMessage ="Geçerli bir email adresi giriniz")]
        public string? Email{get;set;} 
        
         [Required(ErrorMessage ="Katılım Bilgisi boş bırakılamaz")]
        public bool? WillAttend{get;set;}   
    }

}