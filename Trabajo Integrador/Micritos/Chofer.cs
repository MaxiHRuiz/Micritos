using System;
using System.Collections;

namespace Micritos
{
	
	public class Chofer : Persona
	{
	
		private int legajo;
		private static int ContadorLegajo = 0;
		
		public Chofer(string nombre, string apellido, int dni)
		{
			
			ContadorLegajo++;
			this.nombre = nombre;
			this.apellido = apellido;
			this.DNI = dni;
			this.legajo = ContadorLegajo;
			
		}
		public string GetNombre()
		{		
			return nombre +" "+ apellido;
		}
		
		public int GetLegajo()
		{		
			return legajo;
		}
		
		public int GetDNI()
		{		
			return this.DNI;
		}
		
		
		override public string ToString()
		{
			
			return string.Format("{0}, {1} (LEG: {2}) ",this.apellido, this.nombre, this.legajo);
			
			
		} 
		
	}
}
