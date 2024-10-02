using Microsoft.AspNetCore.Mvc;

namespace ControllersUnitTesting
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController:ControllerBase
    {
        private readonly IClientService _clientService;
            
        public ClientController (IClientService clientService)
        {
            clientService=_clientService;
        }

        [HttpGet]
        

    }
}
