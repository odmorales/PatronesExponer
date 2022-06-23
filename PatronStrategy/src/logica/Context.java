/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package logica;

/**
 *
 * @author OdMorales
 */
public class Context {
    private Strategy strategy;

    public void setStrategy(Strategy strategy) {
        this.strategy = strategy;
    }
    
    public String excuteStrategy(String origen, String destino){
        return this.strategy.buildRoute(origen, destino);
    }
}
