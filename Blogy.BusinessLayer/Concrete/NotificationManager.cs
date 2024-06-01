using Blogy.BusinessLayer.Abstract;
using Blogy.DataAccessLayer.Abstract;
using Blogy.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.BusinessLayer.Concrete
{
	public class NotificationManager:INotificationService
	{
		private readonly INotificationDal _notificationDal;

        public NotificationManager(INotificationDal notificationDal)
        {
            _notificationDal = notificationDal;
        }

        public void TDelete(int id)
		{
			_notificationDal.Delete(id);
		}

		public Notification TGetById(int id)
		{
			return _notificationDal.GetById(id);
		}

		public List<Notification> TGetListAll()
		{
			return _notificationDal.GetListAll();
		}

		public List<Notification> TGetListNotification()
		{
			return _notificationDal.GetListNotification();
		}

		public void TInsert(Notification entity)
		{
			_notificationDal.Insert(entity);
		}

		public void TUpdate(Notification entity)
		{
			_notificationDal.Update(entity);
		}
	}
}
