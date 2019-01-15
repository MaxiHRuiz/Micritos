using System;
using System.Collections;

namespace Micritos
{
	
	public class Recorrido
	{
		private ArrayList recorrido;
		
		public Recorrido()
		{
			this.recorrido = new ArrayList();
		}
		
				
		public void CargarTerminal(Terminal terminalseleccionada)
		{
			recorrido.Add(terminalseleccionada);
		}
		
		public int CantidadDeTerminales()
		{
			return recorrido.Count;
		}
		
		public Terminal ListaDeTerminalesSeleccionadas(int k)
		{
			return (Terminal)recorrido[k];
		}
		
		public void MostrarRecorrido()
		{
			for (int i = 0; i < recorrido.Count; i++) 
			{
				Console.Write(recorrido[i] + "-");
			}
		}
		
	
		public override string ToString()
		{
			string reco = "";
			for (int i = 0; i < recorrido.Count; i++) 
			{
				reco += recorrido[i]+ "-";
			}
			
			return Convert.ToString(reco);
			
		} 		
		
		public Terminal GetRecorrido(int num)
		{
			return (Terminal)recorrido[num];
		}
		

		
	}
}
