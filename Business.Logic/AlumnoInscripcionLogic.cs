using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;
using System.Data;

namespace Business.Logic
{
    public class AlumnoInscripcionLogic: BusinessLogic
    {
        private AlumnoInscripcionAdapter _alumnoInscripcionAdapter;

        public AlumnoInscripcionAdapter AlumnoInscripcionData
        {
            get { return _alumnoInscripcionAdapter; }
            set { _alumnoInscripcionAdapter = value; }
        }

        public AlumnoInscripcionLogic()
        {
            AlumnoInscripcionData = new AlumnoInscripcionAdapter();
        }
        public AlumnoInscripcion GetOne(int id)
        {
            return AlumnoInscripcionData.GetOne(id);
        }

        public List<AlumnoInscripcion> GetAll()
        {
            return AlumnoInscripcionData.GetAll();
        }

        public void Save(AlumnoInscripcion aluins)
        {
            AlumnoInscripcionData.Save(aluins);
        }

        public void Delete(int id)
        {
            AlumnoInscripcionData.Delete(id);
        }

    }
}
