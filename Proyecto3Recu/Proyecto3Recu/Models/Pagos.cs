﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Proyecto3Recu.Models
{
    public class Pagos
    {
        [PrimaryKey, AutoIncrement]
        public int id_pago { get; set; }

        [MaxLength(100)]
        public string Descripcion { get; set; }


        public double Monto { get; set; }

        [MaxLength(100)]
        public DateTime Fecha { get; set; }


        public byte[] Photo_recibo { get; set; }

        [MaxLength(200)]
        public string foto_ruta { get; set; }


    }
}
