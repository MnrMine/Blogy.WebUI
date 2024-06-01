using Blogy.DataAccessLayer.Abstract;
using Blogy.DataAccessLayer.Repository;
using Blogy.DataAccessLayer.Context;
using Blogy.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.DataAccessLayer.EntityFramework
{
    public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    {
        BlogyContext context = new BlogyContext();
        public List<Comment> GetCommentsByArticleId(int id)
        {
            var values = context.Comments.Where(x => x.ArticleId == id).ToList();
            return values;
            
        }
    }
}
