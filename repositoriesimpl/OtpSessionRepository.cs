using EntityProject.DBContext;
using EntityProject.entities;
using EntityProject.repositories;
using Microsoft.EntityFrameworkCore;
using Retailbanking.Common.DbObj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OtpSession = EntityProject.entities.OtpSession;

namespace EntityProject.repositoriesimpl
{
    public class OtpSessionRepository : IOtpSessionRepository
    {
        private readonly AppDbContext _context;

        public OtpSessionRepository(AppDbContext context)
        {
            _context = context;
        }

        public void AddOtpSession(OtpSession OtpSession)
        {
           // _context.OtpSession.Add(OtpSession);
           // _context.SaveChanges();
            var existingOtpSession = _context.OtpSession.FirstOrDefault(u => u.Id == OtpSession.Id);
            if (existingOtpSession != null)
            {
                _context.Entry(existingOtpSession).CurrentValues.SetValues(OtpSession);
            }
            else
            {
                _context.OtpSession.Add(OtpSession); // new entities
            }
            _context.SaveChanges();
        }

        public void DeleteOtpSession(int ucid)
        {
            var user = _context.OtpSession
                .FirstOrDefault(p => p.ucid==ucid);
            if (user != null)
            {
                _context.OtpSession.Remove(user);
                _context.SaveChanges();
            }
        }

        public IEnumerable<OtpSession> GetAllOtpSession()
        {
            return _context.OtpSession;
        }

        public OtpSession GetOtpSessionByUserName(int ucid)
        {
            return _context.OtpSession.FirstOrDefault(p => p.ucid==ucid);
        }

        public void UpdateOtpSession(OtpSession OtpSession)
        {
            _context.OtpSession.Update(OtpSession);
            _context.SaveChanges();
        }
    }
}


