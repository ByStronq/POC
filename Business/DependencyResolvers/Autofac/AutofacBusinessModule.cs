using Autofac;
using Business.Abstract;
using Business.Concrete;
using Core.Entities;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EfContext>().As<IDbContext>();

            builder.RegisterType<EmployeeManager>().As<IEmployeeService>().SingleInstance();
            builder.RegisterType<EfEmployeeDal>().As<IEmployeeDal>().SingleInstance();

            builder.RegisterType<DepartmentManager>().As<IDepartmentService>().SingleInstance();
            builder.RegisterType<EfDepartmentDal>().As<IDepartmentDal>().SingleInstance();

            builder.RegisterType<DepartmentAssignmentManager>().As<IDepartmentAssignmentService>();
            builder.RegisterType<EfDepartmentAssignmentDal>().As<IDepartmentAssignmentDal>();
        }
    }
}
