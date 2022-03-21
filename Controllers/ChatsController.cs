using System.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using chatAPI.Hubs;
using chatAPI.ReqDto;
using Microsoft.AspNetCore.SignalR;

namespace chatAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/chat")]
    [ApiController]
    public class ChatsController : ControllerBase
    {
        
        private readonly ChatHub _iChatRep;

        public ChatsController(ChatHub iChatRep)
        {
            this._iChatRep = iChatRep;
        }

       
      
        
        [Route("send")]  
        [HttpPost]
        public IActionResult SendRequest([FromBody]  MessageDto msg)
        {
           _iChatRep.Clients.All.SendAsync("ReceiveOne",msg.user ,msg.msgText);
           return Ok();
   }
 
        

        
    }
}