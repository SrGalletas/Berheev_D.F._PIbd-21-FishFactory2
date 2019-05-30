﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using FishFactoryModel;

namespace FishFactoryServiceImplementDataBase
{
    public class AbstractDbEnvironment : DbContext
    {
        public AbstractDbEnvironment() : base("AbstractDatabase")
        {
            //настройки конфигурации для entity
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            var ensureDLLIsCopied =
            System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<TypeOfFish> TypesOfFish { get; set; }
        public virtual DbSet<Request> Requests { get; set; }
        public virtual DbSet<CannedFood> CannedFoods { get; set; }
        public virtual DbSet<TypeOfCanned> TypeOfCanneds { get; set; }
        public virtual DbSet<Storage> Storages { get; set; }
        public virtual DbSet<StorageFish> StorageFishes { get; set; }
    }
}
