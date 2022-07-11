using System;

namespace EjerciciosTema8
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.setEdad("29");
            persona.setNombre("Cristian Araoz");
            persona.setTelefono("11224556");

            Console.WriteLine(persona.getEdad());
            Console.WriteLine(persona.getNombre());
            Console.WriteLine(persona.getTelefono());
        }
    }

    class Persona
    {
        private String edad;
        private String nombre;
        private String telefono;

        public void setEdad(String edad)
        {
            this.edad = edad;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }
        public void setTelefono(String telefono)
        {
            this.telefono = telefono;
        }

        public String getEdad()
        {
            return this.edad;
        }

        public String getNombre()
        {
            return this.nombre;
        }
        public String getTelefono()
        {
            return this.telefono;
        }

    }
}
