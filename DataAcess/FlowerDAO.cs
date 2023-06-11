using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess
{
    public class FlowerDAO
    {
        
        private static FlowerDAO instance = null;
        private static readonly object instanceLock = new object();
        private FlowerDAO() { }
        public static FlowerDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new FlowerDAO();
                    }
                    return instance;
                }
            }
        }
        
        public List<FlowerBouquet> Flowers()
        {
            List<FlowerBouquet> flowers;
            try
            {
                var dbContext = new FUFlowerBouquetManagementContext();
                flowers = dbContext.FlowerBouquets.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return flowers;
        }
        public int UpdateFlower(FlowerBouquet flower)
        {
            try
            {
                var dbContext = new FUFlowerBouquetManagementContext();
                var flowerToUpdate = dbContext.FlowerBouquets.Where(x => x.FlowerBouquetId == flower.FlowerBouquetId).FirstOrDefault();
                int status = 0;
                if (flowerToUpdate != null)
                {
                    flowerToUpdate.FlowerBouquetName = flower.FlowerBouquetName;
                    flowerToUpdate.CategoryId = flower.CategoryId;
                    flowerToUpdate.UnitPrice = flower.UnitPrice;
                    flowerToUpdate.UnitsInStock = flower.UnitsInStock;
                    flowerToUpdate.FlowerBouquetStatus = flower.FlowerBouquetStatus; 
                    flowerToUpdate.SupplierId = flower.SupplierId;
                    flowerToUpdate.Description = flower.Description;
                    status = dbContext.SaveChanges();
                }
                return status;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int AddFlower(FlowerBouquet flower)
        {
            try
            {
                var dbContext = new FUFlowerBouquetManagementContext();
                dbContext.FlowerBouquets.Add(flower);
                int status = dbContext.SaveChanges();
                return status;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int DeleteFlower(int flowerId)
        {
            try
            {
                var dbContext = new FUFlowerBouquetManagementContext();
                var flowerToDelete = dbContext.FlowerBouquets.Where(x => x.FlowerBouquetId == flowerId).FirstOrDefault();
                int status = 0;
                if (flowerToDelete != null)
                {
                    dbContext.FlowerBouquets.Remove(flowerToDelete);
                    status = dbContext.SaveChanges();
                }
                return status;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}