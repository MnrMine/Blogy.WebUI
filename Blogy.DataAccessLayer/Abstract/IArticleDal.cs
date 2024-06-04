using Blogy.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Blogy.DataAccessLayer.Abstract
{
    public interface IArticleDal : IGenericDal<Article>
    {
        List<Article> GetArticleWithWriter();
        Writer GetWriterInfoByArticleWriter(int id);
        List<Article> GetArticlesByWriter(int id);
        List<Article> GetOtherBlogPostByWriter(int id);
        List<Article> GetLast4BlogPost();
        Article GetArticleByIdWithWriterIdAndCategory(int id);
        List<Article> GetArticleFilterList(string search);
        List<Article> GetArticlesByWriterAndCategory(int id);



    }
}
