
using System.Collections.Generic;

System.Random random = new Random();

int valor_dos_de_diez = 0;
string switchControl = "menu";

int habilidad_de_armas = 0;
int habilidad_de_proyectil = 0;
int fuerza = 0;
int resistencia = 0;
int agilidad = 0;
int inteligencia = 0;
int voluntad = 0;
int empatia = 0;
int ataques = 1;
int heridas = 0;
int bonificacion_por_fuerza = 0;
int bonificacion_por_resitencia = 0;
int movimiento = 0;
int magia = 0;
int puntos_de_locura = 0;
int puntos_de_destino = 0;


List<string> elfo_habilidades = new List<string>();
List<string> enano_habilidades = new List<string>();
List<string> halfling_habilidades = new List<string>();
List<string> humano_habilidades = new List<string>();

List<string> elfo_talentos = new List<string>();
List<string> enano_talentos = new List<string>();
List<string> halfling_talentos = new List<string>();
List<string> humano_talentos = new List<string>();

List<string> elfo_profesion_inicial = new List<string>
{
    "Aprendiz de hechicero","Forajido","Escolta","Bribón","Escriba","Artista","Marinero","Embajador","Estudiante","Ladrón","Cazador","Menestral","Guerrero de camarilla","Vagabundo","Mercenario","Mensajero"
};
List<string> enano_profesion_inicial = new List<string>
{
    "Noble","Alborotador","Forajido","Guardaespaldas","Gladiador","Sicario","Cazarratas","Burgués","Portador de runas","Cochero","Escriba","Artista","Marinero","Sirviente","Rompescudos","Contrabandista","Soldado","Estudiante","Ladrón","Cazador","Peajero","Carcelero","Saqueador de tumbas","Menestral","Matatrolls","Guardia marina","Mercenario","Vigilante","Miliciano","Minero"
};
List<string> halfling_profesion_inicial = new List<string>
{
    "Alborotador","Forajido","Barbero cirujano","Campesino","Osamentero","Cazarrecompensas","Cazarratas","Burgués","Miembro de séquito","Bribón","Carbonero","Artista","Sirviente","Barquero","Contrabandista","Patrulla fronteriza","Soldado","Pescador","Ladrón de tumbas","Estudiante","Ladrón","Cazador","Peajero","Saqueador de tumbas","Menestral","Vagabundo","Mercenario","Ayuda de cámara","Mensajero","Vigilante","Miliciano"
};
List<string> humano_profesion_inicial = new List<string>
{
    "Noble","Alborotador","Aprendiz de hechicero","Bersérker nórdico","Alguacil","Forajido","Barbero cirujano","Escolta","Batelero","Campesino","Guardaespaldas","Gladiador","Osamentero","Sicario","Cazarrecompensas","Cazarratas","Burgués","Patrulla de caminos","Miembro de séquito","Bribón","Carbonero","Cochero","Escriba","Artista","Marinero","Sirviente","Espadachín estaliano","Barquero","Contrabandista","Soldado","Pescador","Escudero","Ladrón de tumbas","Estudiante","Hechicero vulgar","Ladrón","Cazador","Matón","Iniciado","Peajero","Carcelero","Saqueador de tumbas","Kossar kislevita","Menestral","Guardia marina","Vagabundo","Mercenario","Ayuda de cámara","Mensajero","Vigilante","Miliciano","Leñador","Minero","Fanático"
};

List<string> telentos_aleatorios = new List<string>
{
    "Ambidiestro", "Cortés", "Genio aritmético", "Guerrero nato", "Imperturbable", "Imitador", "Intelectual", "Muy fuerte", "Muy resistente", "Oído aguzado", "Pies ligeros", "Puntería", "Recio", "Reflejos rápidos", "Resistencia a enfermedades", "Resistencia a la magia", "Resistencia a venenos", "Robusto", "Sangre fría", "Sexto sentido", "Suerte", "Vista excelente", "Visión nocturna"
};


int DosDeDiez()
{
    valor_dos_de_diez = random.Next(2, 20);
    return valor_dos_de_diez;
    Console.WriteLine(valor_dos_de_diez);
}

void EstadisticasAleatorias()
{
    habilidad_de_armas = DosDeDiez();
    habilidad_de_proyectil = DosDeDiez();
    fuerza = DosDeDiez();
    resistencia = DosDeDiez();
    agilidad = DosDeDiez();
    inteligencia = DosDeDiez();
    voluntad = DosDeDiez();
    empatia = DosDeDiez();
}



void Reset()
{
    habilidad_de_armas = 0;
    habilidad_de_proyectil = 0;
    fuerza = 0;
    resistencia = 0;
    agilidad = 0;
    inteligencia = 0;
    voluntad = 0;
    empatia = 0;
    ataques = 1;
    heridas = 0;
    bonificacion_por_fuerza = 0;
    bonificacion_por_resitencia = 0;
    movimiento = 0;
    magia = 0;
    puntos_de_locura = 0;
    puntos_de_destino = 0;

    elfo_habilidades.Clear();
    elfo_talentos.Clear();
    enano_habilidades.Clear();
    enano_talentos.Clear();
    halfling_habilidades.Clear();
    halfling_talentos.Clear();
    humano_habilidades.Clear();
    humano_talentos.Clear();
}

while (true)
{
    switch (switchControl)
    {

        case "menu":
            Reset();
            Console.WriteLine("Bienvenido al desarrollador de personajes de Warhammer segunda edicion\n" +
                "Con que raza desea hacer el personaje?\n" +
                "\nescriba elfo para crear un elfo y enter\n" +
                "escriba enano para crear un enano y enter\n" +
                "escriba halfling para crear un halfling y enter\n" +
                "escriba humano para crear un humano y enter\n" +
                "Si desea salir escriba salir y enter\n");
            switchControl = Console.ReadLine();
            break;

        case "elfo":
            break;

        case "enano":
            break;

        case "halfling":
            break;

        case "humano":
            break;

        case "aleatorio":
            break;

        case "exit":
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("Disculpe no reconozco lo que quiso decir >>>> VOLVIENDO AL MENU\n");
            switchControl = "menu";
            break;
    }
}

