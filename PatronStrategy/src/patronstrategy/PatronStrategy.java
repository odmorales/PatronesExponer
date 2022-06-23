/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package patronstrategy;

import logica.*;

/**
 *
 * @author OdMorales
 */
public class PatronStrategy {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        Context context = new Context();
        context.setStrategy(new WalkingStrategy());
        
        System.out.println(context.excuteStrategy("Las rocas", "Garupal"));
    }
    
}
