using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

using System.Linq;
using System.Collections.Generic;

namespace DB
{
    public class Metodos
    {
        public static ContextoDeDatos ObtenerBaseDeDatos()
        {
            var contexto = new ContextoDeDatos("isostore:/Ringtones.sdf");

            if (!contexto.DatabaseExists())
            {
                contexto.CreateDatabase();
            }

            return contexto;
        }

        public static void AgregarRingtone(Ringtone nuevoRingtone)
        {
            var baseDeDatos = ObtenerBaseDeDatos();
            baseDeDatos.Ringtones.InsertOnSubmit(nuevoRingtone);
            baseDeDatos.SubmitChanges();
        }

        public static void EliminarRingtone(Ringtone viejoRingtone)
        {
            var baseDeDatos = ObtenerBaseDeDatos();
            baseDeDatos.Ringtones.Attach(viejoRingtone);
            baseDeDatos.Ringtones.DeleteOnSubmit(viejoRingtone);
            baseDeDatos.SubmitChanges();
        }

        public static void ActualizarRingtone(Ringtone NuevoRingtone,Ringtone viejoRingtone)
        {
            var baseDeDatos = ObtenerBaseDeDatos();
            baseDeDatos.Ringtones.Attach(NuevoRingtone, viejoRingtone);
            baseDeDatos.SubmitChanges();
        }

        public static List<Ringtone> ObtenerListaDeRingtones()
        {
            List<Ringtone> ListaObtenida = new List<Ringtone>();

            var baseDeDatos = ObtenerBaseDeDatos();
            var query = from R 
                        in baseDeDatos.Ringtones 
                        select R;
            
            ListaObtenida.AddRange(query);

            return ListaObtenida;
        }
    }
}
