using System;
using Mvvmicro.Extensions;
using Xamarin.Forms;
using MvvmHelpers;
using XLabs.Forms;
using DiaMedics.ListViews;
namespace DiaMedics.Models.Entities
{
    public enum TipusActivitat
    {
        Video, Caminar
    };

    public class Activitat : ObservableObject
    {
        public string titol;
        public string descripcio;
        private int ID;
        private bool fet = false;
        private TipusActivitat tipus;
        public float progres = 0.0f;


        public Activitat()
        {
        }

        public Activitat(int id)
        {
            this.ID = id;
        }

        public Activitat(int id, TipusActivitat tipus)
        {
            this.ID = id;
            this.tipus = tipus;
        }

        public int GetID()
        {
            return this.ID;
        }

        public TipusActivitat GetTipus()
        {
            return this.tipus;
        }

        public bool IsFet()
        {
            return this.fet;
        }

        public void SetID(int id)
        {
            this.ID = id;
        }

        public void SetTipus(TipusActivitat tipus)
        {
            this.tipus = tipus;
        }

        public void SetFet(bool fet)
        {
            this.fet = fet;
        }

    }

    public class ActivitatVideo : Activitat
    {
        public string video_link;
        public string Descripcio;


    }

    public class Caminar : Activitat
    {
        public float temps;
        public float distancia;
        public string Descripcio;
    }
}
