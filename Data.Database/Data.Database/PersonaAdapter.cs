using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class PersonaAdapter:Adapter
    {
        public List<Personas> GetAll()
        {
            List<Personas> personas = new List<Personas>();

            try
            {
                this.OpenConnection();

                SqlCommand cmdPersona = new SqlCommand("SELECT * FROM personas", sqlConn);

                SqlDataReader drPersonas = cmdPersona.ExecuteReader();

                while (drPersonas.Read())
                {
                    Personas per = new Personas();

                    per.ID = (int)drPersonas["id_persona"];
                    per.Nombre = (string)drPersonas["nombre"];
                    per.Apellido = (string)drPersonas["apellido"];
                    per.Direccion = (string)drPersonas["direccion"];
                    per.Email = (string)drPersonas["email"];
                    per.Telefono = (string)drPersonas["telefono"];
                    per.FechaNacimiento = (DateTime)drPersonas["fecha_nac"];
                    per.Legajo = (int)drPersonas["legajo"];
                 /* Personas.TiposPersonas tipo = (Personas.TiposPersonas)Enum.Parse(typeof(Personas.TiposPersonas), Convert.ToString((int)drPersonas["tipo_persona"]));
                    per.TipoPersona = tipo;
                 */ per.IDPlan = (int)drPersonas["id_plan"];

                    personas.Add(per);
                }

                drPersonas.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de personas", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }

            return personas;
        }

        public Personas GetOne(int ID)
        {
            Personas per = new Personas();

            try
            {
                this.OpenConnection();

                SqlCommand cmdPersona = new SqlCommand("SELECT * FROM personas WHERE id_persona=@id", sqlConn);
                cmdPersona.Parameters.Add("@id", SqlDbType.Int).Value = ID;

                SqlDataReader drPersonas = cmdPersona.ExecuteReader();

                if (drPersonas.Read())
                {
                    per.ID = (int)drPersonas["id_persona"];
                    per.Nombre = (string)drPersonas["nombre"];
                    per.Apellido = (string)drPersonas["apellido"];
                    per.Direccion = (string)drPersonas["direccion"];
                    per.Email = (string)drPersonas["email"];
                    per.Telefono = (string)drPersonas["telefono"];
                    per.FechaNacimiento = (DateTime)drPersonas["fecha_nac"];
                    per.Legajo = (int)drPersonas["legajo"];
                  //  Personas.TiposPersonas tipo = (Personas.TiposPersonas)Enum.Parse(typeof(Personas.TiposPersonas), Convert.ToString((int)drPersonas["tipo_persona"]));
                  //  per.TipoPersona = tipo;
                    per.IDPlan = (int)drPersonas["id_plan"];
                }

                drPersonas.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar datos de la persona", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }

            return per;
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdDelete = new SqlCommand("DELETE personas WHERE id_persona=@id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteReader();
            }
            catch (Exception Ex)
            {
                // ErrorEliminar miExp = new ErrorEliminar("No se puede eliminar la persona.", Ex);
                // throw miExp;
                throw Ex;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Update(Personas per)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdSave = new SqlCommand("UPDATE personas SET nombre=@nombre, apellido=@apellido, direccion=@direccion, email=@email, telefono=@telefono, fecha_nac=@fecha_nac, legajo=@legajo, tipo_persona=@tipo_persona, id_plan=@id_plan "
                + "WHERE id_persona=@id_persona", sqlConn);

                cmdSave.Parameters.Add("@id_persona", SqlDbType.Int).Value = per.ID;
                cmdSave.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = per.Nombre;
                cmdSave.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = per.Apellido;
                cmdSave.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = per.Direccion;
                cmdSave.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = per.Email;
                cmdSave.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = per.Telefono;
                cmdSave.Parameters.Add("@fecha_nac", SqlDbType.DateTime).Value = per.FechaNacimiento;
                cmdSave.Parameters.Add("id_plan", SqlDbType.Int).Value = per.IDPlan;
                cmdSave.Parameters.Add("legajo", SqlDbType.Int).Value = per.Legajo;
              //  cmdSave.Parameters.Add("tipo_persona", SqlDbType.Int).Value = per.TipoPersona;
                cmdSave.ExecuteReader();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos de la persona", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert(Personas per)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdSave = new SqlCommand("INSERT INTO personas(nombre,apellido,direccion,email,telefono,fecha_nac,legajo,tipo_persona,id_plan)"
                    + " VALUES(@nombre,@apellido,@direccion,@email,@telefono,@fecha_nac,@legajo,@tipo_persona,@id_plan) " +
                    "SELECT @@identity", sqlConn);

                cmdSave.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = per.Nombre;
                cmdSave.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = per.Apellido;
                cmdSave.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = per.Direccion;
                cmdSave.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = per.Email;
                cmdSave.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = per.Telefono;
                cmdSave.Parameters.Add("@fecha_nac", SqlDbType.DateTime).Value = per.FechaNacimiento;
                cmdSave.Parameters.Add("id_plan", SqlDbType.Int).Value = per.IDPlan;
                cmdSave.Parameters.Add("legajo", SqlDbType.Int).Value = per.Legajo;
              //  cmdSave.Parameters.Add("tipo_persona", SqlDbType.Int).Value = per.TipoPersona;
                per.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar()); // asi se obtiene el ID que asigno al BD automaticamente
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
                Exception ExcepcionManejada = new Exception("Error al crear persona", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Personas per)
        {
            if (per.State == BusinessEntity.States.Deleted)
            {
                this.Delete(per.ID);
            }
            else if (per.State == BusinessEntity.States.New)
            {
                this.Insert(per);
            }
            else if (per.State == BusinessEntity.States.Modified)
            {
                this.Update(per);
            }
            per.State = BusinessEntity.States.Unmodified;
        }

        public List<Personas> GetAllPorApeNom()
        {
            List<Personas> personas = new List<Personas>();

            try
            {
                this.OpenConnection();

                SqlCommand cmdPersona = new SqlCommand("SELECT id_persona, nombre+' '+apellido AS apenom FROM personas", sqlConn);

                SqlDataReader drPersonas = cmdPersona.ExecuteReader();

                while (drPersonas.Read())
                {
                    Personas per = new Personas();

                    per.ID = (int)drPersonas["id_persona"];
                    per.Nombre = (string)drPersonas["apenom"];

                    personas.Add(per);
                }

                drPersonas.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de personas", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }

            return personas;
        }

        public List<Personas> GetAllAlumnos()
        {
            List<Personas> personas = new List<Personas>();

            try
            {
                this.OpenConnection();

                SqlCommand cmdPersona = new SqlCommand("SELECT id_persona, nombre+' '+apellido AS apenom FROM personas WHERE tipo_persona=2", sqlConn);

                SqlDataReader drPersonas = cmdPersona.ExecuteReader();

                while (drPersonas.Read())
                {
                    Personas per = new Personas();

                    per.ID = (int)drPersonas["id_persona"];
                    per.Nombre = (string)drPersonas["apenom"];

                    personas.Add(per);
                }

                drPersonas.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de alumnos", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }

            return personas;
        }

        public List<Personas> GetAllDocentes()
        {
            List<Personas> personas = new List<Personas>();

            try
            {
                this.OpenConnection();

                SqlCommand cmdPersona = new SqlCommand("SELECT id_persona, nombre+' '+apellido AS apenom FROM personas WHERE tipo_persona=1", sqlConn);

                SqlDataReader drPersonas = cmdPersona.ExecuteReader();

                while (drPersonas.Read())
                {
                    Personas per = new Personas();

                    per.ID = (int)drPersonas["id_persona"];
                    per.Nombre = (string)drPersonas["apenom"];

                    personas.Add(per);
                }

                drPersonas.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de alumnos", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }

            return personas;
        }
    }
}
