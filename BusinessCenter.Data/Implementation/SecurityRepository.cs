using BusinessCenter.Data.Common;
using BusinessCenter.Data.Interface;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessCenter.Data.Implementation
{
    public class SecurityRepository : GenericRepository<SecurityQuestion>, ISecurityRepository
    {
        
        protected IdentityConnectionContext _context;

        // Before this constructor gets called.. base class constructor with one parameter will get called
        public SecurityRepository(IUnitOfWork context) : base(context)
        {
            _context = (IdentityConnectionContext)context.getContext();
        }
        public new IEnumerable<SecurityQuestion> GetAll()
        {
            return _context.SecurityQuestion.AsEnumerable<SecurityQuestion>();
        }
    }
}
