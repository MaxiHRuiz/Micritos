using System;

namespace Micritos
{
	
	public class Omnibus
	{
		private string Marca;
		private string Tipo;
		private int Modelo;
		private int Capacidad;
		private int NumeroDeUnidad;
		private static int ContadorUnidad = 0;
		
		public Omnibus(string marca,int modelo,int capacidad,string tipo)
		{
			ContadorUnidad++;
			this.Marca = marca;
			this.Modelo = modelo;
			this.Capacidad = capacidad;
			this.Tipo = tipo;
			this.NumeroDeUnidad = ContadorUnidad;
			
			
		}
		
		public int GetNumeroDeUnidad()
		{
			return NumeroDeUnidad;
		}
		
		public string GetTipo()
		{
			return Tipo;
		}
		
		
	
		
		public override string ToString()
		{
			
			return string.Format("({0} - {1}, {2}, {3})",this.Marca, this.Modelo, this.Tipo, this.Capacidad);
			
			
		}
		
		
	}
}
