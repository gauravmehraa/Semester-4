package library;
import javax.swing.*;
import java.awt.event.*;

public class LibrarianPanel implements ActionListener{
    JFrame frame;
    JButton badd, bview, biss, bviewiss, bret, blog;
    JLabel title;
    
    public LibrarianPanel(){
        frame = new JFrame("Library");
        frame.setVisible(true);
        frame.setSize(500, 520);
        frame.setLayout(null);
        
        title = new JLabel("Librarian Section");
        badd = new JButton("Add Books");
        bview = new JButton("View Books");
        biss = new JButton("Issue Book");
        bviewiss = new JButton("View Issued Books");
        bret = new JButton("Return Book");
        blog = new JButton("Logout");
        
        title.setBounds(200, 50, 400, 30);
        badd.setBounds(170, 100, 150, 50);
        bview.setBounds(170, 160, 150, 50);
        biss.setBounds(170, 220, 150, 50);
        bviewiss.setBounds(170, 280, 150, 50);
        bret.setBounds(170, 340, 150, 50);
        blog.setBounds(170, 400, 150, 50);
        
        blog.addActionListener(this);
        
        frame.add(title);
        frame.add(badd);
        frame.add(bview);
        frame.add(biss);
        frame.add(bviewiss);
        frame.add(bret);
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
        new LibrarianPanel();
    }
    
}
