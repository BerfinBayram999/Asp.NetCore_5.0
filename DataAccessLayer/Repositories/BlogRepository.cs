﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IGenericDal<Blog>
    {
      
        public void Delete(Blog t)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetAll()
        {
            throw new NotImplementedException();
        }

        public Blog GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Blog t)
        {
            throw new NotImplementedException();
        }

        public void Update(Blog t)
        {
            throw new NotImplementedException();
        }

        //public void AddBlog(Blog blog)
        //{
        //    using var c = new Context();
        //    c.Add(blog);
        //    c.SaveChanges();    
        //}

        //public void DeleteBlog(Blog blog)
        //{
        //    using var c = new Context();
        //    c.Remove(blog);
        //    c.SaveChanges();
        //}

        //public Blog GetBlog(int id)
        //{
        //    using var c = new Context();
        //    return c.Blogs.Find(id);
        //}

        //public List<Blog> ListAllBlog()
        //{
        //    using var c = new Context();
        //    return c.Blogs.ToList();
        //}

        //public void UpdateBlog(Blog blog)
        //{
        //    using var c = new Context();
        //    c.Update(blog);
        //    c.SaveChanges();
        //}
    }
}
