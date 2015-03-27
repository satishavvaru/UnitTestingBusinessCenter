using BusinessCenter.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Collections;
using System.Data;

namespace UnitTestProject1
{
    public class TestContext : DbContext
    {
        /// <summary>
        /// Dataset represents an in-memory cache of data.
        /// </summary>
        List<SecurityQuestion> liSecurityQuestions;
        DataSet ds;
        Hashtable ht;
        
        public TestContext()
            : base("Name=TestContext")
        {

        }

        public TestContext(bool enableLazyLoading, bool enableProxyCreation)
            : base("Name=TestContext")
        {
            Configuration.ProxyCreationEnabled = enableProxyCreation;
            Configuration.LazyLoadingEnabled = enableLazyLoading;
        }

        public TestContext(DbConnection connection, List<SecurityQuestion> _liSecurityQuestions, DataSet _ds, Hashtable _ht)
            : base(connection, true)
        {
            Configuration.LazyLoadingEnabled = false;
            this.liSecurityQuestions = _liSecurityQuestions;
            this.ds = _ds;
            this.ht = _ht;
        }

        public DbSet<SecurityQuestion> SecurityQuestions { get; set; }

        public void Seed(TestContext Context)
        {
            #region DataSet to HashTable Without Using List
            //ds.Tables.Add(new DataTable());
            //ds.Tables[0].Columns.Add("Id", typeof(int));
            //ds.Tables[0].Columns.Add("Questions", typeof(string));
            
            //ds.Tables[0].Rows[0]["Id"] = 1;
            //ds.Tables[0].Rows[0]["Questions"] = "Your Favorite past time";

            //ds.Tables[0].Rows[0]["Id"] = 2;
            //ds.Tables[0].Rows[0]["Questions"] = "Your hobbies";

            //ht.Add("SecurityQuestions",ds);
            #endregion

            var liSecurityQuestions = new List<SecurityQuestion> 
                { 
                    new SecurityQuestion { id=1,  Question = "Your Favorite past time" }, 
                    new SecurityQuestion { id =2, Question = "Your hobbies" }, 
                    new SecurityQuestion { id=3,  Question = "Your first school" }, 
                };


            var list = from b in liSecurityQuestions
                       select b;

            //DataTable dt = new DataTable();

            //dt.Columns.Add("Id");
            //dt.Columns.Add("Question");
            //foreach (var item in liSecurityQuestions)
            //{
            //    var row = dt.NewRow();

            //    row["Id"] = item.id;
            //    row["Question"] = item.Question;

            //    dt.Rows.Add(row);
            //}

            ds = (DataSet)list;

            ht.Add("SecurityQuestions", ds);

            Context.SecurityQuestions.Add(ht);
            Context.SaveChanges();
        }
       
    }
}
