using DataAnnotationsExtensions.ClientValidation;
using SampleWebsite.Mvc4;

[assembly: WebActivator.PreApplicationStartMethod(typeof(RegisterClientValidationExtensions), "Start")]
 
namespace SampleWebsite.Mvc4 {
    public static class RegisterClientValidationExtensions {
        public static void Start() {
            DataAnnotationsModelValidatorProviderExtensions.RegisterValidationExtensions();            
        }
    }
}