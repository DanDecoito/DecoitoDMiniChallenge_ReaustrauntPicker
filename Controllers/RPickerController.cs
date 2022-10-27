// Daniel Decoito
// 10-26-22
// Mini Challenge: Restaurant Picker
// Redo the restaurant picker with webapi
// Reviewed by: Kenneth Fujimura -- Works exquisitely. I liked the output text formatting. The RNG works as intended and is formatted to call all of the possible numbers. Code is well organized as well and easy to read/follow. Everything is tops as far as I can see. Great work Daniel!

using Microsoft.AspNetCore.Mvc;

namespace DecoitoDMiniChallenge_ReaustrauntPicker.Controllers;

[ApiController]
[Route("[controller]")]
public class RPickerController : ControllerBase
{
    [HttpGet]
    [Route("Game")]
    public string Game()
    {
        Random randomNum = new Random ();
        string [] Restaurant = new string []{"La Mesa", "Besitos", "Mezo", "Mi Ranchito", "Mi Cocina", "Irmas","Octavios", "Nena's", "Susy's", "Xochimilco", "Hilda's", "Domo", "Shomi", "Thai Me Up", "SunKing", "New fu Lim", "Tsing Tao", "Peking", "China Palace", "Dynasty Seafood", "Dave Wong's", "George's", "LumberJacks", "Cast Iron Co.", " The Creamery", "Market Tavern", "The Downtowner", "the Black Rabbit", "Squeeze Burger", "ElkHorn", "FED", "Prime Table", "Mannys California Fresh", "Bud's Seafood Grille", "Midgley's Public House"  };
        int allChoice = randomNum.Next(0,34);
        return $"You're Restaurant is... \n\n-*-*-*- {Restaurant[allChoice]} -*-*-*-\n";
    }


}
