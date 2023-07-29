using System;
using System.Collections.Generic;
using System.Text;

namespace ClntSrvrWk1.Lessons.Week2
{
    public class ExceptionThrowing
    {
        private string message;
        private string messageTemplate;

        public ExceptionThrowing(string messageTemplate, string message)
        {
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message), "message cannot bu null");
            }

            this.message = message;
            this.messageTemplate = messageTemplate;
        }
    }
}
