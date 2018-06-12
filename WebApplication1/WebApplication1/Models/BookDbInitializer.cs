using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "Війна і мир", Author = "ТОвстий Лев", Price = 220 });
            db.Books.Add(new Book { Name = "Батьки та діти", Author = "І. Тургенєв", Price = 180 });
            db.Books.Add(new Book { Name = "Чайка", Author = "А. Чехов", Price = 150 });

            base.Seed(db);
        }
    }
}