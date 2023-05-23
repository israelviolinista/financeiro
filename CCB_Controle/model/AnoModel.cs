using CCB_Controle.controller;
using CCB_Controle.entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCB_Controle.model
{
    public class AnoModel
    {
        public static int Inserir(Anos obj)
        {
            return new AnoController().Inserir(obj);
        }
    }
}
