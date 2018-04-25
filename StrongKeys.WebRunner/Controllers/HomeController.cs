using AutoMapper;
using StrongKeys.Common.Interfaces;
using StrongKeys.DAL;
using StrongKeys.WebRunner.Models.DTOs;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using PagedList.Mvc;
using PagedList;

namespace StrongKeys.WebRunner.Controllers
{
    public class HomeController : Controller
    {
        readonly IDBContext _dBContext;
        readonly IMapper _mapper;
        readonly ICryptoTarget _target;
        readonly int _pageSize;
        public HomeController(IDBContext dBContext, IMapper mapper, ICryptoTarget target)
        {
            _dBContext = dBContext;
            _mapper = mapper;
            _target = target;
            _pageSize = 5;
        }

        public ActionResult Index()
        {
            return View(_mapper.Map<List<PopulationDTO>>(_dBContext.GetAllPopulations().ToList()));
        }

        public ActionResult Population(int id, int? page)
        {
            var population = _dBContext.GetPopulation(id);
            var generationsData = _dBContext.GetGenerations(id, ((page ?? 1) - 1) * _pageSize, _pageSize);
            var generations = _mapper.Map<List<GenerationDTO>>(generationsData,
                opt =>
                {
                    opt.Items.Add("Image", population.EncryptedImage);
                    opt.Items.Add("Width", population.OriginalImage.Width);
                    opt.Items.Add("Height", population.OriginalImage.Height);
                });
            var pagedList = new StaticPagedList<GenerationDTO>(generations, (page ?? 1), _pageSize, (int)_dBContext.GetGenerationsCount(id));
            return View(pagedList);
        }

        public ActionResult PopulationAll(int id, int? page)
        {
            var pageSize = 50;
            var generationsData = _dBContext.GetGenerations(id, ((page ?? 1) - 1) * pageSize, pageSize);
            var generations = _mapper.Map<List<GenerationMinDTO>>(generationsData);
            var pagedList = new StaticPagedList<GenerationMinDTO>(generations, (page ?? 1), pageSize, (int)_dBContext.GetGenerationsCount(id));
            return View(pagedList);
        }
    }
}