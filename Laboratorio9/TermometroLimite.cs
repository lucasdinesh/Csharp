
namespace Laboratorio9
{
    public class TermometroLimite : Termometro
    {
        public delegate void MeuDelegate(string msg);

        public event MeuDelegate LimiteSuperiorEvent;
        private double limiteSuperior;

        private bool disparadoEventoLimiteSuperior;
        public TermometroLimite(double ls)
        {
            limiteSuperior = ls;
            disparadoEventoLimiteSuperior = false;
        }
        public double LimiteSuperior
        {
            get { return limiteSuperior; }
            set { limiteSuperior = value; }
        }

        public override void Aumentar()
        {
            base.Aumentar();
            OnLimiteSuperiorEvent();
        }
        public override void Aumentar(double quantia)
        {
            base.Aumentar(quantia);
            OnLimiteSuperiorEvent();
        }

        public override void Diminuir()
        {
            base.Diminuir();
            if ((this.Temperatura <= limiteSuperior) && (disparadoEventoLimiteSuperior))
            {
                disparadoEventoLimiteSuperior = false;
            }
        }
        public override void Diminuir(double quantia)
        {
            base.Diminuir(quantia);
            if ((this.Temperatura <= limiteSuperior) && (disparadoEventoLimiteSuperior))
            {
                disparadoEventoLimiteSuperior = false;
            }
        }

        private void OnLimiteSuperiorEvent()
        {
            // verifica se a temperatura ultrapassou o limite e
            // Verifica se o evento já foi disparado, para não disparar continuamente.
            if ((this.Temperatura > limiteSuperior) && (!disparadoEventoLimiteSuperior))
                // verifica se há tratador
                if (LimiteSuperiorEvent != null)
                {
                    LimiteSuperiorEvent("Atenção: temperatura acima do limite!!!");
                    disparadoEventoLimiteSuperior = true;
                }
        }

    }
}