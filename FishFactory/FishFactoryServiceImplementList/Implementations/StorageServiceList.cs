﻿using FishFactoryServiceDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FishFactoryServiceDAL.BindingM;
using FishFactoryServiceDAL.ViewM;
using FishFactoryModel;

namespace FishFactoryServiceImplementList.Implementations
{
    public class StorageServiceList : IStorageService
    {
        private DataListSingleton source;
        public StorageServiceList()
        {
            source = DataListSingleton.GetInstance();
        }
        public List<StorageViewM> GetList()
        {
            List<StorageViewM> result = source.Storages
            .Select(rec => new StorageViewM
            {
                Id = rec.Id,
                StorageName = rec.StorageName,
                StorageFishes = source.StorageFishes
            .Where(recPC => recPC.StorageId == rec.Id)
            .Select(recPC => new StorageFishViewM
            {
                Id = recPC.Id,
                StorageId = recPC.StorageId,
                TypeOfFishId = recPC.TypeOfFishId,
                TypeOfFishName = source.TypesOfFish
            .FirstOrDefault(recC => recC.Id ==
            recPC.TypeOfFishId)?.TypeOfFishName,
                Total = recPC.Total
            })
            .ToList()
            })
            .ToList();
            return result;
        }
        public StorageViewM GetElement(int id)
        {
            Storage element = source.Storages.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new StorageViewM
                {
                    Id = element.Id,
                    StorageName = element.StorageName,
                    StorageFishes = source.StorageFishes
                .Where(recPC => recPC.StorageId == element.Id)
                .Select(recPC => new StorageFishViewM
                {
                    Id = recPC.Id,
                    StorageId = recPC.StorageId,
                    TypeOfFishId = recPC.TypeOfFishId,
                    TypeOfFishName = source.TypesOfFish
                .FirstOrDefault(recC => recC.Id ==
                recPC.TypeOfFishId)?.TypeOfFishName,
                    Total = recPC.Total
                })
                .ToList()
                };
            }
            throw new Exception("Элемент не найден");
        }
        public void AddElement(StorageBindingM model)
        {
            Storage element = source.Storages.FirstOrDefault(rec => rec.StorageName == model.StorageName);
            if (element != null)
            {
                throw new Exception("Уже есть склад с таким названием");
            }
            int maxId = source.Storages.Count > 0 ? source.Storages.Max(rec => rec.Id) : 0;
            source.Storages.Add(new Storage
            {
                Id = maxId + 1,
                StorageName = model.StorageName
            });
        }
        public void UpdElement(StorageBindingM model)
        {
            Storage element = source.Storages.FirstOrDefault(rec =>
            rec.StorageName == model.StorageName && rec.Id !=
            model.Id);
            if (element != null)
            {
                throw new Exception("Уже есть склад с таким названием");
            }
            element = source.Storages.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            element.StorageName = model.StorageName;
        }
        public void DelElement(int id)
        {
            Storage element = source.Storages.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                // при удалении удаляем все записи о компонентах на удаляемом складе
                source.StorageFishes.RemoveAll(rec => rec.StorageId == id);
                source.Storages.Remove(element);
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
    }
}
