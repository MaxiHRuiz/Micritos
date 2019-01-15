/*
 * Date: 16/05/2017 to 22/06/2016
 * Time: 12:35 to Time: 20:49
 */
using System;
using System.Collections;

namespace Micritos
{
	class Program
	{
		
		
		public static void Main(string[] args)
		{
			ArrayList ListaChoferes = new ArrayList();
			ArrayList ListaOmnibus = new ArrayList();
			ArrayList ListaTerminales = new ArrayList();
			ArrayList ListaRecorridos = new ArrayList();
			ArrayList ListaViajesConfirmados = new ArrayList();
			ArrayList ListaUsuarios = new ArrayList();
			ArrayList PasajesVendidos = new ArrayList();
			
			int OpcionMenu = 0;
			
			do
			{
				
				
				Console.WriteLine("A que module desea ingresar? ");
				Console.WriteLine("1) Armado de recorridos\n" +
				                  "2) Gestión de choferes\n" +
				                  "3) Ventas de pasaje\n" +
				                  "4) Estadisticas\n" +
				                  "5) Salir del sistema");
				
				try
				{
					OpcionMenu = int.Parse(Console.ReadLine());
					if (OpcionMenu <=0 || OpcionMenu > 5)
					{
						throw new FormatException();
					}
				}
				catch(FormatException)
				{
					Console.WriteLine("Ingreso un digito incorrecto. Ingrese valor entre 1-5. Presione una tecla para continuar...");
					OpcionMenu = 0;
					Console.ReadKey();
					Console.Clear();
				}
				
				
				Console.Clear();
				
				switch (OpcionMenu)
				{
						
					//MODULO TERMINAL
					case 1:
						
						
						int opcion1 = 0;
						Console.Clear();
						
						do
						{
							Console.WriteLine("1) Alta de terminales\n" +
							                  "2) Alta de ómnibus\n" +
							                  "3) Alta de recorridos\n" +
							                  "4) volver\n");
							
							try
							{
								opcion1 = int.Parse(Console.ReadLine());
								if (opcion1 <=0 || opcion1 > 4)
								{
									throw new FormatException();
								}
							}
							catch(FormatException)
							{
								Console.WriteLine("Ingreso un digito incorrecto. Ingrese valor entre 1-4. Presione una tecla para continuar...");
								opcion1 = 0;
								Console.ReadKey();
								Console.Clear();
							}
							
							
							switch (opcion1)
							{
									//alta terminal.
								case 1:
									Console.Clear();
									DarAltaTerminal(ListaTerminales);
									Console.Clear();
									break;
									
									//alta omnibus.
								case 2:
									Console.Clear();
									DarAltaOmnibus(ListaOmnibus);
									Console.Clear();
									break;
									
									//armado de recorrido.
								case 3:
									Console.Clear();
									try
									{
										DarAltaRecorrido(ListaTerminales, ListaRecorridos);
									}
									catch(ArgumentOutOfRangeException)
									{
										Console.Clear();
										Console.WriteLine("El valor ingresado de la terminal seleccionada debe oscilar entre 1-{0}. Presione una tecla para continuar...", ListaTerminales.Count);
										Console.ReadKey();
										Console.Clear();
										
									}
									catch(FormatException)
									{
										
										Console.Clear();
										Console.WriteLine("El valor ingresado de la terminal seleccionada debe oscilar entre 1-{0}. Presione una tecla para continuar...", ListaTerminales.Count);
										Console.ReadKey();
										Console.Clear();
									}
									
									break;
							}
							
						}
						while(opcion1 != 4);
						Console.Clear();
						break;
						
						// MODULO CHOFER.
					case 2:
						int Opcion2 = 0;
						Console.Clear();
						
						do
						{
							Console.WriteLine("1) Alta de choferes\n" +
							                  "2) Asignacion de recorridos\n" +
							                  "3) Volver\n");
							try
							{
								Opcion2 = int.Parse(Console.ReadLine());
								if (Opcion2 <=0 || Opcion2 > 3)
								{
									throw new FormatException();
								}
							}
							catch(FormatException)
							{
								Console.WriteLine("Ingreso un digito incorrecto. Ingrese valor entre 1-3. Presione una tecla para continuar...");
								Opcion2 = 0;
								Console.ReadKey();
								Console.Clear();
							}
							switch (Opcion2)
							{
									//alta de chofer.
								case 1:
									Console.Clear();
									DarAltaChofer(ListaChoferes);
									Console.Clear();
									break;
									
									//asignación de viaje
								case 2:
									
									if (ListaChoferes.Count == 0)
									{
										Console.WriteLine("No se ha cargado ningun chofer al momento.");
									}
									if (ListaOmnibus.Count == 0)
									{
										Console.WriteLine("No se ha cargado ningun ómnibus al momento.");
									}
									if (ListaRecorridos.Count == 0)
									{
										Console.WriteLine("No se ha cargado ningun recorido al momento.");
									}
									
									if (ListaChoferes.Count == 0 || ListaOmnibus.Count == 0 || ListaRecorridos.Count == 0) 
									{
										Console.WriteLine("\nPresione cualquier tecla para volver...");
										Console.ReadKey();
									}
									
									
									Console.Clear();
									if (ListaChoferes.Count > 0 && ListaOmnibus.Count > 0 && ListaRecorridos.Count > 0)
									{
										Console.Clear();
										try
										{
											AsignarRecorrido(ListaChoferes,ListaOmnibus, ListaRecorridos, ListaViajesConfirmados);
										}
										catch(ArgumentOutOfRangeException){
											Console.Clear();
											Console.WriteLine("\nLa opcion seleccionada no existe. Vuelva a intentarlo por favor.\n" );
											Console.ReadKey();
										}
										Console.Clear();
										break;
									}
									break;
							}
							
						}
						
						while(Opcion2 != 3);
						Console.Clear();
						break;
						
					//MODULO DE USUARIO/COMPRA PASAJE
					case 3:
						int Opcion3 =0;
						do
						{
							Console.WriteLine("1) Alta de usuarios\n" +
							                  "2) Compra de pasajes\n" +
							                  "3) Volver\n");
							try
							{
								Opcion3 = int.Parse(Console.ReadLine());
								if (Opcion3 <=0 || Opcion3 > 3)
								{
									throw new FormatException();
								}
							}
							catch(FormatException)
							{
								Console.WriteLine("Ingreso un digito incorrecto. Ingrese valor entre 1-3. Presione una tecla para continuar...");
								Opcion3 =0;
								Console.ReadKey();
								Console.Clear();
							}
							switch (Opcion3)
							{
								//alta de usuarios.
								case 1:
									Console.Clear();
									DarAltaUsuario(ListaUsuarios);
									Console.Clear();
									break;
								//compra de pasaje.
								case 2:
									Console.Clear();
									ComprarPasaje(ListaUsuarios, ListaTerminales, ListaViajesConfirmados, PasajesVendidos);
									Console.Clear();
									break;
							}
						}
						while(Opcion3 != 3);
						Console.Clear();
						break;
						
						//MODULO ESTADISTICAS.
					case 4:
						
						int opcion4 = 0;
						do
						{
							Console.WriteLine("1) Consultar total de pasajes vendidos\n" +
							                  "2) Consultar usuarios\n" +
							                  "3) Consultar terminal como partida\n" +
							                  "4) Consultar terminal como arribo\n" +
							                  "5) Volver\n");
							
							try
							{
								opcion4 = int.Parse(Console.ReadLine());
								if (opcion4 <=0 || opcion4 > 5)
								{
									throw new FormatException();
								}
							}
							catch(FormatException)
							{
								Console.WriteLine("Ingreso un digito incorrecto. Ingrese valor entre 1-5. Presione una tecla para continuar...");
								opcion4 = 0;
								Console.ReadKey();
								Console.Clear();
							}
							
							
							switch (opcion4)
							{
								case 1:
									Pasaje estadistica = new Pasaje();
									Console.WriteLine("En total se han vendido {0} pasajes. Presione una tecla para continuar...",  estadistica.GetPasajesTotales());
									Console.ReadKey();
									Console.Clear();
									break;
									
								case 2:
									OrdenarUsuarios(ListaUsuarios);
									Console.ReadKey();
									Console.Clear();
									break;
									
								case 3:
									
									
									OrdenarPasajesPartida(ListaTerminales);
									Console.ReadKey();
									Console.Clear();
									break;
									
								case 4:
									
									OrdenarPasajesArribo(ListaTerminales);
									Console.ReadKey();
									Console.Clear();
									break;
								
							}
							
						}
						while(opcion4 != 5);
						
						Console.Clear();
						break;
						
				}
			}

			
			while(OpcionMenu != 5);
			
			Console.WriteLine("saliendo...");
			Console.ReadKey(true);
			
			
		}
		
		
		static void AsignarRecorrido(ArrayList ListaChoferes, ArrayList ListaOmnibus, ArrayList ListaRecorridos, ArrayList ListaViajesConfirmados)
		{
			AgendaRecorrido nuevoCronograma = new AgendaRecorrido();
			int opcion = 0;
			//asignacion de chofer
			
			Console.Clear();
		
			bool choferseleccionadoexiste = false;
			while (! choferseleccionadoexiste) 
			{
				try
				{
					Console.WriteLine("\nseleccione el chofer:");
					for (int i = 0; i < ListaChoferes.Count; i++)
					{
						Console.WriteLine("{0}) "+ ListaChoferes[i], i+1);
					}
					choferseleccionadoexiste = true;
					opcion = int.Parse(Console.ReadLine());
					if (opcion == 0 || opcion > ListaChoferes.Count) 
					{
						throw new FormatException();
					}
				}
				catch(FormatException)
				{
					choferseleccionadoexiste = false;
					Console.WriteLine("La opcion ingresada no corresponde a la lista de choferes. Presione una tecla y vuelva a intentarlo...");
					Console.ReadKey();
					Console.Clear();
				}
			}
			nuevoCronograma.AsignarChofer((Chofer)ListaChoferes[opcion-1]);
			

			//asignacion de omnibus
			Console.Clear();
			
			
			bool omnibusseleccionadoexiste = false;
			while (! omnibusseleccionadoexiste) 
			{
				try
				{
					Console.WriteLine("\nseleccione el Ómnibus:");
					for (int i = 0; i < ListaOmnibus.Count; i++)
					{
						Console.WriteLine("{0}) "+ ListaOmnibus[i], i+1);
					}
					
					omnibusseleccionadoexiste = true;
					opcion = int.Parse(Console.ReadLine());
					if (opcion == 0 || opcion > ListaOmnibus.Count) 
					{
						throw new FormatException();
					}
				}
				catch(FormatException)
				{
					omnibusseleccionadoexiste = false;
					Console.WriteLine("La opcion ingresada no corresponde a la lista de Omnibus. Presione una tecla y vuelva a intentarlo...");
					Console.ReadKey();
					Console.Clear();
				}
			}
			nuevoCronograma.AsignarOmnibus((Omnibus)ListaOmnibus[opcion-1]);
			
			
			//asignacion de recorrido
			Console.Clear();
			
			
			bool recorridoseleccionadoexiste = false;
			while (! recorridoseleccionadoexiste) 
			{
				try
				{
					Console.WriteLine("\nseleccione el recorrido:");
					for (int i = 0; i < ListaRecorridos.Count; i++)
					{
						Console.Write("{0}) ",i+1);
						Console.WriteLine(ListaRecorridos[i]);
					}
					
					recorridoseleccionadoexiste = true;
					opcion = int.Parse(Console.ReadLine());
					if (opcion == 0 || opcion > ListaRecorridos.Count) 
					{
						throw new FormatException();
					}
				}
				catch(FormatException)
				{
					recorridoseleccionadoexiste = false;
					Console.WriteLine("La opcion ingresada no corresponde a la lista de Recorrido. Presione una tecla y vuelva a intentarlo...");
					Console.ReadKey();
					Console.Clear();
				}
			}
			nuevoCronograma.AsignarRecorrido((Recorrido)ListaRecorridos[opcion-1]);
			
			
			//Asignacion del dia del recorrido.
			Console.Clear();
			
			
			bool diacorrecto = false;
			while (! diacorrecto) {
				
			
				try
				{
					Console.WriteLine("\nseleccione el dia a hacer el viaje:");
					Console.Write("1) Lunes\n" +
					              "2) Martes\n" +
					              "3) Miercoles\n" +
					              "4) jueves\n" +
					              "5) Viernes\n" +
					              "6) Sabado\n" +
					              "7) Domingo\n");
					opcion = int.Parse(Console.ReadLine());
					if (opcion < 1 || opcion > 7)
					{
						throw new DiaDeLaSemanaNoValidoException();
					}
					diacorrecto = true;
				}
				catch(DiaDeLaSemanaNoValidoException)
				{
					diacorrecto = false;
					Console.ReadKey();
					Console.Clear();
				}
				catch(FormatException)
				{
					Console.WriteLine("Debe ingresar solo un digito numerico entre 1-7. Presione una tecla y vuelva a intentarlo...");
					Console.ReadKey();
					Console.Clear();
					
				}
			}	
			
			switch (opcion)
			{
				case 1:
					nuevoCronograma.AsignarDiaDeViaje("Lunes");
					break;
				case 2:
					nuevoCronograma.AsignarDiaDeViaje("Martes");
					break;
				case 3:
					nuevoCronograma.AsignarDiaDeViaje("Miercoles");
					break;
				case 4:
					nuevoCronograma.AsignarDiaDeViaje("Jueves");
					break;
				case 5:
					nuevoCronograma.AsignarDiaDeViaje("Viernes");
					break;
				case 6:
					nuevoCronograma.AsignarDiaDeViaje("Sabado");
					break;
				case 7:
					nuevoCronograma.AsignarDiaDeViaje("Domingo");
					break;
					
			}
			
			if (ListaViajesConfirmados.Count == 0)
			{
				ListaViajesConfirmados.Add(nuevoCronograma);
				
				Console.WriteLine("La asignación del recorrido fue dada de alta corerctamente. Presione una tecla para continuar...");
				Console.ReadKey();
				
			}
			else
			{
				//comprobación de viajes para chofer
				bool DiaAsignadoChoferRepetido = false;
				for (int i = 0; i < ListaViajesConfirmados.Count; i++)
				{
					AgendaRecorrido chequeo = (AgendaRecorrido)ListaViajesConfirmados[i];
					if (nuevoCronograma.GetLegajoChofer() == chequeo.GetLegajoChofer() && nuevoCronograma.GetDiaDeViaje() == chequeo.GetDiaDeViaje())
					{
						Console.WriteLine("\nEl chofer ya hace un recorrido ese dia. Presione una tecla para continuar...");
						DiaAsignadoChoferRepetido = true;
						Console.ReadKey();
						break;
					}
				}
				
				//comprobación de viajes para omnibus
				bool DiaAsignadoOmnibusRepetido = false;
				for (int i = 0; i < ListaViajesConfirmados.Count; i++)
				{
					AgendaRecorrido chequeo = (AgendaRecorrido)ListaViajesConfirmados[i];
					if (nuevoCronograma.GetUnidadOmnibus() == chequeo.GetUnidadOmnibus() && nuevoCronograma.GetDiaDeViaje() == chequeo.GetDiaDeViaje())
					{
						Console.WriteLine("\nEl ómnibus ya está reservado ese dia. Presione una tecla para continuar...");
						DiaAsignadoOmnibusRepetido = true;
						Console.ReadKey();
						break;
					}
				}
				
				if (! DiaAsignadoChoferRepetido && ! DiaAsignadoOmnibusRepetido)
				{
					ListaViajesConfirmados.Add(nuevoCronograma);
					
					Console.WriteLine("La asignación del recorrido fue dada de alta corerctamente. Presione una tecla para continuar...");
					Console.ReadKey();
				}
				
			}
			
		}
		
		
		static void DarAltaTerminal(ArrayList ListaTerminales)
		{
			bool nombreTerminal  = false;
			string nombreterminal = null;
			
			bool nombreCiudad  = false;
			string nombreciudad = null;
			
			while (! nombreTerminal)
			{
				try
				{
					Console.Write("ingrese el nombre de la terminal: ");
					nombreterminal = Console.ReadLine();
					nombreTerminal  = true;
					if (string.IsNullOrEmpty(nombreterminal))
					{
						throw new NombreTerminalException();
					}
					
					Console.Clear();
				}
				catch (NombreTerminalException)
				{
					nombreTerminal = false;
					Console.ReadKey();
					Console.Clear();
				}
			}
			while (! nombreCiudad)
			{
				try
				{
					Console.Write("ingrese el nombre de la terminal: {0}\n", nombreterminal);
					Console.Write("ingrese el nombre de la ciudad: ");
					nombreciudad = Console.ReadLine();
					nombreCiudad = true;
					if (string.IsNullOrEmpty(nombreciudad))
					{
						throw new NombreCiudadException();
					}
				
				}
				catch (NombreCiudadException)
				{
					nombreCiudad = false;
					Console.ReadKey();
					Console.Clear();
				}
			}
			
			if (ListaTerminales.Count == 0) 
			{
				Terminal NuevaTerminal = new Terminal(nombreterminal, nombreciudad);
				ListaTerminales.Add(NuevaTerminal);
				Console.WriteLine("La terminal ha sido dado de alta correctamente. presione una tecla para continuar...");
			}
			else
			{
				bool terminalexiste = false;
				foreach (Terminal T in ListaTerminales)
				{
					if (T.GetNombreCiudad() == nombreciudad && T.GetNombreTerminal() == nombreterminal)
					{
						terminalexiste = true;
						Console.WriteLine("La terminal que desea dar de alta ya existe. presione una tecla para continuar...");
						break;
					}
					
				}
				if (! terminalexiste)
				{
					Terminal NuevaTerminal = new Terminal(nombreterminal, nombreciudad);
					ListaTerminales.Add(NuevaTerminal);
					Console.WriteLine("La terminal ha sido dado de alta correctamente. presione una tecla para continuar...");
				}
				
			}
			
			Console.ReadKey();
				
		}
		
		
		static void DarAltaRecorrido(ArrayList ListaTerminales, ArrayList ListaRecorridos)
		{
			//SINO SE CARGÓ NINGUNA TERMINAL AL MOMENTO NO PROCEDO.
			if (ListaTerminales.Count == 0)
			{
				Console.WriteLine("\nNo se ha cargado ninguna terminal de momento. Presione una tecla para continuar...");
				Console.ReadKey();
				Console.Clear();
			}
			
			else
			{
				Recorrido NuevoRecorrido = new Recorrido();
				ArrayList ListaTerminalesDuplicada = new ArrayList();
				for (int i = 0; i < ListaTerminales.Count; i++) 
				{
					ListaTerminalesDuplicada.Add(ListaTerminales[i]);
				}
				
				
				int opcion;
				do
				{
					Console.Clear();
					//muestro el recorrido a medida que va seleccionando terminales.
					if (NuevoRecorrido.CantidadDeTerminales() > 0)
					{
						Console.WriteLine("Su recorrido hasta el momento: ");
						NuevoRecorrido.MostrarRecorrido();
						Console.WriteLine();
					}
					
					
					Console.WriteLine("\nSeleccione las terminales del recorrido, ingrese 0 para finalizar");
					for (int i = 0; i < ListaTerminalesDuplicada.Count; i++) 
					{
						Console.WriteLine("{0}) "+ListaTerminalesDuplicada[i], i+1);
					}
					Console.Write("ingrese: ");
					opcion = int.Parse(Console.ReadLine());
				
					//si la opcion es 0 termino de pedir.
					if (opcion == 0) 
					{
						break;
					}
					
					NuevoRecorrido.CargarTerminal((Terminal)ListaTerminalesDuplicada[opcion-1]);
					ListaTerminalesDuplicada.RemoveAt(opcion-1);
					
				
					
					//compruebo de que queden terminales, sino termino. 
					if (ListaTerminalesDuplicada.Count == 0)
					{
						Console.WriteLine("Ya no hay mas terminales para armar recorrido.");
						break;
					}
					
					
				}
				while(opcion != 0);
				
				// si se seleccionó 0 o 1 terminal no se carga el recorrido.
				if (NuevoRecorrido.CantidadDeTerminales() <= 1)
				{
					if (NuevoRecorrido.CantidadDeTerminales() == 0) 
					{
						Console.WriteLine("No ha seleccionado ninguna terminal para su recorrido. Presione una tecla para continuar...");	
					}
					if (NuevoRecorrido.CantidadDeTerminales() == 1) 
					{
						Console.WriteLine("Para que sea un recorrido valido de haber al menos 2 terminales. Presione una tecla para continuar...");	
					}
					
				}
				//caso contrario doy de alta el recorrido seleccionado.
				else
				{
				Console.Clear();
				Console.Write("El recorrido: ");
				NuevoRecorrido.MostrarRecorrido();
				ListaRecorridos.Add(NuevoRecorrido);
				Console.WriteLine("\nSe ha dado de alta correctamente. Presione una tecla para continuar...");
				}
				Console.ReadKey();
				Console.Clear();

			}
			
		}
		
		
		static void DarAltaOmnibus(ArrayList ListaOmnibus)
		{
			//MARCA DE OMNIBUS
			
			bool MarcaIngresadoVacio = false;
			string Marca = null;
			
			while (! MarcaIngresadoVacio)
			{
				try
				{
					Console.Write("ingrese la marca: ");
					Marca = Console.ReadLine();
					MarcaIngresadoVacio = true;
					if (String.IsNullOrEmpty(Marca))
					{
						throw new MarcaException();
					}
				}
				catch(MarcaException)
				{
					MarcaIngresadoVacio = false;
					Console.ReadKey();
					Console.Clear();
				}
			}
			
			//MODELO DE OMNIBUS
			Console.Clear();
			
			bool ModeloIngresadoVacio = false;
			int Modelo = 0;
			while (! ModeloIngresadoVacio)
			{
				try
				{
					Console.Write("ingrese la marca: {0}\n", Marca);
					Console.Write("ingrese el modelo: ");
					Modelo = int.Parse(Console.ReadLine());
					ModeloIngresadoVacio = true;
					if (Modelo <= 1970 || Modelo > DateTime.Today.Year)
					{
						throw new ModeloException();
					}
				}
				catch(ModeloException)
				{
					ModeloIngresadoVacio = false;
					Console.ReadKey();
					Console.Clear();
				}
				
				catch(FormatException)
				{
					Console.WriteLine("El modelo ingresado no debe ser vacio ni diferente a un número entero.");
					ModeloIngresadoVacio = false;
					Console.ReadKey();
					Console.Clear();
				}
			}
			
			//CAPACIDAD DE OMNIBUS
			Console.Clear();
			
			bool CapacidadIngresada = false;
			int Capacidad = 0;
			while (! CapacidadIngresada) 
			{
				Console.Write("ingrese la marca: {0}\n", Marca);
				Console.Write("ingrese el modelo: {0}\n", Modelo);
				Console.Write("ingrese la capacidad: ");
				CapacidadIngresada = true;
				try
				{
					Capacidad = int.Parse(Console.ReadLine());
					if (Capacidad <= 0) 
					{
						throw new FormatException();
					}
				}
				catch(FormatException)
				{
					Console.WriteLine("La capacidad ingresada debe ser un número entero mayor a 0. Presione una tecla y vuelva a intentarlo...");
					CapacidadIngresada = false;
					Console.ReadKey();
					Console.Clear();
				}
			}
			
			//TIPO DE OMNIBUS
			Console.Clear();
			
			string Tipo = null;
			int opcionTipo = 0;
			
			while(Tipo == null)
			{
				Console.Write("ingrese la marca: {0}\n", Marca);
				Console.Write("ingrese el modelo: {0}\n", Modelo);
				Console.Write("ingrese la capacidad: {0}\n", Capacidad);
				Console.WriteLine("Seleccione el tipo:");
				Console.Write("1) Basico\n" +
				              "2) Semi-Cama\n" +
				              "3) Coche-Cama\n");
				try
				{
				opcionTipo = int.Parse(Console.ReadLine());
					if (opcionTipo > 3 || opcionTipo <= 0) 
					{
						throw new IndexOutOfRangeException();
					}
				}
				catch(IndexOutOfRangeException)
				{
					Console.WriteLine("ingrese opción entre 1-3. Presione una tecla y vuelva a intentarlo...");
					Console.ReadKey();
					Console.Clear();
				}
				catch(FormatException)
				{
					Console.WriteLine("ingresó un valor no valido. Presione una tecla y vuelva a intentarlo...");
					Console.ReadKey();
					Console.Clear();
				}
				
				switch (opcionTipo)
				{
					case 1:
						Tipo = "Basico";
						break;
					case 2:
						Tipo = "Semi-Cama";
						break;
					case 3:
						Tipo = "Coche-Cama";
						break;
				}
			}
			
			Omnibus NuevoOmnibus = new Omnibus(Marca, Modelo, Capacidad, Tipo);
			ListaOmnibus.Add(NuevoOmnibus);
			Console.WriteLine("El ómnibus fue dado de alta correctamente. A la unidad se le asignó el número {0}.\nPresione una tecla para continuar...", NuevoOmnibus.GetNumeroDeUnidad());
			
			Console.ReadKey();
			
		}
		
		
		static void DarAltaChofer(ArrayList ListaChoferes)
		{
			//SOLICITO NOMBRE
			bool nombrecorrecto = false;
			string nombre = "";
			while (! nombrecorrecto)
			{
				Console.Write("ingrese el nombre: ");
				nombre = Console.ReadLine();
				nombrecorrecto = true;
				try
				{
					if (nombre == "")
					{
						throw new NombreIncorrectoException(nombre);
					}
					for (int i = 0; i < nombre.Length; i++)
					{
						if (char.IsNumber(nombre[i]))
						{
							throw new NombreIncorrectoException(nombre);
						}
					}
				}
				catch(NombreIncorrectoException)
				{
					nombrecorrecto = false;
					Console.ReadKey();
					Console.Clear();
				}
			}
			
			
			//SOLICITO APELLIDO
			Console.Clear();
			bool apellidocorrecto = false;
			string apellido = "";
			while (! apellidocorrecto) 
			{
				try
				{
					Console.Write("ingrese el nombre: {0}\n", nombre);
					Console.Write("ingrese el apellido: ");
					apellido = Console.ReadLine();
					apellidocorrecto = true;
					if (apellido == "") 
					{
						throw new ApellidoIncorrectoException(apellido);
					}
					for (int i = 0; i < apellido.Length; i++) 
					{
						if (char.IsNumber(apellido[i])) 
						{
							throw new ApellidoIncorrectoException(apellido);
						}
					}
				}
				catch(ApellidoIncorrectoException)
				{
					apellidocorrecto = false;
					Console.ReadKey();
					Console.Clear();
				}
			}
			
			//SOLICITO DNI
			Console.Clear();
			bool dnicorrecto = false;
			int DNI = 0;
			while (! dnicorrecto) 
			{
				Console.Write("ingrese el nombre: {0}\n", nombre);
				Console.Write("ingrese el apellido: {0}\n", apellido);
				Console.Write("ingrese el DNI: ");
				try 
				{
					DNI = int.Parse(Console.ReadLine());
					if (DNI != 0 && DNI > 0) 
					{
						dnicorrecto = true;
					}
					else throw new FormatException();
					
				} 
				catch (FormatException)
				{
					Console.WriteLine("el DNI ingresado debe contener solo numeros. Sin puntos(.) o comas(,) y ser distinto de 0.");
					dnicorrecto = false;
					Console.ReadKey();
					Console.Clear();
				}
			
			}
			
			if (ListaChoferes.Count == 0) 
			{
				Chofer NuevoChofer = new Chofer(nombre, apellido, DNI);
				Console.WriteLine();
				Console.WriteLine("El chofer {0},{1} ha sido dado de alta correctamente. Su legajo es: {2}.\n" +
				                  "presione una tecla para continuar...", apellido.ToUpper(),nombre.ToUpper(), NuevoChofer.GetLegajo() );
				
				ListaChoferes.Add(NuevoChofer);
				Console.ReadKey();
			}
			
			
			else
			{
				bool DNIDuplicado = false;
				foreach (Chofer C in ListaChoferes) 
				{
					if (DNI == C.GetDNI()) 
					{
						Console.Write("Ya existe un chofer con ese DNI en la empresa.\n" +
						              "Presione una tecla para continuar...");
						DNIDuplicado = true;
						Console.ReadKey();
						break;
					}
				}				
				if (! DNIDuplicado) 
				{
					Chofer NuevoChofer = new Chofer(nombre, apellido, DNI);
					ListaChoferes.Add(NuevoChofer);
					Console.WriteLine("El chofer {0},{1} ha sido dado de alta correctamente. Su legajo es: {2}.\n" +
					                  "presione una tecla para continuar...", apellido.ToUpper(),nombre.ToUpper(), NuevoChofer.GetLegajo());
					Console.ReadKey();
				}	
			}
			
		}
		
		
		static void DarAltaUsuario(ArrayList ListaUsuarios)
		{
			//SOLICITO NOMBRE
			bool nombrecorrecto = false;
			string nombre = "";
			while (! nombrecorrecto)
			{
				Console.Write("ingrese el nombre: ");
				nombre = Console.ReadLine();
				nombrecorrecto = true;
				try
				{
					if (nombre == "") 
					{
						throw new NombreIncorrectoException(nombre);
					}
					for (int i = 0; i < nombre.Length; i++)
					{
						if (char.IsNumber(nombre[i]))
						{
							throw new NombreIncorrectoException(nombre);
							
						}
					}
					
				}
				catch(NombreIncorrectoException)
				{
					nombrecorrecto = false;
					Console.ReadKey();
					Console.Clear();
				}
			}
			
			Console.Clear();
			//SOLICITO APELLIDO
			bool apellidocorrecto = false;
			string apellido = "";
			while (! apellidocorrecto) 
			{
				try
				{
					Console.Write("ingrese el nombre: {0}\n", nombre);
					Console.Write("ingrese el apellido: ");
					apellido = Console.ReadLine();
					apellidocorrecto = true;
					if (apellido == "") 
					{
						throw new ApellidoIncorrectoException(apellido);
					}
					for (int i = 0; i < apellido.Length; i++) 
					{
						if (char.IsNumber(apellido[i])) 
						{
							throw new ApellidoIncorrectoException(apellido);
						}
					}
				}
				catch(ApellidoIncorrectoException)
				{
					apellidocorrecto = false;
					Console.ReadKey();
					Console.Clear();
				}
			}
			Console.Clear();
			//SOLICITO DNI
			bool dnicorrecto = false;
			int DNI = 0;
			while (! dnicorrecto) 
			{
				Console.Write("ingrese el nombre: {0}\n", nombre);
				Console.Write("ingrese el apellido: {0}\n", apellido);
				Console.Write("ingrese el DNI: ");
				try 
				{
					DNI = int.Parse(Console.ReadLine());
					if (DNI != 0 && DNI > 0) 
					{
						dnicorrecto = true;
					}
					else throw new FormatException();
					
				} 
				catch (FormatException)
				{
					Console.WriteLine("el DNI ingresado debe contener solo numeros. Sin puntos(.) o comas(,) y ser distinto de 0.");
					dnicorrecto = false;
					Console.ReadKey();
					Console.Clear();
				}
			
			}
			
			Console.Clear();
			
			//SOLICITO FECHA DE NACIMIENTO
		
			DateTime fechanacimiento = DateTime.Now;
			bool fechacorrecta = false;
			while (! fechacorrecta) 
			{
				try
				{
					Console.Write("ingrese el nombre: {0}\n", nombre);
					Console.Write("ingrese el apellido: {0}\n", apellido);
					Console.Write("ingrese el DNI: {0}\n", DNI);
					Console.Write("ingrese la fecha de nacimiento: ");
					fechanacimiento = DateTime.Parse(Console.ReadLine());
					fechacorrecta = true;
				}
				catch(FormatException)
				{
					fechacorrecta = false;
					Console.WriteLine("La fecha de nacimiento ingresada es incorrecta.\nPruebe ingresando una fecha de las siguientes formas: DD/MM/AA , DD-MM-AA , DD.MM.AA");
					Console.ReadKey();
					Console.Clear();
				}
			}
			
			
			if (ListaUsuarios.Count == 0) 
			{
				Usuario NuevoUsuario = new Usuario(nombre, apellido, DNI, fechanacimiento);
				ListaUsuarios.Add(NuevoUsuario);
				Console.WriteLine("El usuario {0},{1} ha sido dado de alta correctamente. Su N° de usuario es: {2}.\n" +
					                  "presione una tecla para continuar...", apellido.ToUpper(),nombre.ToUpper(), NuevoUsuario.GetNumUser() );
				Console.ReadKey();
			}
			else
			{
				bool UsuarioDuplicado = false;
				for (int i = 0; i < ListaUsuarios.Count; i++) 
				{
					Usuario Ucargado = (Usuario)ListaUsuarios[i];
					if (DNI == Ucargado.GetDNI())
					{
						Console.Write("Ya existe un usuario con ese DNI en el sistema. Presione una tecla para continuar...");			
						UsuarioDuplicado = true;
						Console.ReadKey();
						break;
					}
					else
					{
						UsuarioDuplicado = false;
					}
					
				}
				if (! UsuarioDuplicado) 
				{
					Usuario NuevoUsuario = new Usuario(nombre, apellido, DNI, fechanacimiento);
					ListaUsuarios.Add(NuevoUsuario);
					Console.WriteLine("El usuario {0},{1} ha sido dado de alta correctamente. Su N° de usuario es: {2}.\n" +
					                  "presione una tecla para continuar...", apellido.ToUpper(),nombre.ToUpper(), NuevoUsuario.GetNumUser() );
					Console.ReadKey();
				}
				
			}
			
		}
		
		
		static void ComprarPasaje(ArrayList ListaUsuarios, ArrayList ListaTerminales, ArrayList ListaViajesConfirmados, ArrayList Pasajes)
		{
			int NumUsuario = 0;
			bool NumUsuarioCorrecto = false;
			while (! NumUsuarioCorrecto) 
			{
				
			
				Console.Write("Ingrese el número de usuario: ");
				try
				{
					NumUsuarioCorrecto = true;
					NumUsuario = int.Parse(Console.ReadLine());
				}
				catch(FormatException)
				{
					NumUsuarioCorrecto = false;
					Console.WriteLine("Debe ingresar solo numeros. Presione una tecla para continuar...");
					Console.ReadKey();
					Console.Clear();
				}
			}
			
			Console.Clear();
			
			int DniUsuario = 0;
			bool DniUsuarioCorrecto = false;
			while (! DniUsuarioCorrecto) 
			{
				
				Console.Write("Ingrese el número de usuario: {0}\n", NumUsuario);
				Console.Write("Ingrese el DNI de usuario: ");
				try
				{
					DniUsuarioCorrecto = true;
					DniUsuario = int.Parse(Console.ReadLine());
				}
				catch(FormatException)
				{
					DniUsuarioCorrecto = false;
					Console.WriteLine("Debe ingresar solo numeros. Presione una tecla para continuar...");
					Console.ReadKey();
					Console.Clear();
				}
			}
			
			
			
			bool usuarioexistente= false;
			foreach (Usuario U in ListaUsuarios) 
			{
				if (NumUsuario == U.GetNumUser() && DniUsuario == U.GetDNI() ) 
				{
					usuarioexistente = true;
					break;
				}
				else
				{
					usuarioexistente = false;
				}
			}
			
			if (! usuarioexistente) 
			{
				Console.Clear();
				Console.WriteLine("El usuario solicitado no existe en el sistema. Presione una tecla para continuar...");
				Console.ReadKey();
				Console.Clear();
			}
			
			
			else
			{
				if (ListaViajesConfirmados.Count == 0)
				{
					Console.Clear();
					Console.WriteLine("No se han cargado viajes al momento. Presione una tecla para continuar...");
					Console.ReadKey();
					Console.Clear();
				}
				
				else
				{
					//SELECCIONO TERMINAL DE PARTIDA
					Console.Clear();
					int opcion;
					bool opcionPartidacorrecta = false;
					Terminal TPartida = null;
					while (! opcionPartidacorrecta) 
					{
						try
						{
							Console.WriteLine("Seleccione la terminal de partida: ");
							for (int i = 0; i < ListaTerminales.Count; i++)
							{
								Console.WriteLine("{0}) " + ListaTerminales[i], i+1);
							}
							
							opcion = int.Parse(Console.ReadLine() );
							opcionPartidacorrecta = true;
							TPartida = (Terminal)ListaTerminales[opcion-1];
							Console.Clear();
						}
						catch(ArgumentOutOfRangeException)
						{
							opcionPartidacorrecta = false;
							Console.WriteLine("ingrese opcion entre 1-{0}. Presione una tecla para continuar...", ListaTerminales.Count);
							Console.ReadKey();
							Console.Clear();
						}
						catch(FormatException)
						{
							opcionPartidacorrecta = false;
							Console.WriteLine("ingrese solo valores numericos comprendidos entre 1-{0}. Presione una tecla para continuar...", ListaTerminales.Count);
							Console.ReadKey();
							Console.Clear();
						}
					}
					
						
					Console.Clear();
					
					//SELECCIONO TERMINAL DE ARRIBO
					bool opcionArribocorrecta = false;
					Terminal TArribo  = null;
					while (! opcionArribocorrecta) 
					{
						try
						{
							Console.WriteLine("Seleccione la terminal de partida: {0}",TPartida);
							Console.WriteLine("Seleccione la terminal de arribo: ");
							for (int i = 0; i < ListaTerminales.Count; i++)
							{
								Console.WriteLine("{0}) " + ListaTerminales[i], i+1);
							}
							opcion = int.Parse(Console.ReadLine() );
							opcionArribocorrecta = true;
							TArribo = (Terminal)ListaTerminales[opcion-1];
							Console.Clear();
						}
						catch(ArgumentOutOfRangeException)
						{
							opcionArribocorrecta = false;
							Console.WriteLine("ingrese opcion entre 1-{0}. Presione una tecla para continuar...", ListaTerminales.Count);
							Console.ReadKey();
							Console.Clear();
						}
						catch(FormatException)
						{
							opcionArribocorrecta = false;
							Console.WriteLine("ingrese solo valores numericos comprendidos entre 1-{0}. Presione una tecla para continuar...", ListaTerminales.Count);
							Console.ReadKey();
							Console.Clear();
						}
					}
					
					
					if (TPartida == TArribo)
					{
						Console.WriteLine("La terminal de partida y arribo no deben ser las mismas. Presione una tecla para continuar...");
					}
					
					else
					{
						
						ArrayList RecorridosQueCoinciden = new ArrayList();
						ArrayList ContadorDeParadasIntermedias = new ArrayList();
						

						int posicionTPartida = 0;
						int posicionTArribo = 0;
						bool existeTPartida = false;
						bool existeTArribo = false;
						for (int i = 0; i < ListaViajesConfirmados.Count; i++)
						{
							
							AgendaRecorrido ViajeAComparar = (AgendaRecorrido)ListaViajesConfirmados[i];
							Recorrido recoAcomparar = ViajeAComparar.GetRecorrido();
							
							for (int j = 0; j < recoAcomparar.CantidadDeTerminales(); j++) 
							{
								if (TPartida == recoAcomparar.GetRecorrido(j)) 
								{
									existeTPartida = true;
									posicionTPartida = j;
									break;
								}
								
								
							}
							
							for (int k = 0; k < recoAcomparar.CantidadDeTerminales(); k++) 
							{
								if (TArribo == recoAcomparar.GetRecorrido(k)) 
								{
									existeTArribo = true;
									posicionTArribo = k;
									break;
								}
								
							}
							
							if (existeTPartida && existeTArribo)
							{
								if (posicionTPartida < posicionTArribo)
								{								
									int paradasintermedias = ( (posicionTArribo - (posicionTPartida+1)) );
									ContadorDeParadasIntermedias.Add(paradasintermedias);
									RecorridosQueCoinciden.Add(ViajeAComparar);
									posicionTPartida = 0;//100
									posicionTArribo = 0;//-1
								}
							}
							
						}
						
						
						if (RecorridosQueCoinciden.Count > 0)
						{
							
							bool itinerariocorrecto= false;
							Pasaje NuevoPasaje = null;
							int opcionitinerario = 0;
							while (! itinerariocorrecto) 
							{
								try
								{
									Console.WriteLine("Seleccione itinerario: ");
									for (int i = 0; i < RecorridosQueCoinciden.Count; i++)
									{
										Console.WriteLine("{0}) Saliendo de {1} y llegando a {2} ({3} paradas intermedias,{4})", i+1,TPartida, TArribo, ContadorDeParadasIntermedias[i],RecorridosQueCoinciden[i]);
									}
									opcionitinerario = int.Parse(Console.ReadLine());
									NuevoPasaje = new Pasaje(TPartida, TArribo, (int)ContadorDeParadasIntermedias[opcionitinerario-1], (AgendaRecorrido)RecorridosQueCoinciden[opcionitinerario-1]);
									itinerariocorrecto = true;
								}
								catch(ArgumentOutOfRangeException)
								{
									itinerariocorrecto = false;
									Console.WriteLine("la opcion solicitada del itinerario no existe.");
									Console.ReadKey();
									Console.Clear();
								}
								catch(FormatException)
								{
									itinerariocorrecto = false;
									Console.WriteLine("la opcion ingresa del itinerario debe ser entre 1-{0}.", RecorridosQueCoinciden.Count);
									Console.ReadKey();
									Console.Clear();
								}
							}
							
							Pasajes.Add(NuevoPasaje);
							
							Console.Clear();
							bool pasajessolicitados = false;
							int CantidadPasajes = 0;
							while (! pasajessolicitados) 
							{
								try
								{
									pasajessolicitados= true;
									Console.WriteLine("itinerario: {0}", Pasajes[opcionitinerario-1]);
									Console.WriteLine("¿Cuantos pasajes desea?");
									CantidadPasajes = int.Parse(Console.ReadLine() );
									if (CantidadPasajes <=0 ) 
									{
										throw new FormatException();
									}
									
								}
								catch(FormatException)
								{
									pasajessolicitados= false;
									Console.WriteLine("La cantidad solicitada debe ser un numero entero mayor a 0.");
									Console.ReadKey();
									Console.Clear();
								}
								
									
							}
							
							NuevoPasaje.PasajesTotales(CantidadPasajes);
							
							
							
							//GUARDO LAS ESTADISITICAS
							foreach (Usuario U in ListaUsuarios)
							{
								if (NumUsuario == U.GetNumUser() && DniUsuario == U.GetDNI() )
								{
									for (int i = 0; i < CantidadPasajes; i++) 
									{
										U.ComprarPasaje(NuevoPasaje);
									}
									
									break;
								}
								
							}
							
							foreach (Terminal T in ListaTerminales) 
							{
								if (TPartida == T) 
								{
									T.PasajesComoPartida(CantidadPasajes);
								}
							}
							
							foreach (Terminal T in ListaTerminales) 
							{
								if (TArribo == T) 
								{
									T.PasajesComoArribo(CantidadPasajes);
								}
							}
							Console.WriteLine("La venta se ha realizado con éxito. Presione una tecla para continuar...");
							
							
						}
						
						else
						{
							Console.WriteLine("No existe ningún recorrido con las terminales de partida y arribo solicitadas. Presione una tecla para continuar...");
						}
						
						
					}
					
					Console.ReadKey();
					Console.Clear();
					
				}
			}

		}
		
		
		static void OrdenarPasajesPartida(ArrayList ListaTerminales)
		{
		
			Terminal [] lista = new Terminal[ListaTerminales.Count];
			for (int i = 0; i < ListaTerminales.Count; i++) 
			{
				lista[i] = (Terminal )ListaTerminales[i];
			}
			int n = ListaTerminales.Count;
			bool ordenado = false;
			while (! ordenado)
			{
				
				ordenado = true;
				for (int j = 0; j < (n-1); j++)
				{
					if ( lista[j].GetPasajesVendidosComoPartida() <  lista[j+1].GetPasajesVendidosComoPartida() )
					{
						ordenado = false;
						Terminal cambiar = lista[j];
						lista[j] = lista[j+1];
						lista[j+1] = cambiar;
						
					}
				}
				
			}
			Console.WriteLine("Listado de terminales como partida:");
			foreach (Terminal element in lista) 
			{
				Console.WriteLine(element + " ({0})", element.GetPasajesVendidosComoPartida());
			}
			Console.WriteLine("Presione una tecla para continuar...");
			
		}
		
