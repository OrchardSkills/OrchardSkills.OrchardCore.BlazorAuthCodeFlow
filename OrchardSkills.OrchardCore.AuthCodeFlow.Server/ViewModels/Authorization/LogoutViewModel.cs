using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace OrchardSkills.OrchardCore.AuthCodeFlow.Server.ViewModels.Authorization
{
    public class LogoutViewModel
    {
        [BindNever]
        public string RequestId { get; set; }
    }
}