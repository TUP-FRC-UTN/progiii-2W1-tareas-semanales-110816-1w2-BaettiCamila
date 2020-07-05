using System;
using System.CodeDom;
using System.Collections.Generic;

public class AD_TipoDni
{
	public AD_TipoDni()
	{
	
	}

		public  static List<TipoDniViewModel> ObtenerListaTipoDni() {
			
			//Creo una lista de tipo de la clase model 
			List<TipoDniVM> listaDni = new List<TipoDniVM>();
			
			//creo una variable string y guardo la direccion de la bd
			string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"].ToString();

			//Creo un objeto sqlConnection y le mando el dato de la direccion anterior 
			SqlConnection conexion = new SqlConnection(cadenaConexion);

			//proba hacer esto
			try
			{
				//crea un comando sql
				SqlCommand comando = new SqlCommand();
				// Una variable string con la consulta
				string consulta = "SELECT * from TiposDocumentos";
				//por las dudas limpia los parametros
				comando.Parameters.Clear();

				//asignale tipo texto al comando
				comando.CommandType = System.Data.CommandType.Text;
				//Asignale la consulta al comando que ahora es de tipo texto 

				conexion.Open();
                comando.CommandText = consulta;

				SqlDataReader lector = comando.ExecuteReader();
				//si el lector no está vacio	
				if (lector != null){
					//mientas el lector devuelva filas
					while (lector.Read()) {
						//variable de tipo model tipoDni
						TipoDniVM aux = new TipoDniVM();
						//en el atributo del objeto auxiliar guarda lo que el lector lea en la bd
						aux.idTipoDocumento = int.Parse(lector["id"].ToString());
						aux.TipoDocumento = lector["Nombre"].ToString();

						//en la lista de tipo objetosModelDNI agrega el objeto que acabamos de cargar con los datos de la bd
						listaDni.Add(aux);
						}
					}
			}
			//si no salió lo anterior
			catch (Exception)
			{
				throw;
			}
			
			//si paso por try o por catch no importa, cerra la conexion igual
			finally {

				conexion.Close();
			}
			return listaDni;
		}
	}

