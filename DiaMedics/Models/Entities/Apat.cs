using System;
using DiaMedics.Models.Entities;
namespace DiaMedics.Models.Entities
{
    public enum TipoApat { 
        Esmorzar, Dinar, Brenar, Sopar
    };

    public class Apat
    {
        private int ID;
        private string Name;
        private TipoApat Tipus;
        ArraySegment<Plat> Plats;
        private bool fet = false;

        public Apat()
        {

        }

        public Apat(string Name)
        {
            this.Name = Name;
        }

        public Apat(string Name, TipoApat Tipo)
        {
            this.Name = Name;
            this.Tipus = Tipo;
        }

        public Apat(string Name, TipoApat Tipo, ArraySegment<Plat> Plats)
        {
            this.Name = Name;
            this.Tipus = Tipo;
            this.Plats = Plats;
        }

        public int GetID()
        {
            return this.ID;
        }

        public string GetName()
        {
            return this.Name;
        }

        public TipoApat GetTipo()
        {
            return this.Tipus;
        }

        public ArraySegment<Plat> GetPlats()
        {
            return this.Plats;
        }

        public void SetID(int id)
        {
            this.ID = id;
        }

        public void SetName(string name)
        {
            this.Name = name;
        }

        public void SetTipo(TipoApat tipus)
        {
            this.Tipus = tipus;
        }

        public void SetPlats(ArraySegment<Plat> plats)
        {
            this.Plats = plats;
        }
    }
}
