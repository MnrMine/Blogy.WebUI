using Blogy.DataAccessLayer.Abstract;
using Blogy.DataAccessLayer.Context;
using Blogy.DataAccessLayer.Repository;
using Blogy.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.DataAccessLayer.EntityFramework
{
    public class EfWriterDal : GenericRepository<Writer>, IWriterDal
    {
        BlogyContext context = new BlogyContext();
        public void ChangeToFalseByWriter(int id)
        {
            var values = context.Writers.Find(id);
            values.Status = false;
            context.Update(values);
            context.SaveChanges();
        }

        public void ChangeToTrueByWriter(int id)
        {
            var values = context.Writers.Find(id);
            values.Status = true;
            context.Update(values);
            context.SaveChanges();
        }
    }
}
