package library;
import javax.swing.*;
import java.awt.event.*;

public class Library implements ActionListener{
    JFrame frame;
    JButton badmin, blib;
    JLabel title;
    
    public Library(){
        frame = new JFrame("Library");
        frame.setVisible(true);
        frame.setSize(500, 400);
        frame.setLayout(null);
        
        title = new JLabel("Library Management System");
        badmin = new JButton("Admin Login");
        blib = new JButton("Librarian Login");
        
        title.setBounds(160, 50, 400, 30);
        badmin.setBounds(170, 100, 150, 50);
        blib.setBounds(170, 200, 150, 50);
        
        badmin.addActionListener(this);
        blib.addActionListener(this);
        
        frame.add(title);
        frame.add(badmin);
        frame.add(blib);
    }
    @Override
    public void actionPerformed(ActionEvent e){
        if(e.getSource() == badmin){
            AdminPanel.main(new String[]{});
            frame.dispose();
        }
        if(e.getSource() == blib){
            LibrarianPanel.main(new String[]{});
            frame.dispose();
        }
    }
    public static void main(String[] args) {
        new Library();
    }
    
}
