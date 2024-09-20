using CasionApp.Models;
using CasionApp.Models.MetaData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CasionApp
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static CasinoDBEntities DB = new CasinoDBEntities();
        public static User contextUser;
        public static Frame mainFrame;
        public static Page mainPage;

        App()
        {
            RegistrProvider<User, MetaUser>();
        }

        private void RegistrProvider<T, A>()
        {
            var provider = new AssociatedMetadataTypeTypeDescriptionProvider(typeof(T), typeof(A));
            TypeDescriptor.AddProviderTransparent(provider, typeof(T));
        }

        
    }
}
