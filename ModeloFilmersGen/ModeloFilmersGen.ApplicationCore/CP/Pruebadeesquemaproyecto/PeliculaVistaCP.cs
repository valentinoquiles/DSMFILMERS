
using System;
using System.Text;
using System.Collections.Generic;
using ModeloFilmersGen.ApplicationCore.Exceptions;
using ModeloFilmersGen.ApplicationCore.EN.Pruebadeesquemaproyecto;
using ModeloFilmersGen.ApplicationCore.IRepository.Pruebadeesquemaproyecto;
using ModeloFilmersGen.ApplicationCore.CEN.Pruebadeesquemaproyecto;



namespace ModeloFilmersGen.ApplicationCore.CP.Pruebadeesquemaproyecto
{
public partial class PeliculaVistaCP : GenericBasicCP
{
public PeliculaVistaCP(GenericSessionCP currentSession)
        : base (currentSession)
{
}
}
}
