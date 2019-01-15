using System;

namespace Micritos
{
	
	public class Pasaje
	{
		Terminal TPartida;
		Terminal TArribo;
		int ParadasIntermedias;
		AgendaRecorrido RecorridoSeleccionado;
		
		private static int PasajesTotalesVendidos = 0;
		
		
		public Pasaje()
		{
			
		}
		
		public Pasaje(Terminal partida, Terminal arribo, int paradasintermedias, AgendaRecorrido recorridoseleccionado)
		{
			this.TPartida = partida;
			this.TArribo = arribo;
			this.ParadasIntermedias = paradasintermedias;
			this.RecorridoSeleccionado = recorridoseleccionado;
			
		}
		
		public void PasajesTotales(int cantidad)
		{
			PasajesTotalesVendidos+= cantidad;
		}
		
	
		public int GetPasajesTotales()
		{
			return PasajesTotalesVendidos;
		}
		
		public override string ToString()
		{
			return string.Format("Saliendo de {0} y llegando a {1} ({2} paradas intermedias,{3})", TPartida, TArribo, ParadasIntermedias, RecorridoSeleccionado);
		}

		
	}
}
