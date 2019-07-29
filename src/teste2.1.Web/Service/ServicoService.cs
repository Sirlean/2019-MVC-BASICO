using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using teste2._1.Web.Controllers;
using teste2._1.Web.Models;

namespace teste2._1.Web.Service
{
    public class ServicoService
    {
        private Contexto contexto;// é dado um nome que vc quiser

        public ServicoService()
        {
            contexto = new Contexto();
        }
        internal ServicosViewModel Get(int id)
        {
            return contexto.servico.SingleOrDefault(_ => _.Codigo == id); //Verifica se é unico o registro
        }

        internal void Add(ServicosViewModel model)
        {
            contexto.servico.Add(model);
            contexto.SaveChanges();
        }

        internal void Remove(ServicosViewModel model)
        {
            var itens = contexto.servico.Where(_ => _.Codigo == model.Codigo);
            contexto.servico.RemoveRange(itens);
            contexto.SaveChanges();
        }

        internal void Update(ServicosViewModel model)
        {
            var modelAuxiliar = contexto.servico.SingleOrDefault(_ => _.Codigo == model.Codigo);
            modelAuxiliar.Nome = model.Nome;
            modelAuxiliar.Telefone = model.Telefone;
            modelAuxiliar.Email = model.Email;
            contexto.SaveChanges();
        }

        internal List<ServicosViewModel> GetAll()
        {
            return contexto.servico.ToList();
        }
    }
}