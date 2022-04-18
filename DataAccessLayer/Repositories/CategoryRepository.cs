using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : IGenericDal<Category>
    {
        //Context context = new Context();
        //public void AddCategory(Category category)
        //{
        //    context.Add(category);
        //    context.SaveChanges();
        //}

        //public void DeleteCategory(Category category)
        //{
        //    context.Remove(category);
        //    context.SaveChanges();
        //}

        //public Category GetCategory(int id)
        //{
        //    return context.Categories.Find(id);
        //}

        //public List<Category> ListAllCategories()
        //{
        //   return context.Categories.ToList();
        //}

        //public void UpdateCategory(Category category)
        //{
        //    context.Update(category);
        //    context.SaveChanges();
        //}
        public void Delete(Category t)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Category t)
        {
            throw new NotImplementedException();
        }

        public void Update(Category t)
        {
            throw new NotImplementedException();
        }
    }
}
