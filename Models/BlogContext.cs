using System;
using Microsoft.EntityFrameworkCore;
using AdminBlog.Models;
namespace AdminBlog.Models{

    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options):base(options){
        
        }

        public DbSet<Author> Author{get; set;}
        public DbSet<Blog> Blog{get; set;}
        public DbSet<Category> Category{get; set;}
    }









}