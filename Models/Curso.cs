﻿namespace GestionAcademica.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Creditos { get; set; }
        public int HorasSemanal { get; set; }
        public string Ciclo { get; set; }

        public int IdDocente { get; set; }

    }
}
