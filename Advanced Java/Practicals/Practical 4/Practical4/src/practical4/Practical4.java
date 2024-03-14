//package practical4;
//import java.sql.*;
//
///*
//CREATE TABLE Employee (
//    emp_id INT PRIMARY KEY,
//    emp_name VARCHAR(255),
//    emp_salary DECIMAL(10, 2),
//    emp_department VARCHAR(255),
//    emp_designation VARCHAR(255)
//);
//
//
//DELIMITER $$
//CREATE PROCEDURE UpdateEmployeeSalary(
//    IN p_emp_id INT,
//    OUT p_new_salary DECIMAL(10, 2)
//)
//BEGIN
//    DECLARE v_old_salary DECIMAL(10, 2);
//    SELECT emp_salary INTO v_old_salary
//    FROM employee
//    WHERE emp_id = p_emp_id;
//    SET p_new_salary = v_old_salary * 1.2;
//    UPDATE employee
//    SET emp_salary = p_new_salary
//    WHERE emp_id = p_emp_id;
//END;
//$$
//DELIMITER ;
//*/
//
//
//public class Practical4 {
//   private static final String DB_DRIVER_CLASS = "com.mysql.jdbc.Driver";
//   private static final String DB_URL = "jdbc:mysql://localhost:3306/library";
//   private static final String DB_USERNAME = "root";
//   private static final String DB_PASSWORD = "root";
//
//   public static void main(String[] args) {
//       Connection con = null;
//       CallableStatement stmt = null;
//       
//       try {
//           Class.forName(DB_DRIVER_CLASS);
//           con = DriverManager.getConnection(DB_URL, DB_USERNAME, DB_PASSWORD);
//           stmt = con.prepareCall("{call UpdateEmployeeSalary(?, ?)}");
//           stmt.setInt(1, 1); // assuming the employee ID is 1
//           stmt.setDouble(2, 0.20); // 20% increase
//           stmt.execute();
//       } catch (ClassNotFoundException | SQLException e) {
//           e.printStackTrace();
//       } finally {
//           try {
//               if (stmt != null) stmt.close();
//               if (con != null) con.close();
//               System.out.println("Updated");
//           } catch (SQLException e) {
//               e.printStackTrace();
//           }
//           
//       }
//   }
//}


