/*******************************************************************************
 * Copyright © 2016 东青信息版权所有
 * Author: Allen
 * 安徽东青信息软件开发组
 * 
*********************************************************************************/
using NFine.Data.Entity.SystemManage;
using System.Data.Entity.ModelConfiguration;

namespace NFine.Mapping.SystemManage
{
    public class UserMap : EntityTypeConfiguration<UserEntity>
    {
        public UserMap()
        {
            this.ToTable("Sys_User");
            this.HasKey(t => t.F_Id);
        }
    }
}
