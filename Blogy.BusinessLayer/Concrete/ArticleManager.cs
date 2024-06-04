using Blogy.BusinessLayer.Abstract;
using Blogy.DataAccessLayer.Abstract;
using Blogy.DataAccessLayer.EntityFramework;
using Blogy.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.BusinessLayer.Concrete
{
    public class ArticleManager : IArticleService
    {
        private readonly IArticleDal _articleDal;

        public ArticleManager(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }

        public void TDelete(int id)
        {
            _articleDal.Delete(id);
        }

        public Article TGetArticleByIdWithWriterIdAndCategory(int id)
        {
            return _articleDal.GetArticleByIdWithWriterIdAndCategory(id);
        }

        public List<Article> TGetArticleFilterList(string search)
        {
           return _articleDal.GetArticleFilterList(search);
        }

        public List<Article> TGetArticlesByWriter(int id)
        {
            return _articleDal.GetArticlesByWriter(id);
        }

        public List<Article> TGetArticlesByWriterAndCategory(int id)
        {
            return _articleDal.GetArticlesByWriterAndCategory(id);
        }

        public List<Article> TGetArticleWithWriter()
		{
            return _articleDal.GetArticleWithWriter();
		}

        public List<Article> TGetByFilter(Expression<Func<Article, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Article TGetById(int id)
        {
            //eğer id degerine göre yetkisi varsa
            return _articleDal.GetById(id);
        }

        public List<Article> TGetLast4BlogPost()
        {
            return _articleDal.GetLast4BlogPost();
        }

        public List<Article> TGetListAll()
        {
            return _articleDal.GetListAll();
        }

        public List<Article> TGetOtherBlogPostByWriter(int id)
        {
            return _articleDal.GetOtherBlogPostByWriter(id);
        }

        public Writer TGetWriterInfoByArticleWriter(int id)
        {
            return _articleDal.GetWriterInfoByArticleWriter(id);
        }

        public void TInsert(Article entity)
        {
           
                _articleDal.Insert(entity);
            
        }

        public void TUpdate(Article entity)
        {
            
                _articleDal.Update(entity);
           
        }
    }
}
