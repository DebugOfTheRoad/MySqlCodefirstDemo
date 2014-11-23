using Common.Data;
using Core.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Configurations
{
    internal partial class UserConfiguration :EntityTypeConfiguration<User>,IEntityMapper
    {
        partial void UserConfigurationAppend();
        public UserConfiguration()
        {
            UserConfigurationAppend();
        }

        public void RegistTo(ConfigurationRegistrar configurations)
        {
            configurations.Add(this);
           
        }
    }
}
