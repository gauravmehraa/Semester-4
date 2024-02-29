package library;
import javax.swing.*;
import java.awt.event.*;

public class AdminPanel implements ActionListener{
    JFrame frame;
    JButton badd, bview, bdel, blog;
    JLabel title;
    
    public AdminPanel(){
        frame = new JFrame("Library");
        frame.setVisible(true);
        frame.setSize(500, 400);
        frame.setLayout(null);
        
        title = new JLabel("Admin Section");
        badd = new JButton("Add Librarian");
        bview = new JButton("View Librarian");
        bdel = new JButton("Delete Librarian");
        blog = new JButton("Logout");
        
        title.setBounds(200, 50, 400, 30);
        badd.setBounds(170, 100, 150, 50);
        bview.setBounds(170, 160, 150, 50);
        bdel.setBounds(170, 220, 150, 50);
        blog.setBounds(170, 280, 150, 50);
        
        blog.addActionListener(this);
        
        frame.add(title);
        frame.add(badd);
        frame.add(bview);
        frame.add(bdel);
        frame.add(blog);
    }
    @Override
    public void actionPerformed(ActionEvent e){
        if(e.getSource() == blog){
            Library.main(new String[]{});
            frame.dispose();
        }
    }
    public static void main(String[] args) {
        new AdminPanel();
    }
    
}
