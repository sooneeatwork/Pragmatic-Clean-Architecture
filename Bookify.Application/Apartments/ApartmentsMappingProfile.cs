using AutoMapper;
using Bookify.Application.Apartments.SearchApartments;
using Bookify.Domain.Apartments;

namespace Bookify.Application.Apartments;

public class ApartmentsMappingProfile: Profile
{
    #region Construction

    public ApartmentsMappingProfile()
    {
        CreateMap<Apartment, ApartmentListModel>()
            .ForMember(m => m.City, o => o.MapFrom(a => a.Address.City))
            .ForMember(m => m.Country, o => o.MapFrom(a => a.Address.Country))
            .ForMember(m => m.State, o => o.MapFrom(a => a.Address.State))
            .ForMember(m => m.Street, o => o.MapFrom(a => a.Address.Street))
            .ForMember(m => m.ZipCode, o => o.MapFrom(a => a.Address.ZipCode));
    }

    #endregion
}
