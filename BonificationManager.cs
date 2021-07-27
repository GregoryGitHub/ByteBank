using ByteBank.Employes;


namespace ByteBank
{
    class BonificationManager
    {
        private double _totalBonifications = 0;

        public  void Register(Employe employe)
        {
            this._totalBonifications += employe.GetBonification();
        }

        public double GetTotalBonifications()
        {
            return this._totalBonifications;
        }
    }
}
