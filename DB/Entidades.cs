﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{

    public class Autor
    {
        [Key]
        public long id_autor { get; set; }

        public string nombre_autor { get; set; }

        public string apellidos_autor { get; set; }

        public List<Libro> libros_con_autor { get; set; }

    }

   /* public class Rel_Autores_Libros
    {
        [Key]
        public long id_rel_autores_libros { get; set; }

        public long id_autor { get; set; }
        [ForeignKey("id_autor")]
        public Autor autor { get; set; }
        public long id_libro { get; set; }

        [ForeignKey("id_libro")]
        public Libro libro { get; set; }


    }*/

    public class Libro
    {
        [Key]
        public long id_libro { get; set; }

        public string isbn_libro { get; set; }

        public string titulo_libro { get; set; }

        public string edicion_libro { get; set; }

        public int cantidad {  get; set; }

        public long id_editorial { get; set; }
        [ForeignKey("id_editorial")]
        public Editorial editorial { get; set; }

        public long id_genero { get; set; }
        [ForeignKey("id_genero")]
        public Genero genero { get; set; }

        public long id_coleccion { get; set; }
        [ForeignKey("id_coleccion")]
        public Coleccion coleccion { get; set; }

        public List<Autor> libro_con_autores { get; set; }
        public List<Prestamo> libro_con_prestamos { get; set; }




    }

    public class Editorial
    {
        [Key]
        public long id_editorial { get; set; }
        public string nombre_editorial { get; set; }

        public List<Libro> editorial_con_libros { get; set; }


    }
    public class Genero
    {
        [Key]
        public long id_genero { get; set; }

        public string nombre_genero { get; set; }

        public string descripcion_genero { get; set; }

        public List<Libro> genero_con_libros { get; set; }
    }

    public class Coleccion
    {
        [Key]
        public long id_coleccion { get; set; }
        public string nombre_coleccion { get; set; }

        public List<Libro> coleccion_con_libros { get; set; }
    }
    public class Acceso
    {
        [Key]
        public long id_acceso { get; set; }
        public string codigo_acceso { get; set; }
        public string descipcion_acceso { get; set; }

        public List<Usuario> usuarios_con_acesso { get; set; }
    }

    public class Usuario
    {
        [Key]
        public long id_usuario { get; set; }
        public string dni_usuario { get; set; }
        public string nombre_usuario { get; set; }
        public string apellidos_usuario { get; set; }
        public string tlf_usuario { get; set; }
        public string email_usuario { get; set; }
        public string clave_usuario { get; set; }

        public long id_acceso { get; set; }
        [ForeignKey("id_acceso")]
        public Acceso acceso { get; set; }
        public bool estaBloqueado_usuario { get; set; }
        public DateTime fch_fin_bloqueo_usuario { get; set; }
        public DateTime fch_alta_usuario { get; set; }
        public DateTime fch_baja_usuario { get; set; }

        public List<Prestamo> prestamos_de_usuario{ get; set; }

    }
    public class Prestamo
    {
        [Key]
        public long id_prestamo { get; set; }

        public long id_usuario { get; set; }
        [ForeignKey("id_usuario")]
        public Usuario usuario { get; set; }

        public DateTime fch_inicio_prestamo { get; set; }
        public DateTime fch_fin_prestamo { get; set; }
        public DateTime fch_entrega_prestamo { get; set; }
        public long id_estado_prestamo { get; set; }

        [ForeignKey("id_estado_prestamo")]
        public Estado_Prestamo estadoConPrestamo { get; set; }

        public List<Libro> libros_de_prestamo { get; set; }


    }
    public class Estado_Prestamo
    {
        [Key]
        public long id_estado_prestamo { get; set; }
        public string codigo_estado_prestamo { get; set; }
        public string descripcion_estado_prestamo { get; set; }

        public List<Prestamo> prestamos_con_estado { get; set; }
    }

    /*public class Rel_Prestamo_Libro
    {
        [Key]
        public long id_rel_prestamo_libro { get; set; }

        public long id_prestamo { get; set; }
        [ForeignKey("id_prestamo")]
        Prestamo prestamo { get; set; }

        public long id_libro { get; set; }
        [ForeignKey("id_libro")]
        Libro libro { get; set; }
    }*/
}
