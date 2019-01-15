
using System;

namespace Micritos
{
	public class Terminal
	{
		private string NombreTerminal;
		private string NombreCiudad;
		private int PasajesVendidosComoPartida = 0;
		private int PasajesVendidosComoArribo = 0;
		
		
		public Terminal()
		{
			
		}
		
		public Terminal(string nombreterminal, string nombreciudad)
		{
			this.NombreTerminal = nombreterminal;
			this.NombreCiudad = nombreciudad;
		}
		
		public string GetNombreTerminal()
		{
			return this.NombreTerminal;
		}
		
		
		public string GetNombreCiudad()
		{
			return this.NombreCiudad;
		}
		
			
		
		public void PasajesComoPartida(int cant)
		{
			this.PasajesVendidosComoPartida += cant;
		}
		
		public int GetPasajesVendidosComoPartida()
		{
			return this.PasajesVendidosComoPartida;
		}
		
		
		
		public void PasajesComoArribo(int cant)
		{
			this.PasajesVendidosComoArribo += cant;
		}
		
		public int GetPasajesVendidosComoArribo()
		{
			return this.PasajesVendidosComoArribo;
		}
		
		
		
				
		override public string ToString()
		{
			
			return string.Format(this.NombreTerminal);
			
			
		}
		
	}
}
