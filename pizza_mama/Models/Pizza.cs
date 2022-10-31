using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;

namespace pizza_mama.Models
{
    public class Pizza
    {
        [JsonIgnore]
        public int PizzaID { get; set; }

        [Display(Name = "Nom")]

        public string nom {get; set;}

        [Display(Name = "Prix (€)")]
        public float prix {get; set;}

        [Display(Name = "Végetarienne")]
        public bool vegetarienne {get; set; }

        [Display(Name = "Ingrédients")]
        [JsonIgnore]

        public string ingredients {get; set; }

        [NotMapped]
        [JsonPropertyName("ingredients")]
        public string[] listeIngredients 
        {
            get
            {
                if ((ingredients == null) || (ingredients.Count() == 0))
                {
                    return null;
                }

                return ingredients.Split(", ");
            }
        }
    }
}
