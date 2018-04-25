namespace StrongKeys.WebRunner.Helpers
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            global::AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.AddProfile(new WebProfile());
            });
        }
    }
}