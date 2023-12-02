
using Interfaces;

//IPersonManager customerManager = new CustomerManager();
//customerManager.Add();

//IPersonManager employeeManager = new EmployeeManager();
//employeeManager.Add();

ProjectManager projectManager = new ProjectManager();
projectManager.Add(new CustomerManager());