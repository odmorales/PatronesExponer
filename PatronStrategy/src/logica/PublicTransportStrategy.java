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
public class PublicTransportStrategy implements Strategy{

    @Override
    public String buildRoute(String origen, String destino) {
        return "Ruta en trasporte publico desde "+ origen +" hasta " + destino;
    }
    
}
