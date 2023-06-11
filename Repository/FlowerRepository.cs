using BusinessObject;
using DataAcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class FlowerRepository : IFlowerRepository
    {
        public int AddFlower(FlowerBouquet flower)
        {
            return FlowerDAO.Instance.AddFlower(flower);
        }

        public int DeleteFlower(int flowerId)
        {
            return FlowerDAO.Instance.DeleteFlower(flowerId);
        }

        public IEnumerable<FlowerBouquet> GetFlowers()
        {
            return FlowerDAO.Instance.Flowers();
        }

        public int UpdateFlower(FlowerBouquet flower)
        {
            return FlowerDAO.Instance.UpdateFlower(flower);
        }
    }
}
