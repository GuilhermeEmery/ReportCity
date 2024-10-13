﻿using Fiap.Api.ReportCity.Models;

namespace Fiap.Api.ReportCity.Data.Repository
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        User GetById(int id);
        void Add(User user);
        void Update(User user);
        void Delete(int id);
    }
}
