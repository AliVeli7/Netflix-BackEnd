using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Http;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MovieManager>().As<IMovieService>().SingleInstance();
            builder.RegisterType<EfMovieDal>().As<IMovieDal>().SingleInstance();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<GenreManager>().As<IGenreService>();
            builder.RegisterType<EfGenreDal>().As<IGenreDal>();

            builder.RegisterType<ActorManager>().As<IActorService>();
            builder.RegisterType<EfActorDal>().As<IActorDal>();

            builder.RegisterType<ProductionCompanyManager>().As<IProductionCompanyService>();
            builder.RegisterType<EfProductionCompanyDal>().As<IProductionCompanyDal>();

            builder.RegisterType<ProductionCountryManager>().As<IProductionCountryService>();
            builder.RegisterType<EfProductionCountryDal>().As<IProductionCountryDal>();
            builder.RegisterType<TvSeriesManager>().As<ITvSeriesService>();
            builder.RegisterType<EfTvSeriesDal>().As<ITvSeriesDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}
