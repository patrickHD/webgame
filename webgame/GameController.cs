using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace webgame
{
    [Route("api/[controller]")]
    public class GameController : Controller
    {
        List<ConnectedUser> connectedUsers = new List<ConnectedUser>();
        List<GameRoom> gameRooms = new List<GameRoom>();

        public IActionResult Index()
        {
            return new JsonResult("game");
        } 
        /*
         * Login ->
         * Game:
         *  Rooms:
         *      now connected
         */

        [Route("[action]")]
        public IActionResult Two()
        {
            return new JsonResult("2");
        }

        [Route("[action]")]
        public IActionResult One()
        {
            return new JsonResult("12");
        }
    }

    class ConnectedUser
    {
        string username;
        DateTime added;
    }

    class GameRoom 
    {
        
    }
}
