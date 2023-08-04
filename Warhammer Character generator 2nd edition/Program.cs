
using System.Collections.Generic;

System.Random random = new Random();

int valor_un_de_diez = 0;
int valor_dos_de_diez = 0;
int valor_un_de_cien = 0;
int leer_seleccion = 0;
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
int bonificacion_por_resistencia = 0;
int movimiento = 0;
int magia = 0;
int puntos_de_locura = 0;
int puntos_de_destino = 0;

string nombre = "";
string profesion = "";


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
    "Aprendiz de hechicero","Artista","Embajador","Cazador","Guerrero de camarilla","Mercenario","Mensajero","Forajido","Escolta","Bribón","Escriba","Marinero","Estudiante","Ladrón","Menestral","Vagabundo"
};
List<string> elfo_profesion_inicial_descripcion = new List<string>
{
    "Los hymanos que nacen con capacidades magicas son individuos pelogrosos y temibles. Un hechicero inexperto siempre acaba rodeado de demonios y catastrofes.\n" +
    "Para acabar con esta amenaza, el imperio envia lejos a estas personas para que se unan a una de las ocho ordenes de hechiceria.\n" +
    "Durante su aprendizaje los jovenes hechiceros aprenden a usar la magia sin percances, y deciden a cual de las ordenes se unira.\n" +
    "Algunos aprendices estaran obligados a servir al hechicero que descubrio sus talentos,\n" +
    "mientra que otros se van de aventuras para ganar dinero suficiente para pagar su tutela en los Colegios de la Magia.\n" +
    "Los elfos son magicos por naturaleza, y no necesitan asistir a estas instituciones humanas, sino que aprenden de sus propios maestros del saber sobre las ordenes de la magia\n" +
    "Esquema de mejoras Agilidad +5 Inteligencia +10 Voluntad +15 Heridas +2 Magia +1\n" +
    "Habilidades:Buscar,Canalizacion,Hablar idioma(clasico),leer/escribir,Lengua arcana(Magia),Percepcion,Sabiduria academica(Magia),Sentir magia\n" +
    "Talentos: Afinidad con el Aethyr o Manos rapidas, Intelectual o Muy resistente,Magia pueril(Arcana)\n" +
    "Enseres: Baculo,mochila,libro impreso\n" +
    "accesos:Erudito,escriba,estudiante,hechicero vulgar\n" +
    "salidas:Erudito,escriba,hechicero adepto\n" +
    "nota: si quieres ser cvapaz de lanzar hechizos debes aumentar tu caracteristica de Magia con la mejora gratis disponiblñe durante la creacion de personaje.Los halflings y enanos no pueden acceder a esta profesion. Los hechiceros son temidos y a veces odiados. Piensatelo bien antes de escoger esta profesion.",
};
List<string> enano_profesion_inicial = new List<string>
{
    "Alborotador","Guardaespaldas","Burgués","Cochero","Artista","Cazador","Carcelero","Guardia marina","Mercenario","Miliciano","Minero","Noble","Forajido","Gladiador","Sicario","Cazarratas","Portador de runas","Escriba","Marinero","Sirviente","Rompescudos","Contrabandista","Soldado","Estudiante","Ladrón","Peajero","Saqueador de tumbas","Menestral","Matatrolls","Vigilante"
};
List<string> halfling_profesion_inicial = new List<string>
{
    "Alborotador","Barbero cirujano","Osamentero","Cazarrecompensas","Burgués","Miembro de séquito","Carbonero","Artista","Barquero","Patrulla fronteriza","Pescador","Ladrón de tumbas","Cazador","Mercenario","Mensajero","Miliciano","Forajido","Campesino","Cazarratas","Bribón","Sirviente","Contrabandista","Soldado","Estudiante","Ladrón","Peajero","Saqueador de tumbas","Menestral","Vagabundo","Ayuda de cámara","Vigilante"
};
List<string> humano_profesion_inicial = new List<string>
{
    "Alborotador","Aprendiz de hechicero","Alguacil","Barbero cirujano","Batelero","Guardaespaldas","Osamentero","Cazarrecompensas","Burgués","Miembro de séquito","Carbonero","Cochero","Artista","Espadachín estaliano","Barquero","Pescador","Ladrón de tumbas","Hechicero vulgar","Cazador","Iniciado","Carcelero","Kossar kislevita","Guardia marina","Mercenario","Mensajero","Miliciano","Minero","Noble","Bersérker nórdico","Forajido","Escolta","Campesino","Gladiador","Sicario","Cazarratas","Patrulla de caminos","Bribón","Escriba","Marinero","Sirviente","Contrabandista","Soldado","Escudero","Estudiante","Ladrón","Matón","Peajero","Saqueador de tumbas","Menestral","Vagabundo","Ayuda de cámara","Vigilante","Leñador","Fanático"
};

