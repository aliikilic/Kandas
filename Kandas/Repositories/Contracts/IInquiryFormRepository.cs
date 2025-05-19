using Entities.Dtos;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IInquiryFormRepository : IRepositoryBase<PersonInquiryForm>
    {
        void FirstInquiryForm(PersonInquiryForm form,int id);
        void UpdateInquiryForm(PersonInquiryForm form, int id);
    }
}
