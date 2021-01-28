# Trabajo Final Simulación 2020  
## Pub-Simulation    
## Descripción
 Este repositorio contiene el código fuente de una simulación de un bar de cervezas.
## Enunciado
- La cantidad de vasos de cerveza ordenada por hora en un bar sigue una distribución Poisson, con un promedio de 30 cervezas pedidas por hora. 
- Hay un cantinero que sirve las cervezas, recoge vasos sucios y lava vasos sucios. 
- Las prioridades del cantinero son: servir cervezas, lavar vasos y recoger vasos. 
- Demora en servir una cerveza un tiempo que va entre 1 y 2 minutos uniformemente distribuido, en lavar un vaso constante de 15 segundos y recoger vasos según la cantidad de vasos que recoge. Si recoge entre 1 y 10 vasos 3 minutos, entre 10 y 20 vasos 5 minutos (nunca recoge más de 20 vasos por vuelta).
- Si tiene cliente para atender y no tiene vaso limpio, primero lava un vaso y luego atiende el cliente, si tampoco hay vaso sucios (o sea no hay vasos sucios ni limpios), recoge hasta 10 vasos y luego lava un vaso y luego atiende al cliente.
- Si cuando llega un cliente hay más de 3 clientes esperando que lo atiendan, se va. Si un cliente espera más de 5 minutos se va.
- El tiempo de tomar cerveza es una distribución normal de media 5 minutos y desviación estándar de 2 minutos.
- El bar tiene una provisión inicial de vasos limpios de 100.
## Objetivos
- Determinar la cantidad de clientes que se van sin consumir.
- Determinar la cantidad de clientes que esperaron y se van sin consumir.
- Determinar la espera máxima de un cliente para tomar una cerveza.
- Determinar el promedio de espera de los clientes para tomar una cerveza.
