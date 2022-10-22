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
    public class Docentes_cursosLogic
    {
        private Docentes_cursoAdapter _materiaData;
        public Docentes_cursos MateriaData
        {
            get { return _docentes_cursoData; }
            set { _materiaData = value; }
        }

        public MateriaLogic()
        {
            MateriaData = new MateriaAdapter();
        }

        public Materia GetOne(int id)
        {
            return MateriaData.GetOne(id);
        }

        public List<Materia> GetAll()
        {
            return MateriaData.GetAll();
        }

        public void Delete(int id)
        {
            MateriaData.Delete(id);
        }

        public void Save(Materia mat)
        {
            MateriaData.Save(mat);
        }

        public DataTable GetMaterias()
        {
            return MateriaData.GetMaterias();
        }
    }
}
