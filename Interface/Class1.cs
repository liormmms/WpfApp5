using Model;

namespace Interface
{
    public class Iapi
    {
        public interface IApi 
        {
            public Task<Kindlist> Getallkinds();
            public Task<int> DeleteAkind(int id);
            public Task<int> UpdateAkind(Kind i);

            public Task<int> Insertkind(Kind i);
            public Task<BuyerList> Getallbuyers();
            public Task<int> DeleteAbuyers(int id);
            public Task<int> UpdateAbuyers(Buyer i);

            public Task<int> Insertbuyers(Buyer i);

        }

    }
}
