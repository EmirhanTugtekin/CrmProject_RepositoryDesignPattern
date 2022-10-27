using BusinessLayer.Abstract;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Abstract
{
    public interface IMessageService:IGenericService<Message>
    {
        public List<Message> TGetReceiverMessageList(string mail);
        public List<Message> TGetSenderMessageList(string mail);
    }
}
