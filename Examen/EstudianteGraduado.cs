using System;

namespace Examen
{
    class EstudianteGraduado: Estudiante
    {
        private String titulo;

        public EstudianteGraduado(string nombre, int edad, float calificaciones,String titulo) : base(nombre, edad, calificaciones)
        {
            this.titulo = titulo;
        }
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
    }
}
