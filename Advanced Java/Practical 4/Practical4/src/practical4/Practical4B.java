package practical4;
import java.sql.*;

public class Practical4B {
  private static final String DB_DRIVER_CLASS = "com.mysql.jdbc.Driver";
  private static final String DB_USERNAME = "root";
  private static final String DB_PASSWORD = "root";

   public static void main(String[] args) {
       String url = "jdbc:mysql://localhost:3306/library";
       String user = "root";
       String password = "root";

       try {
           Class.forName(DB_DRIVER_CLASS);
           Connection conn = DriverManager.getConnection(url, user, password);

           String sql = "SELECT emp_id, emp_name, emp_salary, emp_department from Employee";

           Statement stmt = conn.createStatement();
           ResultSet rs = stmt.executeQuery(sql);

           // Process the ResultSet
           while (rs.next()) {
               Integer id = rs.getInt("emp_id");
               String name = rs.getString("emp_name");
               String salary = rs.getString("emp_salary");
               String dept = rs.getString("emp_department");

               System.out.println("Employee ID: " + id);
               System.out.println("Name: " + name);
               System.out.println("Salary: " + salary);
               System.out.println("Department: " + dept);
               System.out.println();
           }

           // Close resources
           rs.close();
           stmt.close();
           conn.close();
       } catch (Exception e) {
           e.printStackTrace();
       }
   }
}
