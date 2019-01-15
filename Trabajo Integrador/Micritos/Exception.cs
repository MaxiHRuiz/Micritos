using System;

namespace Micritos
{
	public class NombreIncorrectoException : Exception
	{
		public NombreIncorrectoException(string nombre)
		{
			Console.WriteLine("el nombre ingresado  \"{0}\" no debe contener numeros o ser vacio.", nombre);
		}
	}
	
	
	public class ApellidoIncorrectoException : Exception
	{
		public ApellidoIncorrectoException (string nombre)
		{
			Console.WriteLine("el apellido ingresado  \"{0}\" no debe contener numeros o ser vacio.", nombre);
		}
	}
	
	public class DiaDeLaSemanaNoValidoException : Exception
	{
		public DiaDeLaSemanaNoValidoException ()
		{
			Console.WriteLine("El dia seleccionado debe ser entre 1-7.");
		}
	}
	
	public class NombreTerminalException : Exception
	{
		public NombreTerminalException ()
		{
			Console.WriteLine("El nombre de la terminal no debe ser vacio. Presione una tecla y vuelva a intentarlo...");
		}
	}
	
	public class NombreCiudadException : Exception
	{
		public NombreCiudadException ()
		{
			Console.WriteLine("El nombre de la ciudad no debe ser vacio. Presione una tecla y vuelva a intentarlo...");
		}
	}
	
	public class MarcaException : Exception
	{
		public MarcaException ()
		{
			Console.WriteLine("La marca ingresada del omnibus no debe ser vacio. Presione una tecla y vuelva a intentarlo...");
		}
	}
	
	public class ModeloException : Exception
	{
		public ModeloException  ()
		{
			Console.WriteLine("El modelo ingresada del omnibus no debe ser inferior al año 1970 ni mayor al año actual. Presione una tecla y vuelva a intentarlo...");
		}
	}
	
}