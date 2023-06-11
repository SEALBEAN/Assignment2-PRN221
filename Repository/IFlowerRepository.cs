using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace Repository
{
    public interface IFlowerRepository
    {
        //create CRUD for Flower
        int AddFlower(FlowerBouquet flower);
        int DeleteFlower(int flowerId);
        IEnumerable<FlowerBouquet> GetFlowers();
        int UpdateFlower(FlowerBouquet flower);

    }
}
