﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Materia : BusinessEntity
    {
        private string descripcion;
        private int hsSemanales;
        private int hsTotales;
        private int idPlan;
        private string descPlan;

        public string Descripcion
        {
            get
            {
                return descripcion;
            }
            set
            {
                descripcion = value;
            }
        }

        public int HsSemanales
        {
            get
            {
                return hsSemanales;
            }
            set
            {
                hsSemanales = value;
            }
        }

        public int HsTotales
        {
            get
            {
                return hsTotales;
            }
            set
            {
                hsTotales = value;
            }
        }

        public int IdPlan
        {
            get
            {
                return idPlan;
            }
            set
            {
                idPlan = value;
            }
        }


        public string DescPlan 
        {
            get 
            {
                return descPlan;
            }
            set 
            {
                descPlan = value;
            }
        }
    }
}
