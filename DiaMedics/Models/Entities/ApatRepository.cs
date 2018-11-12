
using System.Collections.ObjectModel;
using DiaMedics.Models.Entities;
namespace DiaMedics.Models.Entities
{
    public class ApatRepository
    {
        private ObservableCollection<Apat> apets;

        public ObservableCollection<Apat> Apets
        {
            get { return apets; }
            set { this.apets = value; }
        }

        public ApatRepository()
        {
            GenerateApets();
        }

        internal void GenerateApets()
        {
            apets = new ObservableCollection<Apat>
            {
                new Apat("LLet amb una poma", TipoApat.Esmorzar),
                new Apat("Amanida Verda", TipoApat.Dinar),
                new Apat("Peix bullit", TipoApat.Sopar)
            };

        }
    }
}
