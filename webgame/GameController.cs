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
        static List<ConnectedUser> connectedUsers = new List<ConnectedUser>();
        //List<GameRoom> gameRooms = new List<GameRoom>();

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
            connectedUsers.Add(new ConnectedUser { username = "User" + DateTime.Now.Ticks, added = DateTime.Now });
            return new JsonResult(connectedUsers.Last());
        }

        [Route("[action]")]
        public IActionResult One()
        {
            return new JsonResult(string.Join(",", connectedUsers.Select(s => s.username + " - " + s.added)));
        }
    }

    class ConnectedUser
    {
        public string username;
        public DateTime added;
    }

    class GameRoom 
    {
        
    }
}
