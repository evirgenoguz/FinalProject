﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        DataResult<List<Category>> GetAll();
        DataResult<Category> GetById(int categoryId);
    }
}