List<string> telentos_aleatorios = new List<string>
{
    "Ambidiestro", "Cortés", "Genio aritmético", "Guerrero nato", "Imperturbable", "Imitador", "Intelectual", "Muy fuerte", "Muy resistente", "Oído aguzado", "Pies ligeros", "Puntería", "Recio", "Reflejos rápidos", "Resistencia a enfermedades", "Resistencia a la magia", "Resistencia a venenos", "Robusto", "Sangre fría", "Sexto sentido", "Suerte", "Vista excelente", "Visión nocturna"
};

List<string> elfo_nombre_elementos_1 = new List<string>
{
    "Aed","Ael","Aelf","Aen","Aeth","Alth","An","And","Ar","Arg","Ast","Ath","Ay","Ban","Bel","Beth","Cad","Cael","Caem","Caeth","Cal","Cam","Cel","Cir","Eld","El","Elth","End","Er","Ers","Fand","Ferg","Fim","Fin","Gal","Gald","Gaen","Gaes","Ged","Gen","Ges","Geth","Glor","Has","Hath","Hel","Heth","Ill","Ind","Ist","Ith","Iy","Kor","Kyr","Ky","La","Lan","Lil","Lim","Lith","Loth","Mal","Mar","Mas","Math","Me","Mes","Men","Meth","Mor","Mort","Nal","Nar","Nen","Nor","Norl","Ri","Riabb","Riann","Rid","Rien","Riell","Ruth","Ryn","Tab","Tal","Tan","Tar","Teth","Tel","Tor","Ty","Ul","Um","Ur","Yr","Yv"
};

List<string> elfo_nombre_elementos_2 = new List<string>
{
    "Baen","Baine","Baire","Bar","Bhir","Brier","Brior","Brin","Daen","Daine","Daire","Dar","Dhil","Dhir","Drel","Drir","Dror","Eorl","Eos","Eoth","Eor","Fil","Fin","Fir","Hil","Hin","Hir","Hor","Il","In","Ion","Ir","Is","Ith","Laen","Laer","Laine","Laire","Lan","Las","Len","Les","Lil","Lin","Lis","Lor","Los","Maen","Mael","Mair","Mal","Mar","Mil","Min","Mir","Nael","Naen","Naer","Nail","Nair","Nal","Nan","Nar","Nael","Naen","Naer","Nail","Nair","Nal","Nan","Nar","Neael","Nean","Neal","Near","Neael","Nean","Neal","Near","Nin","Nil","Nir","Nis","Nin","Nil","Nir","Nis","Ran","Rea","Rel","Ril","Riol","Rir","Rior","Rion","Riorl","Ryel","Riorn","Rir","Rior","Rion","Riorl","Ryel","Riorn","Taen","Tain","Tair","Than","Thar","Thel","Thil","Thin","Thir","Thil","Thin","Thir","Thr","Thwe","Thrin","Thril","Thr","Thwe","Thrin","Thril","Thrin","Til","Tin","Tis","We","Yan"
};

List<string> elfo_nombre_conectores = new List<string>
{
    "A","Al","An","Ar","As","E","El","En","Er","Es","Fan","Fen","Fin","I","Il","In","Ir","Is","O","Ol","On","Or","Os","Ra","Ral","Ran","Rel","Ren","Ri","Ril","Rin","Ro","Rol","Ron","Ry","Sa","Sal","San","Sen","Sel","Si","Sin","So","Sol","Son","U","Ul"
};

List<string> elfo_nombre_elementos_elfa = new List<string>
{
    "A","Aine","Am","Ann","Arma","Arna","Arth","Ath","Beann","Bet","Beth","Brim","Brys","Deann","Det","Derth","Drian","Driel","Drys","Eann","Eanna","Earna","Earth","Elle","Eth","Eys","Eyth","Felle","Fionn","Flys","Fyll","Fyr","Fys","Illa","Ina","Ira","I","Itt","Ithi","Lielle","Lieth","Let","Leth","Lyann","Lam","Lana","Larna","La","Leann","Leath","Lel","Lelle","Leth","Let","Lyann","Lam","Lana","Larna","La","Leann","Leath","Lel","Lelle","Nelle","Nem","Neth","Niell","Niella","Ni","Nith","Nell","Nem","Neth","Niell","Niella","Ni","Nith","Ris","Rith","Rys","Ras","Reann","Rell","Relle","Rielle","Ri","Ris","Rith","Rys","Ras","Reann","Rell","Relle","Rielle","Ri","Sar","Sath","Ser","Seth","Sir","Sith","Sor","Soth","Sher","Shar","Shir","Sys","Teal","Teann","Ter","Tha","Ther","Thi","Ther","Thryn","Thyn","Tir","Tor","Tos","Tryan","Trys","Yll","Yrs","Ys"
};