		static void OrdenarPasajesArribo(ArrayList ListaTerminales)
		{
			
			Terminal [] lista = new Terminal[ListaTerminales.Count];
			for (int i = 0; i < ListaTerminales.Count; i++) 
			{
				lista[i] = (Terminal )ListaTerminales[i];
			}
			int n = ListaTerminales.Count;
			bool ordenado = false;
			while (! ordenado)
			{
				
				ordenado = true;
				for (int j = 0; j < (n-1); j++)
				{
					if ( lista[j].GetPasajesVendidosComoArribo() <  lista[j+1].GetPasajesVendidosComoArribo() )
					{
						ordenado = false;
						Terminal cambiar = lista[j];
						lista[j] = lista[j+1];
						lista[j+1] = cambiar;
						
					}
				}
				
			}
			Console.WriteLine("Listado de terminales como arribo:");
			foreach (Terminal element in lista) 
			{
				Console.WriteLine(element + " ({0})", element.GetPasajesVendidosComoArribo());
			}
			Console.WriteLine("Presione una tecla para continuar...");
			
		}
		
		static void OrdenarUsuarios(ArrayList ListaUsuarios)
		{
			
			Usuario [] ListaOrdenada = new Usuario[ListaUsuarios.Count];
			for (int i = 0; i < ListaUsuarios.Count; i++) 
			{
				ListaOrdenada[i] = (Usuario)ListaUsuarios[i];
			}
			int n = ListaUsuarios.Count;
			bool ordenado = false;
			while (! ordenado)
			{
				
				ordenado = true;
				for (int j = 0; j < (n-1); j++)
				{
					if ( ListaOrdenada[j].GetPasajesComprados() <  ListaOrdenada[j+1].GetPasajesComprados() )
					{
						ordenado = false;
						Usuario cambiar = ListaOrdenada[j];
						ListaOrdenada[j] = ListaOrdenada[j+1];
						ListaOrdenada[j+1] = cambiar;
						
					}
				}
				
			}
			
			Console.WriteLine("Listado de ventas por usuario:");
			foreach (Usuario element in ListaOrdenada) 
			{
				Console.WriteLine(element + " ({0})", element.GetPasajesComprados());
			}
			Console.WriteLine("Presione una tecla para continuar...");
			
		}
	}
}