using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Aprendendo.ViewModels
{
    internal class MainPageViewModel : NotificaBase
    {
        public string Nome { get; set; }

        private string _Mensagem;
        public string Mensagem 
        {
            get { return _Mensagem; }
            set 
            { 
                _Mensagem = value;
                Notificar();
            }
        }

        public Command BoasVindasCommand
        {
            get
            {
                return new Command(() =>
                {
                    Mensagem ="Seja bem-vindo " + Nome;
                }
                );
            }
        }
    }
}
