Web site on ASP.NET MVC6 Core 2.2 and Abp (UI boilerplate framework) 
 Support functionality:
 - Multi-Tenancy configuration (run IS.Migrator to create host Database.) -
  DB migrations will be applied to base tenant Db (create DB and fill with admin user);  
 - IdentityServer4 (IS.Web.Host - starts IdentityServer);
 - IS.Web.Mvc = web project on ASP.NET MVC Core2.2 and Abp framework 
Includes:
   * login as "super" admin (without Tenant:  Tenant= null).
          Login: admin
          Password: 123qwe

Super admin can with all tenants, create\edit\remove;
   * login as "tenant" and (Tenant\Brand name must be selected)
Tenant admin can 
  ** create\edit\delete users of this tenant;
  ** create\remove toles;
User of some tenant may see UI of this Tenant (brand);
