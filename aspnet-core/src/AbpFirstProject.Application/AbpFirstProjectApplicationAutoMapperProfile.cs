using AutoMapper;

namespace AbpFirstProject
{
    public class AbpFirstProjectApplicationAutoMapperProfile : Profile
    {
        public AbpFirstProjectApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Todo, TodoDto>();
        }
    }
}
