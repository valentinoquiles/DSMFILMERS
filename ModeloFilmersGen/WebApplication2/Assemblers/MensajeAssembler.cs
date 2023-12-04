﻿using ModeloFilmersGen.ApplicationCore.EN.Pruebadeesquemaproyecto;
using WebApplication2.Models;

namespace WebApplication2.Assemblers
{
    public class MensajeAssembler
    {
        public MensajeViewModel ConvertirENToViewModel(MensajeEN en)
        {
            MensajeViewModel men = new MensajeViewModel();
            men.IdMensaje = en.Id;
            men.Contenido = en.Contenido;
            men.Fecha = (DateTime)en.Fecha;
            return men;
        }

        public IList<MensajeViewModel> ConvertirListENToViewModel(IList<MensajeEN> ens)
        {
            IList<MensajeViewModel> mens = new List<MensajeViewModel>();
            foreach (MensajeEN en in ens)
            {
                mens.Add(ConvertirENToViewModel(en));
            }
            return mens;
        }
    }
}
