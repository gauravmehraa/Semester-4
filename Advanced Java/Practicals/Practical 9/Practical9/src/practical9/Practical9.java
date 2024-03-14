package practical9;
import org.json.simple.JSONObject;
import org.json.simple.JSONValue;
public class Practical9 {
    public static void main(String[] args) {
        System.out.println("Student: \n");
        JSONObject student = new JSONObject();
        student.put("name", "Mayin");
        student.put("dob", "04-Dec-2004");
        student.put("mobile", "9999999999");
        System.out.print("Encoded: " + student);  
        
        Object obj=JSONValue.parse(student.toString());
        JSONObject jsonObject = (JSONObject) obj;
        String name = (String)jsonObject.get("name");
        String dob = (String)jsonObject.get("dob");
        String mobile = (String)jsonObject.get("mobile");
        System.out.println("\nDecoded: \nName: " + name +"\nDOB: " + dob + "\nMobile: " + mobile);
        
        System.out.println("Employee: \n");
        JSONObject employee = new JSONObject();
        employee.put("name", "Mayin");
        employee.put("id", "40315220036");
        employee.put("mobile", "9999999999");
        System.out.println("Encoded: " + employee);  
        
        obj=JSONValue.parse(employee.toString());
        jsonObject = (JSONObject) obj;
        name = (String)jsonObject.get("name");
        String id = (String)jsonObject.get("id");
        mobile = (String)jsonObject.get("mobile");
        System.out.println("\nDecoded: \nName: " + name +"\nEmployee ID: " + id + "\nMobile: " + mobile);
    }
}
