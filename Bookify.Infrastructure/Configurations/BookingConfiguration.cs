using Bookify.Domain.Apartments;
using Bookify.Domain.Bookings;
using Bookify.Domain.Shared;
using Bookify.Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bookify.Infrastructure.Configurations;

internal sealed class BookingConfiguration: IEntityTypeConfiguration<Booking>
{
    public void Configure(EntityTypeBuilder<Booking> builder)
    {
        builder.HasKey(b => b.Id);

        builder.OwnsOne(b => b.PriceForPeriod, priceBuilder =>
                                               {
                                                   priceBuilder.Property(m => m.Currency)
                                                               .HasConversion(c => c.Code, code => Currency.FromCode(code));
                                               });

        builder.OwnsOne(b => b.CleaningFee, priceBuilder =>
                                               {
                                                   priceBuilder.Property(m => m.Currency)
                                                               .HasConversion(c => c.Code, code => Currency.FromCode(code));
                                               });
        
        builder.OwnsOne(b => b.AmenitiesUpCharge, priceBuilder =>
                                            {
                                                priceBuilder.Property(m => m.Currency)
                                                            .HasConversion(c => c.Code, code => Currency.FromCode(code));
                                            });
        
        builder.OwnsOne(b => b.TotalPrice, priceBuilder =>
                                                  {
                                                      priceBuilder.Property(m => m.Currency)
                                                                  .HasConversion(c => c.Code, code => Currency.FromCode(code));
                                                  });

        builder.OwnsOne(b => b.Duration);

        builder.HasOne<Apartment>()
               .WithMany()
               .HasForeignKey(b => b.ApartmentId);

        builder.HasOne<User>()
               .WithMany()
               .HasForeignKey(b => b.UserId);
    }
}
