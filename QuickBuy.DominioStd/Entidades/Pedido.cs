using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido:Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }

        public int UsuarioId { get; set; }

        public DateTime DataPrevisaoEntrega { get; set; }

        public string CEP { get; set; }
        
        public string Estado { get; set; }

        public string EnderecoCompleto { get; set; }

        public string NumeroEndereco { get; set; }

        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        /**
         * Um pedido pode ter varios items de pedidos tipo
         
         * */
        public ICollection<Usuario> ItensPedidos { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();
            if(ItensPedidos.Any())
            {
                AdicionarCritica("Atenção: Item de pedido não pode ficar vasio");

            }
            if( string.IsNullOrEmpty(CEP))
            {
                AdicionarCritica("Atenção: O CEP Deve estar Preenchido");
            }
            if( FormaPagamento.Id == 0)
            {
                AdicionarCritica("Atenção: nâo foi informado a forma de pagamento");
            }
        }
    }
}
