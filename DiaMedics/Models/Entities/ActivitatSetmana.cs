using System;
namespace DiaMedics.Models.Entities
{
    public class ActivitatSetmana
    {
        public ArraySegment<Activitat> dilluns;
        public ArraySegment<Activitat> dimarts;
        public ArraySegment<Activitat> dimecres;
        public ArraySegment<Activitat> dijous;
        public ArraySegment<Activitat> divendres;
        public ArraySegment<Activitat> dissabte;
        public ArraySegment<Activitat> diumenge;

        public ActivitatSetmana()
        {
        }

        public ActivitatSetmana( ArraySegment<Activitat> dilluns,   ArraySegment<Activitat> dimarts,
                                ArraySegment<Activitat> dimecres,   ArraySegment<Activitat> dijous,
                                ArraySegment<Activitat> divendres,  ArraySegment<Activitat> dissabte,
                                ArraySegment<Activitat> diumenge)
        {

        }
    }
}
