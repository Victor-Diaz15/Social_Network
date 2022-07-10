using AutoMapper;
using Social_Network.Core.Application.Interfaces.Repositories;
using Social_Network.Core.Application.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Network.Core.Application.Services
{
    public class GenericService<SaveViewModel, ViewModel, Entity> : IGenericService<SaveViewModel, ViewModel, Entity>
        where SaveViewModel : class
        where ViewModel : class
        where Entity : class
    {

        private readonly IGenericRepository<Entity> _repository;
        private readonly IMapper _mapper;

        public GenericService(IGenericRepository<Entity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //METHODS

        //Method to get all ViewModel
        public virtual async Task<List<ViewModel>> GetAllViewModel()
        {
            var entityList = await _repository.GetAllAsync();

            return _mapper.Map<List<ViewModel>>(entityList);
        }

        //Method to get a SaveViewModel by id
        public virtual async Task<SaveViewModel> GetByIdSaveViewModel(int id)
        {
            Entity entity = await _repository.GetByIdAsync(id);

            SaveViewModel vm = _mapper.Map<SaveViewModel>(entity);

            return vm;
        }

        //Method to add new SaveViewModel
        public virtual async Task<SaveViewModel> AddSaveViewModel(SaveViewModel vm)
        {
            Entity entity = _mapper.Map<Entity>(vm);

            entity = await _repository.AddAsync(entity);

            SaveViewModel savedVm = _mapper.Map<SaveViewModel>(entity);

            return savedVm;
        }

        //Method to update a SaveViewModel
        public virtual async Task UpdateSaveViewModel(SaveViewModel vm, int id)
        {
            Entity entity = _mapper.Map<Entity>(vm);

            
            await _repository.UpdateAsync(entity, id);
        }

        //Method to delete a ViewModel
        public virtual async Task DeleteViewModel(int id)
        {
            Entity entity = await _repository.GetByIdAsync(id);
            await _repository.DeleteAsync(entity);
        }
    }
}
