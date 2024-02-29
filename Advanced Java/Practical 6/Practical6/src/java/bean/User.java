/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Admin
 */
package bean;
public class User {
    private String username;
    private String email;
    
    public User(){}
    
    public String getUsername(){ return username; }
    public void setUsername(String username){ this.username = username; }
    
    public String getEmail(){ return email; }
    public void setEmail(String email){ this.email = email; }
    
}
