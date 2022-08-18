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

        private readonly IMapper _mapper;


        public FullArmorService(IFullArmorRepository fullArmorRepository, IMapper mapper)
        {
            _fullArmorRepository = fullArmorRepository;
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



        public ListofFullArmorsVm GetAllFullArmorsForList(bool isActive)
        {
            var fullArmors = _fullArmorRepository.GetAllActiveFullArmors()
                .ProjectTo<SingleFullArmorForListVm>(_mapper.ConfigurationProvider)
                .ToList();
            var fullArmorList = new ListofFullArmorsVm()
            {
                FullArmors = fullArmors,
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
