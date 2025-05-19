using Entities.Dtos;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IInquiryFormService
    {
        Task CreateInquiryForm(CreateInquiryFormDto form,int id);
        Task UpdateInquiryForm(UpdateInquiryDto form,int id);
    }
}
