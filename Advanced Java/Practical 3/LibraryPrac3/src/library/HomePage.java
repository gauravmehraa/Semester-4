package library;
import javax.swing.*;
import java.awt.event.*;
import java.sql.*;

public class HomePage implements ActionListener{
    JFrame frame;
    JButton badmin, blib;
    JLabel title;
    JTextField user, pass;
    
    public HomePage(){
        frame = new JFrame("Library");
        frame.setVisible(true);
        frame.setSize(600, 400);
        frame.setLayout(null);
        
        title = new JLabel("Library Management System");
        badmin = new JButton("Admin Login");
        blib = new JButton("Librarian Login");
        user = new JTextField();
        pass = new JTextField();
        
        title.setBounds(160, 50, 400, 30);
        user.setBounds(170, 75, 150, 20);
        pass.setBounds(170, 100, 150, 20);
        badmin.setBounds(170, 150, 150, 50);
        blib.setBounds(170, 250, 150, 50);
        
        badmin.addActionListener(this);
        blib.addActionListener(this);
        
        frame.add(title);
        frame.add(user);
        frame.add(pass);
        frame.add(badmin);
        frame.add(blib);
    }
    @Override
    public void actionPerformed(ActionEvent e){
        try{
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection("jdbc:mysql://localhost:3306/library?characterEncoding=utf8", "root", "root");
            PreparedStatement stmt = null;
            
                if(e.getSource() == badmin){
                    stmt = (PreparedStatement) con.prepareStatement("select * from admin where username=? and password = ?");
                    stmt.setString(1, user.getText());
                    stmt.setString(2, pass.getText());
                    ResultSet rs = stmt.executeQuery();
                    if(rs.next()){
                        frame.dispose();
                        AdminPanel.main(new String[]{});
                    }
                    else{
                        JOptionPane.showMessageDialog(frame, "Incorrect ID Password");
                    }
            }
            if(e.getSource() == blib){
                stmt = (PreparedStatement) con.prepareStatement("select * from librarian where username=? and password = ?");
                    stmt.setString(1, user.getText());
                    stmt.setString(2, pass.getText());
                    ResultSet rs = stmt.executeQuery();
                    if(rs.next()){
                        frame.dispose();
                        LibrarianPanel.main(new String[]{});
                    }
                    else{
                        JOptionPane.showMessageDialog(frame, "Incorrect ID Password");
                    }
            }
        }
        catch(Exception ex){
            ex.printStackTrace();
        }
        
    }
    public static void main(String[] args) {
        new HomePage();
    }
    
}
