using System.ComponentModel.DataAnnotations;

namespace Ppt.Api.Data;

public class Vybaveni
{
    //[Key] //už ví z názvu Id, že je to primární klíč. 
    public Guid Id { get; set; }

    [Required, MinLength(5, ErrorMessage = "Alespoň 5 písmen!")]
    public string Name { get; set; } = "";
    public int PriceCzk { get; set; }
    public DateTime BoughtDateTime { get; set; }
    public DateTime LastRevisionDateTime { get; set; }

    public bool isRevisionNeeded { get; set; }
}