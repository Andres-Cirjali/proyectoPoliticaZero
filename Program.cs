// POLITICA ZERO, UN PROGRAMA que nos permite ver informacion sobre la politica, pagando un precio obviamente porque nada es gratis en este mundo.

// precio packs

const double PrecioBasico = 10.00;
const double PrecioPremium = 20.00;
const double PrecioEstandar = 18.00;

// extras

const double PreciogRaficos = 5.00;
const double precioTRraduccion = 7.00;
const double precioAsesoria = 15.00;
const double precioUrgente = 4.50;
const double DescuentoMin = 40.00;
const double DescuentoAplicado = 0.10;

// secciones // menu

bool puedeverdhont = false;
bool puedeVerpartidospoliticos = false;
bool puedeVerElecciones = false;
bool puedeVerCorrupcion = false;

int numventas = 0;
double dineroRecaudadoEstafando = 0.00;
double ventaMasAlta = 0.00;
string ClienteMasCaro = "";

bool salir = false;
while (!salir)
{
    Console.WriteLine("===== POLITICAZERO v67 =====.");
    Console.WriteLine("Seleccione una opcion para mirar todo:");
    Console.WriteLine("1. Comprar un pase");
    Console.WriteLine("2. Ley D'Hondt y calculos" + (puedeverdhont ? "" : " [BLOQUEADO]"));
    Console.WriteLine("3. Partidos politicos y sus politicas" + (puedeVerpartidospoliticos ? "" : " [BLOQUEADO]"));
    Console.WriteLine("4. Elecciones" + (puedeVerElecciones ? "" : " [BLOQUEADO]"));
    Console.WriteLine("5. Corrupcion" + (puedeVerCorrupcion ? "" : " [BLOQUEADO]"));
    Console.WriteLine("6. CAJA D sesion");
    Console.WriteLine("7. Salir");
    Console.Write("Ingrese el numero de la opcion deseada: ");
    int opcion = Convert.ToInt32(Console.ReadLine()!);

    if (opcion == 1)
    {
        // variables dentro del if para no no ponerlo todo el rato (teacher porque no me dejas usar CASE si es 91839183 veces mas facil? :c)
        string Nombre = "";
        while (Nombre == "")
        {
            Console.Write("Ingrese su nombre: ");
            Nombre = Console.ReadLine()!.Trim();
            if (Nombre == "")
            {
                Console.WriteLine("pero vamos a ver hombre q el nombre no puede estar vacio loco");
            }
        }
        // 2. packs p2w
        int pase  = 0;
        string nombrePase = "";
        double precioPase = 0.00;
        while (pase < 1 || pase > 3)
        {
            Console.WriteLine("Seleccione un pase:");
            Console.WriteLine("1. basico (dhont + partidosPoliticos) " + PrecioBasico);
            Console.WriteLine("2. estandar (basico + elecciones) " + PrecioEstandar);
            Console.WriteLine("3. premium (todo) " + PrecioPremium);
            Console.Write("Ingrese el numero del pase deseado: ");
            pase = Convert.ToInt32(Console.ReadLine()!);

            if (pase == 1)
            {
                nombrePase = "basico";
                precioPase = PrecioBasico;
            }
            else if (pase == 2)
            {
                nombrePase = "estandar";
                precioPase = PrecioEstandar;
            }
            else if (pase == 3)
            {
                nombrePase = "premium";
                precioPase = PrecioPremium;
            }
            else
            {
                Console.WriteLine("Opcion invalida. un num del 1-3 por favor");
            }
        }

        // 3. extras (para joder al cliente y q compre mas en info q puede encontrar en google de manera gratis literalmente)
        bool tieneGraficos = false;
        bool tieneTraduccion = false;
        bool tieneAsesoria = false;
        int numExtras = 0;
        double dineroExtras = 0.00;
        bool terminado = false;
        while (!terminado)
        {
            Console.WriteLine("Seleccione los extras que desea agregar (ingrese 4 para terminar):");
            Console.WriteLine("1. Graficos " + PreciogRaficos);
            Console.WriteLine("2. Traduccion " + precioTRraduccion);
            Console.WriteLine("3. Asesoria " + precioAsesoria);
            Console.WriteLine("4. NO QUIERO NADA MAS DEJAME EN PAZ // NO QUIERO NADA");
            Console.Write("Elige extra: ");
            int extra = Convert.ToInt32(Console.ReadLine()!);

            if (extra == 4)
            {
                terminado = true;
            }
            else if (extra == 1 && !tieneGraficos)
            {
                tieneGraficos = true;
                numExtras++;
                dineroExtras += PreciogRaficos;
            }
            else if (extra == 2 && !tieneTraduccion)
            {
                tieneTraduccion = true;
                numExtras++;
                dineroExtras += precioTRraduccion;
            }
            else if (extra == 3 && !tieneAsesoria)
            {
                tieneAsesoria = true;
                numExtras++;
                dineroExtras += precioAsesoria;
            }
            else
            {
                Console.WriteLine("Opcion invalida o extra ya seleccionado.");
            }
            Console.WriteLine($"Extras: {numExtras} | llevas {Math.Round(precioPase + dineroExtras, 2)} €");
        }

        // 4. atencion normal o urgente 
        int atencion = 0;
        double dineroUrgente = 0.00;
        while (atencion < 1 || atencion > 2)
        {
            Console.WriteLine("Seleccione el tipo de atencion:");
            Console.WriteLine("1. normal (gratis)");
            Console.WriteLine("2. urgente (atencion casi instantania por WHATSAPP) +" + precioUrgente);
            Console.Write("Ingrese 1 o 2: ");
            atencion = Convert.ToInt32(Console.ReadLine()!);

            if (atencion == 2)
            {
                dineroUrgente = precioUrgente;
            }
            else if (atencion != 1)
            {
                Console.WriteLine("haber cabeza ALMENDRA [ERROR ERROR] SELECIONA 1 O 2?? Q HACES TIO?");
            }
        }

        // 5. calc
        double subtotal = precioPase + dineroExtras;
        double descuento = 0.00;
        if (subtotal >= DescuentoMin)
        {
            descuento = Math.Round(subtotal * DescuentoAplicado, 2);
        }
        double total = subtotal - descuento + dineroUrgente;

        Console.WriteLine("----- DESGLOSE -----");
        Console.WriteLine("Pase " + nombrePase + ": " + precioPase + " €");
        Console.WriteLine("Extras (" + numExtras + "): " + dineroExtras + " €");
        Console.WriteLine("Subtotal: " + subtotal + " €");
        Console.WriteLine("Descuento: -" + descuento + " €");
        Console.WriteLine("Urgente: " + dineroUrgente + " €");
        Console.WriteLine("TOTAL: " + total + " €");

        // 6. Cobro
        double pagado = 0.00;
        while (pagado < total)
        {
            Console.Write("Dinero entregado: ");
            pagado = Convert.ToDouble(Console.ReadLine()!);
            if (pagado < total)
            {
                Console.WriteLine("illo q eso no es todo lo que debes " + total + " €, mete el importe completo o te borro el system 32");
            }
        }
        double cambio = Math.Round(pagado - total, 2);

        
        numventas++;
        dineroRecaudadoEstafando += total;
        if (total > ventaMasAlta) 
        {
            ventaMasAlta = total;
            ClienteMasCaro = Nombre;
        }

        // depende q pase tenga comprao se desbloquea o no 
        puedeverdhont = true;
        puedeVerpartidospoliticos = true;
        if (pase >= 2) puedeVerElecciones = true;
        if (pase == 3) puedeVerCorrupcion = true;

        // 7. ticket
        Console.WriteLine("");
        Console.WriteLine("Venta n. " + numventas);
        Console.WriteLine("Cliente: " + Nombre);
        Console.WriteLine("Pase " + nombrePase + ": " + precioPase + " €");
        if (numExtras == 0)
        {
            Console.WriteLine("Extras: sin extras");
        }
        else
        {
            if (tieneGraficos) Console.WriteLine("  + Graficos: " + PreciogRaficos + " €");
            if (tieneTraduccion) Console.WriteLine("  + Traduccion: " + precioTRraduccion + " €");
            if (tieneAsesoria) Console.WriteLine("  + Asesoria: " + precioAsesoria + " €");
        }
        Console.WriteLine(atencion == 1 ? "Atencion: normal" : "Atencion: urgente");
        Console.WriteLine("Descuento: -" + descuento + " €");
        Console.WriteLine("Urgente: " + dineroUrgente + " €");
        Console.WriteLine("TOTAL: " + total + " €");
        Console.WriteLine("Entregado: " + pagado + " €");
        Console.WriteLine("Cambio: " + cambio + " €");
        Console.WriteLine("");
        Console.WriteLine("Pase comprado correctamente");
    }
    else if (opcion == 2)
    {
        if (!puedeverdhont)
        {
            Console.WriteLine("[BLOQUEADO] compra un pase para ver esto (opcion 1)");
        }
        else
        {
            Console.WriteLine("===== LEY D'HONDT =====");
            Console.WriteLine("El Congreso tiene 350 diputados repartidos en 52 provincias (bueno 50 provincias + Ceuta y Melilla).");
            Console.WriteLine("Cada provincia reparte sus escaños por separado y hace falta un 3% de los votos COMO minimo para obtener un escaño // espacio d diputado.");
            Console.WriteLine("Se dividen los votos de cada partido entre 1, 2, 3... y cada escaño va al cociente mas alto.");

            // calculo 1: porcentaje de votos
            Console.WriteLine("calc % de votos-");
            int votosTotales = 0;
            while (votosTotales <= 0)
            {
                Console.Write("Votos totales de la circunscripcion: ");
                votosTotales = Convert.ToInt32(Console.ReadLine()!);
            }
            int votosPartido = -1;
            while (votosPartido < 0 || votosPartido > votosTotales)
            {
                Console.Write("Votos de tu partido: ");
                votosPartido = Convert.ToInt32(Console.ReadLine()!);
                if (votosPartido < 0 || votosPartido > votosTotales)
                {
                    Console.WriteLine("tiene que estar entre 0 y los votos totales");
                }
            }
            double porciento = Math.Round(votosPartido * 100.0 / votosTotales, 2);
            Console.WriteLine("Tu partido tiene el " + porciento + "% de los votos");
            if (porciento >= 3)
            {
                Console.WriteLine("Pasa del 3%, asi que entra en el reparto");
            }
            else
            {
                Console.WriteLine("No llega al 3%, se queda sin escaños");
            }

            // calculo 2: los primeros cocientes de dhont
            Console.WriteLine("--- CALCULO 2: dhont reparto-");
            Console.WriteLine("Votos entre 1: " + Math.Round(votosPartido / 1.0, 2));
            Console.WriteLine("Votos entre 2: " + Math.Round(votosPartido / 2.0, 2));
            Console.WriteLine("Votos entre 3: " + Math.Round(votosPartido / 3.0, 2));
            Console.WriteLine("Esto se compara con los de los demas partidos y los mas altos se llevan los escaños");
        }
    }
    else if (opcion == 3)
    {
        if (!puedeVerpartidospoliticos)
        {
            Console.WriteLine("[BLOQUEADO] compra un pase para ver esto (opcion 1)");
        }
        else
        {
            Console.WriteLine("===== PARTIDOS POLITICOS =====");
            Console.WriteLine("1. PP - centroderecha: unidad de España, economia de mercado, bajar impuestos.");
            Console.WriteLine("2. PSOE - centroizquierda: justicia social, igualdad y derechos laborales.");
            Console.WriteLine("3. VOX - derecha: unidad del Estado, control migratorio, menos Estado autonomico.");
            Console.WriteLine("4. Sumar - izquierda: empleo verde, vivienda asequible y justicia fiscal.");
        }
    }
    else if (opcion == 4)
    {
        if (!puedeVerElecciones)
        {
            Console.WriteLine("[BLOQUEADO] necesitas el pase estandar o el premium (opcion 1)");
        }
        else
        {
            Console.WriteLine("===== GENERALES 2023 (escaños - votos - %) =====");
            Console.WriteLine("PP 137 - 8.160.837 - 33,06%");
            Console.WriteLine("PSOE 121 - 7.821.718 - 31,68%");
            Console.WriteLine("VOX 33 - 3.057.000 - 12,38%");
            Console.WriteLine("SUMAR 31 - 3.044.996 - 12,33%");
            Console.WriteLine("===== GENERALES NOVIEMBRE 2019 =====");
            Console.WriteLine("PSOE 120 - 6.792.199 - 28,25%");
            Console.WriteLine("PP 89 - 5.047.040 - 20,99%");
            Console.WriteLine("VOX 52 - 3.656.979 - 15,21%");
            Console.WriteLine("Unidas Podemos 35 - 3.119.364 - 12,97%");
        }
    }
    else if (opcion == 5)
    {
        if (!puedeVerCorrupcion)
        {
            Console.WriteLine("[BLOQUEADO] esto solo esta en el pase premium (opcion 1)");
        }
        else
        {
            Console.WriteLine("===== CASOS DE CORRUPCION POR PARTIDO =====");
            Console.WriteLine("1. PP: 261 | 2. PSOE: 135 | 3. UM: 18 | 4. PNV: 15 | 5. CC: 12");
            Console.WriteLine("===== CASOS CON MAS DINERO =====");
            Console.WriteLine("ERE: 3.600 M€ (PSOE) | Malaya: 2.400 M€ (GIL) | Acuamed: 1.000 M€ (PSOE)");
            Console.WriteLine("Punica y Gurtel: 370 M€ (PP) | Taula: 175 M€ (PP)");
            Console.WriteLine("Investigaciones recientes: caso Koldo, caso Montoro, caso Begoña Gomez...");
        }
    }
    else if (opcion == 6)
    {
        Console.WriteLine("===== CAJA D sesion =====");
        if (numventas == 0)
        {
            
            Console.WriteLine("Todavia no se ha vendido ningun pase");
        }
        else
        {
            Console.WriteLine("Pases vendidos: " + numventas);
            Console.WriteLine("Recaudacion: " + dineroRecaudadoEstafando + " €");
            Console.WriteLine("Importe medio: " + Math.Round(dineroRecaudadoEstafando / numventas, 2) + " €");
            Console.WriteLine("Venta mas alta: " + ventaMasAlta + " € (" + ClienteMasCaro + ")");
        }
    }
    else if (opcion == 7)
    {
        salir = true;
    }
    else
    {
        Console.WriteLine("t crees muy listo o que? un NUMERO DEL 1 AL 7 [ERROR ERROR SYSTEM 32 BORRADO POR LISTILLO]");
    }

    if (!salir)
    {
        Console.WriteLine("Pulsa una tecla para seguir...");
        Console.ReadKey();
        Console.Clear();
    }
}

