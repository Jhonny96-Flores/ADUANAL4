using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.BL
{
   public  class datosInicio: CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            /*Jonathan*/
            var usuario1 = new usuario();
            usuario1.Nombre = "Jonathan";
            usuario1.Pass =Encriptar.CodificarContrasena( "20152006137");

            contexto.usuario.Add(usuario1);

            /*Yoseph*/
            var  usuario2 = new usuario();
            usuario2.Nombre = "Yoseph";
            usuario2.Pass = Encriptar.CodificarContrasena("20162031397");

            contexto.usuario.Add(usuario2);

            /*Wiliam*/
            var usuario3 = new usuario();
            usuario3.Nombre = "Wiliam";
            usuario3.Pass = Encriptar.CodificarContrasena("20172000847");

            contexto.usuario.Add(usuario3);

            /*Oscar*/
            var usuario4 = new usuario();
            usuario4.Nombre = "Oscar";
            usuario4.Pass = Encriptar.CodificarContrasena("20152001504");

            contexto.usuario.Add(usuario4);

            /*Miler*/
            var usuario5 = new usuario();
            usuario5.Nombre = "Miler";
            usuario5.Pass = Encriptar.CodificarContrasena("20152030014");

            contexto.usuario.Add(usuario4);

            base.Seed(contexto);
        }
    }
}
