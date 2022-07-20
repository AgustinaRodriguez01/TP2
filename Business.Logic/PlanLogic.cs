using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;
using System.Windows.Forms;

namespace Business.Logic
{
    public class PlanLogic : BusinessLogic
    {
        private PlanAdapter _planData;
        public PlanAdapter PlanData
        {
            get { return _planData; }
            set { _planData = value; }
        }

        public PlanLogic()
        {
            PlanData = new PlanAdapter();
        }

        public Plan GetOne(int id)
        {
            return PlanData.GetOne(id);
        }

        public List<Plan> GetAll()
        {
            return PlanData.GetAll();
        }

        //public void GetDescripcion()
        //{
        //    PlanData.GetDescripciones();
        //}
        public void Delete(int id)
        {
            PlanData.Delete(id);
        }

        public void Save(Plan plan)
        {
            PlanData.Save(plan);
        }
    }
}

