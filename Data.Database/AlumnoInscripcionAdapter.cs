using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Business.Entities;

namespace Data.Database
{
    public class AlumnoInscripcionAdapter : Adapter
    {
        public List<AlumnoInscripcion> GetAll()
        {
            List<AlumnoInscripcion> alumnosinscripciones = new List<AlumnoInscripcion>();
            try
            {
                OpenConnection();
                SqlCommand cmdAlumnosInscripciones = new SqlCommand("select * from alumnos_inscripciones", sqlConn);
                SqlDataReader drAlumnosInscripciones = cmdAlumnosInscripciones.ExecuteReader();
                while (drAlumnosInscripciones.Read())
                {
                    AlumnoInscripcion aluins = new AlumnoInscripcion();
                    aluins.IdInscripcion = (int)drAlumnosInscripciones["id_inscripcion"];
                    aluins.Condicion = (string)drAlumnosInscripciones["condicion"];
                    aluins.IdAlumno = (int)drAlumnosInscripciones["id_alumno"];
                    aluins.IdCurso = (int)drAlumnosInscripciones["id_curso"];
                    aluins.Nota = (int)drAlumnosInscripciones["nota"];
                    alumnosinscripciones.Add(aluins);
                }
                drAlumnosInscripciones.Close();
            }

            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar alumnos inscripciones", Ex);
                //throw ExcepcionManejada;
            }

            finally
            {
                CloseConnection();
            }
            return alumnosinscripciones;
        }

        public AlumnoInscripcion GetOne(int ID)
        {
            AlumnoInscripcion alumins = new AlumnoInscripcion();
            OpenConnection();
            SqlCommand cmdAlumnosInscripciones = new SqlCommand("select * from alumnos_inscripciones where id_inscripcion=@id", sqlConn);
            cmdAlumnosInscripciones.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            SqlDataReader drAlumnosInscripciones = cmdAlumnosInscripciones.ExecuteReader();

            try
            {
                if (drAlumnosInscripciones.Read())
                {
                    alumins.IdInscripcion = (int)drAlumnosInscripciones["id_inscripcion"];
                    alumins.Condicion = (string)drAlumnosInscripciones["condicion"];
                    alumins.IdAlumno = (int)drAlumnosInscripciones["id_alumno"];
                    alumins.IdCurso = (int)drAlumnosInscripciones["id_curso"];
                    alumins.Nota = (int)drAlumnosInscripciones["nota"];
                }
                else alumins = null;
                drAlumnosInscripciones.Close();
            }

            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de la inscripcion del alumno", Ex);
                throw ExcepcionManejada;
            }

            finally
            {
                this.CloseConnection();
            }
            return alumins;
        }

        public void Delete(int ID)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete alumnos_inscripciones where id_inscripcion=@id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }

            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("No se pudo eliminar el la inscripcion del alumno", Ex);
                throw ExcepcionManejada;
            }

            finally
            {
                CloseConnection();
            }

        }

        public void Save(AlumnoInscripcion alumins)
        {
            if (alumins.State == BusinessEntity.States.Deleted)
            {
                this.Delete(alumins.ID);
            }

            if (alumins.State == BusinessEntity.States.New)
            {
                this.Insert(alumins);
            }

            if (alumins.State == BusinessEntity.States.Modified)
            {
                this.Update(alumins);
            }
            alumins.State = BusinessEntity.States.Unmodified;
        }

        public void Insert(AlumnoInscripcion alumins)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdInsert = new SqlCommand("insert into alumnos_incripciones(id_inscripcion, id_alumno, id_curso, condicion, nota)" +
                    "values(@idinscripcion, @idalumno, @idcurso, @condicion, @nota)" +
                    "select @@identity", sqlConn);
                cmdInsert.Parameters.Add("@idinscripcion", SqlDbType.Int).Value = alumins.IdInscripcion;
                cmdInsert.Parameters.Add("@idalumno", SqlDbType.Int).Value = alumins.IdAlumno;
                cmdInsert.Parameters.Add("@idcurso", SqlDbType.Int).Value = alumins.IdCurso;
                cmdInsert.Parameters.Add("@condicion", SqlDbType.VarChar).Value = alumins.Condicion;
                cmdInsert.Parameters.Add("@nota", SqlDbType.Int).Value = alumins.Nota;
                alumins.ID = Decimal.ToInt32((decimal)cmdInsert.ExecuteScalar());
            }

            catch (Exception Ex)
            {
                Exception ExcepctionManejada = new Exception("Error al crear la inscripcion del alumno", Ex);
                throw ExcepctionManejada;
            }

            finally
            {
                CloseConnection();
            }
        }

        public void Update(AlumnoInscripcion aluins)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdUpdate = new SqlCommand("UPDATE alumnos_inscripciones SET id_inscripcion = @idinscripcion, " +
                    "id_alumno = @idalumno," +
                    "id_curso = @idcurso, condicion = @condicion where id_inscripcion = @id", sqlConn);

                cmdUpdate.Parameters.Add("@idinscripcion", SqlDbType.Int).Value = aluins.IdInscripcion;
                cmdUpdate.Parameters.Add("@idalumno", SqlDbType.Int).Value = aluins.IdAlumno;
                cmdUpdate.Parameters.Add("@idcurso", SqlDbType.Int).Value = aluins.IdCurso;
                cmdUpdate.Parameters.Add("@condicion", SqlDbType.Int).Value = aluins.Condicion;
                cmdUpdate.Parameters.Add("@id", SqlDbType.Int).Value = aluins.ID;

                cmdUpdate.ExecuteNonQuery();
            }

            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al actualizar la inscripcion del alumno", Ex);
                throw ExceptionManejada;
            }

            finally
            {
                CloseConnection();
            }
        }

        public DataTable GetAlumnos()
        {
            DataTable alumnosinscripciones = new DataTable();
            try
            {
                OpenConnection();
                SqlCommand cmdAlumnosInscripciones = new SqlCommand("select id_persona, legajo from personas", sqlConn);
                SqlDataAdapter daAlumnosInscripciones = new SqlDataAdapter(cmdAlumnosInscripciones);
                daAlumnosInscripciones.Fill(alumnosinscripciones);
            }

            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("No se pudo cargar las inscripciones del alumno", Ex);
                throw ExceptionManejada;
            }

            finally
            {
                CloseConnection();
            }
            return alumnosinscripciones;
        }
    }
}
