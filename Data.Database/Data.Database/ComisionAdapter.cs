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
    public class ComisionAdapter : Adapter
    {

        public List<Comision> GetAll()
        {
            List<Comision> comisiones = new List<Comision>();

            try
            {
                this.OpenConnection();

                SqlCommand cmdComisiones = new SqlCommand("SELECT * FROM comisiones", sqlConn);

                SqlDataReader drComisiones = cmdComisiones.ExecuteReader();

                while (drComisiones.Read())
                {
                    Comision com = new Comision();

                    com.ID = (int)drComisiones["id_comision"];
                    com.Descripcion = (string)drComisiones["desc_comision"];
                    com.AnioEspecialidad = (int)drComisiones["anio_especialidad"];
                    com.IDPlan = (int)drComisiones["id_plan"];

                    comisiones.Add(com);
                }

                drComisiones.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de comisiones", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }

            return comisiones;
        }

        public Business.Entities.Comision GetOne(int ID)
        {
            Comision com = new Comision();

            try
            {
                this.OpenConnection();

                SqlCommand cmdComision = new SqlCommand("SELECT * FROM comisiones WHERE id_comision=@id", sqlConn);
                cmdComision.Parameters.Add("@id", SqlDbType.Int).Value = ID;

                SqlDataReader drComisiones = cmdComision.ExecuteReader();

                if (drComisiones.Read())
                {
                    com.ID = (int)drComisiones["id_comision"];
                    com.Descripcion = (string)drComisiones["desc_comision"];
                    com.AnioEspecialidad = (int)drComisiones["anio_especialidad"];
                    com.IDPlan = (int)drComisiones["id_plan"];
                }

                drComisiones.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar datos de comision", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }

            return com;
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdDelete = new SqlCommand("DELETE comisiones WHERE id_comision=@id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteReader();
            }
            catch (Exception Ex)
            {
                ErrorEliminar miExp = new ErrorEliminar("No se puede eliminar la comision.", Ex);
                throw miExp;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Comision comision)
        {
            if (comision.State == BusinessEntity.States.Deleted)
            {
                this.Delete(comision.ID);
            }
            else if (comision.State == BusinessEntity.States.New)
            {
                this.Insert(comision);
            }
            else if (comision.State == BusinessEntity.States.Modified)
            {
                this.Update(comision);
            }
            comision.State = BusinessEntity.States.Unmodified;
        }

        protected void Insert(Comision comision)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdSave = new SqlCommand("INSERT INTO comisiones(desc_comision,anio_especialidad,id_plan) " +
                    "VALUES(@desc_comision,@anio_especialidad,@id_plan) " +
                    "SELECT @@identity", //esta linea es para recuperar el ID que asignó el SQL automaticamente
                    sqlConn);

                cmdSave.Parameters.Add("@desc_comision", SqlDbType.VarChar, 50).Value = comision.Descripcion;
                cmdSave.Parameters.Add("@anio_especialidad", SqlDbType.Int).Value = comision.AnioEspecialidad;
                cmdSave.Parameters.Add("@id_plan", SqlDbType.Int).Value = comision.IDPlan;
                comision.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar()); // asi se obtiene el ID que asigno al BD automaticamente
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
                Exception ExcepcionManejada = new Exception("Error al crear comision", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Update(Comision comision)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdSave = new SqlCommand("UPDATE comisiones SET desc_comision=@desc_comision, anio_especialidad=@anio_especialidad, " +
                    "id_plan=@id_plan " + "WHERE id_comision=@id_comision", sqlConn);

                cmdSave.Parameters.Add("@id_comision", SqlDbType.Int).Value = comision.ID;
                cmdSave.Parameters.Add("@desc_comision", SqlDbType.VarChar, 50).Value = comision.Descripcion;
                cmdSave.Parameters.Add("@anio_especialidad", SqlDbType.Int).Value = comision.AnioEspecialidad;
                cmdSave.Parameters.Add("@id_plan", SqlDbType.Int).Value = comision.IDPlan;
                cmdSave.ExecuteReader();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos de la comision", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
    }
}