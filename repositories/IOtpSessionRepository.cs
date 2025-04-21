using EntityProject.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityProject.repositories
{
    public interface IOtpSessionRepository
    {
        IEnumerable<OtpSession> GetAllOtpSession();
        OtpSession GetOtpSessionByUserName(int ucid);
        void AddOtpSession(OtpSession OtpSession);
        void UpdateOtpSession(OtpSession OtpSession);
        void DeleteOtpSession(int ucid);
    }
}
