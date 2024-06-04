using Blogy.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.DataAccessLayer.Abstract
{
    public interface IWriterDal : IGenericDal<Writer>
    {
        void ChangeToTrueByWriter(int id);
        void ChangeToFalseByWriter(int id);

    }
}
