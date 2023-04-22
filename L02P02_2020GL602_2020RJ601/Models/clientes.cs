using System.ComponentModel.DataAnnotations;
namespace L02P02_2020GL602_2020RJ601.Models
{
    public class clientes
    {
        [Key]
        public int clienteId { get; set; }
        public string nombreCliente { get; set; }
        public string direccion { get; set; }
    }
}
