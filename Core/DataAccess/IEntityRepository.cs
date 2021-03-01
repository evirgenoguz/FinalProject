using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

//namespace classlara vs kolay erişmek için gruplandırma gibi düşün
namespace Core.DataAccess
{
    //generic constraint
    //alt satırdaki class referans tip anlamında yani bunadan sonra T yerine referans tip gelicek sadece
    //IEntity : Ienetity ya da ıentity implemente eden bir nesne olabilir demek
    //new() yazmamızın nedeni ise orada ınterface yerine düzgün class yazılması için
    //çünkü ınterfaceler newlenemez.
    public interface IEntityRepository<T> where T : class, IEntity, new() //burada t Ientity ya da ıentity vari bişi olucak
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

//core katmanı diğer katmanları referans almaz Bağımlılıktan dolayı ilerleyen zamanlarda core katmanı diğer projelerinde de kullanılabilir