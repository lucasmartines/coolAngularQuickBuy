using System.Collections;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario :Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public string Nome { get; set; }
        public string SobreNome{ get; set; }

        /**
         * Um usuario pode ter um ou varios pedidos
         * */
        public ICollection<Usuario> Pedidos { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
            {
                AdicionarCritica("Atenção:  Email não informado");
            }
            if (string.IsNullOrEmpty(Senha))
            {
                AdicionarCritica("Atenção: Senha não informado");
            }
        }
    }
}
