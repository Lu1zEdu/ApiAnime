using API.Domain.Entity;
using API.Domain.Enum;

namespace API.Infrastructure.Mapper;

    public static class UserMapper
    {
        public static User ToUserEntity(this User user, Rating rating)
        {
            if (rating == null)
                throw new ArgumentException("É necessário escolher um Rating para o usuário.");

            user.Rating = rating;
            return user;
        }
    }
