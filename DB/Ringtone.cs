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

using System.Data.Linq.Mapping;
namespace DB
{
    [Table]
    public class Ringtone
    {
        [Column (IsDbGenerated=true, IsPrimaryKey=true)]
        public int ID{ get; set; }

        [Column]
        public string Nombre { get; set; }

        [Column]
        public string Artista { get; set; }

        [Column]
        public string Album { get; set; }
    }
}
