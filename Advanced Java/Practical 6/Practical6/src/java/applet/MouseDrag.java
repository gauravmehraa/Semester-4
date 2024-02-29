/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Admin
 */
package applet;
import java.applet.Applet;
import java.awt.Graphics;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
public class MouseDrag extends Applet{
    private int x, y;
    @Override
    public void init(){
        x = 0;
        y = 0;
        addMouseListener(new MouseAdapter(){
            @Override
            public void mousePressed(MouseEvent e){
                x = e.getX();
                y = e.getY();
                repaint();
            }
        });
    }
    @Override
    public void paint(Graphics g){
        g.drawString("Mouse Drag", x, y);
    }
}
