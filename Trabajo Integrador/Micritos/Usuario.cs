using System;
using System.Collections;

namespace Micritos
{
	
	public class Usuario : Persona
	{
		private DateTime fechanacimiento;
		private int numUsuario;
		private ArrayList PasajesComprados;
		
		private static int ContadorNumUsuario = 0;
		public Usuario(string nombre, string apellido, int DNI, DateTime fechanacimiento)
		{
			ContadorNumUsuario++;
			this.nombre = nombre;
			this.apellido = apellido;
			this.DNI = DNI;
			this.fechanacimiento = fechanacimiento;
			this.numUsuario = ContadorNumUsuario;
			PasajesComprados = new ArrayList();
				
		}
		public int GetDNI()
		{
			return this.DNI;
		}
		public string GetNombre()
		{		
			return nombre +" "+ apellido;
		}
		public int GetNumUser()
		{
			return this.numUsuario;
		}
		
		public void ComprarPasaje(Pasaje pasajecomprado)
		{
			PasajesComprados.Add(pasajecomprado);
		}
		
		public int GetPasajesComprados()
		{
			return PasajesComprados.Count;
		}
		
		public override string ToString()
		{
			return string.Format("{0} {1}",this.nombre, this.apellido);
		}

	}
}
