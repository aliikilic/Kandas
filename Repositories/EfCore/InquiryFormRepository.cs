using Entities.Dtos;
using Entities.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EfCore
{
    public class InquiryFormRepository : RepositoryBase<PersonInquiryForm>, IInquiryFormRepository
    {
        public InquiryFormRepository(RepositoryContext context) : base(context)
        {
        }

        public void FirstInquiryForm(PersonInquiryForm form, int id)
        {
            form.PersonalInformationId = id;
            form.LastCheckDate = DateTime.Today;
            Create(form);
        }

        public void UpdateInquiryForm(PersonInquiryForm form, int id)
        {
            form.PersonalInformationId = id;
            form.LastCheckDate = DateTime.Today;
            Update(form);
            
        }
    }
}
