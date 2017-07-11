/*******************************************************************************
 * Copyright © 2016 东青信息版权所有
 * Author: Allen
 * 安徽东青信息软件开发组
 * 
*********************************************************************************/
using NFine.Data.Entity.SystemManage;
using System.Data.Entity.ModelConfiguration;

namespace NFine.Data.SystemManage
{
    public class ModuleMap : EntityTypeConfiguration<ModuleEntity>
    {
        public ModuleMap()
        {
            this.ToTable("Sys_Module");
            this.HasKey(t => t.F_Id);
        }
    }
}
