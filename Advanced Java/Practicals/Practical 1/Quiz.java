import javax.swing.*;
import java.awt.event.*;

public class Quiz implements ActionListener{
    JFrame frame;
    String questions[] = {"Which is the largest country in the world?",
                          "CLI stands for ______",
                          "Which among these is not a primitive datatype?"};
    String o1[] = {"Russia", "1", "int"};
    String o2[] = {"India", "Command Line Interface", "Object"};
    String o3[] = {"Canda", "3", "byte"};
    JLabel ques = new JLabel("");
    JRadioButton op1, op2, op3;
    ButtonGroup bg = new ButtonGroup();
    JButton next;
    int score = 0, questionnumber = 0;
    public Quiz(){
        frame = new JFrame("Online Test of Java");
        frame.setVisible(true);
        frame.setLayout(null);
        frame.setSize(600, 400);

        ques = new JLabel("");
        op1 = new JRadioButton();
        op2 = new JRadioButton();
        op3 = new JRadioButton();
        next = new JButton("Next");

        display(questionnumber);

    }
    public void display(int n){
        ques.setText(questions[n]);
        op1.setText(o1[n]);
        op2.setText(o2[n]);
        op3.setText(o3[n]);

        bg.add(op1);
        bg.add(op2);
        bg.add(op3);

        ques.setBounds(100, 80, 400, 10);
        op1.setBounds(100, 100, 100, 10);
        op2.setBounds(100, 120, 100, 10);
        op3.setBounds(100, 140, 100, 10);
        next.setBounds(100, 180, 100 , 20);
        next.addActionListener(this);

        frame.add(ques);
        frame.add(op1);
        frame.add(op2);
        frame.add(op3);
        frame.add(next);

        questionnumber++;
    }
    public void validate(int questionnumber){
        if(questionnumber == 0 && op1.isSelected()) score ++;
        if(questionnumber == 1 && op2.isSelected()) score ++;
        if(questionnumber == 2 && op2.isSelected()) score ++;
        bg.clearSelection();
    }
    public void actionPerformed(ActionEvent e){
        if(e.getSource() == next){
            validate(questionnumber);
            if(questionnumber == 3){
                JLabel sc = new JLabel("Score = " +Integer.toString(score));
                frame.add(sc);
                sc.setBounds(100, 200, 100 , 20);
                return;
            }
            display(questionnumber);
        }
    }
    public static void main(String[] args) {
        new Quiz();
    }

}