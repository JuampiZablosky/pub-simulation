using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Sim_Ej207.clases;
using Final_Sim_Ej267.clases;

namespace Final_Sim_Ej267
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txt_desde.Text = "0";
            txt_hasta.Text = "10";
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            dtgvTabla.AutoGenerateColumns = false;
            dtgvTabla.Rows.Clear();

            dtgvTabla.Refresh();

         
            double reloj = 0;
            string evento;

            //Llegada Clientes
            Random objRndLlegada = new Random();
            double rndLlegada;
            double tiempoEntreLlegadas;
            double proxLlegada = 0;

            //Fin Servir Cerveza
            Random objRndServirCerveza = new Random();
            double rndServirCerveza = 0;
            double tiempoServirCerveza = 0;
            double finServirCerveza = 0;

            //Fin Lavar vaso
            double tiempoLavar = 0.25;
            double finLavado = 0;

            //Fin recogida de vasos
            Random objRndVasosARecoger = new Random();
            double rndVasosRecoger = 0;
            int vasosARecoger = 0;
            double tiempoRecogidaVasos = 0;
            double finRecogidaVasos = 0;

            //Fin tomar cerveza cliente
            Random objRndTomarCerveza = new Random();
            double rndTomarCerveza1;
            double rndTomarCerveza2;
            double tiempoTomarCerveza;
            double finTomarCerveza;
            double finTomarCervezaDefinitivo = 0;

            //Fin espera en cola
            double finEsperaCola = 0;
            
            //manejador columnas
            int r= 0;
            int n = 0;

            //Para manejar las columnas vacias
            List<int> colLibres = new List<int>();

            //estadisticas MIAS
            double cantClientesRetirados = 0;
            double cantClientesEsperandoRetirados = 0;
            double cantTotalClientesRetirados = 0;
            double esperaMax = 0;
            double cantClientesTomaron = 0;
            double totalEsperaTomar = 0;
            double promEsperaTomar = 0;

            //listas MIAS
            String[] estadosCantinero = { "Libre", "Sirviendo Cerveza", "Lavando Vasos", "Recogiendo Vasos" };
            String[] estadosCliente = { "En Cola", "Esperando Vaso", "Tomando" };
            String[] events = { "Llegada Cliente", "Fin Servir Cerveza", "Fin Lavado Vaso", "Fin Recogida Vaso", "Fin Tomar Cerveza", "Fin Espera Cliente" };

            //clase Funciones
            Funciones generarFunciones = new Funciones();

            //Crear Cantinero
            Cantinero cantinero = new Cantinero();
            cantinero.estado = estadosCantinero[0];
            cantinero.cola = 0;

            //Estado para ver si el cantinero estaba libre o no, para mostrar los eventos
            bool eraLibre = false;

            //Crear Vasos
            Vasos vasos = new Vasos();
            vasos.Limpios = 100;
            vasos.Sucios = 0;
            vasos.Recoger = 0;
            vasos.EnUso = 0;

            //Validamos y tomamos los inputs
            int cantidadSimulaciones = 0;
            int desde = 0;
            int hasta = 0;

            if (txt_CantSim.Text != "")
            {
                cantidadSimulaciones = Int32.Parse(txt_CantSim.Text);
            }
            else
            {
                MessageBox.Show("Debe ingresar la cantidad de simulaciones");
                return;
            }

            if (txt_desde.Text != "")
            {
                desde = Int32.Parse(txt_desde.Text);
            }
            else
            {
                MessageBox.Show("Debe ingresar 'desde' para simular");
                return;
            }

            if (txt_hasta.Text != "")
            {
                hasta = Int32.Parse(txt_hasta.Text);
            }
            else
            {
                MessageBox.Show("Debe ingresar 'hasta' para simular");
                return;
            }

            if (desde > hasta)
            {
                MessageBox.Show("El valor de desde debe ser menor que el valor de hasta");
                return;
            }

            //Crear el cliente
            Clientes cliente = new Clientes();
            Queue<Clientes> clientes = new Queue<Clientes>();
            List<Clientes> clientesAux = new List<Clientes>();

            // Creo la cola de clientes que estan tomando
            List<Clientes> clientesTomando = new List<Clientes>();

            // Creo auxiliar para calculo del proximo retiro
            Clientes clienteRetiro = new Clientes();


            rndLlegada = objRndLlegada.NextDouble();
            double promedio = 0.5;
            tiempoEntreLlegadas = generarFunciones.poisson(rndLlegada, promedio);
            if (tiempoEntreLlegadas == 0)
            {
                tiempoEntreLlegadas = 1;
            }
            proxLlegada = reloj + tiempoEntreLlegadas;

            if (0 >= desde && 0 <= hasta)
            {
                n = dtgvTabla.Rows.Add();
                dtgvTabla.Rows[n].Cells["NroFila"].Value = 0;
                dtgvTabla.Rows[n].Cells["evento"].Value = "Inicio";
                dtgvTabla.Rows[n].Cells["reloj"].Value = reloj;

                //Prox llegada cliente
                dtgvTabla.Rows[n].Cells["rnd_cliente"].Value = Math.Round(rndLlegada, 4);
                dtgvTabla.Rows[n].Cells["tpoEntreLlegada"].Value = tiempoEntreLlegadas;
                dtgvTabla.Rows[n].Cells["proxLlegada"].Value = proxLlegada;
              
                // Cantinero y cola
                dtgvTabla.Rows[n].Cells["estadoCantinero"].Value = cantinero.estado;
                dtgvTabla.Rows[n].Cells["colaCantinero"].Value = cantinero.cola;
               
                // Vasos
                dtgvTabla.Rows[n].Cells["vasosLimpios"].Value = vasos.Limpios;
                dtgvTabla.Rows[n].Cells["vasosSucios"].Value = vasos.Sucios;
                dtgvTabla.Rows[n].Cells["vasosRecoger"].Value = vasos.Recoger;
                dtgvTabla.Rows[n].Cells["vasosUtilizados"].Value = vasos.EnUso;
                
                // Estadísticas
                dtgvTabla.Rows[n].Cells["cantClientesRetirados"].Value = cantClientesRetirados;
                dtgvTabla.Rows[n].Cells["cantClientesEsperandoRetirados"].Value = cantClientesEsperandoRetirados;
                dtgvTabla.Rows[n].Cells["cantTotalClientesRetirados"].Value = cantTotalClientesRetirados;
                dtgvTabla.Rows[n].Cells["esperaMaxTomar"].Value = esperaMax;
                dtgvTabla.Rows[n].Cells["cantClientesTomaron"].Value = cantClientesTomaron;
                dtgvTabla.Rows[n].Cells["totalEsperaCerveza"].Value = totalEsperaTomar;
                dtgvTabla.Rows[n].Cells["promEsperaTomar"].Value = promEsperaTomar;
            }

            reloj = proxLlegada;
            double min = proxLlegada;

            for (int i = 1; i <= cantidadSimulaciones; i++)
            {

                min = generarFunciones.menor(proxLlegada, finEsperaCola, finServirCerveza, finLavado, finRecogidaVasos, finTomarCervezaDefinitivo);
                evento = generarFunciones.DeterminarEventoFinaliza(events, min, proxLlegada, finEsperaCola, finServirCerveza, finLavado, finRecogidaVasos, finTomarCervezaDefinitivo);

                reloj = min;

                switch (evento)
                {
                    case ("Llegada Cliente"):

                        //evento llegada de cliente
                        rndLlegada = objRndLlegada.NextDouble();
                        tiempoEntreLlegadas = generarFunciones.poisson(rndLlegada, promedio);
                        if (tiempoEntreLlegadas == 0)
                        {
                            tiempoEntreLlegadas = 1;
                        }
                        proxLlegada = reloj + tiempoEntreLlegadas;
                        
                        //Crear cliente
                        cliente = new Clientes();
                        cliente.idCliente = r + 1;
                        r += 1;

                        //Me fijo si hay menos de 3 clientes en la cola, para ver si se va o se queda en la cola
                        if (clientes.Count() < 4)
                        {
                            cliente.tiempoLlegada = reloj;
                            cliente.finEsperaCola = reloj + 5;

                            //Meto en la cola al cliente
                            clientes.Enqueue(cliente);

                            //Solo agrego las columnas del cliente si habia menos de 3 clientes 'En cola' antes
                            //Si hay alguna columna libre, cambio de nombre la columna para asignar los valores
                            //del nuevo cliente a esa columna sin borrar los anteriores 
                            if (colLibres.Count > 0)
                            {
                                //Saco la primer columnaLibre
                                int idColumna;
                                idColumna = colLibres.ElementAt(0);
                                colLibres.RemoveAt(0);

                                dtgvTabla.Columns["idCliente" + idColumna.ToString()].Name = "idCliente" + cliente.idCliente.ToString();
                                dtgvTabla.Columns["clienteEstado" + idColumna.ToString()].Name = "clienteEstado" + cliente.idCliente.ToString();
                                dtgvTabla.Columns["horaLlegada" + idColumna.ToString()].Name = "horaLlegada" + cliente.idCliente.ToString();
                                dtgvTabla.Columns["finEsperaEnCola" + idColumna.ToString()].Name = "finEsperaEnCola" + cliente.idCliente.ToString();
                                dtgvTabla.Columns["horaFinTomar" + idColumna.ToString()].Name = "horaFinTomar" + cliente.idCliente.ToString();
                            }
                            else
                            {
                                // Creo la columna para el cliente recien llegado
                                dtgvTabla.Columns.Add("idCliente" + cliente.idCliente.ToString(), "ID del Cliente");
                                dtgvTabla.Columns.Add("clienteEstado" + cliente.idCliente.ToString(), "Estado cliente");
                                dtgvTabla.Columns.Add("horaLlegada" + cliente.idCliente.ToString(), "Tiempo de llegada");
                                dtgvTabla.Columns.Add("finEsperaEnCola" + cliente.idCliente.ToString(), "Tiempo retiro cliente");
                                dtgvTabla.Columns.Add("horaFinTomar" + cliente.idCliente.ToString(), "Fin tomar cerveza");
                            }
                        }
                        else
                        {
                            cantClientesRetirados += 1;
                            cantTotalClientesRetirados += 1;
                            cantinero.cola -= 1;
                        }

                        //Si el cantinero esta libre y la cola es 0
                        if (cantinero.estado == estadosCantinero[0])
                        {
                            cliente.estado = estadosCliente[1];
                            eraLibre = true;

                            //Me fijo si hay vasos limpios y calculo su tiempo de fin de evento
                            if (vasos.Limpios > 0)
                            {
                                rndServirCerveza = objRndServirCerveza.NextDouble();
                                tiempoServirCerveza = generarFunciones.uniforme(rndServirCerveza, 1, 2);
                                finServirCerveza = reloj + tiempoServirCerveza;

                                cantinero.estado = estadosCantinero[1];
                            }

                            // Si no hay limpios, me fijo si hay vasos sucios, y calculo su tiempo de fin de evento
                            if (vasos.Limpios == 0 && vasos.Sucios > 0)
                            {
                                finLavado = reloj + tiempoLavar;

                                cantinero.estado = estadosCantinero[2];
                            }

                            // Si no hay limpios ni sucios, veo que haya para recoger y calculo su tiempo de fin de evento
                            if (vasos.Limpios == 0 && vasos.Sucios == 0 && vasos.Recoger > 0)
                            {
                                rndVasosRecoger = objRndVasosARecoger.NextDouble();
                                vasosARecoger = generarFunciones.cantVasosARecoger(rndVasosRecoger, vasos.Recoger);
                                tiempoRecogidaVasos = generarFunciones.tiempoRecogerVasos(vasosARecoger);
                                finRecogidaVasos = reloj + tiempoRecogidaVasos;

                                cantinero.estado = estadosCantinero[3];
                            }

                            finEsperaCola = 0;
                        }
                        else
                        {
                            finEsperaCola = clientes.ElementAt(1).finEsperaCola;
                            cantinero.cola += 1;
                            cliente.estado = estadosCliente[0];
                        }

                        //Agrego lo anterior en las columnas
                        if (i >= desde && i <= hasta || i == cantidadSimulaciones)
                        {
                            n = dtgvTabla.Rows.Add();
                            dtgvTabla.Rows[n].Cells["NroFila"].Value = i;
                            dtgvTabla.Rows[n].Cells["evento"].Value = evento + " " + cliente.idCliente;
                            dtgvTabla.Rows[n].Cells["reloj"].Value = Math.Round(reloj, 4);

                            //Proxima llegada
                            dtgvTabla.Rows[n].Cells["rnd_cliente"].Value = Math.Round(rndLlegada, 4);
                            dtgvTabla.Rows[n].Cells["tpoEntreLlegada"].Value = tiempoEntreLlegadas;
                            dtgvTabla.Rows[n].Cells["proxLlegada"].Value = Math.Round(proxLlegada, 4);

                            //Si el cantinero estaba libre, tengo que mostrar los tiempos que calcule, sino muestro solo los fines > 0
                            if (eraLibre)
                            {
                                //Me fijo si hay vasos limpios y muestro fin servir cerveza
                                if (vasos.Limpios > 0)
                                {
                                    dtgvTabla.Rows[n].Cells["rnd_ServirCerveza"].Value = Math.Round(rndServirCerveza, 4);
                                    dtgvTabla.Rows[n].Cells["tpoServirCerveza"].Value = Math.Round(tiempoServirCerveza, 4);
                                    dtgvTabla.Rows[n].Cells["finServirCerveza"].Value = Math.Round(finServirCerveza, 4);
                                }

                                // Si no hay limpios, me fijo si hay vasos sucios, y muestro fin lavado
                                if (vasos.Limpios == 0 && vasos.Sucios > 0)
                                {
                                    dtgvTabla.Rows[n].Cells["tpoLavado"].Value = tiempoLavar;
                                    dtgvTabla.Rows[n].Cells["finLavadoVaso"].Value = Math.Round(finLavado, 4);
                                }

                                // Si no hay limpios ni sucios, veo que haya para recoger y muestro el fin recoger
                                if (vasos.Limpios == 0 && vasos.Sucios == 0 && vasos.Recoger > 0)
                                {
                                    dtgvTabla.Rows[n].Cells["rnd_VasosARecoger"].Value = Math.Round(rndVasosRecoger, 4);
                                    dtgvTabla.Rows[n].Cells["vasosARecoger"].Value = vasosARecoger;
                                    dtgvTabla.Rows[n].Cells["tpoRecogida"].Value = tiempoRecogidaVasos;
                                    dtgvTabla.Rows[n].Cells["finRecogidaVasos"].Value = Math.Round(finRecogidaVasos, 4);
                                }

                                eraLibre = false;
                            }
                            else
                            {
                                //Fin servir cerveza
                                if (finServirCerveza > 0)
                                {
                                    dtgvTabla.Rows[n].Cells["finServirCerveza"].Value = Math.Round(finServirCerveza, 4);
                                }

                                //Fin lavado
                                if (finLavado > 0)
                                {
                                    dtgvTabla.Rows[n].Cells["finLavadoVaso"].Value = Math.Round(finLavado, 4);
                                }

                                //Fin recogida vasos
                                if (finRecogidaVasos > 0)
                                {
                                    dtgvTabla.Rows[n].Cells["finRecogidaVasos"].Value = Math.Round(finRecogidaVasos, 4);
                                }
                            }

                            //Fin tomar cerveza
                            if (finTomarCervezaDefinitivo > 0)
                            {
                                dtgvTabla.Rows[n].Cells["finTomarCervezaDefinitivo"].Value = Math.Round(finTomarCervezaDefinitivo, 4);
                            }

                            //Fin espera en cola
                            if (finEsperaCola > 0 && clientes.Count() > 1)
                            {
                                dtgvTabla.Rows[n].Cells["finEsperaCliente"].Value = Math.Round(finEsperaCola, 4);
                            }

                            // Cantinero y cola 
                            dtgvTabla.Rows[n].Cells["estadoCantinero"].Value = cantinero.estado;
                            dtgvTabla.Rows[n].Cells["colaCantinero"].Value = cantinero.cola;

                            // Vasos
                            dtgvTabla.Rows[n].Cells["vasosLimpios"].Value = vasos.Limpios;
                            dtgvTabla.Rows[n].Cells["vasosSucios"].Value = vasos.Sucios;
                            dtgvTabla.Rows[n].Cells["vasosRecoger"].Value = vasos.Recoger;
                            dtgvTabla.Rows[n].Cells["vasosUtilizados"].Value = vasos.EnUso;

                            // Estadísticas
                            dtgvTabla.Rows[n].Cells["cantClientesRetirados"].Value = cantClientesRetirados;
                            dtgvTabla.Rows[n].Cells["cantClientesEsperandoRetirados"].Value = cantClientesEsperandoRetirados;
                            dtgvTabla.Rows[n].Cells["cantTotalClientesRetirados"].Value = cantTotalClientesRetirados;
                            dtgvTabla.Rows[n].Cells["esperaMaxTomar"].Value = Math.Round(esperaMax, 4);
                            dtgvTabla.Rows[n].Cells["cantClientesTomaron"].Value = cantClientesTomaron;
                            dtgvTabla.Rows[n].Cells["totalEsperaCerveza"].Value = Math.Round(totalEsperaTomar, 4);
                            dtgvTabla.Rows[n].Cells["promEsperaTomar"].Value = Math.Round(promEsperaTomar, 4);
                                                     
                        }

                        break;
                    
                    case ("Fin Servir Cerveza"):

                        // EN EL CASO QUE EL EVENTO SEA EL FIN DE SERVIR CERVEZA
                        Clientes clienteTomando = new Clientes();
                        clienteTomando = clientes.Dequeue();
                        clienteTomando.estado = estadosCliente[2];
                        clienteTomando.tiempoEnCola = reloj - clienteTomando.tiempoLlegada;                        

                        vasos.Limpios -= 1;
                        vasos.EnUso += 1;

                        // Calculo cual fue la espera maxima para tomar
                        if (clienteTomando.tiempoEnCola > esperaMax)
                        {
                            esperaMax = clienteTomando.tiempoEnCola;
                        }

                        cantClientesTomaron += 1;
                        totalEsperaTomar += clienteTomando.tiempoEnCola;
                        promEsperaTomar = totalEsperaTomar / cantClientesTomaron;

                        // Calculo el proximo fin de servir cerveza si hay clientes en la cola
                        if (clientes.Count() > 0)
                        {
                            cantinero.cola -= 1;

                            //Cambio el estado del cliente que acaba de ser atendido
                            clientes.First().estado = estadosCliente[1];

                            //Verifico si hay vasos limpios
                            if (vasos.Limpios > 0)
                            {
                                rndServirCerveza = objRndServirCerveza.NextDouble();
                                tiempoServirCerveza = generarFunciones.uniforme(rndServirCerveza, 1, 2);
                                finServirCerveza = reloj + tiempoServirCerveza;

                                cantinero.estado = estadosCantinero[1];

                                finLavado = 0;
                                finRecogidaVasos = 0;
                            }

                            // Si no hya limpios, me fijo si hay vasos sucios, y calculo su tiempo de fin de evento
                            if (vasos.Limpios == 0 && vasos.Sucios > 0)
                            {
                                finLavado = reloj + tiempoLavar;

                                cantinero.estado = estadosCantinero[2];

                                finServirCerveza = 0;
                                finRecogidaVasos = 0;
                            }

                            // Si no hay limpios ni sucios, veo que haya para recoger y calculo su tiempo de fin de evento
                            if (vasos.Limpios == 0 && vasos.Sucios == 0 && vasos.Recoger > 0)
                            {
                                rndVasosRecoger = objRndVasosARecoger.NextDouble();
                                vasosARecoger = generarFunciones.cantVasosARecoger(rndVasosRecoger, vasos.Recoger);
                                tiempoRecogidaVasos = generarFunciones.tiempoRecogerVasos(vasosARecoger);
                                finRecogidaVasos = reloj + tiempoRecogidaVasos;

                                cantinero.estado = estadosCantinero[3];

                                finLavado = 0;
                                finServirCerveza = 0;
                            }

                            if (clientes.Count() > 1)
                            {
                                finEsperaCola = clientes.ElementAt(1).finEsperaCola;
                            }
                            else
                            {
                                finEsperaCola = 0;
                            }
                        }
                        else
                        {
                            finServirCerveza = 0;
                            cantinero.estado = estadosCantinero[0];
                        }

                        

                        // Calculo el fin de tomar del cliente que acaba de recibir el vaso
                        rndTomarCerveza1 = objRndTomarCerveza.NextDouble();
                        rndTomarCerveza2 = objRndTomarCerveza.NextDouble();
                        tiempoTomarCerveza = generarFunciones.normal(rndTomarCerveza1, rndTomarCerveza2, 5, 2);
                        finTomarCerveza = reloj + tiempoTomarCerveza;
                        clienteTomando.finTomarCerveza = finTomarCerveza;

                        clientesTomando.Add(clienteTomando);

                        clientesTomando = clientesTomando.OrderBy(x => x.finTomarCerveza).ToList();

                        // Calculo si este fin tomar cerveza es menor que el ultimo fin tomar cerveza
                        if (clientesTomando.Count > 0)
                        {
                            finTomarCervezaDefinitivo = clientesTomando[0].finTomarCerveza;
                        }


                        //Agrego lo anterior en las columnas
                        if (i >= desde && i <= hasta || i == cantidadSimulaciones)
                        {
                            n = dtgvTabla.Rows.Add();
                            dtgvTabla.Rows[n].Cells["NroFila"].Value = i;
                            dtgvTabla.Rows[n].Cells["evento"].Value = evento;
                            dtgvTabla.Rows[n].Cells["reloj"].Value = Math.Round(reloj, 4);

                            //Proxima llegada
                            if (proxLlegada > 0)
                            {
                                dtgvTabla.Rows[n].Cells["proxLlegada"].Value = Math.Round(proxLlegada, 4);

                            }

                            //Fin servir cerveza
                            if (clientes.Count() > 0)
                            {
                                //Me fijo si hay vasos limpios y muestro fin servir cerveza
                                if (vasos.Limpios > 0)
                                {
                                    dtgvTabla.Rows[n].Cells["rnd_ServirCerveza"].Value = Math.Round(rndServirCerveza, 4);
                                    dtgvTabla.Rows[n].Cells["tpoServirCerveza"].Value = Math.Round(tiempoServirCerveza, 4);
                                    dtgvTabla.Rows[n].Cells["finServirCerveza"].Value = Math.Round(finServirCerveza, 4);
                                }

                                // Si no hay limpios, me fijo si hay vasos sucios, y muestro fin lavado
                                if (vasos.Limpios == 0 && vasos.Sucios > 0)
                                {
                                    dtgvTabla.Rows[n].Cells["tpoLavado"].Value = tiempoLavar;
                                    dtgvTabla.Rows[n].Cells["finLavadoVaso"].Value = Math.Round(finLavado, 4);
                                }

                                // Si no hay limpios ni sucios, veo que haya para recoger y muestro el fin recoger
                                if (vasos.Limpios == 0 && vasos.Sucios == 0 && vasos.Recoger > 0)
                                {
                                    dtgvTabla.Rows[n].Cells["rnd_VasosARecoger"].Value = Math.Round(rndVasosRecoger, 4);
                                    dtgvTabla.Rows[n].Cells["vasosARecoger"].Value = vasosARecoger;
                                    dtgvTabla.Rows[n].Cells["tpoRecogida"].Value = tiempoRecogidaVasos;
                                    dtgvTabla.Rows[n].Cells["finRecogidaVasos"].Value = Math.Round(finRecogidaVasos, 4);
                                }
                            }
                            else
                            {
                                //Fin servir cerveza
                                if (finServirCerveza > 0)
                                {
                                    dtgvTabla.Rows[n].Cells["finServirCerveza"].Value = Math.Round(finServirCerveza, 4);
                                }

                                //Fin lavado
                                if (finLavado > 0)
                                {
                                    dtgvTabla.Rows[n].Cells["finLavadoVaso"].Value = Math.Round(finLavado, 4);
                                }

                                //Fin recogida vasos
                                if (finRecogidaVasos > 0)
                                {
                                    dtgvTabla.Rows[n].Cells["finRecogidaVasos"].Value = Math.Round(finRecogidaVasos, 4);
                                }
                            }

                            //Fin tomar cerveza
                            if (finTomarCervezaDefinitivo > 0)
                            {
                                dtgvTabla.Rows[n].Cells["rnd_TomarCerveza1"].Value = Math.Round(rndTomarCerveza1, 4);
                                dtgvTabla.Rows[n].Cells["rnd_TomarCerveza2"].Value = Math.Round(rndTomarCerveza2, 4);
                                dtgvTabla.Rows[n].Cells["tpoTomarCerveza"].Value = Math.Round(tiempoTomarCerveza, 4);
                                dtgvTabla.Rows[n].Cells["finTomarCerveza"].Value = Math.Round(finTomarCerveza, 4);
                                dtgvTabla.Rows[n].Cells["finTomarCervezaDefinitivo"].Value = Math.Round(finTomarCervezaDefinitivo, 4);
                            }

                            //Fin espera en cola
                            if (finEsperaCola > 0 && clientes.Count() > 1)
                            {
                                dtgvTabla.Rows[n].Cells["finEsperaCliente"].Value = Math.Round(finEsperaCola, 4);
                            }

                            // Cantinero y cola 
                            dtgvTabla.Rows[n].Cells["estadoCantinero"].Value = cantinero.estado;
                            dtgvTabla.Rows[n].Cells["colaCantinero"].Value = cantinero.cola;

                            // Vasos
                            dtgvTabla.Rows[n].Cells["vasosLimpios"].Value = vasos.Limpios;
                            dtgvTabla.Rows[n].Cells["vasosSucios"].Value = vasos.Sucios;
                            dtgvTabla.Rows[n].Cells["vasosRecoger"].Value = vasos.Recoger;
                            dtgvTabla.Rows[n].Cells["vasosUtilizados"].Value = vasos.EnUso;

                            // Estadísticas
                            dtgvTabla.Rows[n].Cells["cantClientesRetirados"].Value = cantClientesRetirados;
                            dtgvTabla.Rows[n].Cells["cantClientesEsperandoRetirados"].Value = cantClientesEsperandoRetirados;
                            dtgvTabla.Rows[n].Cells["cantTotalClientesRetirados"].Value = cantTotalClientesRetirados;
                            dtgvTabla.Rows[n].Cells["esperaMaxTomar"].Value = Math.Round(esperaMax, 4);
                            dtgvTabla.Rows[n].Cells["cantClientesTomaron"].Value = cantClientesTomaron;
                            dtgvTabla.Rows[n].Cells["totalEsperaCerveza"].Value = Math.Round(totalEsperaTomar, 4);
                            dtgvTabla.Rows[n].Cells["promEsperaTomar"].Value = Math.Round(promEsperaTomar, 4);
                        }

                        break;

                    case ("Fin Lavado Vaso"):

                        //Calculo el fin servir cerveza
                        rndServirCerveza = objRndServirCerveza.NextDouble();
                        tiempoServirCerveza = generarFunciones.uniforme(rndServirCerveza, 1, 2);
                        finServirCerveza = reloj + tiempoServirCerveza;

                        cantinero.estado = estadosCantinero[1];

                        vasos.Limpios += 1;
                        vasos.Sucios -= 1;

                        finLavado = 0;

                        //Agrego lo anterior en las columnas
                        if (i >= desde && i <= hasta || i == cantidadSimulaciones)
                        {
                            n = dtgvTabla.Rows.Add();
                            dtgvTabla.Rows[n].Cells["NroFila"].Value = i;
                            dtgvTabla.Rows[n].Cells["evento"].Value = evento;
                            dtgvTabla.Rows[n].Cells["reloj"].Value = Math.Round(reloj, 4);

                            //Proxima llegada
                            if (proxLlegada > 0)
                            {
                                dtgvTabla.Rows[n].Cells["proxLlegada"].Value = Math.Round(proxLlegada, 4);

                            }

                            //Fin servir cerveza
                            dtgvTabla.Rows[n].Cells["rnd_ServirCerveza"].Value = Math.Round(rndServirCerveza, 4);
                            dtgvTabla.Rows[n].Cells["tpoServirCerveza"].Value = Math.Round(tiempoServirCerveza, 4);
                            dtgvTabla.Rows[n].Cells["finServirCerveza"].Value = Math.Round(finServirCerveza, 4);                            

                            //Fin tomar cerveza
                            if (finTomarCervezaDefinitivo > 0)
                            {
                                dtgvTabla.Rows[n].Cells["finTomarCervezaDefinitivo"].Value = Math.Round(finTomarCervezaDefinitivo, 4);
                            }

                            //Fin espera en cola
                            if (finEsperaCola > 0 && clientes.Count() > 1)
                            {
                                dtgvTabla.Rows[n].Cells["finEsperaCliente"].Value = Math.Round(finEsperaCola, 4);
                            }

                            // Cantinero y cola 
                            dtgvTabla.Rows[n].Cells["estadoCantinero"].Value = cantinero.estado;
                            dtgvTabla.Rows[n].Cells["colaCantinero"].Value = cantinero.cola;

                            // Vasos
                            dtgvTabla.Rows[n].Cells["vasosLimpios"].Value = vasos.Limpios;
                            dtgvTabla.Rows[n].Cells["vasosSucios"].Value = vasos.Sucios;
                            dtgvTabla.Rows[n].Cells["vasosRecoger"].Value = vasos.Recoger;
                            dtgvTabla.Rows[n].Cells["vasosUtilizados"].Value = vasos.EnUso;

                            // Estadísticas
                            dtgvTabla.Rows[n].Cells["cantClientesRetirados"].Value = cantClientesRetirados;
                            dtgvTabla.Rows[n].Cells["cantClientesEsperandoRetirados"].Value = cantClientesEsperandoRetirados;
                            dtgvTabla.Rows[n].Cells["cantTotalClientesRetirados"].Value = cantTotalClientesRetirados;
                            dtgvTabla.Rows[n].Cells["esperaMaxTomar"].Value = Math.Round(esperaMax, 4);
                            dtgvTabla.Rows[n].Cells["cantClientesTomaron"].Value = cantClientesTomaron;
                            dtgvTabla.Rows[n].Cells["totalEsperaCerveza"].Value = Math.Round(totalEsperaTomar, 4);
                            dtgvTabla.Rows[n].Cells["promEsperaTomar"].Value = Math.Round(promEsperaTomar, 4);

                        }

                        break;

                    case ("Fin Recogida Vaso"):

                        //Calculo el fin lavado vaso
                        finLavado = reloj + tiempoLavar;

                        cantinero.estado = estadosCantinero[2];

                        vasos.Sucios += vasosARecoger;
                        vasos.Recoger -= vasosARecoger;

                        finRecogidaVasos = 0;

                        //Agrego lo anterior en las columnas
                        if (i >= desde && i <= hasta || i == cantidadSimulaciones)
                        {
                            n = dtgvTabla.Rows.Add();
                            dtgvTabla.Rows[n].Cells["NroFila"].Value = i;
                            dtgvTabla.Rows[n].Cells["evento"].Value = evento;
                            dtgvTabla.Rows[n].Cells["reloj"].Value = Math.Round(reloj, 4);

                            //Proxima llegada
                            if (proxLlegada > 0)
                            {
                                dtgvTabla.Rows[n].Cells["proxLlegada"].Value = Math.Round(proxLlegada, 4);

                            }

                            //Fin lavado vaso
                            dtgvTabla.Rows[n].Cells["tpoLavado"].Value = tiempoLavar;
                            dtgvTabla.Rows[n].Cells["finLavadoVaso"].Value = Math.Round(finLavado, 4);

                            //Fin tomar cerveza
                            if (finTomarCervezaDefinitivo > 0)
                            {
                                dtgvTabla.Rows[n].Cells["finTomarCervezaDefinitivo"].Value = Math.Round(finRecogidaVasos, 4);
                            }

                            //Fin espera en cola
                            if (finEsperaCola > 0 && clientes.Count() > 1)
                            {
                                dtgvTabla.Rows[n].Cells["finEsperaCliente"].Value = Math.Round(finEsperaCola, 4);
                            }

                            // Cantinero y cola 
                            dtgvTabla.Rows[n].Cells["estadoCantinero"].Value = cantinero.estado;
                            dtgvTabla.Rows[n].Cells["colaCantinero"].Value = cantinero.cola;

                            // Vasos
                            dtgvTabla.Rows[n].Cells["vasosLimpios"].Value = vasos.Limpios;
                            dtgvTabla.Rows[n].Cells["vasosSucios"].Value = vasos.Sucios;
                            dtgvTabla.Rows[n].Cells["vasosRecoger"].Value = vasos.Recoger;
                            dtgvTabla.Rows[n].Cells["vasosUtilizados"].Value = vasos.EnUso;

                            // Estadísticas
                            dtgvTabla.Rows[n].Cells["cantClientesRetirados"].Value = cantClientesRetirados;
                            dtgvTabla.Rows[n].Cells["cantClientesEsperandoRetirados"].Value = cantClientesEsperandoRetirados;
                            dtgvTabla.Rows[n].Cells["cantTotalClientesRetirados"].Value = cantTotalClientesRetirados;
                            dtgvTabla.Rows[n].Cells["esperaMaxTomar"].Value = Math.Round(esperaMax, 4);
                            dtgvTabla.Rows[n].Cells["cantClientesTomaron"].Value = cantClientesTomaron;
                            dtgvTabla.Rows[n].Cells["totalEsperaCerveza"].Value = Math.Round(totalEsperaTomar, 4);
                            dtgvTabla.Rows[n].Cells["promEsperaTomar"].Value = Math.Round(promEsperaTomar, 4);

                        }

                        break;

                    case ("Fin Tomar Cerveza"):
                        //Elimino al cliente de la lista
                        Clientes clienteTomo = clientesTomando[0];
                        clientesTomando.RemoveAt(0);

                        //Agrego su id para manejar las columnas vacías
                        colLibres.Add(clienteTomo.idCliente);

                        vasos.Recoger += 1;
                        vasos.EnUso -= 1;

                        //Calculo el proximo fin tomar si es que hay clientes en la cola
                        if (clientesTomando.Count() > 0)
                        {
                            finTomarCervezaDefinitivo = clientesTomando.First().finTomarCerveza;
                        }
                        else
                        {
                            finTomarCervezaDefinitivo = 0;
                        }

                        //Agrego lo anterior en las columnas
                        if (i >= desde && i <= hasta || i == cantidadSimulaciones)
                        {
                            n = dtgvTabla.Rows.Add();
                            dtgvTabla.Rows[n].Cells["NroFila"].Value = i;
                            dtgvTabla.Rows[n].Cells["evento"].Value = evento + " Cliente " + clienteTomo.idCliente;
                            dtgvTabla.Rows[n].Cells["reloj"].Value = Math.Round(reloj, 4);

                            //Proxima llegada
                            if (proxLlegada > 0)
                            {
                                dtgvTabla.Rows[n].Cells["proxLlegada"].Value = Math.Round(proxLlegada, 4);

                            }

                            //Fin servir cerveza
                            if (finServirCerveza > 0)
                            {
                                dtgvTabla.Rows[n].Cells["finServirCerveza"].Value = Math.Round(finServirCerveza, 4);

                            }

                            //Fin lavado vaso
                            if (finLavado > 0)
                            {
                                dtgvTabla.Rows[n].Cells["finLavadoVaso"].Value = Math.Round(finLavado, 4);
                            }

                            //Fin recoger vasos
                            if (finRecogidaVasos > 0)
                            {
                                dtgvTabla.Rows[n].Cells["finRecogidaVasos"].Value = Math.Round(finRecogidaVasos, 4);
                            }

                            //Fin tomar cerveza
                            if (finTomarCervezaDefinitivo > 0)
                            {
                                dtgvTabla.Rows[n].Cells["finTomarCervezaDefinitivo"].Value = Math.Round(finTomarCervezaDefinitivo, 4);
                            }

                            //Fin espera en cola
                            if (finEsperaCola > 0 && clientes.Count() > 1)
                            {
                                dtgvTabla.Rows[n].Cells["finEsperaCliente"].Value = Math.Round(finEsperaCola, 4);
                            }

                            // Cantinero y cola 
                            dtgvTabla.Rows[n].Cells["estadoCantinero"].Value = cantinero.estado;
                            dtgvTabla.Rows[n].Cells["colaCantinero"].Value = cantinero.cola;

                            // Vasos
                            dtgvTabla.Rows[n].Cells["vasosLimpios"].Value = vasos.Limpios;
                            dtgvTabla.Rows[n].Cells["vasosSucios"].Value = vasos.Sucios;
                            dtgvTabla.Rows[n].Cells["vasosRecoger"].Value = vasos.Recoger;
                            dtgvTabla.Rows[n].Cells["vasosUtilizados"].Value = vasos.EnUso;

                            // Estadísticas
                            dtgvTabla.Rows[n].Cells["cantClientesRetirados"].Value = cantClientesRetirados;
                            dtgvTabla.Rows[n].Cells["cantClientesEsperandoRetirados"].Value = cantClientesEsperandoRetirados;
                            dtgvTabla.Rows[n].Cells["cantTotalClientesRetirados"].Value = cantTotalClientesRetirados;
                            dtgvTabla.Rows[n].Cells["esperaMaxTomar"].Value = Math.Round(esperaMax, 4);
                            dtgvTabla.Rows[n].Cells["cantClientesTomaron"].Value = cantClientesTomaron;
                            dtgvTabla.Rows[n].Cells["totalEsperaCerveza"].Value = Math.Round(totalEsperaTomar, 4);
                            dtgvTabla.Rows[n].Cells["promEsperaTomar"].Value = Math.Round(promEsperaTomar, 4);

                            //Pongo sus columnas en ------
                            dtgvTabla.Rows[n].Cells["idCliente" + clienteTomo.idCliente.ToString()].Value = "---";
                            dtgvTabla.Rows[n].Cells["clienteEstado" + clienteTomo.idCliente.ToString()].Value = "---";
                            dtgvTabla.Rows[n].Cells["horaLlegada" + clienteTomo.idCliente.ToString()].Value = "---";
                            dtgvTabla.Rows[n].Cells["finEsperaEnCola" + clienteTomo.idCliente.ToString()].Value = "---";
                            dtgvTabla.Rows[n].Cells["horaFinTomar" + clienteTomo.idCliente.ToString()].Value = "---";

                        }

                        break;

                    case ("Fin Espera Cliente"):

                        Queue<Clientes> clientesRetiro = new Queue<Clientes>(clientes.Where(x => x.finEsperaCola == reloj));
                        Clientes clienteRetiroId = clientesRetiro.Dequeue();

                        //Agrego su id a la lista para manejar las columnas vacias
                        colLibres.Add(clienteRetiroId.idCliente);

                        clientes = new Queue<Clientes>(clientes.Where(x => x.finEsperaCola != reloj));
                        cantClientesEsperandoRetirados += 1;
                        cantTotalClientesRetirados += 1;
                        cantinero.cola -= 1;

                        //Calculo el proximo evento retiro por exceso de tiempo
                        if (clientes.Count() > 1)
                        {
                            clienteRetiro = clientes.ElementAt(1);
                            finEsperaCola = clienteRetiro.finEsperaCola;
                        }
                        else
                        {
                            finEsperaCola = 0;
                        }

                        //Agrego lo anterior en las columnas
                        if (i >= desde && i <= hasta || i == cantidadSimulaciones)
                        {
                            n = dtgvTabla.Rows.Add();
                            dtgvTabla.Rows[n].Cells["NroFila"].Value = i;
                            dtgvTabla.Rows[n].Cells["evento"].Value = evento + " " + clienteRetiroId.idCliente;
                            dtgvTabla.Rows[n].Cells["reloj"].Value = Math.Round(reloj, 4);

                            //Proxima llegada
                            if (proxLlegada > 0)
                            {
                                dtgvTabla.Rows[n].Cells["proxLlegada"].Value = Math.Round(proxLlegada, 4);

                            }

                            //Fin servir cerveza
                            if (finServirCerveza > 0)
                            {
                                dtgvTabla.Rows[n].Cells["finServirCerveza"].Value = Math.Round(finServirCerveza, 4);

                            }

                            //Fin lavado vaso
                            if (finLavado > 0)
                            {
                                dtgvTabla.Rows[n].Cells["finLavadoVaso"].Value = Math.Round(finLavado, 4);
                            }

                            //Fin recoger vasos
                            if (finRecogidaVasos > 0)
                            {
                                dtgvTabla.Rows[n].Cells["finRecogidaVasos"].Value = Math.Round(finRecogidaVasos, 4);
                            }

                            //Fin tomar cerveza
                            if (finTomarCervezaDefinitivo > 0)
                            {
                                dtgvTabla.Rows[n].Cells["finTomarCervezaDefinitivo"].Value = Math.Round(finTomarCervezaDefinitivo, 4);
                            }

                            //Fin espera en cola
                            if (finEsperaCola > 0 && clientes.Count() > 1)
                            {
                                dtgvTabla.Rows[n].Cells["finEsperaCliente"].Value = Math.Round(finEsperaCola, 4);
                            }

                            // Cantinero y cola 
                            dtgvTabla.Rows[n].Cells["estadoCantinero"].Value = cantinero.estado;
                            dtgvTabla.Rows[n].Cells["colaCantinero"].Value = cantinero.cola;

                            // Vasos
                            dtgvTabla.Rows[n].Cells["vasosLimpios"].Value = vasos.Limpios;
                            dtgvTabla.Rows[n].Cells["vasosSucios"].Value = vasos.Sucios;
                            dtgvTabla.Rows[n].Cells["vasosRecoger"].Value = vasos.Recoger;
                            dtgvTabla.Rows[n].Cells["vasosUtilizados"].Value = vasos.EnUso;

                            // Estadísticas
                            dtgvTabla.Rows[n].Cells["cantClientesRetirados"].Value = cantClientesRetirados;
                            dtgvTabla.Rows[n].Cells["cantClientesEsperandoRetirados"].Value = cantClientesEsperandoRetirados;
                            dtgvTabla.Rows[n].Cells["cantTotalClientesRetirados"].Value = cantTotalClientesRetirados;
                            dtgvTabla.Rows[n].Cells["esperaMaxTomar"].Value = Math.Round(esperaMax, 4);
                            dtgvTabla.Rows[n].Cells["cantClientesTomaron"].Value = cantClientesTomaron;
                            dtgvTabla.Rows[n].Cells["totalEsperaCerveza"].Value = Math.Round(totalEsperaTomar, 4);
                            dtgvTabla.Rows[n].Cells["promEsperaTomar"].Value = Math.Round(promEsperaTomar, 4);

                            //Pongo sus columnas en ------
                            dtgvTabla.Rows[n].Cells["idCliente" + clienteRetiroId.idCliente.ToString()].Value = "---";
                            dtgvTabla.Rows[n].Cells["clienteEstado" + clienteRetiroId.idCliente.ToString()].Value = "---";
                            dtgvTabla.Rows[n].Cells["horaLlegada" + clienteRetiroId.idCliente.ToString()].Value = "---";
                            dtgvTabla.Rows[n].Cells["finEsperaEnCola" + clienteRetiroId.idCliente.ToString()].Value = "---";
                            dtgvTabla.Rows[n].Cells["horaFinTomar" + clienteRetiroId.idCliente.ToString()].Value = "---";
                        }

                        break;

                }

                if (i >= desde && i <= hasta || i == cantidadSimulaciones)
                {
                    //Asigno los clientes a sus columnas
                    if (clientes.Count() > 0)
                    {
                        foreach (Clientes cli in clientes)
                        {
                            dtgvTabla.Rows[n].Cells["idCliente" + cli.idCliente.ToString()].Value = cli.idCliente;
                            dtgvTabla.Rows[n].Cells["clienteEstado" + cli.idCliente.ToString()].Value = cli.estado;
                            dtgvTabla.Rows[n].Cells["horaLlegada" + cli.idCliente.ToString()].Value = Math.Round(cli.tiempoLlegada, 4);
                            dtgvTabla.Rows[n].Cells["finEsperaEnCola" + cli.idCliente.ToString()].Value = Math.Round(cli.finEsperaCola, 4);

                        }
                    }

                    if (clientesTomando.Count() > 0)
                    {
                        foreach (Clientes cliTom in clientesTomando)
                        {
                            dtgvTabla.Rows[n].Cells["idCliente" + cliTom.idCliente.ToString()].Value = cliTom.idCliente;
                            dtgvTabla.Rows[n].Cells["clienteEstado" + cliTom.idCliente.ToString()].Value = cliTom.estado;
                            dtgvTabla.Rows[n].Cells["horaLlegada" + cliTom.idCliente.ToString()].Value = Math.Round(cliTom.tiempoLlegada, 4);
                            dtgvTabla.Rows[n].Cells["finEsperaEnCola" + cliTom.idCliente.ToString()].Value = Math.Round(cliTom.finEsperaCola, 4);
                            dtgvTabla.Rows[n].Cells["horaFinTomar" + cliTom.idCliente.ToString()].Value = Math.Round(cliTom.finTomarCerveza, 4);
                        }
                    }
                }
                
            }

            //Muestro las estadisticasa del ejercicio en los txt box
            txt_PromEsperaCerveza.Text = Convert.ToString(Math.Round(promEsperaTomar, 4));
            txt_ClientesEsperaSinConsumir.Text = Convert.ToString(Math.Round(cantClientesEsperandoRetirados, 4));
            txt_ClientesRetiradosSinConsumir.Text = Convert.ToString(Math.Round(cantTotalClientesRetirados, 4));
            txt_EsperaMaxCerveza.Text = Convert.ToString(Math.Round(esperaMax, 4));

        }

        private void txt_clientes_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_desde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_hasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_desde_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_desde.Text, "  ^ [0-9]"))
            {
                txt_desde.Text = "";
            }
        }

        private void txt_hasta_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_hasta.Text, "  ^ [0-9]"))
            {
                txt_hasta.Text = "";
            }
        }

        private void txt_CantSim_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_CantSim.Text, "  ^ [0-9]"))
            {
                txt_CantSim.Text = "";
            }
        }
    }
}
