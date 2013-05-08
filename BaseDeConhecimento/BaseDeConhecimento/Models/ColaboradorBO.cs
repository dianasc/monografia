using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaseDeConhecimento.Dtos;

namespace BaseDeConhecimento.Models
{
    public class ColaboradorBO
    {
        public static void Salvar(ColaboradorDTO colaboradorDto)
        {
            Usuario user = new Usuario() { nome = colaboradorDto.nome, email = colaboradorDto.email };
            using (BaseDeConhecimentoEntities contexto  = new BaseDeConhecimentoEntities())
            {
                contexto.Usuario.Add(user);
                contexto.SaveChanges();
            }

        }

        public static List<ColaboradorDTO> GetAll()
        {
            using (BaseDeConhecimentoEntities contexto = new BaseDeConhecimentoEntities())
            {
                var usuarios = (from u in contexto.Usuario.AsEnumerable()
                                select new ColaboradorDTO
                                {
                                    idUsuario = u.idUsuario,
                                    nome = u.nome,
                                    email = u.email
                                }).ToList();

                return usuarios;
            }
        }
    }
}