package login;
import com.opensymphony.xwork2.ActionSupport;
public class LoginAction extends ActionSupport{
    String username, password;
    public String getUsername(){
        return username;
    }
    public void setUsername(String username){
        this.username = username;
    }
    public String getPassword(){
        return password;
    }
    public void setPassword(String password){
        this.password = password;
    }
    public String execute(){
        return username.equals("gaurav") && password.equals("root")? "Success": "Error";
    }
}
