﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course.Services.Catalog.Settings
{
  public  interface IDatabaseSettings
    {
         string CourseCollectionName { get; set; }
         string CategoryCollectionName { get; set; }
         string ConnectionString { get; set; }
         string DatabaseName { get; set; }
    }
}
