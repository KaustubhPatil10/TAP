select * from employee;

SELECT  e.employee_id  AS  EmployeeID,
        e.employeename AS EmployeeName,
        m.employeename  AS ManagerName
FROM  employee e
LEFT JOIN employee m ON e.managerid =m.employee_id;
