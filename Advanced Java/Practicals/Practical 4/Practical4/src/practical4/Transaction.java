package practical4;
import java.sql.*;
public class Transaction {
   public static Connection conn;
   public static void main(String[] args) {
       String url = "jdbc:mysql://localhost:3306/library";
       String user = "root";
       String password = "root";
       try {
           Class.forName("com.mysql.cj.jdbc.Driver");
           Connection conn = DriverManager.getConnection(url, user, password);
           conn.setAutoCommit(false);
           String sql1 = "UPDATE Employee SET name = 'Gaurav' WHERE empid = 1";
           Statement stmt = conn.createStatement();
           stmt.executeUpdate(sql1);
           conn.commit();
           stmt.close();
           conn.close();
       } catch (Exception e) {
           e.printStackTrace();
           try {
               conn.rollback();
           } catch (SQLException se) {
               se.printStackTrace();
           }
       }
   }
}