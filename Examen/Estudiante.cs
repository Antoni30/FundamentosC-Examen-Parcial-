using System;


namespace Examen
{
    class Estudiante
    {
        private String nombre;
        private int edad;
        private float calificaciones;
        public Estudiante(string nombre, int edad, float calificaciones)        {
            this.nombre = nombre;
            this.edad = edad;
            this.calificaciones = calificaciones;
        }
 
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

 
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public float Calificaciones
        {
            get { return calificaciones; }
            set { calificaciones = value; }
        }
        public void mostrarInformacion()
        {
            Console.WriteLine($"Nombre: {this.Nombre}");
            Console.WriteLine($"Edad: {this.Edad}");
            Console.WriteLine($"Calificaciones: {this.Calificaciones}");
        }

    }
}
