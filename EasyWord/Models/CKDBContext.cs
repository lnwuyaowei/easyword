using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EasyWord.Models
{
    //public class CKDBContext : Z__程序源码_COREWEB_EASYWORD_EASYWORD_DB_CKDB_MDFContext
    //{
    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    {

    //    }
    //    public CKDBContext(DbContextOptions<CKDBContext> options) : base(options)
    //    { }
    //}

    partial class mydb
    {
        public mydb(DbContextOptions<mydb> options) : base(options)
        {

        }

        //protected override partial void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //}
    }
}
