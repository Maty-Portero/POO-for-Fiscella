import java.util.ArrayList;
import java.util.Scanner;


public class Main {
    static Persona personaTop;
    static Persona personaTop2;
    static ArrayList<Persona> personas = new ArrayList<>();
    static int n = 3, promedi = 0;
    static Scanner scanner = new Scanner(System.in);


    static Persona mayor(){
        personaTop = personas.get(0);
        for(int i = 1; i < personas.size(); i++){
            if(personas.get(i).edad() > personaTop.edad()){
                personaTop = personas.get(i);
            }
        }
        return personaTop;
    }

    static void menor(){
        ArrayList<Persona> auxiliar = new ArrayList<>();
        auxiliar = personas;
        personaTop = auxiliar.get(0);
        for(int i = 1; i < auxiliar.size(); i++){
            if(auxiliar.get(i).edad() < personaTop.edad()){
                personaTop = auxiliar.get(i);
            }
        }
        auxiliar.remove(personaTop);


        personaTop2 = auxiliar.get(0);
        for(int i = 1; i < auxiliar.size(); i++){
            if(auxiliar.get(i).edad() < personaTop2.edad()){
                personaTop2 = auxiliar.get(i);
            }
        }
    }

    static int promedio(){
        int prom = 0;
        for (int i = 0; i < personas.size(); i++){
            personaTop = personas.get(i);
            prom += personaTop.edad();
        }
        int promedi = prom/ personas.size();
        return promedi;
    }


    public static void main(String[] args){
        String inputNombre = "";
        String inputFecha = "";
        Scanner inputEscaner = new Scanner(System.in);
        for(int i = 0; i < n; i++){
            System.out.print("Ingresar nombre: ");
            inputNombre = inputEscaner.nextLine();
            System.out.print("Ingresar fecha de nacimiento: ");
            inputFecha = inputEscaner.nextLine();
            personaTop = new Persona(inputNombre,inputFecha);
            personas.add(personaTop);
        }
        personaTop = mayor();
        System.out.println("El mayor es: " + personaTop.nombre);
        menor();
        System.out.println("Los menores son: " + personaTop.nombre + " y " + personaTop2.nombre);
        promedi = promedio();
        System.out.println("El promedio es " + promedi);

    }
}