using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace CapaDatos
{
    public class CD_Clientes
    {
        //Constructores
        public CD_Clientes()
        {

        }

        // ==================================================
        //  Permite devolver todos los clientes activos de la BD
        // ==================================================
        private CD_Conexion conexion = new CD_Conexion();
        MySqlDataReader leer;
        DataTable tabla = new DataTable();
        MySqlCommand comando = new MySqlCommand();

        public DataSet ListarClientesPaginado(int desde)
        {
            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "bsp_listar_clientes";

            MySqlParameter pDesde = new MySqlParameter();
            pDesde.ParameterName = "@pDesde";
            pDesde.MySqlDbType = MySqlDbType.Int32;
            pDesde.Value = desde;
            comando.Parameters.Add(pDesde);

            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            DataSet ds = new DataSet();
            da.Fill(ds);

            comando.Parameters.Clear();

            conexion.CerrarConexion();

            return ds;

        }

        public DataSet dameHistoricoClientePaginado(int IdCliente,int desde)
        {
            string ds = "";
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "bsp_historico_cliente";

            MySqlParameter pIdCliente = new MySqlParameter();
            pIdCliente.ParameterName = "@pIdCliente";
            pIdCliente.MySqlDbType = MySqlDbType.Int32;
            pIdCliente.Value = IdCliente;
            comando.Parameters.Add(pIdCliente);

            MySqlParameter pDesde = new MySqlParameter();
            pDesde.ParameterName = "@pDesde";
            pDesde.MySqlDbType = MySqlDbType.Int32;
            pDesde.Value = desde;
            comando.Parameters.Add(pDesde);

            try
            {

                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                DataSet ds1 = new DataSet();
                da.Fill(ds1);

                comando.Parameters.Clear();

                conexion.CerrarConexion();

                return ds1;

            }
            catch (Exception ex)
            {
                ds = ex.Message;
            }
            finally
            {
                conexion.CerrarConexion();
            }
            return null;

        }

        public DataTable dameTrabajo(int IdTrabajo)
        {
            DataTable tabla1 = new DataTable();
            try
            {
                comando.Parameters.Clear();
                comando.Connection = conexion.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "bsp_dame_trabajo";

                MySqlParameter pIdTrabajo = new MySqlParameter();
                pIdTrabajo.ParameterName = "@pIdTrabajo";
                pIdTrabajo.MySqlDbType = MySqlDbType.Int64;
                pIdTrabajo.Value = IdTrabajo;
                comando.Parameters.Add(pIdTrabajo);

                leer = comando.ExecuteReader();
                tabla1.Load(leer);

                comando.Parameters.Clear();
                conexion.CerrarConexion();

                return tabla1;
            }
            catch(Exception e)
            {
                return null;
            }
            

        }
        // devuelve solo 1 cliente de la BD
        public DataTable MostrarCliente(int IdCliente)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "bsp_dame_cliente";

            MySqlParameter pIdCliente = new MySqlParameter();
            pIdCliente.ParameterName = "@pIdCliente";
            pIdCliente.MySqlDbType = MySqlDbType.Int32;
            // pIdProducto.Size = 60;
            pIdCliente.Value = IdCliente;
            comando.Parameters.Add(pIdCliente);

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            
            comando.Parameters.Clear();
            conexion.CerrarConexion();

            return tabla;

        }

        public string Editar(int IdCliente,string Apellidos, string Nombres, string Telefono, string Marca, string Patente, string Correo,
            string Direccion, string Modelo, string Observaciones)
        {
            string rpta = "";
            comando.Parameters.Clear();
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "bsp_editar_cliente";

                MySqlParameter pIdCliente = new MySqlParameter();
                pIdCliente.ParameterName = "@pIdCliente";
                pIdCliente.MySqlDbType = MySqlDbType.Int32;
                pIdCliente.Value = IdCliente;
                comando.Parameters.Add(pIdCliente);

                MySqlParameter pApellidos = new MySqlParameter();
                pApellidos.ParameterName = "@pApellidos";
                pApellidos.MySqlDbType = MySqlDbType.VarChar;
                pApellidos.Size = 60;
                pApellidos.Value = Apellidos;
                comando.Parameters.Add(pApellidos);

                MySqlParameter pNombres = new MySqlParameter();
                pNombres.ParameterName = "@pNombres";
                pNombres.MySqlDbType = MySqlDbType.VarChar;
                pNombres.Size = 60;
                pNombres.Value = Nombres;
                comando.Parameters.Add(pNombres);

                MySqlParameter pMarca = new MySqlParameter();
                pMarca.ParameterName = "@pMarca";
                pMarca.MySqlDbType = MySqlDbType.VarChar;
                pMarca.Size = 45;
                pMarca.Value = Marca;
                comando.Parameters.Add(pMarca);

                MySqlParameter pPatente = new MySqlParameter();
                pPatente.ParameterName = "@pPatente";
                pPatente.MySqlDbType = MySqlDbType.VarChar;
                pPatente.Size = 60;
                pPatente.Value = Patente;
                comando.Parameters.Add(pPatente);

                MySqlParameter pDireccion = new MySqlParameter();
                pDireccion.ParameterName = "@pDireccion";
                pDireccion.MySqlDbType = MySqlDbType.VarChar;
                pDireccion.Size = 250;
                pDireccion.Value = Direccion;
                comando.Parameters.Add(pDireccion);

                MySqlParameter pCorreo = new MySqlParameter();
                pCorreo.ParameterName = "@pCorreo";
                pCorreo.MySqlDbType = MySqlDbType.VarChar;
                pCorreo.Size = 60;
                pCorreo.Value = Correo;
                comando.Parameters.Add(pCorreo);

                MySqlParameter pTelefono = new MySqlParameter();
                pTelefono.ParameterName = "@pTelefono";
                pTelefono.MySqlDbType = MySqlDbType.VarChar;
                pTelefono.Size = 15;
                pTelefono.Value = Telefono;
                comando.Parameters.Add(pTelefono);

                MySqlParameter pModelo = new MySqlParameter();
                pModelo.ParameterName = "@pModelo";
                pModelo.MySqlDbType = MySqlDbType.VarChar;
                pModelo.Size = 60;
                pModelo.Value = Modelo;
                comando.Parameters.Add(pModelo);

                MySqlParameter pObservaciones = new MySqlParameter();
                pObservaciones.ParameterName = "@pObservaciones";
                pObservaciones.MySqlDbType = MySqlDbType.VarChar;
                pObservaciones.Size = 250;
                pObservaciones.Value = Observaciones;
                comando.Parameters.Add(pObservaciones);

                rpta = comando.ExecuteScalar().ToString();


            }
            catch (Exception ex)
            {

                rpta = ex.Message;
            }
            finally
            {
                conexion.CerrarConexion();
            }
            comando.Parameters.Clear();
            return rpta;
        }

        //Métodos
        //Insertar
        public string Insertar(string Apellidos,string Nombres,string Telefono,string Marca,string Patente,string Correo,
            string Direccion,string Modelo,string Observaciones)
        {
            string rpta = "";
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "bsp_alta_cliente";

                MySqlParameter pApellidos = new MySqlParameter();
                pApellidos.ParameterName = "@pApellidos";
                pApellidos.MySqlDbType = MySqlDbType.VarChar;
                pApellidos.Size = 60;
                pApellidos.Value = Apellidos;
                comando.Parameters.Add(pApellidos);

                MySqlParameter pNombres = new MySqlParameter();
                pNombres.ParameterName = "@pNombres";
                pNombres.MySqlDbType = MySqlDbType.VarChar;
                pNombres.Size = 60;
                pNombres.Value = Nombres;
                comando.Parameters.Add(pNombres);                                

                MySqlParameter pMarca = new MySqlParameter();
                pMarca.ParameterName = "@pMarca";
                pMarca.MySqlDbType = MySqlDbType.VarChar;
                pMarca.Size = 45;
                pMarca.Value = Marca;
                comando.Parameters.Add(pMarca);

                MySqlParameter pPatente = new MySqlParameter();
                pPatente.ParameterName = "@pPatente";
                pPatente.MySqlDbType = MySqlDbType.VarChar;
                pPatente.Size = 250;
                pPatente.Value = Patente;
                comando.Parameters.Add(pPatente);

                MySqlParameter pDireccion = new MySqlParameter();
                pDireccion.ParameterName = "@pDireccion";
                pDireccion.MySqlDbType = MySqlDbType.VarChar;
                pDireccion.Size = 250;
                pDireccion.Value = Direccion;
                comando.Parameters.Add(pDireccion);

                MySqlParameter pCorreo = new MySqlParameter();
                pCorreo.ParameterName = "@pCorreo";
                pCorreo.MySqlDbType = MySqlDbType.VarChar;
                pCorreo.Size = 60;
                pCorreo.Value = Correo;
                comando.Parameters.Add(pCorreo);

                MySqlParameter pTelefono = new MySqlParameter();
                pTelefono.ParameterName = "@pTelefono";
                pTelefono.MySqlDbType = MySqlDbType.VarChar;
                pTelefono.Size = 60;
                pTelefono.Value = Telefono;
                comando.Parameters.Add(pTelefono);

                MySqlParameter pModelo = new MySqlParameter();
                pModelo.ParameterName = "@pModelo";
                pModelo.MySqlDbType = MySqlDbType.VarChar;
                pModelo.Size = 60;
                pModelo.Value = Modelo;
                comando.Parameters.Add(pModelo);

                MySqlParameter pObservaciones = new MySqlParameter();
                pObservaciones.ParameterName = "@pObservaciones";
                pObservaciones.MySqlDbType = MySqlDbType.VarChar;
                pObservaciones.Size = 250;
                pObservaciones.Value = Observaciones;
                comando.Parameters.Add(pObservaciones);

                //rpta = comando.ExecuteScalar().ToString();

                
                var reader = comando.ExecuteReader();

                

                while (reader.Read())
                {
                    if(Convert.ToString(reader[0]) == "Ok")
                    {
                        rpta = "Ok";
                    }
                    else
                    {
                        rpta = "Ocurrio un problema, contactese con el administrador";
                    }
                    
                }
                reader.Close();


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                conexion.CerrarConexion();
            }
            return rpta;

        }

        // Metodo ELIMINAR Empleado (da de baja)
        public string EliminarCliente(int IdCliente)
        {
            string rpta = "";
            try
            {

                comando.Connection = conexion.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "bsp_baja_cliente";

                MySqlParameter pIdCliente = new MySqlParameter();
                pIdCliente.ParameterName = "@pIdCliente";
                pIdCliente.MySqlDbType = MySqlDbType.Int32;
                pIdCliente.Value = IdCliente;
                comando.Parameters.Add(pIdCliente);

                rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "NO se Elimino el Registro";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                conexion.CerrarConexion();
            }
            return rpta;
        }

        public string EliminarTrabajo(int IdTrabajo)
        {
            string rpta = "";
            try
            {

                comando.Connection = conexion.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "bsp_baja_trabajo";

                MySqlParameter pIdTrabajo = new MySqlParameter();
                pIdTrabajo.ParameterName = "@pIdTrabajo";
                pIdTrabajo.MySqlDbType = MySqlDbType.Int32;
                pIdTrabajo.Value = IdTrabajo;
                comando.Parameters.Add(pIdTrabajo);

                rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "NO se Elimino el Registro";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                conexion.CerrarConexion();
            }
            return rpta;
        }

        public DataTable BuscarPatente(string patente)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "bsp_buscar_cliente_patente";

                MySqlParameter pPatente = new MySqlParameter();
                pPatente.ParameterName = "@pPatente";
                pPatente.MySqlDbType = MySqlDbType.VarChar;
                pPatente.Size = 30;
                pPatente.Value = patente;
                comando.Parameters.Add(pPatente);

                leer = comando.ExecuteReader();
                tabla.Load(leer);
                comando.Parameters.Clear();
                conexion.CerrarConexion();

                // return tabla;
            }
            catch (Exception ex)
            {
                tabla = null;
            }
            return tabla;

        }

        public DataTable BuscarCliente(string apellidos,string nombres)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "bsp_buscar_cliente_apellidos_nombres";

                MySqlParameter pApellidos = new MySqlParameter();
                pApellidos.ParameterName = "@pApellidos";
                pApellidos.MySqlDbType = MySqlDbType.VarChar;
                pApellidos.Size = 45;
                pApellidos.Value = apellidos;
                comando.Parameters.Add(pApellidos);

                MySqlParameter pNombres = new MySqlParameter();
                pNombres.ParameterName = "@pNombres";
                pNombres.MySqlDbType = MySqlDbType.VarChar;
                pNombres.Size = 45;
                pNombres.Value = nombres;
                comando.Parameters.Add(pNombres);

                leer = comando.ExecuteReader();
                tabla.Load(leer);
                comando.Parameters.Clear();
                conexion.CerrarConexion();

                // return tabla;
            }
            catch (Exception ex)
            {
                tabla = null;
            }
            return tabla;

        }

        public string NuevoTrabajo(int IdCliente, string Aceite, string FiltroAceite, string FiltroAire, string CorreaDist,
            string Alternador, string TensorDist, string BombaAgua, string PastillaFreno, string CambioRef,
            string CambioBujia, string cableBujia, string CambioComb,
            string CambioAA, string Kilometros,string Fecha,string Observaciones)
        {
            string rpta = "";
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "bsp_alta_trabajo";

                MySqlParameter pIdCliente = new MySqlParameter();
                pIdCliente.ParameterName = "@pIdCliente";
                pIdCliente .MySqlDbType = MySqlDbType.Int32;
                pIdCliente.Value = IdCliente;
                comando.Parameters.Add(pIdCliente);

                MySqlParameter pAceite = new MySqlParameter();
                pAceite.ParameterName = "@pAceite";
                pAceite.MySqlDbType = MySqlDbType.VarChar;
                pAceite.Size = 250;
                pAceite.Value = Aceite;
                comando.Parameters.Add(pAceite);

                MySqlParameter pFiltroAceite = new MySqlParameter();
                pFiltroAceite.ParameterName = "@pFiltroAceite";
                pFiltroAceite.MySqlDbType = MySqlDbType.VarChar;
                pFiltroAceite.Size = 250;
                pFiltroAceite.Value = FiltroAceite;
                comando.Parameters.Add(pFiltroAceite);

                MySqlParameter pFiltroAire = new MySqlParameter();
                pFiltroAire.ParameterName = "@pFiltroAire";
                pFiltroAire.MySqlDbType = MySqlDbType.VarChar;
                pFiltroAire.Size = 250;
                pFiltroAire.Value = FiltroAire;
                comando.Parameters.Add(pFiltroAire);

                MySqlParameter pCorreaDist = new MySqlParameter();
                pCorreaDist.ParameterName = "@pCorreaDist";
                pCorreaDist.MySqlDbType = MySqlDbType.VarChar;
                pCorreaDist.Size = 1;
                pCorreaDist.Value = CorreaDist;
                comando.Parameters.Add(pCorreaDist);

                MySqlParameter pAlternador = new MySqlParameter();
                pAlternador.ParameterName = "@pAlternador";
                pAlternador.MySqlDbType = MySqlDbType.VarChar;
                pAlternador.Size = 1;
                pAlternador.Value = Alternador;
                comando.Parameters.Add(pAlternador);

                MySqlParameter pTensorDist = new MySqlParameter();
                pTensorDist.ParameterName = "@pTensorDist";
                pTensorDist.MySqlDbType = MySqlDbType.VarChar;
                pTensorDist.Size = 1;
                pTensorDist.Value = TensorDist;
                comando.Parameters.Add(pTensorDist);

                MySqlParameter pBombaAgua = new MySqlParameter();
                pBombaAgua.ParameterName = "@pBombaAgua";
                pBombaAgua.MySqlDbType = MySqlDbType.VarChar;
                pBombaAgua.Size = 1;
                pBombaAgua.Value = BombaAgua;
                comando.Parameters.Add(pBombaAgua);

                MySqlParameter pPastillaFreno = new MySqlParameter();
                pPastillaFreno.ParameterName = "@pPastillaFreno";
                pPastillaFreno.MySqlDbType = MySqlDbType.VarChar;
                pPastillaFreno.Size = 1;
                pPastillaFreno.Value = PastillaFreno;
                comando.Parameters.Add(pPastillaFreno);

                MySqlParameter pCambioRef = new MySqlParameter();
                pCambioRef.ParameterName = "@pCambioRef";
                pCambioRef.MySqlDbType = MySqlDbType.VarChar;
                pCambioRef.Size = 1;
                pCambioRef.Value = CambioRef;
                comando.Parameters.Add(pCambioRef);

                MySqlParameter pCambioBujia = new MySqlParameter();
                pCambioBujia.ParameterName = "@pCambioBujia";
                pCambioBujia.MySqlDbType = MySqlDbType.VarChar;
                pCambioBujia.Size = 250;
                pCambioBujia.Value = CambioBujia;
                comando.Parameters.Add(pCambioBujia);

                MySqlParameter pCableBujia = new MySqlParameter();
                pCableBujia.ParameterName = "@pCableBujia";
                pCableBujia.MySqlDbType = MySqlDbType.VarChar;
                pCableBujia.Size = 250;
                pCableBujia.Value = cableBujia;
                comando.Parameters.Add(pCableBujia);

                MySqlParameter pCambioComb = new MySqlParameter();
                pCambioComb.ParameterName = "@pCambioComb";
                pCambioComb.MySqlDbType = MySqlDbType.VarChar;
                pCambioComb.Size = 250;
                pCambioComb.Value = CambioComb;
                comando.Parameters.Add(pCambioComb);

                MySqlParameter pCambioAA = new MySqlParameter();
                pCambioAA.ParameterName = "@pCambioAA";
                pCambioAA.MySqlDbType = MySqlDbType.VarChar;
                pCambioAA.Size = 250;
                pCambioAA.Value = CambioAA;
                comando.Parameters.Add(pCambioAA);

                MySqlParameter pKilometros = new MySqlParameter();
                pKilometros.ParameterName = "@pKilometros";
                pKilometros.MySqlDbType = MySqlDbType.VarChar;
                pKilometros.Size = 45;
                pKilometros.Value = Kilometros;
                comando.Parameters.Add(pKilometros);

                MySqlParameter pFecha = new MySqlParameter();
                pFecha.ParameterName = "@pFecha";
                pFecha.MySqlDbType = MySqlDbType.VarChar;
                pFecha.Size = 60;
                pFecha.Value = Fecha;
                comando.Parameters.Add(pFecha);

                MySqlParameter pObservaciones = new MySqlParameter();
                pObservaciones.ParameterName = "@pObservaciones";
                pObservaciones.MySqlDbType = MySqlDbType.VarChar;
                pObservaciones.Size = 250;
                pObservaciones.Value = Observaciones;
                comando.Parameters.Add(pObservaciones);

                rpta = comando.ExecuteScalar().ToString();

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                conexion.CerrarConexion();
            }
            return rpta;

        }

        public string EditarTrabajo(int IdTrabajo, string Aceite, string FiltroAceite, string FiltroAire, string CorreaDist,
            string Alternador, string TensorDist, string BombaAgua, string PastillaFreno, string CambioRef,
            string CambioBujia, string cableBujia, string CambioComb,
            string CambioAA, string Kilometros,string Fecha, string Observaciones)
        {
            string rpta = "";
            comando.Parameters.Clear();
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "bsp_editar_trabajo";

                MySqlParameter pIdTrabajo = new MySqlParameter();
                pIdTrabajo.ParameterName = "@pIdTrabajo";
                pIdTrabajo.MySqlDbType = MySqlDbType.Int32;
                pIdTrabajo.Value = IdTrabajo;
                comando.Parameters.Add(pIdTrabajo);

                MySqlParameter pAceite = new MySqlParameter();
                pAceite.ParameterName = "@pAceite";
                pAceite.MySqlDbType = MySqlDbType.VarChar;
                pAceite.Size = 250;
                pAceite.Value = Aceite;
                comando.Parameters.Add(pAceite);

                MySqlParameter pFiltroAceite = new MySqlParameter();
                pFiltroAceite.ParameterName = "@pFiltroAceite";
                pFiltroAceite.MySqlDbType = MySqlDbType.VarChar;
                pFiltroAceite.Size = 250;
                pFiltroAceite.Value = FiltroAceite;
                comando.Parameters.Add(pFiltroAceite);

                MySqlParameter pFiltroAire = new MySqlParameter();
                pFiltroAire.ParameterName = "@pFiltroAire";
                pFiltroAire.MySqlDbType = MySqlDbType.VarChar;
                pFiltroAire.Size = 250;
                pFiltroAire.Value = FiltroAire;
                comando.Parameters.Add(pFiltroAire);

                MySqlParameter pCorreaDist = new MySqlParameter();
                pCorreaDist.ParameterName = "@pCorreaDist";
                pCorreaDist.MySqlDbType = MySqlDbType.VarChar;
                pCorreaDist.Size = 1;
                pCorreaDist.Value = CorreaDist;
                comando.Parameters.Add(pCorreaDist);

                MySqlParameter pAlternador = new MySqlParameter();
                pAlternador.ParameterName = "@pAlternador";
                pAlternador.MySqlDbType = MySqlDbType.VarChar;
                pAlternador.Size = 1;
                pAlternador.Value = Alternador;
                comando.Parameters.Add(pAlternador);

                MySqlParameter pTensorDist = new MySqlParameter();
                pTensorDist.ParameterName = "@pTensorDist";
                pTensorDist.MySqlDbType = MySqlDbType.VarChar;
                pTensorDist.Size = 1;
                pTensorDist.Value = TensorDist;
                comando.Parameters.Add(pTensorDist);

                MySqlParameter pBombaAgua = new MySqlParameter();
                pBombaAgua.ParameterName = "@pBombaAgua";
                pBombaAgua.MySqlDbType = MySqlDbType.VarChar;
                pBombaAgua.Size = 1;
                pBombaAgua.Value = BombaAgua;
                comando.Parameters.Add(pBombaAgua);

                MySqlParameter pPastillaFreno = new MySqlParameter();
                pPastillaFreno.ParameterName = "@pPastillaFreno";
                pPastillaFreno.MySqlDbType = MySqlDbType.VarChar;
                pPastillaFreno.Size = 1;
                pPastillaFreno.Value = PastillaFreno;
                comando.Parameters.Add(pPastillaFreno);

                MySqlParameter pCambioRef = new MySqlParameter();
                pCambioRef.ParameterName = "@pCambioRef";
                pCambioRef.MySqlDbType = MySqlDbType.VarChar;
                pCambioRef.Size = 1;
                pCambioRef.Value = CambioRef;
                comando.Parameters.Add(pCambioRef);

                MySqlParameter pCambioBujia = new MySqlParameter();
                pCambioBujia.ParameterName = "@pCambioBujia";
                pCambioBujia.MySqlDbType = MySqlDbType.VarChar;
                pCambioBujia.Size = 250;
                pCambioBujia.Value = CambioBujia;
                comando.Parameters.Add(pCambioBujia);

                MySqlParameter pCableBujia = new MySqlParameter();
                pCableBujia.ParameterName = "@pCableBujia";
                pCableBujia.MySqlDbType = MySqlDbType.VarChar;
                pCableBujia.Size = 250;
                pCableBujia.Value = cableBujia;
                comando.Parameters.Add(pCableBujia);

                MySqlParameter pCambioComb = new MySqlParameter();
                pCambioComb.ParameterName = "@pCambioComb";
                pCambioComb.MySqlDbType = MySqlDbType.VarChar;
                pCambioComb.Size = 250;
                pCambioComb.Value = CambioComb;
                comando.Parameters.Add(pCambioComb);

                MySqlParameter pCambioAA = new MySqlParameter();
                pCambioAA.ParameterName = "@pCambioAA";
                pCambioAA.MySqlDbType = MySqlDbType.VarChar;
                pCambioAA.Size = 250;
                pCambioAA.Value = CambioAA;
                comando.Parameters.Add(pCambioAA);

                MySqlParameter pKilometros = new MySqlParameter();
                pKilometros.ParameterName = "@pKilometros";
                pKilometros.MySqlDbType = MySqlDbType.VarChar;
                pKilometros.Size = 45;
                pKilometros.Value = Kilometros;
                comando.Parameters.Add(pKilometros);

                MySqlParameter pFecha = new MySqlParameter();
                pFecha.ParameterName = "@pFecha";
                pFecha.MySqlDbType = MySqlDbType.VarChar;
                pFecha.Size = 60;
                pFecha.Value = Fecha;
                comando.Parameters.Add(pFecha);

                MySqlParameter pObservaciones = new MySqlParameter();
                pObservaciones.ParameterName = "@pObservaciones";
                pObservaciones.MySqlDbType = MySqlDbType.VarChar;
                pObservaciones.Size = 250;
                pObservaciones.Value = Observaciones;
                comando.Parameters.Add(pObservaciones);

                rpta = comando.ExecuteScalar().ToString();

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                conexion.CerrarConexion();
            }
            return rpta;
        }

    }
}
