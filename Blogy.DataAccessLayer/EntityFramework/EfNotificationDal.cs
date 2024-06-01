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
	public class EfNotificationDal : GenericRepository<Notification>, INotificationDal
	{
		BlogyContext context = new BlogyContext();

		public List<Notification> GetListNotification()
		{
			var values = context.Notifications.OrderByDescending(x => x.Date).Take(3).ToList();
			return values;
		}
	}
}