void ElfoNombre(int genero)
{
    string name = "";
    if (genero == 1) 
    { 
        name = elfo_nombre_elementos_1[(random.Next(0, elfo_nombre_elementos_1.Count))]+
           elfo_nombre_conectores[(random.Next(0, elfo_nombre_conectores.Count))]+
           elfo_nombre_elementos_2[(random.Next(elfo_nombre_elementos_2.Count))];
    }
    else if (genero == 2)
    {
        name = elfo_nombre_elementos_1[(random.Next(0, elfo_nombre_elementos_1.Count))] +
           elfo_nombre_conectores[(random.Next(0, elfo_nombre_conectores.Count))] +
           elfo_nombre_elementos_2[(random.Next(elfo_nombre_elementos_elfa.Count))];
    }
    nombre = name;
}

void ElfoProfesion(int numeroProfesion)
{
    string prof = "";
    int num = 0;
    prof = elfo_profesion_inicial[numeroProfesion];
    Console.WriteLine($"\n{prof}\n" +
        $"{elfo_profesion_inicial_descripcion[numeroProfesion]}");

    profesion = prof;

    //if(num == 1) 
    //{
    //    profesion = prof;
    //}
    //else if(num == 2)
    //{
    //    return;
    //}
}
int UnDeDiez()
{
    valor_dos_de_diez = random.Next(1, 10);
    return valor_dos_de_diez;
}

int DosDeDiez()
{
    valor_dos_de_diez = random.Next(2, 20);
    return valor_dos_de_diez;
}

int UnDeCien()
{
    valor_un_de_cien = random.Next(1, 100);
    return valor_un_de_cien;
}

void Mostrar()
{
    Console.WriteLine($"{ habilidad_de_armas},{ habilidad_de_proyectil},{agilidad},{ inteligencia},{ voluntad},{ empatia},{ movimiento},{ heridas},{ fuerza},{ bonificacion_por_fuerza},{ resistencia},{ bonificacion_por_resistencia},{puntos_de_destino}");
    foreach (var item in elfo_talentos)
    {
        Console.WriteLine(item);
    }
    foreach (var item in elfo_habilidades)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine($"{nombre},{profesion}");
}

