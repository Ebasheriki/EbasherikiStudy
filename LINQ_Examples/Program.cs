﻿using System;
using System.Collections.Generic;
using System.Linq;
using FirstTask.ManyToMany;

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // init actors and films
            var actorBodya = new Actor
            {
                Id = new Random().Next(1, 10000),
                Name = "Bodya"
            };
            var actorKolya = new Actor
            {
                Id = new Random().Next(1, 10000),
                Name = "Kolya"
            };
            var filmTupitNaLINQ = new Film
            {
                Id = new Random().Next(1, 10000),
                Name = "tupitNaLINQ"
            };
            var filmOtchislen = new Film
            {
                Id = new Random().Next(1, 10000),
                Name = "Otchislen"
            };
            var actorFilmKolyaOtchislen = new ActorFilm
            {
                ActorId = actorKolya.Id,
                FilmId = filmOtchislen.Id
            };
            var actorFilmBodyaTupoi = new ActorFilm
            {
                ActorId = actorBodya.Id,
                FilmId = filmTupitNaLINQ.Id
            };
            var actorFilmKolyaTupoi = new ActorFilm
            {
                ActorId = actorKolya.Id,
                FilmId = filmTupitNaLINQ.Id
            };
            // create collections with actors and films
            // create collection that unites actors and films
            // for visual example read https://dzone.com/articles/how-to-handle-a-many-to-many-relationship-in-datab
            var actorList = new List<Actor> {actorBodya, actorKolya};
            var filmList = new List<Film> {filmOtchislen, filmTupitNaLINQ};
            var actorFilms = new List<ActorFilm> {actorFilmBodyaTupoi, actorFilmKolyaOtchislen, actorFilmKolyaTupoi};
            // fill films collection (List<Film> Films) in authors
            var actorsWithFilms =
                from actor in actorList
                    select new Actor
                    {
                        Id = actor.Id,
                        Name = actor.Name,
                        Films = (from actorFilm in actorFilms
                            join film in filmList on actorFilm.FilmId equals film.Id
                            where actorFilm.ActorId == actor.Id
                            select film).ToList(),
                    };
            // write in console
            actorsWithFilms.ToList().ForEach(_ =>
            {
                Console.WriteLine($"Id: {_.Id} \n Name: {_.Name} \n Films:");
                _.Films.ForEach(x => Console.WriteLine($"        Id: {x.Id} | Name: {x.Name}"));
            });
        }
    }
}
