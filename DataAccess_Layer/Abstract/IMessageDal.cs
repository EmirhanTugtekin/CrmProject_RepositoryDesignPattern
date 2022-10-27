using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer.Abstract
{
    public interface IMessageDal:IGenericDal<Message>
    {
        List<Message> GetReceiverMessageList(string mail);
        List<Message> GetSenderMessageList(string mail);
    }
}
