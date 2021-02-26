using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint
    //alt satırdaki class referans tip anlamında yani bunadan sonra T yerine referans tip gelicek sadece
    //IEntity : Ienetity ya da ıentity implemente eden bir nesne olabilir demek
    //new() yazmamızın nedeni ise orada ınterface yerine düzgün class yazılması için
    //çünkü ınterfaceler newlenemez.
    public interface IEntityRepository<T> where T:class, IEntity, new() //burada t Ientity ya da ıentity vari bişi olucak
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
