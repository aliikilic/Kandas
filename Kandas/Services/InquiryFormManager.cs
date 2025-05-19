using AutoMapper;
using Entities.Dtos;
using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class InquiryFormManager : IInquiryFormService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;

        public InquiryFormManager(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public async Task CreateInquiryForm(CreateInquiryFormDto form, int id)
        {
            var entity = _mapper.Map<PersonInquiryForm>(form);
            if (entity is null)
                throw new Exception("Form boş olamaz");
            _manager.InquiryForm.FirstInquiryForm(entity,id);
            await _manager.SaveAsync();
        }

        public async Task UpdateInquiryForm(UpdateInquiryDto form, int id)
        {
            var entity = _mapper.Map<PersonInquiryForm>(form);
            if (entity is null)
                throw new Exception("Form boş olamaz");
            _manager.InquiryForm.UpdateInquiryForm(entity,id);
            await _manager.SaveAsync();
            
        }
    }
}
