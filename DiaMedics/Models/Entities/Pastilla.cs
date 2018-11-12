using System;
namespace DiaMedics.Models.Entities
{
    public class Pastilla
    {
        private int ID;
        private string descripcio;

        public Pastilla()
        {
        }

        public Pastilla(int id, string descripcio)
        {
            this.ID = id;
            this.descripcio = descripcio;
        }

        public int GetID()
        {
            return this.ID;
        }

        public string GetDescripcio()
        {
            return this.descripcio;
        }

        public void SetId(int id)
        {
            this.ID = id;
        }

        public void SetDescripcio(string descripcio)
        {
            this.descripcio = descripcio;
        }
    }
}
