﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SendFormDataViaEmailNoDb.EmailService
{
    public interface IEmailSender
    {
        void SendEmail(Message message);
        Task SendEmailAsync(Message message);
    }
}
