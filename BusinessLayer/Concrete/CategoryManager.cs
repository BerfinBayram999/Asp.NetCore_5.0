using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {

        EFCategoryRepository efCategoryRepos;

        public CategoryManager()
        {
            efCategoryRepos = new EFCategoryRepository();
        }
        public void CategoryAdd(Category category)
        {
            efCategoryRepos.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            efCategoryRepos.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            efCategoryRepos.Update(category);
        }

        public Category GetById(int id)
        {
            return  efCategoryRepos.GetById(id);
        }

        public List<Category> GetList()
        {
           return efCategoryRepos.GetAll();
        }
    }
}
