using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMvcApplication.Models;
using TestMvcApplication.DAL;

namespace TestMvcApplication.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        //public ActionResult Load()
        //{
        //    Employee emp = new Employee{ EmployeeId = 100, FirstName = "Nanda", LastName = "Periyasamy" };
        //    return View("Employee", emp);
        //}

        public ActionResult Enter()
        {
            //Employee emp = new Employee();
            //User usr = new User(){UserName = "Quest"};
            EmployeeViewModel emp = new EmployeeViewModel();
            emp.emp = new Employee();
            emp.usr = new User(){UserName = "Quest"};
            //ViewBag.CurrentUser = usr;
            return View("EnterCustomer", emp);
        }

        //public ActionResult Submit([ModelBinder(typeof(EmployeeBinder))] Employee emp)
        public ActionResult Submit(Employee emp)
        {
            if (ModelState.IsValid)
            {
                EmployeeDal dal = new EmployeeDal();
                dal.Employees.Add(emp);
                dal.SaveChanges();
                return View("Employee", emp);
            }

            return View("EnterCustomer", emp);
        }
    }

    //public class EmployeeBinder: IModelBinder
    //{

    //    public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
    //    {
    //        HttpContextBase objContext = controllerContext.HttpContext;
    //        string empId = objContext.Request.Form["EmpId"];
    //        string fName = objContext.Request.Form["FName"];

    //        Employee objEmployee = new Employee() {EmployeeId = empId, Name = fName};
    //        return objEmployee;
    //    }
    //}
}
