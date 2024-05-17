﻿
using Transflower.ECommerce.HR.Entities;
using Transflower.ECommerce.HR.Controllers;
using Transflower.ECommerce.HR.Services;
using Transflower.ECommerce.HR.Repositories;
using Transflower.ECommerce.HR.Repositories.Interfaces;
using Transflower.ECommerce.HR.Services.Interfaces;


using Transflower.ECommerce.Entities;
using Transflower.ECommerce.Controllers;
using Transflower.ECommerce.Services;
using Transflower.ECommerce.Repositories;
using Transflower.ECommerce.Repositories.Interfaces;
using Transflower.ECommerce.Services.Interfaces;

using Transflower.ECommerce.Employees.Entities;
using Transflower.ECommerce.Employees.Controllers;
using Transflower.ECommerce.Employees.Services;
using Transflower.ECommerce.Employees.Repositories;
using Transflower.ECommerce.Employees.Repositories.Interfaces;
using Transflower.ECommerce.Employees.Services.Interfaces;


IMembershipRepository repo = new MembershipMSSQLRepository();
//IMembershipRepository repo=new MembershipMySqlRepository();
IMembershipService service=new MembershipService(repo);
MembershipController controller=new MembershipController(service);
List<Member> allMembers=await controller.GetAll();

foreach (Member member in allMembers){
       Console.WriteLine(member);
}

Console.WriteLine(" ");

/*IRolesRepository repo1=new RolesRepository();
IRolesService service1=new RolesService(repo1);
RolesController controllers=new RolesController(service1);
List<Roles> allRoles=await controllers.GetAllRoles();

foreach (Roles roles in allRoles){
       Console.WriteLine(roles);
}

*/