using System;
using System.Collections.Generic;

namespace aula.lista
{
    public class ListaLigada
    {
        public Vagao Trem { get; set; }

        public void InserirVagao(Vagao novoVagao) {
            if(Trem == null) Trem = novoVagao;
            else {
                var vagaoAnterior = getUltimoVagao();
                vagaoAnterior.VagaoAnterior = novoVagao;
            }
        }

        public Vagao getUltimoVagao() {
            var tempVagao = Trem;
            while(tempVagao.VagaoAnterior != null) {
                tempVagao = tempVagao.VagaoAnterior;
            }
            return tempVagao;
        }

        public List<Vagao> getVagoes() {
            var _trem = new List<Vagao>();
            var tempVagao = Trem;
            while(tempVagao != null) {
                _trem.Add(tempVagao);
                tempVagao = tempVagao.VagaoAnterior;
            };
            return _trem;
        }

        public Vagao GetById(int id) 
        {
            var tempVagao = Trem;
            while (tempVagao != null)
            {
                if (tempVagao.Id == id) return tempVagao;
                tempVagao = tempVagao.VagaoAnterior;
            };
            return null; 
        }

        public Vagao GetByCarga(string carga) 
        {
            var tempVagao = Trem;
            while (tempVagao != null)
            {
                if (tempVagao.Carga == carga) return tempVagao;
                tempVagao = tempVagao.VagaoAnterior;
            };
            return null; 
        }

        public Vagao GetByPeso(int peso) 
        {
            var tempVagao = Trem;
            while (tempVagao != null)
            {
                if (tempVagao.Peso == peso) return tempVagao;
                tempVagao = tempVagao.VagaoAnterior;
            };
            return null; 
        }

        public void ExibirVagao(Vagao vagao)
        {
            Console.WriteLine("ID {0}", vagao.Id);
            Console.WriteLine("Carga {0}", vagao.Carga);
            Console.WriteLine("Peso {0}", vagao.Peso);
        }
    }
}