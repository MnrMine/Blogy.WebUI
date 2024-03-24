﻿using Blogy.BusinessLayer.Abstract;
using Blogy.DataAccessLayer.Abstract;
using Blogy.DataAccessLayer.EntityFramework;
using Blogy.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.BusinessLayer.Concrete
{
    public class TagManager : ITagService
    {
        private readonly ITagDal _tagDal;

        public TagManager(ITagDal tagDal)
        {
            _tagDal = tagDal;
        }

        public void TDelete(int id)
        {
            _tagDal.Delete(id);
        }

        public Tag TGetById(int id)
        {
            return _tagDal.GetById(id);
        }

        public List<Tag> TGetListAll()
        {
            return _tagDal.GetListAll();
        }

        public void TInsert(Tag entity)
        {
            _tagDal.Insert(entity);
        }

        public void TUpdate(Tag entity)
        {
            _tagDal.Update(entity);
        }
    }
}
