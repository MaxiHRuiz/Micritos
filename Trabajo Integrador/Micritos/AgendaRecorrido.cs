
using System;

namespace Micritos
{
	
	public class AgendaRecorrido
	{
		Chofer choferSeleccionado;
		Omnibus omnibusSeleccionado;
		Recorrido recorridoSeleccionado;
		string diaDeViaje;
		
		public AgendaRecorrido()
		{
		}
		
		public void AsignarChofer(Chofer nuevochofer)
		{
			this.choferSeleccionado = nuevochofer;
		}
		public void AsignarOmnibus(Omnibus nuevoomnibus)
		{
			this.omnibusSeleccionado = nuevoomnibus;
		}
		public void AsignarRecorrido(Recorrido nuevorecorrido)
		{
			this.recorridoSeleccionado = nuevorecorrido;
		}
		public void AsignarDiaDeViaje(string dia)
		{
			this.diaDeViaje = dia;
		}
		
		
		
		public string GetNombreChofer()
		{
			return choferSeleccionado.GetNombre();
		}
		
		public int GetLegajoChofer()
		{
			return choferSeleccionado.GetLegajo();
		}
		
		public string GetDiaDeViaje()
		{
			return this.diaDeViaje;
		}
		
		public int GetUnidadOmnibus()
		{
			return omnibusSeleccionado.GetNumeroDeUnidad();
		}
		
		public Recorrido GetRecorrido()
		{
			return recorridoSeleccionado;
		}
		
		public override string ToString()
		{
			return string.Format("{0},{1}", diaDeViaje, omnibusSeleccionado.GetTipo());
		}
		
		
	}
}
