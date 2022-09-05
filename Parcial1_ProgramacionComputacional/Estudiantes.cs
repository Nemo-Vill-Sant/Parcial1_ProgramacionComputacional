using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_ProgramacionComputacional
{
    class Estudiantes
    {
        private int id;
        private String código;
        private String nombre;
        private int edad;
        private String facultad;
        private string asignatura;
        private double notaFinal;

        public String Facultad
        {
            get { return facultad; }
            set { facultad = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public String Código
        {
            get { return código; }
            set { código = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }

        }
        public string Asignatura
        {
            get { return asignatura; }
            set { asignatura = value; }

        }
        public double NotaFinal
        {
            get { return notaFinal; }
            set { notaFinal = value; }

        }
        public Estudiantes(int id, String código, string nombre, int edad, String facultad, string asignatura, double NotaFinal)
        {
            this.id = id;
            this.código = código;
            this.nombre = nombre;
            this.edad = edad;
            this.facultad = facultad;
            this.asignatura = asignatura;
            this.NotaFinal = NotaFinal;
        }
        public string mostrar()
        {
            return id + " " + código + " " + nombre + " " + " " + edad + " " + facultad + " " + asignatura + " " + notaFinal;
        }
    }
}
