using System;
namespace DiaMedics.Models.Entities
{
    public class User
    {
        private int ID;
        private string nickname;
        private DateTime proxima_cita;
        private TasquesSetmanals tasques;

        public User()
        {
        }

        public User(int id)
        {
            this.ID = id;
        }

        public User(int id, string nickname)
        {

        }

         
    }
}
