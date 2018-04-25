using AutoMapper;
using Ninject;
using StrongKeys.Common.GAModels;
using StrongKeys.Common.ImageWorkers;
using StrongKeys.Common.Interfaces;
using StrongKeys.DAL.Entities;
using StrongKeys.WebRunner.Models.DTOs;
using StrongKeys.WebRunner.Modules;

namespace StrongKeys.WebRunner.Helpers
{
    public class WebProfile : Profile
    {
        public WebProfile()
        {
            var kernel = new StandardKernel(new CryptoModule());
            var target = kernel.Get<ICryptoTarget>();

            CreateMap<Population, PopulationDTO>()
                .ForMember(x => x.OriginalImage,
                o => o.MapFrom(s => BitmapImageReaderWriter.GetBitmapBytes(s.OriginalImage)))
                .ForMember(x => x.EncryptedImage,
                o => o.MapFrom(s => BitmapImageReaderWriter.GetBitmapBytes(new ImageProperties
                {
                    Width = s.OriginalImage.Width,
                    Height = s.OriginalImage.Height,
                    Image = s.EncryptedImage
                })));

            CreateMap<Chromosome, ChromosomeDTO>()
                .ForMember(x => x.DecryptedImage,
                o => o.ResolveUsing((src, dest, destMember, resContext) =>
                dest.DecryptedImage = BitmapImageReaderWriter.GetBitmapBytes(new ImageProperties
                {
                    Width = (int)resContext.Items["Width"],
                    Height = (int)resContext.Items["Height"],
                    Image = target.Decrypt(resContext.Items["Image"] as byte[], src.Key)
                })));

            CreateMap<Generation, GenerationDTO>();
            CreateMap<Chromosome, ChromosomeMinDTO>();
            CreateMap<Generation, GenerationMinDTO>();
        }
    }
}