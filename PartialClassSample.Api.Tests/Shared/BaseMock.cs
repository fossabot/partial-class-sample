﻿using FizzWare.NBuilder;
using Model = PartialClassSample.Api.Models;

namespace PartialClassSample.Api.Tests.Shared
{
    public class BaseMock
    {
        public Model.Register RegisterFake(string lastName = null, string firstName = null, string email = null, string passWord = null)
            => Builder<Model.Register>.CreateNew()
                .With(_ => _.Id, 1)
                .With(_ => _.LastName, lastName ?? "None")
                .With(_ => _.FirstName, firstName ?? "No Name")
                .With(_ => _.Email, email ?? "any@nothing.com")
                .With(_ => _.PassWord, passWord ?? "1234")
                .Build();
    }
}