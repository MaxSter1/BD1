using AutoMapper;
using BusinessLogic.Concrete;
using BusinessLogic.Interface;
using MongoDal.Concrete;
using MongoDal.Interface;
using MongoDTO;
using Neo4jDal.Concrete;
using Neo4jDal.Interface;
using SocialWinFormApp.Models;
using SocialWinFormApp.Profiles;
using SocialWinFormApp.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using Unity.Injection;

namespace SocialWinFormApp
{
    static class Program
    {
        public static UnityContainer Container;
        public static string _connString;
        public static string _DbName;

        public static string _connNeo4j,_login,_pass;
        //public static IAppUser user;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            _connNeo4j = "http://localhost:7474/db/data/";
            _login = "neo4j";
            _pass = "sbhbsbbhsbfh";

            _connString = "mongodb://localhost:27017/";
            _DbName = "SocialDatabase";


            ConfigureUnity();


            var Login = Container.Resolve<LoginForm>();
            if(Login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(Container.Resolve<StartPage>());
            }
            else
            {
                Application.Exit();
            }



        }

        private static void ConfigureUnity()
        {
            MapperConfiguration config = new MapperConfiguration(
              cfg =>
              {
                  cfg.AddProfile(new UserProfile());
                  cfg.AddProfile(new PostProfile());
              });

           

            Container = new UnityContainer();
            Container.RegisterInstance<IMapper>(config.CreateMapper());

            Container.RegisterInstance<IAppUser>(new AppUser());
            Container.RegisterType<IAuthManager, AuthManager>()
                .RegisterType<IPostManager, PostManager>()
                .RegisterType<IUserManager, UserManager>();
            Container
                .RegisterType<IUserDal, UserDal>(new InjectionConstructor(_connString, _DbName))
                .RegisterType<IPostDal, PostDal>(new InjectionConstructor(_connString, _DbName));
            Container
                .RegisterType<IFollowerDal, FollowerDal>(new InjectionConstructor(_connNeo4j,_login,_pass));

        }
    }
}
