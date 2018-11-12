using System;
namespace DiaMedics.Models.Entities
{

    public enum TipoPlat
    {
        Primer, Segon, Unic
    };

    public class Plat
    {
        private int ID;
        private string Name;
        private TipoPlat tipus;
        private string Descripcio;

        public Plat()
        {

        }

        public Plat(int ID, TipoPlat tipus, string Descripcio)
        {
            this.ID = ID;
            this.tipus = tipus;
            this.Descripcio = Descripcio;
        }

        public Plat GetPlat()
        {
            return this;
        }

        public int GetID()
        {
            return this.ID;
        }

        public string GetName()
        {
            return this.Name;
        }

        public TipoPlat GetTipus()
        {
            return this.tipus;
        }

        public string GetDescripcio()
        {
            return this.Descripcio;
        }

        public void SetID(int id)
        {
            this.ID = id;
        }

        public void SetName(string name)
        {
            this.Name = name;
        }

        public void SetTipus(TipoPlat tipus)
        {
            this.tipus = tipus;
        }

        public void SetDescripcio(string descripcio)
        {
            this.Descripcio = descripcio;
        }
    }
}
