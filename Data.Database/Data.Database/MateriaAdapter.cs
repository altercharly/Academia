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
    public class MateriaAdapter : Adapter
    {
        public List<Materia> GetAll()
        {
            List<Materia> materias = new List<Materia>();

            try
            {
                this.OpenConnection();

                SqlCommand cmdMaterias = new SqlCommand("SELECT * FROM materias", sqlConn);

                SqlDataReader drMaterias = cmdMaterias.ExecuteReader();

                while (drMaterias.Read())
                {
                    Materia mat = new Materia();

                    mat.ID = (int)drMaterias["id_materia"];
                    mat.Descripcion = (string)drMaterias["descripcion"];
                    mat.HSSemanales = (int)drMaterias["HS Semanales"];
                    mat.HSTotales = (int)drMaterias["HS Totales"];
                    mat.IDPlan = (int)drMaterias["id_plan"];

                    materias.Add(mat);
                }

                drMaterias.Close();
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

            return materias;
        }

        public Materia GetOne(int ID)
        {
            Materia mat = new Materia();

            try
            {
                this.OpenConnection();

                SqlCommand cmdMaterias = new SqlCommand("SELECT * FROM materia WHERE id_materia=@id", sqlConn);
                cmdMaterias.Parameters.Add("@id", SqlDbType.Int).Value = ID;

                SqlDataReader drMateria = cmdMaterias.ExecuteReader();

                if (drMateria.Read())
                {
                    mat.ID = (int)drMateria["id_materia"];
                    mat.Descripcion = (string)drMateria["descripcion"];
                    mat.HSSemanales = (int)drMateria["HS Semanales"];
                    mat.HSTotales = (int)drMateria["HS Totales"];
                    mat.IDPlan = (int)drMateria["id_plan"];


                }

                drMateria.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar datos de la materia", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }

            return mat;
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdDelete = new SqlCommand("DELETE materia WHERE id_materia=@id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteReader();
            }
            catch (Exception Ex)
            {
                // ErrorEliminar miExp = new ErrorEliminar("No se puede eliminar la materia.", Ex);
                // throw miExp;
                throw Ex;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Update(Materia mat)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdSave = new SqlCommand("UPDATE materia SET descripcion=@descripcion, HSSemanales=@HSSemanales, HSTotales=@dHSTotales, IDPlan=@IDPlan"
                + "WHERE id_materia=@id_materia", sqlConn);

                cmdSave.Parameters.Add("@id_materia", SqlDbType.Int).Value = mat.ID;
                cmdSave.Parameters.Add("@descripcion", SqlDbType.VarChar, 50).Value = mat.Descripcion;
                cmdSave.Parameters.Add("@HSSemanales", SqlDbType.Int).Value = mat.HSSemanales;
                cmdSave.Parameters.Add("@HSTotales", SqlDbType.Int).Value = mat.HSTotales;
                cmdSave.Parameters.Add("@IDPlan", SqlDbType.Int).Value = mat.IDPlan;
                cmdSave.ExecuteReader();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos de la materia", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert(Materia mat)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdSave = new SqlCommand("INSERT INTO materia(id,descripcion,hssemanales,hstotales,idplan)"
                    + " VALUES(@id,@descripcion,@hssemanales,@hstotales,@idplan) " +
                    "SELECT @@identity", sqlConn);
                cmdSave.Parameters.Add("@id_materia", SqlDbType.Int).Value = mat.ID;
                cmdSave.Parameters.Add("@descripcion", SqlDbType.VarChar, 50).Value = mat.Descripcion;
                cmdSave.Parameters.Add("@HSSemanales", SqlDbType.Int).Value = mat.HSSemanales;
                cmdSave.Parameters.Add("@HSTotales", SqlDbType.Int).Value = mat.HSTotales;
                cmdSave.Parameters.Add("@IDPlan", SqlDbType.Int).Value = mat.IDPlan;
                cmdSave.ExecuteReader();

                mat.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar()); // asi se obtiene el ID que asigno al BD automaticamente
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
                Exception ExcepcionManejada = new Exception("Error al crear materia", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Materia mat)
        {
            if (mat.State == BusinessEntity.States.Deleted)
            {
                this.Delete(mat.ID);
            }
            else if (mat.State == BusinessEntity.States.New)
            {
                this.Insert(mat);
            }
            else if (mat.State == BusinessEntity.States.Modified)
            {
                this.Update(mat);
            }
            mat.State = BusinessEntity.States.Unmodified;
        }

        public List<Materia> GetAllPordesc()
        {
            List<Materia> materias = new List<Materia>();

            try
            {
                this.OpenConnection();

                SqlCommand cmdMateria = new SqlCommand("SELECT id_materia, descripcion AS desc FROM materia", sqlConn);

                SqlDataReader drMaterias = cmdMateria.ExecuteReader();

                while (drMaterias.Read())
                {
                    Materia mat = new Materia();

                    mat.ID = (int)drMaterias["id_materia"];
                    mat.Descripcion = (string)drMaterias["desc"];

                    materias.Add(mat);
                }

                drMaterias.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de materias", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }

            return materias;
        }

      
    }
}

