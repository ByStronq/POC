using Autofac;
using Business.Abstract;
using Business.Concrete;
using Core.Entities;
using DataAccess.Abstract;
using DataAccess.Concrete.ApiConsumers;
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
            builder.RegisterType<EmployeeApiManager>().As<IEmployeeApiService>().SingleInstance();
            builder.RegisterType<HttpClientEmployeeApiConsumer>().As<IEmployeeApiConsumer>().SingleInstance();

            builder.RegisterType<DepartmentManager>().As<IDepartmentService>().SingleInstance();
            builder.RegisterType<EfDepartmentDal>().As<IDepartmentDal>().SingleInstance();
            builder.RegisterType<DepartmentApiManager>().As<IDepartmentApiService>().SingleInstance();
            builder.RegisterType<HttpClientDepartmentApiConsumer>().As<IDepartmentApiConsumer>().SingleInstance();

            builder.RegisterType<DepartmentAssignmentManager>().As<IDepartmentAssignmentService>();
            builder.RegisterType<EfDepartmentAssignmentDal>().As<IDepartmentAssignmentDal>();
            builder.RegisterType<DepartmentAssignmentApiManager>().As<IDepartmentAssignmentApiService>().SingleInstance();
            builder.RegisterType<HttpClientDepartmentAssignmentApiConsumer>().As<IDepartmentAssignmentApiConsumer>().SingleInstance();
        }
    }
}
