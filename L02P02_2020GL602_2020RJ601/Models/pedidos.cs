using System.ComponentModel.DataAnnotations;

namespace L02P02_2020GL602_2020RJ601.Models
{
    public class pedidos
    {

        [Key]
        public int pedidoId { get; set; }

        public int motoristaId { get; set; }

        public int clienteId { get; set; }
        public int platoId { get; set; }
        public int cantidad { get; set; }
        public decimal precio { get; set; }

    }
}
