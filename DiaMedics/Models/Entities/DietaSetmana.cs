using System;
using DiaMedics.Models.Entities;
namespace DiaMedics.Models.Entities
{

    public class DietaSetmana
    {
        public ArraySegment<Apat> dilluns;
        public ArraySegment<Apat> dimarts;
        public ArraySegment<Apat> dimecres;
        public ArraySegment<Apat> dijous;
        public ArraySegment<Apat> divendres;
        public ArraySegment<Apat> dissabte;
        public ArraySegment<Apat> diumenge;

        public DietaSetmana()
        {
        }

        public DietaSetmana(ArraySegment<Apat> dilluns, ArraySegment<Apat> dimarts, ArraySegment<Apat> dimecres,
                            ArraySegment<Apat> dijous, ArraySegment<Apat> divendres, ArraySegment<Apat> dissabte,
                            ArraySegment<Apat> diumenge)
        {

        }
    }
}
