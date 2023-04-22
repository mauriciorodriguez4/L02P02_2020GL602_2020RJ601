using System.ComponentModel.DataAnnotations;

namespace L02P02_2020GL602_2020RJ601.Models
{
    public class platos
    {

        [Key]
        public int platoId { get; set; }

        public string nombrePlato { get; set; }

        public double precio { get; set; }
    }
}