void BonificadoresFuerzaYResistencia()
{
    bonificacion_por_fuerza = fuerza / 10;
    bonificacion_por_resistencia = resistencia / 10;
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

void GeneradorElfo()
{
    EstadisticasAleatorias();
    habilidad_de_armas += 20;
    habilidad_de_proyectil += 30;
    fuerza += 20;
    resistencia += 20;
    agilidad += 30;
    inteligencia += 20;
    voluntad += 20;
    empatia += 20;
    movimiento = 3;
    BonificadoresFuerzaYResistencia();
    
    UnDeDiez();
    if (valor_un_de_diez <= 3)
    {
        heridas = 9;
    }
    else if (valor_un_de_diez <= 6)
    {
        heridas = 10;
    }
    else if (valor_un_de_diez <= 9)
    {
        heridas = 11;
    }
    else
    {
        heridas = 12;
    }

    UnDeDiez();
    if (valor_un_de_diez <= 4)
    {
        puntos_de_destino = 1;
    }
    else if (valor_un_de_diez <= 7)
    {
        puntos_de_destino = 2;
    }
    else
    {
        puntos_de_destino = 3;
    }

    elfo_habilidades.Add("Hablar idioma(Eltharin)");
    elfo_habilidades.Add("Hablar idioma(Reikspiel)");
    elfo_habilidades.Add("Sabiduría popular(Elfos)");
    elfo_talentos.Add("Vision nocturna");
    elfo_talentos.Add("Vista exelente");

    Console.WriteLine("Elija uno de los siguientes talentos para su elfo:\n" +
        "Afinidad con el Aethyr o Especialista en armas (arco largo)\n" +
        "Afinidad con el Aethyr +10 a sentir magia y a canalizar\n" +
        "Especialista en armas (arco largo) puedes usar el arco largo sin penalizacion\n" +
        "Escriba 1 y enter para Afinidad con el aethyr o 2 para especialista en armas(arco largo)");
    leer_seleccion = int.Parse(Console.ReadLine());
    if (leer_seleccion == 1)
    {
        elfo_talentos.Add("Afinidad con el Aethyr");
    }
    else if(leer_seleccion == 2)
    {
        elfo_talentos.Add("Especialista en armas(arco largo)");
    }

    Console.WriteLine("Elija uno de los siguientes talentos para su elfo:\n" +
        "Sangre fria o Intelectual\n" +
        "Sangre fria +5 permanente a tu voluntad\n" +
        "Intelectual +5 permanente a tu inteligencia\n"+
        "Escriba 1 y enter para Sangre fria o 2 para Intelectual\n");

    leer_seleccion = int.Parse(Console.ReadLine());
        if (leer_seleccion == 1)
        {
            elfo_talentos.Add("Sangre fria");
            voluntad += 5;
        }
        else if(leer_seleccion == 2)
        {
            elfo_talentos.Add("Intelectual");
            inteligencia += 5;
    
        }

    Console.WriteLine("Eliga un genero para su personaje\n" +
        "Escriba 1 si desea que sea hombre y 2 si desea que sea mujer");
    ElfoNombre(int.Parse(Console.ReadLine()));

    leer_seleccion = int.Parse(Console.ReadLine());
    ElfoProfesion(leer_seleccion);

    Mostrar();
}
void GeneradorEnano()
{
    EstadisticasAleatorias();
    habilidad_de_armas += 30;
    habilidad_de_proyectil += 20;
    fuerza += 20;
    resistencia += 30;
    agilidad += 10;
    inteligencia += 20;
    voluntad += 20;
    empatia += 10;
    movimiento = 5;
    BonificadoresFuerzaYResistencia();
    UnDeDiez();

    if (valor_un_de_diez <= 3)
    {
        heridas = 11;
    }
    else if (valor_un_de_diez <= 6)
    {
        heridas = 12;
    }
    else if (valor_un_de_diez <= 9)
    {
        heridas = 13;
    }
    else
    {
        heridas = 14;
    }

    UnDeDiez();
    if (valor_un_de_diez <= 7)
    {
        puntos_de_destino = 2;
    }
    else
    {
        puntos_de_destino = 3;
    }
}
void GeneradorHalfling()
{
    EstadisticasAleatorias();
    habilidad_de_armas += 10;
    habilidad_de_proyectil += 30;
    fuerza += 10;
    resistencia += 10;
    agilidad += 30;
    inteligencia += 20;
    voluntad += 20;
    empatia += 30;
    movimiento = 4;
    BonificadoresFuerzaYResistencia();
    UnDeDiez();

    if (valor_un_de_diez <= 3)
    {
        heridas = 8;
    }
    else if (valor_un_de_diez <= 6)
    {
        heridas = 9;
    }
    else if (valor_un_de_diez <= 9)
    {
        heridas = 10;
    }
    else
    {
        heridas = 11;
    }

    UnDeDiez();
    if (valor_un_de_diez <= 7)
    {
        puntos_de_destino = 2;
    }
    else
    {
        puntos_de_destino = 3;
    }
}
void GeneradorHumano()
{
    EstadisticasAleatorias();
    habilidad_de_armas += 20;
    habilidad_de_proyectil += 20;
    fuerza += 20;
    resistencia += 20;
    agilidad += 20;
    inteligencia += 20;
    voluntad += 20;
    empatia += 20;
    movimiento = 4;
    BonificadoresFuerzaYResistencia();
    UnDeDiez();

    if (valor_un_de_diez <= 3)
    {
        heridas = 10;
    }
    else if (valor_un_de_diez <= 6)
    {
        heridas = 11;
    }
    else if (valor_un_de_diez <= 9)
    {
        heridas = 12;
    }
    else
    {
        heridas = 13;
    }

    UnDeDiez();
    if (valor_un_de_diez <= 4)
    {
        puntos_de_destino = 2;
    }
    else
    {
        puntos_de_destino = 3;
    }

}

void GeneradorAleatorio()
{

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
    bonificacion_por_resistencia = 0;
    movimiento = 0;
    magia = 0;
    puntos_de_locura = 0;
    puntos_de_destino = 0;
    nombre = "";

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
                "\nEscriba elfo para crear un elfo y enter\n" +
                "Escriba enano para crear un enano y enter\n" +
                "Escriba halfling para crear un halfling y enter\n" +
                "Escriba humano para crear un humano y enter\n" +
                "Si desea un personaje totalmente aleatorio escriba aleatorio y enter" +
                "Si desea salir escriba salir y enter\n");
            switchControl = Console.ReadLine();
            break;

        case "elfo":
            GeneradorElfo();
            break;

        case "enano":
            break;

        case "halfling":
            break;

        case "humano":
            break;

        case "aleatorio":
            break;

        case "salir":
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("Disculpe a ocurrido un error >>>> VOLVIENDO AL MENU\n");
            switchControl = "menu";
            break;
    }
}

