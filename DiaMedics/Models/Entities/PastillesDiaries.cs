using System;
namespace DiaMedics.Models.Entities
{
    public class PastillesDiaries
    {
        private int ID;

        public ArraySegment<Pastilla> esmorzar;
        public ArraySegment<Pastilla> dinar;
        public ArraySegment<Pastilla> sopar;
        public ArraySegment<Pastilla> nit;

        public PastillesDiaries(int id)
        {
            this.ID = id;
        }

        public PastillesDiaries( int id, ArraySegment<Pastilla> esmorzar, ArraySegment<Pastilla> dinar,
                                    ArraySegment<Pastilla> sopar, ArraySegment<Pastilla> nit)
        {
            this.ID = id;
            this.esmorzar = esmorzar;
            this.dinar = dinar;
            this.sopar = sopar;
            this.nit = nit;
        }

        public int GetiD()
        {
            return this.ID;
        }

        public void SetID(int id)
        {
            this.ID = id;
        }

    }
}
