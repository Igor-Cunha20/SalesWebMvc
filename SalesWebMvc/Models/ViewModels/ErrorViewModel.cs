using System;

namespace SalesWebMvc.Models.ViewModels
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        //Campo novo - mensagem para o usu�rio
        public string Message { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}