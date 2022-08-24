using AutoMapper;
using AutoMapper.QueryableExtensions;
using RpgChestMVC.Application.Interfaces;
using RpgChestMVC.Application.ViewModels.Item;
using RpgChestMVC.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChestMVC.Application.Services
{
    public class FullArmorService : IFullArmorService
    {

        private readonly IFullArmorRepository _fullArmorRepository;
        private readonly ISingleItemRepository _singleItemRepository;

        private readonly IMapper _mapper;
        

        public FullArmorService(IFullArmorRepository fullArmorRepository, ISingleItemRepository singleItemRepository, IMapper mapper)
        {
            _fullArmorRepository = fullArmorRepository;
            _singleItemRepository = singleItemRepository;
            _mapper = mapper;
            

        }

        public int AddNewFullArmor(NewSingleFullArmorWm fullArmor)
        {
            throw new NotImplementedException();
        }

        public List<int> GetAllFullArmors()
        {
            return new List<int>();
        }

        public ListofFullArmorsVm GetAllFullArmorsForList(int pageSize, int pageNumber, string searchString,bool isActive)
        {
            var fullArmors = _fullArmorRepository.GetAllActiveFullArmors().Where(p => p.TypeOfArmor.ArmorTypes.StartsWith(searchString))
                .ProjectTo<SingleFullArmorForListVm>(_mapper.ConfigurationProvider).ToList();

            var fullArmosToShow = fullArmors.Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
            var fullArmorList = new ListofFullArmorsVm()
            {
                PageSize = pageSize,
                CurrentPage = pageNumber,
                SearchString = searchString,
                FullArmors = fullArmosToShow,
                Count = fullArmors.Count
            };
            return fullArmorList;
        }

        public SingleFullArmorForDetailsVm GetFullArmorDetails(int fullArmorId)
        {
            var fullArmor = _fullArmorRepository.GetFullArmorById(fullArmorId);

            var fullArmorVm = _mapper.Map<SingleFullArmorForDetailsVm>(fullArmor);

            fullArmorVm.Resistances = new List<ResistanceForListVm>();

            foreach (var resistance in fullArmorVm.Resistances)
            {

                var add = new ResistanceForListVm()
                {
                    Id = resistance.Id,
                    Resistances = resistance.Resistances,
                    ValueR = resistance.ValueR
                };
                fullArmorVm.Resistances.Add(add);
            }
            return fullArmorVm;
      
        }
    }
}
