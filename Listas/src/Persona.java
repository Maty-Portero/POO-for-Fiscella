import java.time.LocalDate;
import java.time.Period;
import java.time.format.DateTimeFormatter;

public class Persona {
    String  nombre;
    LocalDate fecha_nac;
    private LocalDate ano_actual;
    private Period periodo;
    private DateTimeFormatter format;

    public int edad(){
        //format = DateTimeFormatter.ofPattern("dd/MM/yyyy");
        ano_actual = LocalDate.now();
        periodo = Period.between(fecha_nac, ano_actual);
        return periodo.getYears();
    }

    public Persona(String nombre, String fechaNacimiento) {
        format = DateTimeFormatter.ofPattern("dd/MM/yyyy");

        this.nombre = nombre;
        this.fecha_nac = LocalDate.parse(fechaNacimiento, format);
    }
}