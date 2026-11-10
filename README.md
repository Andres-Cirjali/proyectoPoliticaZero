programa de consola en c# donde pagas un pase para ver informacion politica. para ejecutarlo hace falta .net 6 o mas y se pone dotnet run. todo esta en program.cs
al abrirlo sale un menu que se repite hasta que le das a salir. si pones una opcion que no existe te avisa y te la vuelve a pedir
para comprar un pase te pide el nombre (no vale vacio), eliges entre basico (10), estandar (18) o premium (20), luego los extras (graficos, traduccion y asesoria, cada uno solo una vez) y al final si quieres atencion normal o urgente (la urgente cuesta 4,5 mas)
el total es pase mas extras, y si eso llega a 40 se le quita un 10 por ciento. lo de urgente se suma al final y ese no tiene descuento. luego pide el dinero hasta que llegue y calcula el cambio y saca el ticket
segun el pase que compres se desbloquea la informacion: el basico da dhont y partidos, el estandar suma elecciones y el premium lo de corrupcion. lo que no has pagado sale como bloqueado
en la parte de dhont hay dos calculos faciles: el porcentaje de votos de un partido (y si llega al 3 por ciento) y los votos dividido entre 1, 2 y 3
la caja enseña las ventas, lo recaudado, la media y la venta mas alta con el nombre del cliente. si no hay ventas avisa. los datos se borran al cerrar el programa
