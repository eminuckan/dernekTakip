using Dernek.Application.Abstractions;

namespace Dernek.BLL.Services
{
    public class MessageService : IMessageService
    {
        public string GetSuccessMessage()
        {
            return "Successfull message"; 
        }
    }
}
