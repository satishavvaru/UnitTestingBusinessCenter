using BusinessCenter.Data;
using BusinessCenter.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessCenter.Service.Interface;

namespace BusinessCenter.Service.Implementation
{
    public class SecurityQuestionService : ISecurityQuestionsService
    {
        protected ISecurityRepository _repository;

        /// <summary>
        /// Initializes a new Instance of SecurityQuestionService
        /// </summary>
        /// <param name="repo"></param>
        public SecurityQuestionService(ISecurityRepository repo)
        {
            _repository = repo;
        }

        public IEnumerable<SecurityQuestion> GetAll()
        {
            var f = _repository.GetAll();
            return f.ToList();
        }
    }
}
