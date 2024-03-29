﻿using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        private List<string> _mensagensValidacao { get; set; }

        private List<string> MensagemValidacao
        {
            get
            {
                return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); 
            }
        }
        protected void LimparMensagemValidacao()
        {
            MensagemValidacao.Clear();
        }
        protected void AdicionarCritica( string Mensagem)
        {
            MensagemValidacao.Add(Mensagem);
        }
        public abstract void Validate();

        protected bool EhValido
        {
            get { return MensagemValidacao.Any(); }
        }


    }
}
