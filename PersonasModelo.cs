namespace MarilinGEjercicio4
{
    internal class PersonasModelo
    {
        public List<Persona> Personas { get; set; }

        public PersonasModelo()
        {
            Personas = new List<Persona>()
            {
            new Persona { Apellido = "Perez", Nombre = "Juan", Documento = 11111, Telefono = new Telefono { Tipo = Tipo.Casa, CodPais = 54, CodArea = 11, Numero = 3179445 }},
            new Persona { Apellido = "Gomez", Nombre = "Maria", Documento = 22222, Telefono = new Telefono { Tipo = Tipo.Otro, CodPais = 54, CodArea = 11, Numero = 3155555 }},
            new Persona { Apellido = "Lopez", Nombre = "Carlos", Documento = 33333, Telefono = new Telefono { Tipo = Tipo.Trabajo, CodPais = 54, CodArea = 11, Numero = 3166666 }},
            new Persona { Apellido = "Rodriguez", Nombre = "Ana", Documento = 44444, Telefono = new Telefono { Tipo = Tipo.Casa, CodPais = 54, CodArea = 11, Numero = 3188888 }},
            new Persona { Apellido = "Martinez", Nombre = "Luis", Documento = 55555, Telefono = new Telefono { Tipo = Tipo.Trabajo, CodPais = 54, CodArea = 11, Numero = 3199999 }},
            new Persona { Apellido = "Sanchez", Nombre = "Laura", Documento = 66666, Telefono = new Telefono { Tipo = Tipo.Trabajo, CodPais = 54, CodArea = 11, Numero = 3110101 }},
            new Persona { Apellido = "Gonzalez", Nombre = "Diego", Documento = 77777, Telefono = new Telefono { Tipo = Tipo.Casa, CodPais = 54, CodArea = 11, Numero = 3121212 }},
            new Persona { Apellido = "Diaz", Nombre = "Fernanda", Documento = 88888, Telefono = new Telefono { Tipo = Tipo.Otro, CodPais = 54, CodArea = 11, Numero = 3132323 }},
            new Persona { Apellido = "Suarez", Nombre = "Julio", Documento = 99999, Telefono = new Telefono { Tipo = Tipo.Trabajo, CodPais = 54, CodArea = 11, Numero = 3143434 }},
            new Persona { Apellido = "Alvarez", Nombre = "Gabriela", Documento = 101010, Telefono = new Telefono { Tipo = Tipo.Casa, CodPais = 54, CodArea = 11, Numero = 3104040 }}

            };
        }
    }
}