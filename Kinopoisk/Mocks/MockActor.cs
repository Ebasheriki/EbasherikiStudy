﻿using Kinopoisk.Interfaces;
using Kinopoisk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinopoisk.Mocks
{
    public class MockActor : IActor
    {
        public IEnumerable<Actor> Actors
        {
            get
            {
                return new List<Actor>
                {
                    new Actor
                    {
                        Id = 0,
                        Name = "Biba"
                    },
                    new Actor
                    {
                        Id = 1,
                        Name = "Boba"
                    },
                    new Actor
                    {
                        Id = 2,
                        Name = "Ebanko"
                    },
                    new Actor
                    {
                        Id = 3,
                        Name = "Kekos"
                    }
                };
            }
        }
    }
}