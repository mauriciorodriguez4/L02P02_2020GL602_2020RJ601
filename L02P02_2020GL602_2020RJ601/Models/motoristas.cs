using System.ComponentModel.DataAnnotations;
namespace L02P02_2020GL602_2020RJ601.Models
{
    public class motoristas
    {
        [Key]
        public int motoristaId { get; set; }
        public string nombreMotorista { get; set; }
    }
}
