using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProjectGame.Models;
using PLAYER;

namespace ProjectGame.Controllers;

public class PlayerController : Controller
{
    private readonly ILogger<PlayerController> _logger;

    public PlayerController(ILogger<PlayerController> logger)
    {
        _logger = logger;
    }

    public IActionResult Player_Profiles(){
        Player p1 = new Player();
        Player p2 = new Player();
        Player p3 = new Player();

        // Player1 Profile
        p1.pID = 50123;
        p1.pName = "Killer_Sam";
        p1.pImage = "/images/Player1.jfif";
        p1.plevel = 56;

        // Player2 Profile
         p2.pID= 50343;
         p2.pName = "Dark_Devil";
         p2.pImage  = "/images/Player2.jfif";
         p2.plevel = 43;

        // Player3 Profile
         p3.pID = 50902;
         p3.pName = "Ghost_Rider";
         p3.pImage = "/images/Player3.jfif";
         p3.plevel = 12;

        Player [] p_arr = new Player[3];
        p_arr[0] = p1;
        p_arr[1] = p2;
        p_arr[2] = p3;

        ViewData["Players"] = p_arr;
        return View();
    }
}
