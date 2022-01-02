using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.DDD.InternalCommand.Domain
{
    public class InternalCommand
    {
        protected InternalCommand()
        {

        }

        public Guid Id { get; private set; }
        public string Message { get; private set; }
        public DateTime SavedOn { get; private set; }
        public DateTime? ExecutedOn { get; set; }
        public string Type { get; private set; }

        public static InternalCommand New(object message)
        {
            var serializedMessage = JsonConvert.SerializeObject(message);

            var type = message.GetType().FullName + ", " +
                  message.GetType().Assembly.GetName().Name;
            // var type = message.GetType().ToString();

            return new InternalCommand
            {
                Message = serializedMessage,
                Type = type,
                SavedOn = DateTime.UtcNow,
                Id = Guid.NewGuid()
            };
        }
        public object RecreateMessage() =>
              JsonConvert.DeserializeObject(Message, System.Type.GetType(Type));

    }
}
