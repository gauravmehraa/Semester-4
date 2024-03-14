package library;
import javax.swing.*;
import java.awt.event.*;
import java.sql.*;

public class AdminPanel implements ActionListener{
    JFrame frame;
    JButton badd, bview, bdel, blog;
    JLabel title, idlabel, namelabel, passwordlabel;
    JTextField id, name, password;
    
    public AdminPanel(){
        frame = new JFrame("Library");
        frame.setVisible(true);
        frame.setSize(500, 600);
        frame.setLayout(null);
        
        title = new JLabel("Admin Section");
        badd = new JButton("Add Librarian");
        bview = new JButton("View Librarian");
        bdel = new JButton("Delete Librarian");
        blog = new JButton("Logout");
        id = new JTextField();
        idlabel  = new JLabel("Librarian ID: ");
        name = new JTextField();
        namelabel  = new JLabel("Username: ");
        password = new JTextField();
        passwordlabel  = new JLabel("Password: ");
        
        
        title.setBounds(170, 50, 400, 30);
        id.setBounds(170, 90, 150, 20);
        idlabel.setBounds(100, 90, 400, 30);
        name.setBounds(170, 120, 150, 20);
        namelabel.setBounds(100, 120, 400, 30);
        password.setBounds(170, 150, 150, 20);
        passwordlabel.setBounds(100, 150, 400, 30);
        badd.setBounds(170, 190, 150, 50);
        bview.setBounds(170, 250, 150, 50);
        bdel.setBounds(170, 310, 150, 50);
        blog.setBounds(170, 370, 150, 50);
        
        blog.addActionListener(this);
        badd.addActionListener(this);
        bview.addActionListener(this);
        bdel.addActionListener(this);
        
        frame.add(title);
        frame.add(id);
        frame.add(idlabel);
        frame.add(name);
        frame.add(namelabel);
        frame.add(password);
        frame.add(passwordlabel);
        frame.add(badd);
        frame.add(bview);
        frame.add(bdel);
        frame.add(blog);
    }
    @Override
    public void actionPerformed(ActionEvent e){
        try{
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection("jdbc:mysql://localhost:3306/library?characterEncoding=utf8", "root", "root");
            PreparedStatement stmt = null;
            
            if(e.getSource() == badd){
                stmt = (PreparedStatement) con.prepareStatement("insert into librarian values(?, ?, ?)");
                stmt.setInt(1, Integer.parseInt(id.getText()));
                stmt.setString(2, name.getText());
                stmt.setString(3, password.getText());
                int i  = stmt.executeUpdate();
                if(i != 0){
                    JOptionPane.showMessageDialog(frame, "Librarian '"+name.getText()+"' inserted");
                    id.setText("");
                    name.setText("");
                    password.setText("");
                }
            }
            
            if(e.getSource() == bview){
                stmt = (PreparedStatement) con.prepareStatement("select * from librarian where id=?");
                stmt.setInt(1, Integer.parseInt(id.getText()));
                ResultSet rs  = stmt.executeQuery();
                if(rs.next()){
                    JOptionPane.showMessageDialog(frame, "ID: " + rs.getInt(1) + "\nName: " + rs.getString(2)+ "\nPassword: " + rs.getString(3));
                    id.setText("");
                    name.setText("");
                    password.setText("");
                }
                else{
                    JOptionPane.showMessageDialog(frame, "Librarian not found");
                }
            }
            
            if(e.getSource() == bdel){
                stmt = (PreparedStatement) con.prepareStatement("delete from librarian where id=?");
                stmt.setInt(1, Integer.parseInt(id.getText()));
                int i  = stmt.executeUpdate();
                if(i != 0){
                    JOptionPane.showMessageDialog(frame, "Librarian " +id.getText()+ " deleted");
                    id.setText("");
                    name.setText("");
                    password.setText("");
                }
                else{
                    JOptionPane.showMessageDialog(frame, "Librarian not found");
                }
            }
            
            if(e.getSource() == blog){
                frame.dispose();
                HomePage.main(new String[]{});
            }
        }
        catch(Exception ex){
            ex.printStackTrace();
        }
    }
    public static void main(String[] args) {
        new AdminPanel();
    }
    
}
