using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.Estoque
{
    class EstoqueDTO
    {
        public int id_Estoque { get; set; }
        public int qnt_Produto { get; set; }
        public int num_Est_Min { get; set; }
        public int num_Est_Max { get; set; }
        
    }
}
id_Estoque` INT(11) NOT NULL AUTO_INCREMENT,
  `qnt_Produto` INT(11) NOT NULL,
  `num_Est_Min` INT(11) NULL DEFAULT NULL,
  `num_Est_Max` INT(11) NULL DEFAULT NULL,