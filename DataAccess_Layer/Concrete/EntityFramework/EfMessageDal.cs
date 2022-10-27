using DataAccess_Layer.Abstract;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer.Concrete.EntityFramework
{
    public class EfMessageDal : GenericRepo<Message>, IMessageDal
    {
        public List<Message> GetReceiverMessageList(string mail)
        {
            Context context = new Context();
            return context.Messages.Where(x => x.ReceiverMail == mail).ToList();
        }

        public List<Message> GetSenderMessageList(string mail)
        {
            Context context = new Context();
            return context.Messages.Where(x => x.SenderMail == mail).ToList();
        }
    }
}
