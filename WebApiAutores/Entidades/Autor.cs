﻿

namespace WebApiAutores.Entidades;
public class Autor
{
    public int Id {  get; set; }    
    public string Nombre { get; set; }
    public List<AutorLibro> AutoresLibros { get; set; }
}